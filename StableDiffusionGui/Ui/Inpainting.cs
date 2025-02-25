﻿using ImageMagick;
using StableDiffusionGui.Data;
using StableDiffusionGui.Extensions;
using StableDiffusionGui.Forms;
using StableDiffusionGui.Io;
using StableDiffusionGui.Main;
using StableDiffusionGui.MiscUtils;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Paths = StableDiffusionGui.Io.Paths;

namespace StableDiffusionGui.Ui
{
    internal class Inpainting
    {
        public static string MaskImagePath { get { return Path.Combine(Paths.GetSessionDataPath(), "inpaint-mask.png"); } }
        public static string MaskImagePathDiffusers { get { return Path.Combine(Paths.GetSessionDataPath(), "inpaint-mask-dif.png"); } }
        public static string MaskedImagePath { get { return Path.Combine(Paths.GetSessionDataPath(), "inpaint-masked.png"); } }

        private static Image _currentMask;
        public static Image CurrentMask
        {
            get => _currentMask;
            set
            {
                _currentMask = value;
                Program.MainForm.UpdateInpaintUi();
            }
        }

        public static Image CurrentRawMask;
        public static int CurrentBlurValue = -1;

        /// <returns> If inpainting was enabled </returns>
        public static bool PrepareInpaintingIfEnabled(TtiSettings settings)
        {
            List<string> initImgs = settings.Params["initImgs"].FromJson<List<string>>();

            if (initImgs == null)
            {
                return false;
            }

            if (settings.Params["inpainting"].FromJson<Enums.StableDiffusion.InpaintMode>() == Enums.StableDiffusion.InpaintMode.ImageMask)
            {
                if (initImgs.Count > 1)
                {
                    Logger.Log($"Inpainting is currently only available when using a single image as input, but you are using {initImgs.Count}.");
                    return false;
                }

                PrepareInpainting(initImgs[0], settings.Params["res"].FromJson<Size>());
                return true;
            }

            return false;
        }

        public static void PrepareInpainting(string initImgPath, Size targetSize)
        {
            Image img = IoUtils.GetImage(initImgPath);
            Size scaleSize = Config.Get<bool>(Config.Keys.InitImageRetainAspectRatio) ? ImgMaths.FitIntoFrame(img.Size, targetSize) : targetSize;
            img = ImgUtils.ScaleAndPad(ImgUtils.GetMagickImage(img), scaleSize, targetSize).ToBitmap();

            if (CurrentMask == null)
            {
                EditCurrentMask(img, MainFormUtils.FormControls.IsUsingInpaintingModel);
            }

            if (CurrentMask == null)
            {
                TextToImage.Cancel("Inpainting is enabled, but no mask was used!", true);
                return;
            }

            if (CurrentMask.Size != img.Size)
                CurrentMask = ImgUtils.ResizeImage(CurrentMask, img.Size);

            CurrentMask.Save(MaskImagePath, System.Drawing.Imaging.ImageFormat.Png); // Save mask (black = inpaint, transparent = keep)
            MagickImage maskedOverlay = ImgUtils.AlphaMask(ImgUtils.GetMagickImage(img), ImgUtils.GetMagickImage(CurrentMask), true);
            maskedOverlay.Write(MaskedImagePath); // Save overlay mask (image with mask cutout)

            MagickImage maskDiffusers = ImgUtils.RemoveTransparency(ImgUtils.GetMagickImage(CurrentMask), ImgUtils.NoAlphaMode.Fill, MagickColors.White);
            maskDiffusers = ImgUtils.Invert(maskDiffusers);
            maskDiffusers.Write(MaskImagePathDiffusers); // Safe diffusers mask (white = inpaint, black = keep)
            maskDiffusers.Dispose();
        }

        public static void EditCurrentMask (Image image, bool inpaintingModel)
        {
            var maskForm = new Forms.DrawForm(image, CurrentRawMask, inpaintingModel);
            maskForm.ShowDialogForm();
            CurrentMask = maskForm.Mask;
        }

        public static void DeleteMaskedImage()
        {
            IoUtils.TryDeleteIfExists(MaskedImagePath);
        }

        public static void ClearMask ()
        {
            CurrentRawMask = null;
            CurrentMask = null;
        }
    }
}

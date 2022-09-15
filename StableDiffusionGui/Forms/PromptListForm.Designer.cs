﻿namespace StableDiffusionGui.Forms
{
    partial class PromptListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromptListForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.promptListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddPromptsToQueue = new System.Windows.Forms.Button();
            this.btnOpenOutFolder = new System.Windows.Forms.Button();
            this.menuStripDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPromptHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPromptIntoGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDelete.SuspendLayout();
            this.menuStripPromptHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 40);
            this.titleLabel.TabIndex = 12;
            // 
            // promptListView
            // 
            this.promptListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.promptListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promptListView.CheckBoxes = true;
            this.promptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.promptListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.promptListView.ForeColor = System.Drawing.Color.White;
            this.promptListView.FullRowSelect = true;
            this.promptListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.promptListView.HideSelection = false;
            this.promptListView.LabelWrap = false;
            this.promptListView.Location = new System.Drawing.Point(12, 62);
            this.promptListView.Name = "promptListView";
            this.promptListView.Size = new System.Drawing.Size(1060, 287);
            this.promptListView.TabIndex = 53;
            this.promptListView.UseCompatibleStateImageBehavior = false;
            this.promptListView.View = System.Windows.Forms.View.Details;
            this.promptListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.promptListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1030;
            // 
            // btnAddPromptsToQueue
            // 
            this.btnAddPromptsToQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPromptsToQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddPromptsToQueue.BackgroundImage = global::StableDiffusionGui.Properties.Resources.addToListIcon;
            this.btnAddPromptsToQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPromptsToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPromptsToQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPromptsToQueue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAddPromptsToQueue.Location = new System.Drawing.Point(986, 9);
            this.btnAddPromptsToQueue.Name = "btnAddPromptsToQueue";
            this.btnAddPromptsToQueue.Size = new System.Drawing.Size(40, 40);
            this.btnAddPromptsToQueue.TabIndex = 96;
            this.btnAddPromptsToQueue.TabStop = false;
            this.toolTip.SetToolTip(this.btnAddPromptsToQueue, "Add Current Prompt/Settings to List");
            this.btnAddPromptsToQueue.UseVisualStyleBackColor = false;
            this.btnAddPromptsToQueue.Visible = false;
            this.btnAddPromptsToQueue.Click += new System.EventHandler(this.btnAddPromptsToQueue_Click);
            // 
            // btnOpenOutFolder
            // 
            this.btnOpenOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOutFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOpenOutFolder.BackgroundImage = global::StableDiffusionGui.Properties.Resources.deleteBtn;
            this.btnOpenOutFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenOutFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOutFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOutFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnOpenOutFolder.Location = new System.Drawing.Point(1032, 9);
            this.btnOpenOutFolder.Name = "btnOpenOutFolder";
            this.btnOpenOutFolder.Size = new System.Drawing.Size(40, 40);
            this.btnOpenOutFolder.TabIndex = 95;
            this.btnOpenOutFolder.TabStop = false;
            this.toolTip.SetToolTip(this.btnOpenOutFolder, "Delete...");
            this.btnOpenOutFolder.UseVisualStyleBackColor = false;
            this.btnOpenOutFolder.Click += new System.EventHandler(this.btnOpenOutFolder_Click);
            // 
            // menuStripDelete
            // 
            this.menuStripDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.menuStripDelete.Name = "contextMenuDelete";
            this.menuStripDelete.Size = new System.Drawing.Size(155, 48);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // menuStripPromptHistory
            // 
            this.menuStripPromptHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPromptIntoGUIToolStripMenuItem,
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem});
            this.menuStripPromptHistory.Name = "menuStripPromptHistory";
            this.menuStripPromptHistory.Size = new System.Drawing.Size(260, 48);
            // 
            // loadPromptIntoGUIToolStripMenuItem
            // 
            this.loadPromptIntoGUIToolStripMenuItem.Name = "loadPromptIntoGUIToolStripMenuItem";
            this.loadPromptIntoGUIToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.loadPromptIntoGUIToolStripMenuItem.Text = "Load Prompt Into GUI";
            this.loadPromptIntoGUIToolStripMenuItem.Click += new System.EventHandler(this.loadPromptIntoGUIToolStripMenuItem_Click);
            // 
            // loadPromptAndSettingsIntoGUIToolStripMenuItem
            // 
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem.Name = "loadPromptAndSettingsIntoGUIToolStripMenuItem";
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem.Text = "Load Prompt And Settings Into GUI";
            this.loadPromptAndSettingsIntoGUIToolStripMenuItem.Click += new System.EventHandler(this.loadPromptAndSettingsIntoGUIToolStripMenuItem_Click);
            // 
            // PromptListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1084, 361);
            this.Controls.Add(this.btnAddPromptsToQueue);
            this.Controls.Add(this.btnOpenOutFolder);
            this.Controls.Add(this.promptListView);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 300);
            this.Name = "PromptListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PromptListForm_Load);
            this.Shown += new System.EventHandler(this.PromptListForm_Shown);
            this.menuStripDelete.ResumeLayout(false);
            this.menuStripPromptHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView promptListView;
        private System.Windows.Forms.Button btnOpenOutFolder;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip menuStripDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuStripPromptHistory;
        private System.Windows.Forms.ToolStripMenuItem loadPromptIntoGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPromptAndSettingsIntoGUIToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAddPromptsToQueue;
    }
}
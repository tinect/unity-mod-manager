﻿namespace UnityModManagerNet.Installer
{
    partial class UnityModManagerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnityModManagerForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.gameList = new System.Windows.Forms.ComboBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.installedVersion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerMods = new System.Windows.Forms.SplitContainer();
            this.listMods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inputLog = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMain.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainerMods.Panel1.SuspendLayout();
            this.splitContainerMods.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainerMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(326, 398);
            this.panelMain.TabIndex = 3;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainerMain.Panel2MinSize = 20;
            this.splitContainerMain.Size = new System.Drawing.Size(326, 398);
            this.splitContainerMain.SplitterDistance = 374;
            this.splitContainerMain.TabIndex = 11;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 4);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(326, 374);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 10;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabs_Changed);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnOpenFolder);
            this.tabPage1.Controls.Add(this.gameList);
            this.tabPage1.Controls.Add(this.btnInstall);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.currentVersion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.installedVersion);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Install";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(3, 48);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(312, 45);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Uninstall";
            this.btnRemove.UseMnemonic = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenFolder.Location = new System.Drawing.Point(5, 129);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(171, 23);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Select Game Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // gameList
            // 
            this.gameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameList.FormattingEnabled = true;
            this.gameList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gameList.Location = new System.Drawing.Point(6, 102);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(170, 21);
            this.gameList.Sorted = true;
            this.gameList.TabIndex = 8;
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_Changed);
            // 
            // btnInstall
            // 
            this.btnInstall.AutoSize = true;
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInstall.Location = new System.Drawing.Point(3, 3);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(5);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(312, 45);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseMnemonic = false;
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Installed Version:";
            // 
            // currentVersion
            // 
            this.currentVersion.AutoSize = true;
            this.currentVersion.Location = new System.Drawing.Point(270, 105);
            this.currentVersion.Name = "currentVersion";
            this.currentVersion.Size = new System.Drawing.Size(31, 13);
            this.currentVersion.TabIndex = 4;
            this.currentVersion.Text = "1.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Version:";
            // 
            // installedVersion
            // 
            this.installedVersion.AutoSize = true;
            this.installedVersion.Location = new System.Drawing.Point(275, 125);
            this.installedVersion.Name = "installedVersion";
            this.installedVersion.Size = new System.Drawing.Size(10, 13);
            this.installedVersion.TabIndex = 5;
            this.installedVersion.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.splitContainerMods);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mods";
            // 
            // splitContainerMods
            // 
            this.splitContainerMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMods.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMods.IsSplitterFixed = true;
            this.splitContainerMods.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMods.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerMods.Name = "splitContainerMods";
            this.splitContainerMods.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMods.Panel1
            // 
            this.splitContainerMods.Panel1.Controls.Add(this.listMods);
            // 
            // splitContainerMods.Panel2
            // 
            this.splitContainerMods.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerMods.Panel2.BackgroundImage")));
            this.splitContainerMods.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMods.Size = new System.Drawing.Size(312, 336);
            this.splitContainerMods.SplitterDistance = 179;
            this.splitContainerMods.TabIndex = 0;
            // 
            // listMods
            // 
            this.listMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMods.FullRowSelect = true;
            this.listMods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMods.Location = new System.Drawing.Point(0, 0);
            this.listMods.MultiSelect = false;
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(312, 179);
            this.listMods.TabIndex = 0;
            this.listMods.UseCompatibleStateImageBehavior = false;
            this.listMods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.Width = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.inputLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(318, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            // 
            // inputLog
            // 
            this.inputLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.inputLog.Location = new System.Drawing.Point(3, 3);
            this.inputLog.Multiline = true;
            this.inputLog.Name = "inputLog";
            this.inputLog.ReadOnly = true;
            this.inputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputLog.Size = new System.Drawing.Size(312, 336);
            this.inputLog.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, -2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.statusLabel.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 20);
            this.statusLabel.Text = "Ready";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Manager Version";
            this.columnHeader3.Width = 100;
            // 
            // UnityModManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 398);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnityModManagerForm";
            this.ShowIcon = false;
            this.Text = "UnityModManager Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnityModLoaderForm_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainerMods.Panel1.ResumeLayout(false);
            this.splitContainerMods.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label currentVersion;
        private System.Windows.Forms.Label installedVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gameList;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainerMods;
        private System.Windows.Forms.ListView listMods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TextBox inputLog;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}


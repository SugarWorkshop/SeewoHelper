namespace SeewoHelper.Forms
{
    partial class WindowMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OperationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpgradeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonStartCoursewareSorting = new System.Windows.Forms.Button();
            this.buttonGettingCoursewareSortingSearchingPath = new System.Windows.Forms.Button();
            this.labelCoursewareSortingSearchingPath = new System.Windows.Forms.Label();
            this.textBoxCoursewareSortingSearchingPath = new System.Windows.Forms.TextBox();
            this.listViewSubjectStorageInfos = new System.Windows.Forms.ListView();
            this.listViewSubjectStorageInfosColumnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderKeywords = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubjectStorageInfoAdd = new System.Windows.Forms.Button();
            this.buttonSubjectInfoStorageRemove = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxDisableServiceShellHardwareDetection = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextNotifyIconMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationMenuItem,
            this.HelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(809, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // OperationMenuItem
            // 
            this.OperationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingMenuItem});
            this.OperationMenuItem.Name = "OperationMenuItem";
            this.OperationMenuItem.Size = new System.Drawing.Size(47, 23);
            this.OperationMenuItem.Text = "操作";
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.Name = "SettingMenuItem";
            this.SettingMenuItem.Size = new System.Drawing.Size(104, 24);
            this.SettingMenuItem.Text = "选项";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpgradeMenuItem,
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(47, 23);
            this.HelpMenuItem.Text = "帮助";
            // 
            // UpgradeMenuItem
            // 
            this.UpgradeMenuItem.Name = "UpgradeMenuItem";
            this.UpgradeMenuItem.Size = new System.Drawing.Size(130, 24);
            this.UpgradeMenuItem.Text = "检查更新";
            this.UpgradeMenuItem.Click += new System.EventHandler(this.UpgradeMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(130, 24);
            this.AboutMenuItem.Text = "关于...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonStartCoursewareSorting);
            this.tabPage1.Controls.Add(this.buttonGettingCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.labelCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.textBoxCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.listViewSubjectStorageInfos);
            this.tabPage1.Controls.Add(this.tableLayoutPanelSubjectStorageInfoListControlButtons);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(773, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课件整理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStartCoursewareSorting
            // 
            this.buttonStartCoursewareSorting.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartCoursewareSorting.Location = new System.Drawing.Point(662, 391);
            this.buttonStartCoursewareSorting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartCoursewareSorting.Name = "buttonStartCoursewareSorting";
            this.buttonStartCoursewareSorting.Size = new System.Drawing.Size(102, 34);
            this.buttonStartCoursewareSorting.TabIndex = 16;
            this.buttonStartCoursewareSorting.Text = "整理";
            this.buttonStartCoursewareSorting.UseVisualStyleBackColor = true;
            this.buttonStartCoursewareSorting.Click += new System.EventHandler(this.ButtonStartCoursewareSorting_Click);
            // 
            // buttonGettingCoursewareSortingSearchingPath
            // 
            this.buttonGettingCoursewareSortingSearchingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGettingCoursewareSortingSearchingPath.Location = new System.Drawing.Point(736, 8);
            this.buttonGettingCoursewareSortingSearchingPath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGettingCoursewareSortingSearchingPath.Name = "buttonGettingCoursewareSortingSearchingPath";
            this.buttonGettingCoursewareSortingSearchingPath.Size = new System.Drawing.Size(28, 25);
            this.buttonGettingCoursewareSortingSearchingPath.TabIndex = 15;
            this.buttonGettingCoursewareSortingSearchingPath.Text = "...";
            this.buttonGettingCoursewareSortingSearchingPath.UseVisualStyleBackColor = true;
            this.buttonGettingCoursewareSortingSearchingPath.Click += new System.EventHandler(this.ButtonGettingCoursewareSortingSearchingPath_Click);
            // 
            // labelCoursewareSortingSearchingPath
            // 
            this.labelCoursewareSortingSearchingPath.AutoSize = true;
            this.labelCoursewareSortingSearchingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoursewareSortingSearchingPath.Location = new System.Drawing.Point(8, 11);
            this.labelCoursewareSortingSearchingPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoursewareSortingSearchingPath.Name = "labelCoursewareSortingSearchingPath";
            this.labelCoursewareSortingSearchingPath.Size = new System.Drawing.Size(74, 19);
            this.labelCoursewareSortingSearchingPath.TabIndex = 13;
            this.labelCoursewareSortingSearchingPath.Text = "搜索路径：";
            // 
            // textBoxCoursewareSortingSearchingPath
            // 
            this.textBoxCoursewareSortingSearchingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCoursewareSortingSearchingPath.Location = new System.Drawing.Point(89, 8);
            this.textBoxCoursewareSortingSearchingPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoursewareSortingSearchingPath.Name = "textBoxCoursewareSortingSearchingPath";
            this.textBoxCoursewareSortingSearchingPath.Size = new System.Drawing.Size(639, 25);
            this.textBoxCoursewareSortingSearchingPath.TabIndex = 14;
            // 
            // listViewSubjectStorageInfos
            // 
            this.listViewSubjectStorageInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSubjectStorageInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewSubjectStorageInfosColumnHeaderName,
            this.listViewSubjectStorageInfosColumnHeaderPath,
            this.listViewSubjectStorageInfosColumnHeaderKeywords});
            this.listViewSubjectStorageInfos.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewSubjectStorageInfos.FullRowSelect = true;
            this.listViewSubjectStorageInfos.HideSelection = false;
            this.listViewSubjectStorageInfos.Location = new System.Drawing.Point(4, 41);
            this.listViewSubjectStorageInfos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSubjectStorageInfos.Name = "listViewSubjectStorageInfos";
            this.listViewSubjectStorageInfos.Size = new System.Drawing.Size(765, 338);
            this.listViewSubjectStorageInfos.TabIndex = 2;
            this.listViewSubjectStorageInfos.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectStorageInfos.View = System.Windows.Forms.View.Details;
            this.listViewSubjectStorageInfos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListViewSubjectStorageInfos_ColumnWidthChanging);
            this.listViewSubjectStorageInfos.DoubleClick += new System.EventHandler(this.ListViewSubjectStorageInfos_DoubleClick);
            // 
            // listViewSubjectStorageInfosColumnHeaderName
            // 
            this.listViewSubjectStorageInfosColumnHeaderName.Name = "listViewSubjectStorageInfosColumnHeaderName";
            this.listViewSubjectStorageInfosColumnHeaderName.Text = "名称";
            this.listViewSubjectStorageInfosColumnHeaderName.Width = 52;
            // 
            // listViewSubjectStorageInfosColumnHeaderPath
            // 
            this.listViewSubjectStorageInfosColumnHeaderPath.Name = "listViewSubjectStorageInfosColumnHeaderPath";
            this.listViewSubjectStorageInfosColumnHeaderPath.Text = "路径";
            this.listViewSubjectStorageInfosColumnHeaderPath.Width = 400;
            // 
            // listViewSubjectStorageInfosColumnHeaderKeywords
            // 
            this.listViewSubjectStorageInfosColumnHeaderKeywords.Name = "listViewSubjectStorageInfosColumnHeaderKeywords";
            this.listViewSubjectStorageInfosColumnHeaderKeywords.Text = "关键词";
            this.listViewSubjectStorageInfosColumnHeaderKeywords.Width = 300;
            // 
            // tableLayoutPanelSubjectStorageInfoListControlButtons
            // 
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnCount = 2;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectStorageInfoAdd, 0, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectInfoStorageRemove, 1, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Location = new System.Drawing.Point(8, 387);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Name = "tableLayoutPanelSubjectStorageInfoListControlButtons";
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowCount = 1;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Size = new System.Drawing.Size(198, 40);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.TabIndex = 1;
            // 
            // buttonSubjectStorageInfoAdd
            // 
            this.buttonSubjectStorageInfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubjectStorageInfoAdd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubjectStorageInfoAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonSubjectStorageInfoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubjectStorageInfoAdd.Name = "buttonSubjectStorageInfoAdd";
            this.buttonSubjectStorageInfoAdd.Size = new System.Drawing.Size(91, 32);
            this.buttonSubjectStorageInfoAdd.TabIndex = 0;
            this.buttonSubjectStorageInfoAdd.Text = "添加";
            this.buttonSubjectStorageInfoAdd.UseVisualStyleBackColor = true;
            this.buttonSubjectStorageInfoAdd.Click += new System.EventHandler(this.ButtonSubjectStorageInfoAdd_Click);
            // 
            // buttonSubjectInfoStorageRemove
            // 
            this.buttonSubjectInfoStorageRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubjectInfoStorageRemove.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubjectInfoStorageRemove.Location = new System.Drawing.Point(103, 4);
            this.buttonSubjectInfoStorageRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubjectInfoStorageRemove.Name = "buttonSubjectInfoStorageRemove";
            this.buttonSubjectInfoStorageRemove.Size = new System.Drawing.Size(91, 32);
            this.buttonSubjectInfoStorageRemove.TabIndex = 1;
            this.buttonSubjectInfoStorageRemove.Text = "删除";
            this.buttonSubjectInfoStorageRemove.UseVisualStyleBackColor = true;
            this.buttonSubjectInfoStorageRemove.Click += new System.EventHandler(this.ButtonSubjectInfoRemove_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(15, 33);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 467);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxDisableServiceShellHardwareDetection);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(773, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实用功能";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisableServiceShellHardwareDetection
            // 
            this.checkBoxDisableServiceShellHardwareDetection.AutoSize = true;
            this.checkBoxDisableServiceShellHardwareDetection.Location = new System.Drawing.Point(4, 4);
            this.checkBoxDisableServiceShellHardwareDetection.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisableServiceShellHardwareDetection.Name = "checkBoxDisableServiceShellHardwareDetection";
            this.checkBoxDisableServiceShellHardwareDetection.Size = new System.Drawing.Size(389, 23);
            this.checkBoxDisableServiceShellHardwareDetection.TabIndex = 0;
            this.checkBoxDisableServiceShellHardwareDetection.Text = "关闭U盘插入提示修复（禁用Shell Hardware Detection服务）";
            this.checkBoxDisableServiceShellHardwareDetection.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(773, 435);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "调试";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxLogs);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(773, 435);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "日志";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogs.Location = new System.Drawing.Point(4, 4);
            this.textBoxLogs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogs.Size = new System.Drawing.Size(765, 427);
            this.textBoxLogs.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextNotifyIconMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SeewoHelper";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextNotifyIconMenuStrip
            // 
            this.contextNotifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextNotifyIconMenuStrip.Name = "contextNotifyIconMenuStrip";
            this.contextNotifyIconMenuStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpenToolStripMenuItem.Text = "打开界面";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(809, 513);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowMain";
            this.ShowIcon = false;
            this.Text = "SeewoHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowMain_FormClosing);
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.contextNotifyIconMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem UpgradeMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSubjectStorageInfoListControlButtons;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderName;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderPath;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderKeywords;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListView listViewSubjectStorageInfos;
        private System.Windows.Forms.Button buttonSubjectStorageInfoAdd;
        private System.Windows.Forms.Button buttonSubjectInfoStorageRemove;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button buttonGettingCoursewareSortingSearchingPath;
        private System.Windows.Forms.Label labelCoursewareSortingSearchingPath;
        private System.Windows.Forms.TextBox textBoxCoursewareSortingSearchingPath;
        private System.Windows.Forms.Button buttonStartCoursewareSorting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxDisableServiceShellHardwareDetection;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextNotifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}


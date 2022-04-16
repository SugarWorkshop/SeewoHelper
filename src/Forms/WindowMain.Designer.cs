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
            this.tabPageFileSorting = new System.Windows.Forms.TabPage();
            this.buttonStartFileSorting = new Sunny.UI.UIButton();
            this.comboBoxExtraFileSortingWay = new Sunny.UI.UIComboBox();
            this.labelExtraFileSortingWay = new Sunny.UI.UILabel();
            this.listViewFileSortingInfos = new System.Windows.Forms.ListView();
            this.listViewSubjectStorageInfosColumnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderKeywords = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFileSortingInfoAdd = new Sunny.UI.UIButton();
            this.buttonFileSortingInfoRemove = new Sunny.UI.UIButton();
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabPageUsefulFeatures = new System.Windows.Forms.TabPage();
            this.groupBoxQuicklyControl = new System.Windows.Forms.GroupBox();
            this.processBarQuicklyControl = new Sunny.UI.UIProcessBar();
            this.tableLayoutPanelQuicklyControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShutdown = new Sunny.UI.UIButton();
            this.buttonCancel = new Sunny.UI.UIButton();
            this.buttonRestart = new Sunny.UI.UIButton();
            this.buttonLogout = new Sunny.UI.UIButton();
            this.checkBoxDisableServiceWindowsSearch = new Sunny.UI.UICheckBox();
            this.checkBoxDisableServiceWindowsUpdate = new Sunny.UI.UICheckBox();
            this.checkBoxDisableServiceShellHardwareDetection = new Sunny.UI.UICheckBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxHideToNotify = new Sunny.UI.UICheckBox();
            this.checkBoxDoubleClickNotify = new Sunny.UI.UICheckBox();
            this.checkBoxHideWhenStart = new Sunny.UI.UICheckBox();
            this.checkBoxAutoCheckUpdate = new Sunny.UI.UICheckBox();
            this.buttonCleanLog = new Sunny.UI.UIButton();
            this.checkBoxAutoStart = new Sunny.UI.UICheckBox();
            this.tableLayoutPanelSkin = new System.Windows.Forms.TableLayoutPanel();
            this.labelStyle = new Sunny.UI.UILabel();
            this.comboBoxStyle = new Sunny.UI.UIComboBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAbout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelGithub = new Sunny.UI.UILinkLabel();
            this.labelProgramName = new Sunny.UI.UILabel();
            this.labelVersion = new Sunny.UI.UILabel();
            this.tableLayoutPanelContributors = new System.Windows.Forms.TableLayoutPanel();
            this.uiAvatarSugar = new Sunny.UI.UIAvatar();
            this.uiAvatarRicky = new Sunny.UI.UIAvatar();
            this.tableLayoutPanelMoInk = new System.Windows.Forms.TableLayoutPanel();
            this.symbolLabelSugar = new Sunny.UI.UISymbolLabel();
            this.linkLabelSugarGithub = new Sunny.UI.UILinkLabel();
            this.tableLayoutPanelRicky = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelRickyGithub = new Sunny.UI.UILinkLabel();
            this.symbolLabelRicky = new Sunny.UI.UISymbolLabel();
            this.tabPageLogs = new System.Windows.Forms.TabPage();
            this.comboBoxLogLevel = new Sunny.UI.UIComboBox();
            this.labelLogLevel = new Sunny.UI.UILabel();
            this.textBoxLogs = new Sunny.UI.UITextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotifyIconMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItemUpdateCheckerShow = new System.Windows.Forms.ToolStripMenuItem();
            this.timerQuicklyControl = new System.Windows.Forms.Timer(this.components);
            this.tabPageFileSorting.SuspendLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageUsefulFeatures.SuspendLayout();
            this.groupBoxQuicklyControl.SuspendLayout();
            this.tableLayoutPanelQuicklyControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanelSkin.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tableLayoutPanelAbout.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.tableLayoutPanelContributors.SuspendLayout();
            this.tableLayoutPanelMoInk.SuspendLayout();
            this.tableLayoutPanelRicky.SuspendLayout();
            this.tabPageLogs.SuspendLayout();
            this.contextNotifyIconMenuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageFileSorting
            // 
            this.tabPageFileSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPageFileSorting.Controls.Add(this.buttonStartFileSorting);
            this.tabPageFileSorting.Controls.Add(this.comboBoxExtraFileSortingWay);
            this.tabPageFileSorting.Controls.Add(this.labelExtraFileSortingWay);
            this.tabPageFileSorting.Controls.Add(this.listViewFileSortingInfos);
            this.tabPageFileSorting.Controls.Add(this.tableLayoutPanelSubjectStorageInfoListControlButtons);
            this.tabPageFileSorting.ForeColor = System.Drawing.Color.White;
            this.tabPageFileSorting.Location = new System.Drawing.Point(0, 40);
            this.tabPageFileSorting.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFileSorting.Name = "tabPageFileSorting";
            this.tabPageFileSorting.Size = new System.Drawing.Size(801, 453);
            this.tabPageFileSorting.TabIndex = 0;
            this.tabPageFileSorting.Text = "桌面整理";
            // 
            // buttonStartFileSorting
            // 
            this.buttonStartFileSorting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartFileSorting.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartFileSorting.Location = new System.Drawing.Point(706, 413);
            this.buttonStartFileSorting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartFileSorting.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonStartFileSorting.Name = "buttonStartFileSorting";
            this.buttonStartFileSorting.Size = new System.Drawing.Size(91, 32);
            this.buttonStartFileSorting.TabIndex = 16;
            this.buttonStartFileSorting.Text = "整理";
            this.buttonStartFileSorting.Click += new System.EventHandler(this.ButtonStartFileSorting_Click);
            // 
            // comboBoxExtraFileSortingWay
            // 
            this.comboBoxExtraFileSortingWay.DataSource = null;
            this.comboBoxExtraFileSortingWay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxExtraFileSortingWay.FillColor = System.Drawing.Color.White;
            this.comboBoxExtraFileSortingWay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxExtraFileSortingWay.Location = new System.Drawing.Point(142, 5);
            this.comboBoxExtraFileSortingWay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxExtraFileSortingWay.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxExtraFileSortingWay.Name = "comboBoxExtraFileSortingWay";
            this.comboBoxExtraFileSortingWay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxExtraFileSortingWay.Size = new System.Drawing.Size(655, 26);
            this.comboBoxExtraFileSortingWay.TabIndex = 20;
            this.comboBoxExtraFileSortingWay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExtraFileSortingWay
            // 
            this.labelExtraFileSortingWay.AutoSize = true;
            this.labelExtraFileSortingWay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExtraFileSortingWay.Location = new System.Drawing.Point(7, 7);
            this.labelExtraFileSortingWay.Name = "labelExtraFileSortingWay";
            this.labelExtraFileSortingWay.Size = new System.Drawing.Size(135, 20);
            this.labelExtraFileSortingWay.TabIndex = 19;
            this.labelExtraFileSortingWay.Text = "额外文件处理方式：";
            this.labelExtraFileSortingWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewFileSortingInfos
            // 
            this.listViewFileSortingInfos.BackColor = System.Drawing.Color.White;
            this.listViewFileSortingInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFileSortingInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewSubjectStorageInfosColumnHeaderName,
            this.listViewSubjectStorageInfosColumnHeaderPath,
            this.listViewSubjectStorageInfosColumnHeaderKeywords});
            this.listViewFileSortingInfos.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewFileSortingInfos.ForeColor = System.Drawing.Color.Black;
            this.listViewFileSortingInfos.FullRowSelect = true;
            this.listViewFileSortingInfos.HideSelection = false;
            this.listViewFileSortingInfos.Location = new System.Drawing.Point(4, 34);
            this.listViewFileSortingInfos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewFileSortingInfos.Name = "listViewFileSortingInfos";
            this.listViewFileSortingInfos.Size = new System.Drawing.Size(793, 371);
            this.listViewFileSortingInfos.TabIndex = 17;
            this.listViewFileSortingInfos.UseCompatibleStateImageBehavior = false;
            this.listViewFileSortingInfos.View = System.Windows.Forms.View.Details;
            this.listViewFileSortingInfos.DoubleClick += new System.EventHandler(this.ListViewSubjectStorageInfos_DoubleClick);
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
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonFileSortingInfoAdd, 0, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonFileSortingInfoRemove, 1, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Location = new System.Drawing.Point(4, 409);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Name = "tableLayoutPanelSubjectStorageInfoListControlButtons";
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowCount = 1;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Size = new System.Drawing.Size(198, 40);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.TabIndex = 1;
            // 
            // buttonFileSortingInfoAdd
            // 
            this.buttonFileSortingInfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileSortingInfoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFileSortingInfoAdd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFileSortingInfoAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonFileSortingInfoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileSortingInfoAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonFileSortingInfoAdd.Name = "buttonFileSortingInfoAdd";
            this.buttonFileSortingInfoAdd.Size = new System.Drawing.Size(91, 32);
            this.buttonFileSortingInfoAdd.TabIndex = 0;
            this.buttonFileSortingInfoAdd.Text = "添加";
            this.buttonFileSortingInfoAdd.Click += new System.EventHandler(this.ButtonSubjectStorageInfoAdd_Click);
            // 
            // buttonFileSortingInfoRemove
            // 
            this.buttonFileSortingInfoRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileSortingInfoRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFileSortingInfoRemove.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFileSortingInfoRemove.Location = new System.Drawing.Point(103, 4);
            this.buttonFileSortingInfoRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileSortingInfoRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonFileSortingInfoRemove.Name = "buttonFileSortingInfoRemove";
            this.buttonFileSortingInfoRemove.Size = new System.Drawing.Size(91, 32);
            this.buttonFileSortingInfoRemove.TabIndex = 1;
            this.buttonFileSortingInfoRemove.Text = "删除";
            this.buttonFileSortingInfoRemove.Click += new System.EventHandler(this.ButtonSubjectInfoRemove_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageFileSorting);
            this.tabControl.Controls.Add(this.tabPageUsefulFeatures);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Controls.Add(this.tabPageLogs);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(4, 39);
            this.tabControl.MainPage = "";
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 493);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabIndex = 1;
            this.tabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // tabPageUsefulFeatures
            // 
            this.tabPageUsefulFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPageUsefulFeatures.Controls.Add(this.groupBoxQuicklyControl);
            this.tabPageUsefulFeatures.Controls.Add(this.checkBoxDisableServiceWindowsSearch);
            this.tabPageUsefulFeatures.Controls.Add(this.checkBoxDisableServiceWindowsUpdate);
            this.tabPageUsefulFeatures.Controls.Add(this.checkBoxDisableServiceShellHardwareDetection);
            this.tabPageUsefulFeatures.ForeColor = System.Drawing.Color.White;
            this.tabPageUsefulFeatures.Location = new System.Drawing.Point(0, 40);
            this.tabPageUsefulFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUsefulFeatures.Name = "tabPageUsefulFeatures";
            this.tabPageUsefulFeatures.Size = new System.Drawing.Size(801, 453);
            this.tabPageUsefulFeatures.TabIndex = 1;
            this.tabPageUsefulFeatures.Text = "实用功能";
            // 
            // groupBoxQuicklyControl
            // 
            this.groupBoxQuicklyControl.Controls.Add(this.processBarQuicklyControl);
            this.groupBoxQuicklyControl.Controls.Add(this.tableLayoutPanelQuicklyControl);
            this.groupBoxQuicklyControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxQuicklyControl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxQuicklyControl.Location = new System.Drawing.Point(4, 321);
            this.groupBoxQuicklyControl.Name = "groupBoxQuicklyControl";
            this.groupBoxQuicklyControl.Size = new System.Drawing.Size(794, 129);
            this.groupBoxQuicklyControl.TabIndex = 9;
            this.groupBoxQuicklyControl.TabStop = false;
            this.groupBoxQuicklyControl.Text = "快捷电源控制";
            // 
            // processBarQuicklyControl
            // 
            this.processBarQuicklyControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.processBarQuicklyControl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processBarQuicklyControl.Location = new System.Drawing.Point(6, 25);
            this.processBarQuicklyControl.Maximum = 1000;
            this.processBarQuicklyControl.MinimumSize = new System.Drawing.Size(70, 5);
            this.processBarQuicklyControl.Name = "processBarQuicklyControl";
            this.processBarQuicklyControl.Size = new System.Drawing.Size(782, 32);
            this.processBarQuicklyControl.TabIndex = 8;
            this.processBarQuicklyControl.TagString = "";
            this.processBarQuicklyControl.Text = "0.0%";
            // 
            // tableLayoutPanelQuicklyControl
            // 
            this.tableLayoutPanelQuicklyControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanelQuicklyControl.ColumnCount = 4;
            this.tableLayoutPanelQuicklyControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuicklyControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuicklyControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuicklyControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuicklyControl.Controls.Add(this.buttonShutdown, 0, 0);
            this.tableLayoutPanelQuicklyControl.Controls.Add(this.buttonCancel, 3, 0);
            this.tableLayoutPanelQuicklyControl.Controls.Add(this.buttonRestart, 1, 0);
            this.tableLayoutPanelQuicklyControl.Controls.Add(this.buttonLogout, 2, 0);
            this.tableLayoutPanelQuicklyControl.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanelQuicklyControl.Name = "tableLayoutPanelQuicklyControl";
            this.tableLayoutPanelQuicklyControl.RowCount = 1;
            this.tableLayoutPanelQuicklyControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQuicklyControl.Size = new System.Drawing.Size(788, 60);
            this.tableLayoutPanelQuicklyControl.TabIndex = 7;
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShutdown.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShutdown.Location = new System.Drawing.Point(38, 4);
            this.buttonShutdown.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(120, 51);
            this.buttonShutdown.TabIndex = 3;
            this.buttonShutdown.Text = "关机";
            this.buttonShutdown.Click += new System.EventHandler(this.ButtonShutdown_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(629, 4);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 51);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消操作";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.Location = new System.Drawing.Point(235, 4);
            this.buttonRestart.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(120, 51);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "重启";
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(432, 4);
            this.buttonLogout.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 51);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "注销";
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // checkBoxDisableServiceWindowsSearch
            // 
            this.checkBoxDisableServiceWindowsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDisableServiceWindowsSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDisableServiceWindowsSearch.Location = new System.Drawing.Point(7, 72);
            this.checkBoxDisableServiceWindowsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisableServiceWindowsSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxDisableServiceWindowsSearch.Name = "checkBoxDisableServiceWindowsSearch";
            this.checkBoxDisableServiceWindowsSearch.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxDisableServiceWindowsSearch.Size = new System.Drawing.Size(207, 26);
            this.checkBoxDisableServiceWindowsSearch.TabIndex = 2;
            this.checkBoxDisableServiceWindowsSearch.Text = "禁用 Windows Search";
            // 
            // checkBoxDisableServiceWindowsUpdate
            // 
            this.checkBoxDisableServiceWindowsUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDisableServiceWindowsUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDisableServiceWindowsUpdate.Location = new System.Drawing.Point(7, 38);
            this.checkBoxDisableServiceWindowsUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisableServiceWindowsUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxDisableServiceWindowsUpdate.Name = "checkBoxDisableServiceWindowsUpdate";
            this.checkBoxDisableServiceWindowsUpdate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxDisableServiceWindowsUpdate.Size = new System.Drawing.Size(207, 26);
            this.checkBoxDisableServiceWindowsUpdate.TabIndex = 1;
            this.checkBoxDisableServiceWindowsUpdate.Text = "禁用 Windows Update";
            // 
            // checkBoxDisableServiceShellHardwareDetection
            // 
            this.checkBoxDisableServiceShellHardwareDetection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDisableServiceShellHardwareDetection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDisableServiceShellHardwareDetection.Location = new System.Drawing.Point(7, 4);
            this.checkBoxDisableServiceShellHardwareDetection.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisableServiceShellHardwareDetection.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxDisableServiceShellHardwareDetection.Name = "checkBoxDisableServiceShellHardwareDetection";
            this.checkBoxDisableServiceShellHardwareDetection.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxDisableServiceShellHardwareDetection.Size = new System.Drawing.Size(144, 26);
            this.checkBoxDisableServiceShellHardwareDetection.TabIndex = 0;
            this.checkBoxDisableServiceShellHardwareDetection.Text = "禁用 自动播放";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPageSettings.Controls.Add(this.checkBoxHideToNotify);
            this.tabPageSettings.Controls.Add(this.checkBoxDoubleClickNotify);
            this.tabPageSettings.Controls.Add(this.checkBoxHideWhenStart);
            this.tabPageSettings.Controls.Add(this.checkBoxAutoCheckUpdate);
            this.tabPageSettings.Controls.Add(this.buttonCleanLog);
            this.tabPageSettings.Controls.Add(this.checkBoxAutoStart);
            this.tabPageSettings.Controls.Add(this.tableLayoutPanelSkin);
            this.tabPageSettings.Location = new System.Drawing.Point(0, 40);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(801, 453);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "设置";
            // 
            // checkBoxHideToNotify
            // 
            this.checkBoxHideToNotify.Checked = true;
            this.checkBoxHideToNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxHideToNotify.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHideToNotify.Location = new System.Drawing.Point(6, 147);
            this.checkBoxHideToNotify.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxHideToNotify.Name = "checkBoxHideToNotify";
            this.checkBoxHideToNotify.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxHideToNotify.Size = new System.Drawing.Size(192, 26);
            this.checkBoxHideToNotify.TabIndex = 7;
            this.checkBoxHideToNotify.Text = "关闭窗口隐藏至托盘";
            this.checkBoxHideToNotify.CheckedChanged += new System.EventHandler(this.CheckBoxHideToNotify_CheckedChanged);
            // 
            // checkBoxDoubleClickNotify
            // 
            this.checkBoxDoubleClickNotify.Checked = true;
            this.checkBoxDoubleClickNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDoubleClickNotify.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDoubleClickNotify.Location = new System.Drawing.Point(6, 179);
            this.checkBoxDoubleClickNotify.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxDoubleClickNotify.Name = "checkBoxDoubleClickNotify";
            this.checkBoxDoubleClickNotify.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxDoubleClickNotify.Size = new System.Drawing.Size(192, 26);
            this.checkBoxDoubleClickNotify.TabIndex = 6;
            this.checkBoxDoubleClickNotify.Text = "双击托盘图标显示界面";
            this.checkBoxDoubleClickNotify.CheckedChanged += new System.EventHandler(this.CheckBoxDoubleClickNotify_CheckedChanged);
            // 
            // checkBoxHideWhenStart
            // 
            this.checkBoxHideWhenStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxHideWhenStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxHideWhenStart.Location = new System.Drawing.Point(6, 83);
            this.checkBoxHideWhenStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxHideWhenStart.Name = "checkBoxHideWhenStart";
            this.checkBoxHideWhenStart.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxHideWhenStart.Size = new System.Drawing.Size(164, 26);
            this.checkBoxHideWhenStart.TabIndex = 5;
            this.checkBoxHideWhenStart.Text = "启动时隐藏到托盘";
            this.checkBoxHideWhenStart.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.CheckBoxHideWhenStart_ValueChanged);
            // 
            // checkBoxAutoCheckUpdate
            // 
            this.checkBoxAutoCheckUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoCheckUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAutoCheckUpdate.Location = new System.Drawing.Point(6, 115);
            this.checkBoxAutoCheckUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxAutoCheckUpdate.Name = "checkBoxAutoCheckUpdate";
            this.checkBoxAutoCheckUpdate.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxAutoCheckUpdate.Size = new System.Drawing.Size(192, 26);
            this.checkBoxAutoCheckUpdate.TabIndex = 4;
            this.checkBoxAutoCheckUpdate.Text = "启动时自动检查更新";
            this.checkBoxAutoCheckUpdate.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.CheckBoxAutoCheckUpdate_ValueChanged);
            // 
            // buttonCleanLog
            // 
            this.buttonCleanLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCleanLog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCleanLog.Location = new System.Drawing.Point(6, 211);
            this.buttonCleanLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonCleanLog.Name = "buttonCleanLog";
            this.buttonCleanLog.Size = new System.Drawing.Size(123, 36);
            this.buttonCleanLog.TabIndex = 3;
            this.buttonCleanLog.Text = "清除Logs";
            this.buttonCleanLog.Click += new System.EventHandler(this.ButtonCleanLog_Click);
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAutoStart.Location = new System.Drawing.Point(6, 51);
            this.checkBoxAutoStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxAutoStart.Size = new System.Drawing.Size(123, 26);
            this.checkBoxAutoStart.TabIndex = 2;
            this.checkBoxAutoStart.Text = "开机自动启动";
            this.checkBoxAutoStart.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.CheckBoxAutoStart_ValueChanged);
            // 
            // tableLayoutPanelSkin
            // 
            this.tableLayoutPanelSkin.ColumnCount = 2;
            this.tableLayoutPanelSkin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSkin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelSkin.Controls.Add(this.labelStyle, 0, 0);
            this.tableLayoutPanelSkin.Controls.Add(this.comboBoxStyle, 1, 0);
            this.tableLayoutPanelSkin.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSkin.Name = "tableLayoutPanelSkin";
            this.tableLayoutPanelSkin.RowCount = 1;
            this.tableLayoutPanelSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSkin.Size = new System.Drawing.Size(226, 42);
            this.tableLayoutPanelSkin.TabIndex = 1;
            // 
            // labelStyle
            // 
            this.labelStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStyle.AutoSize = true;
            this.labelStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStyle.Location = new System.Drawing.Point(3, 0);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(50, 42);
            this.labelStyle.Style = Sunny.UI.UIStyle.Blue;
            this.labelStyle.TabIndex = 1;
            this.labelStyle.Text = "皮肤";
            this.labelStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStyle.DataSource = null;
            this.comboBoxStyle.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxStyle.FillColor = System.Drawing.Color.White;
            this.comboBoxStyle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.ItemHeight = 33;
            this.comboBoxStyle.Location = new System.Drawing.Point(60, 6);
            this.comboBoxStyle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxStyle.MaxDropDownItems = 6;
            this.comboBoxStyle.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxStyle.Size = new System.Drawing.Size(162, 29);
            this.comboBoxStyle.TabIndex = 0;
            this.comboBoxStyle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStyle_SelectedIndexChanged);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPageAbout.Controls.Add(this.tableLayoutPanelAbout);
            this.tabPageAbout.Location = new System.Drawing.Point(0, 40);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(200, 60);
            this.tabPageAbout.TabIndex = 4;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.Paint += new System.Windows.Forms.PaintEventHandler(this.TabPageAbout_Paint);
            // 
            // tableLayoutPanelAbout
            // 
            this.tableLayoutPanelAbout.ColumnCount = 1;
            this.tableLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAbout.Controls.Add(this.tableLayoutPanelInfo, 0, 0);
            this.tableLayoutPanelAbout.Controls.Add(this.tableLayoutPanelContributors, 0, 1);
            this.tableLayoutPanelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAbout.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAbout.Name = "tableLayoutPanelAbout";
            this.tableLayoutPanelAbout.RowCount = 2;
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAbout.Size = new System.Drawing.Size(200, 60);
            this.tableLayoutPanelAbout.TabIndex = 5;
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.ColumnCount = 1;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Controls.Add(this.linkLabelGithub, 0, 2);
            this.tableLayoutPanelInfo.Controls.Add(this.labelProgramName, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 3;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(194, 24);
            this.tableLayoutPanelInfo.TabIndex = 0;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.linkLabelGithub.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelGithub.Location = new System.Drawing.Point(3, 16);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(188, 8);
            this.linkLabelGithub.TabIndex = 4;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub 仓库地址";
            this.linkLabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelGithub.Click += new System.EventHandler(this.LinkLabelGithub_Click);
            // 
            // labelProgramName
            // 
            this.labelProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("微软雅黑", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProgramName.Location = new System.Drawing.Point(3, 0);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(188, 8);
            this.labelProgramName.Style = Sunny.UI.UIStyle.Blue;
            this.labelProgramName.TabIndex = 2;
            this.labelProgramName.Text = "SeewoHelper";
            this.labelProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(3, 8);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(188, 8);
            this.labelVersion.Style = Sunny.UI.UIStyle.Blue;
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "应用版本：";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelContributors
            // 
            this.tableLayoutPanelContributors.ColumnCount = 4;
            this.tableLayoutPanelContributors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContributors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContributors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContributors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContributors.Controls.Add(this.uiAvatarSugar, 0, 0);
            this.tableLayoutPanelContributors.Controls.Add(this.uiAvatarRicky, 2, 0);
            this.tableLayoutPanelContributors.Controls.Add(this.tableLayoutPanelMoInk, 1, 0);
            this.tableLayoutPanelContributors.Controls.Add(this.tableLayoutPanelRicky, 3, 0);
            this.tableLayoutPanelContributors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContributors.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanelContributors.Name = "tableLayoutPanelContributors";
            this.tableLayoutPanelContributors.RowCount = 1;
            this.tableLayoutPanelContributors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContributors.Size = new System.Drawing.Size(194, 24);
            this.tableLayoutPanelContributors.TabIndex = 1;
            // 
            // uiAvatarSugar
            // 
            this.uiAvatarSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatarSugar.AvatarSize = 180;
            this.uiAvatarSugar.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiAvatarSugar.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatarSugar.Image = ((System.Drawing.Image)(resources.GetObject("uiAvatarSugar.Image")));
            this.uiAvatarSugar.Location = new System.Drawing.Point(3, 3);
            this.uiAvatarSugar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatarSugar.Name = "uiAvatarSugar";
            this.uiAvatarSugar.Size = new System.Drawing.Size(42, 18);
            this.uiAvatarSugar.SymbolSize = 50;
            this.uiAvatarSugar.TabIndex = 0;
            this.uiAvatarSugar.Text = "uiAvatar1";
            // 
            // uiAvatarRicky
            // 
            this.uiAvatarRicky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatarRicky.AvatarSize = 180;
            this.uiAvatarRicky.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiAvatarRicky.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatarRicky.Image = ((System.Drawing.Image)(resources.GetObject("uiAvatarRicky.Image")));
            this.uiAvatarRicky.Location = new System.Drawing.Point(99, 3);
            this.uiAvatarRicky.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatarRicky.Name = "uiAvatarRicky";
            this.uiAvatarRicky.Size = new System.Drawing.Size(42, 18);
            this.uiAvatarRicky.SymbolSize = 50;
            this.uiAvatarRicky.TabIndex = 1;
            this.uiAvatarRicky.Text = "uiAvatar2";
            // 
            // tableLayoutPanelMoInk
            // 
            this.tableLayoutPanelMoInk.ColumnCount = 1;
            this.tableLayoutPanelMoInk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMoInk.Controls.Add(this.symbolLabelSugar, 0, 1);
            this.tableLayoutPanelMoInk.Controls.Add(this.linkLabelSugarGithub, 0, 2);
            this.tableLayoutPanelMoInk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMoInk.Location = new System.Drawing.Point(51, 3);
            this.tableLayoutPanelMoInk.Name = "tableLayoutPanelMoInk";
            this.tableLayoutPanelMoInk.RowCount = 4;
            this.tableLayoutPanelMoInk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMoInk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMoInk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMoInk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMoInk.Size = new System.Drawing.Size(42, 18);
            this.tableLayoutPanelMoInk.TabIndex = 2;
            // 
            // symbolLabelSugar
            // 
            this.symbolLabelSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolLabelSugar.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbolLabelSugar.Location = new System.Drawing.Point(3, 38);
            this.symbolLabelSugar.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolLabelSugar.Name = "symbolLabelSugar";
            this.symbolLabelSugar.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolLabelSugar.Size = new System.Drawing.Size(36, 1);
            this.symbolLabelSugar.Symbol = 61447;
            this.symbolLabelSugar.TabIndex = 0;
            this.symbolLabelSugar.Text = "SugarMGP";
            // 
            // linkLabelSugarGithub
            // 
            this.linkLabelSugarGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelSugarGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSugarGithub.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.linkLabelSugarGithub.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelSugarGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelSugarGithub.Location = new System.Drawing.Point(3, 9);
            this.linkLabelSugarGithub.Name = "linkLabelSugarGithub";
            this.linkLabelSugarGithub.Size = new System.Drawing.Size(36, 1);
            this.linkLabelSugarGithub.TabIndex = 1;
            this.linkLabelSugarGithub.TabStop = true;
            this.linkLabelSugarGithub.Text = "GitHub 主页";
            this.linkLabelSugarGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelSugarGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelSugarGithub.Click += new System.EventHandler(this.LinkLabelMoInkGithub_Click);
            // 
            // tableLayoutPanelRicky
            // 
            this.tableLayoutPanelRicky.ColumnCount = 1;
            this.tableLayoutPanelRicky.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRicky.Controls.Add(this.linkLabelRickyGithub, 0, 2);
            this.tableLayoutPanelRicky.Controls.Add(this.symbolLabelRicky, 0, 1);
            this.tableLayoutPanelRicky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRicky.Location = new System.Drawing.Point(147, 3);
            this.tableLayoutPanelRicky.Name = "tableLayoutPanelRicky";
            this.tableLayoutPanelRicky.RowCount = 4;
            this.tableLayoutPanelRicky.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelRicky.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRicky.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRicky.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelRicky.Size = new System.Drawing.Size(44, 18);
            this.tableLayoutPanelRicky.TabIndex = 3;
            // 
            // linkLabelRickyGithub
            // 
            this.linkLabelRickyGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelRickyGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRickyGithub.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.linkLabelRickyGithub.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRickyGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelRickyGithub.Location = new System.Drawing.Point(3, 9);
            this.linkLabelRickyGithub.Name = "linkLabelRickyGithub";
            this.linkLabelRickyGithub.Size = new System.Drawing.Size(38, 1);
            this.linkLabelRickyGithub.TabIndex = 2;
            this.linkLabelRickyGithub.TabStop = true;
            this.linkLabelRickyGithub.Text = "GitHub 主页";
            this.linkLabelRickyGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelRickyGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelRickyGithub.Click += new System.EventHandler(this.LinkLabelRickyGithub_Click);
            // 
            // symbolLabelRicky
            // 
            this.symbolLabelRicky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolLabelRicky.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbolLabelRicky.Location = new System.Drawing.Point(3, 38);
            this.symbolLabelRicky.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolLabelRicky.Name = "symbolLabelRicky";
            this.symbolLabelRicky.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolLabelRicky.Size = new System.Drawing.Size(38, 1);
            this.symbolLabelRicky.Symbol = 61447;
            this.symbolLabelRicky.TabIndex = 1;
            this.symbolLabelRicky.Text = "Ricky8955555";
            // 
            // tabPageLogs
            // 
            this.tabPageLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPageLogs.Controls.Add(this.comboBoxLogLevel);
            this.tabPageLogs.Controls.Add(this.labelLogLevel);
            this.tabPageLogs.Controls.Add(this.textBoxLogs);
            this.tabPageLogs.ForeColor = System.Drawing.Color.White;
            this.tabPageLogs.Location = new System.Drawing.Point(0, 40);
            this.tabPageLogs.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLogs.Name = "tabPageLogs";
            this.tabPageLogs.Size = new System.Drawing.Size(200, 60);
            this.tabPageLogs.TabIndex = 2;
            this.tabPageLogs.Text = "日志";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.DataSource = null;
            this.comboBoxLogLevel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxLogLevel.FillColor = System.Drawing.Color.White;
            this.comboBoxLogLevel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLogLevel.Location = new System.Drawing.Point(77, 423);
            this.comboBoxLogLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLogLevel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxLogLevel.Size = new System.Drawing.Size(255, 23);
            this.comboBoxLogLevel.TabIndex = 2;
            this.comboBoxLogLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBoxLogLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLogLevel_SelectedIndexChanged);
            // 
            // labelLogLevel
            // 
            this.labelLogLevel.AutoSize = true;
            this.labelLogLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogLevel.Location = new System.Drawing.Point(4, 423);
            this.labelLogLevel.Name = "labelLogLevel";
            this.labelLogLevel.Size = new System.Drawing.Size(79, 20);
            this.labelLogLevel.TabIndex = 1;
            this.labelLogLevel.Text = "日志级别：";
            this.labelLogLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.AutoScroll = true;
            this.textBoxLogs.ButtonSymbol = 61761;
            this.textBoxLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogs.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogs.Location = new System.Drawing.Point(4, 5);
            this.textBoxLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogs.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ShowText = false;
            this.textBoxLogs.Size = new System.Drawing.Size(793, 413);
            this.textBoxLogs.TabIndex = 0;
            this.textBoxLogs.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxLogs.WordWarp = false;
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
            this.contextNotifyIconMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.contextNotifyIconMenuStrip.DropShadowEnabled = false;
            this.contextNotifyIconMenuStrip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextNotifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextNotifyIconMenuStrip.Name = "contextNotifyIconMenuStrip";
            this.contextNotifyIconMenuStrip.Size = new System.Drawing.Size(136, 52);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.OpenToolStripMenuItem.Text = "打开界面";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.contextMenuStrip.DropShadowEnabled = false;
            this.contextMenuStrip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpdateCheckerShow});
            this.contextMenuStrip.Name = "uiContextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 28);
            // 
            // toolStripMenuItemUpdateCheckerShow
            // 
            this.toolStripMenuItemUpdateCheckerShow.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemUpdateCheckerShow.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemUpdateCheckerShow.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItemUpdateCheckerShow.Name = "toolStripMenuItemUpdateCheckerShow";
            this.toolStripMenuItemUpdateCheckerShow.Size = new System.Drawing.Size(135, 24);
            this.toolStripMenuItemUpdateCheckerShow.Text = "检查更新";
            this.toolStripMenuItemUpdateCheckerShow.Click += new System.EventHandler(this.ToolStripMenuItemUpdateCheckerShow_Click);
            // 
            // timerQuicklyControl
            // 
            this.timerQuicklyControl.Interval = 1;
            this.timerQuicklyControl.Tick += new System.EventHandler(this.TimerQuicklyControl_Tick);
            // 
            // WindowMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowMain";
            this.Text = "SeewoHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowMain_FormClosing);
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.tabPageFileSorting.ResumeLayout(false);
            this.tabPageFileSorting.PerformLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageUsefulFeatures.ResumeLayout(false);
            this.groupBoxQuicklyControl.ResumeLayout(false);
            this.tableLayoutPanelQuicklyControl.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanelSkin.ResumeLayout(false);
            this.tableLayoutPanelSkin.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tableLayoutPanelAbout.ResumeLayout(false);
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.tableLayoutPanelContributors.ResumeLayout(false);
            this.tableLayoutPanelMoInk.ResumeLayout(false);
            this.tableLayoutPanelRicky.ResumeLayout(false);
            this.tabPageLogs.ResumeLayout(false);
            this.tabPageLogs.PerformLayout();
            this.contextNotifyIconMenuStrip.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageFileSorting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSubjectStorageInfoListControlButtons;
        private Sunny.UI.UIButton buttonFileSortingInfoAdd;
        private Sunny.UI.UIButton buttonFileSortingInfoRemove;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUsefulFeatures;
        private System.Windows.Forms.TabPage tabPageLogs;
        private Sunny.UI.UICheckBox checkBoxDisableServiceShellHardwareDetection;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Sunny.UI.UIContextMenuStrip contextNotifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private Sunny.UI.UITextBox textBoxLogs;
        private System.Windows.Forms.ListView listViewFileSortingInfos;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderName;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderPath;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderKeywords;
        private Sunny.UI.UIContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateCheckerShow;
        private Sunny.UI.UIButton buttonStartFileSorting;
        private System.Windows.Forms.TabPage tabPageSettings;
        private Sunny.UI.UIComboBox comboBoxStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSkin;
        private Sunny.UI.UILabel labelStyle;
        private Sunny.UI.UICheckBox checkBoxAutoStart;
        private Sunny.UI.UIButton buttonCleanLog;
        private Sunny.UI.UIComboBox comboBoxLogLevel;
        private Sunny.UI.UILabel labelLogLevel;
        private Sunny.UI.UILabel labelExtraFileSortingWay;
        private Sunny.UI.UIComboBox comboBoxExtraFileSortingWay;
        private Sunny.UI.UICheckBox checkBoxAutoCheckUpdate;
        private Sunny.UI.UICheckBox checkBoxHideWhenStart;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private Sunny.UI.UILabel labelProgramName;
        private Sunny.UI.UILabel labelVersion;
        private Sunny.UI.UILinkLabel linkLabelGithub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContributors;
        private Sunny.UI.UIAvatar uiAvatarSugar;
        private Sunny.UI.UIAvatar uiAvatarRicky;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMoInk;
        private Sunny.UI.UISymbolLabel symbolLabelSugar;
        private Sunny.UI.UILinkLabel linkLabelSugarGithub;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRicky;
        private Sunny.UI.UILinkLabel linkLabelRickyGithub;
        private Sunny.UI.UISymbolLabel symbolLabelRicky;
        private Sunny.UI.UICheckBox checkBoxDoubleClickNotify;
        private Sunny.UI.UICheckBox checkBoxDisableServiceWindowsUpdate;
        private Sunny.UI.UICheckBox checkBoxDisableServiceWindowsSearch;
        private Sunny.UI.UICheckBox checkBoxHideToNotify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuicklyControl;
        private Sunny.UI.UIButton buttonShutdown;
        private Sunny.UI.UIButton buttonCancel;
        private Sunny.UI.UIButton buttonRestart;
        private Sunny.UI.UIButton buttonLogout;
        private System.Windows.Forms.GroupBox groupBoxQuicklyControl;
        private Sunny.UI.UIProcessBar processBarQuicklyControl;
        private System.Windows.Forms.Timer timerQuicklyControl;
    }
}


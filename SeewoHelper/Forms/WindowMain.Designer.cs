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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewSubjectStorageInfos = new System.Windows.Forms.ListView();
            this.listViewSubjectStorageInfosColumnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.listViewSubjectStorageInfosColumnHeaderKeywords = new System.Windows.Forms.ColumnHeader();
            this.buttonStartCoursewareSorting = new Sunny.UI.UIButton();
            this.buttonGettingCoursewareSortingSearchingPath = new Sunny.UI.UIButton();
            this.labelCoursewareSortingSearchingPath = new Sunny.UI.UILabel();
            this.textBoxCoursewareSortingSearchingPath = new Sunny.UI.UITextBox();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubjectStorageInfoAdd = new Sunny.UI.UIButton();
            this.buttonSubjectInfoStorageRemove = new Sunny.UI.UIButton();
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxDisableServiceShellHardwareDetection = new Sunny.UI.UICheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBoxAutoStart = new Sunny.UI.UICheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStyle = new Sunny.UI.UILabel();
            this.comboBoxStyle = new Sunny.UI.UIComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxLogs = new Sunny.UI.UITextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotifyIconMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItemShowAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdateCheckerShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextNotifyIconMenuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.listViewSubjectStorageInfos);
            this.tabPage1.Controls.Add(this.buttonStartCoursewareSorting);
            this.tabPage1.Controls.Add(this.buttonGettingCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.labelCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.textBoxCoursewareSortingSearchingPath);
            this.tabPage1.Controls.Add(this.tableLayoutPanelSubjectStorageInfoListControlButtons);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(801, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课件整理";
            // 
            // listViewSubjectStorageInfos
            // 
            this.listViewSubjectStorageInfos.BackColor = System.Drawing.Color.White;
            this.listViewSubjectStorageInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSubjectStorageInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewSubjectStorageInfosColumnHeaderName,
            this.listViewSubjectStorageInfosColumnHeaderPath,
            this.listViewSubjectStorageInfosColumnHeaderKeywords});
            this.listViewSubjectStorageInfos.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewSubjectStorageInfos.ForeColor = System.Drawing.Color.Black;
            this.listViewSubjectStorageInfos.FullRowSelect = true;
            this.listViewSubjectStorageInfos.HideSelection = false;
            this.listViewSubjectStorageInfos.Location = new System.Drawing.Point(4, 41);
            this.listViewSubjectStorageInfos.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSubjectStorageInfos.Name = "listViewSubjectStorageInfos";
            this.listViewSubjectStorageInfos.Size = new System.Drawing.Size(793, 349);
            this.listViewSubjectStorageInfos.TabIndex = 17;
            this.listViewSubjectStorageInfos.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectStorageInfos.View = System.Windows.Forms.View.Details;
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
            // buttonStartCoursewareSorting
            // 
            this.buttonStartCoursewareSorting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartCoursewareSorting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonStartCoursewareSorting.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonStartCoursewareSorting.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartCoursewareSorting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonStartCoursewareSorting.Location = new System.Drawing.Point(689, 400);
            this.buttonStartCoursewareSorting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartCoursewareSorting.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonStartCoursewareSorting.Name = "buttonStartCoursewareSorting";
            this.buttonStartCoursewareSorting.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonStartCoursewareSorting.Size = new System.Drawing.Size(93, 34);
            this.buttonStartCoursewareSorting.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonStartCoursewareSorting.TabIndex = 16;
            this.buttonStartCoursewareSorting.Text = "整理";
            this.buttonStartCoursewareSorting.Click += new System.EventHandler(this.ButtonStartCoursewareSorting_Click);
            // 
            // buttonGettingCoursewareSortingSearchingPath
            // 
            this.buttonGettingCoursewareSortingSearchingPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGettingCoursewareSortingSearchingPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonGettingCoursewareSortingSearchingPath.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingCoursewareSortingSearchingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGettingCoursewareSortingSearchingPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingCoursewareSortingSearchingPath.Location = new System.Drawing.Point(769, 8);
            this.buttonGettingCoursewareSortingSearchingPath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGettingCoursewareSortingSearchingPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonGettingCoursewareSortingSearchingPath.Name = "buttonGettingCoursewareSortingSearchingPath";
            this.buttonGettingCoursewareSortingSearchingPath.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingCoursewareSortingSearchingPath.Size = new System.Drawing.Size(28, 25);
            this.buttonGettingCoursewareSortingSearchingPath.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonGettingCoursewareSortingSearchingPath.TabIndex = 15;
            this.buttonGettingCoursewareSortingSearchingPath.Text = "...";
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
            this.labelCoursewareSortingSearchingPath.Style = Sunny.UI.UIStyle.LightBlue;
            this.labelCoursewareSortingSearchingPath.TabIndex = 13;
            this.labelCoursewareSortingSearchingPath.Text = "搜索路径：";
            this.labelCoursewareSortingSearchingPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCoursewareSortingSearchingPath
            // 
            this.textBoxCoursewareSortingSearchingPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCoursewareSortingSearchingPath.FillColor = System.Drawing.Color.White;
            this.textBoxCoursewareSortingSearchingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCoursewareSortingSearchingPath.Location = new System.Drawing.Point(89, 8);
            this.textBoxCoursewareSortingSearchingPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoursewareSortingSearchingPath.Maximum = 2147483647D;
            this.textBoxCoursewareSortingSearchingPath.Minimum = -2147483648D;
            this.textBoxCoursewareSortingSearchingPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxCoursewareSortingSearchingPath.Name = "textBoxCoursewareSortingSearchingPath";
            this.textBoxCoursewareSortingSearchingPath.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxCoursewareSortingSearchingPath.Size = new System.Drawing.Size(672, 25);
            this.textBoxCoursewareSortingSearchingPath.Style = Sunny.UI.UIStyle.LightBlue;
            this.textBoxCoursewareSortingSearchingPath.TabIndex = 14;
            this.textBoxCoursewareSortingSearchingPath.Leave += new System.EventHandler(this.TextBoxCoursewareSortingSearchingPath_Leave);
            // 
            // tableLayoutPanelSubjectStorageInfoListControlButtons
            // 
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnCount = 2;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectStorageInfoAdd, 0, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectInfoStorageRemove, 1, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Location = new System.Drawing.Point(8, 398);
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
            this.buttonSubjectStorageInfoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubjectStorageInfoAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonSubjectStorageInfoAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectStorageInfoAdd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubjectStorageInfoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectStorageInfoAdd.Location = new System.Drawing.Point(4, 4);
            this.buttonSubjectStorageInfoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubjectStorageInfoAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSubjectStorageInfoAdd.Name = "buttonSubjectStorageInfoAdd";
            this.buttonSubjectStorageInfoAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectStorageInfoAdd.Size = new System.Drawing.Size(91, 32);
            this.buttonSubjectStorageInfoAdd.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonSubjectStorageInfoAdd.TabIndex = 0;
            this.buttonSubjectStorageInfoAdd.Text = "添加";
            this.buttonSubjectStorageInfoAdd.Click += new System.EventHandler(this.ButtonSubjectStorageInfoAdd_Click);
            // 
            // buttonSubjectInfoStorageRemove
            // 
            this.buttonSubjectInfoStorageRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubjectInfoStorageRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubjectInfoStorageRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonSubjectInfoStorageRemove.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectInfoStorageRemove.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubjectInfoStorageRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectInfoStorageRemove.Location = new System.Drawing.Point(103, 4);
            this.buttonSubjectInfoStorageRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubjectInfoStorageRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSubjectInfoStorageRemove.Name = "buttonSubjectInfoStorageRemove";
            this.buttonSubjectInfoStorageRemove.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonSubjectInfoStorageRemove.Size = new System.Drawing.Size(91, 32);
            this.buttonSubjectInfoStorageRemove.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonSubjectInfoStorageRemove.TabIndex = 1;
            this.buttonSubjectInfoStorageRemove.Text = "删除";
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
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(4, 39);
            this.tabControl.MainPage = "";
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 493);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.Style = Sunny.UI.UIStyle.LightBlue;
            this.tabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabIndex = 1;
            this.tabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.checkBoxDisableServiceShellHardwareDetection);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(801, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实用功能";
            // 
            // checkBoxDisableServiceShellHardwareDetection
            // 
            this.checkBoxDisableServiceShellHardwareDetection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDisableServiceShellHardwareDetection.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDisableServiceShellHardwareDetection.Location = new System.Drawing.Point(4, 4);
            this.checkBoxDisableServiceShellHardwareDetection.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisableServiceShellHardwareDetection.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxDisableServiceShellHardwareDetection.Name = "checkBoxDisableServiceShellHardwareDetection";
            this.checkBoxDisableServiceShellHardwareDetection.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxDisableServiceShellHardwareDetection.Size = new System.Drawing.Size(426, 22);
            this.checkBoxDisableServiceShellHardwareDetection.Style = Sunny.UI.UIStyle.LightBlue;
            this.checkBoxDisableServiceShellHardwareDetection.TabIndex = 0;
            this.checkBoxDisableServiceShellHardwareDetection.Text = "关闭U盘插入提示修复（禁用Shell Hardware Detection服务）";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBoxAutoStart);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(801, 453);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAutoStart.Location = new System.Drawing.Point(6, 51);
            this.checkBoxAutoStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxAutoStart.Size = new System.Drawing.Size(123, 25);
            this.checkBoxAutoStart.Style = Sunny.UI.UIStyle.LightBlue;
            this.checkBoxAutoStart.TabIndex = 2;
            this.checkBoxAutoStart.Text = "开机自动启动";
            this.checkBoxAutoStart.ValueChanged += new Sunny.UI.UICheckBox.OnValueChanged(this.CheckBoxAutoStart_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.labelStyle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStyle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 42);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.labelStyle.Style = Sunny.UI.UIStyle.LightBlue;
            this.labelStyle.TabIndex = 1;
            this.labelStyle.Text = "皮肤";
            this.labelStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.comboBoxStyle.Style = Sunny.UI.UIStyle.LightBlue;
            this.comboBoxStyle.TabIndex = 0;
            this.comboBoxStyle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStyle_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.textBoxLogs);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(801, 453);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "日志";
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.AutoScroll = true;
            this.textBoxLogs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogs.FillColor = System.Drawing.Color.White;
            this.textBoxLogs.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogs.Location = new System.Drawing.Point(4, 5);
            this.textBoxLogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLogs.Maximum = 2147483647D;
            this.textBoxLogs.Minimum = -2147483648D;
            this.textBoxLogs.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.Size = new System.Drawing.Size(793, 443);
            this.textBoxLogs.Style = Sunny.UI.UIStyle.LightBlue;
            this.textBoxLogs.TabIndex = 0;
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
            this.toolStripMenuItemShowAbout,
            this.toolStripMenuItemUpdateCheckerShow});
            this.contextMenuStrip.Name = "uiContextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 52);
            // 
            // toolStripMenuItemShowAbout
            // 
            this.toolStripMenuItemShowAbout.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemShowAbout.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItemShowAbout.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItemShowAbout.Name = "toolStripMenuItemShowAbout";
            this.toolStripMenuItemShowAbout.Size = new System.Drawing.Size(135, 24);
            this.toolStripMenuItemShowAbout.Text = "关于";
            this.toolStripMenuItemShowAbout.Click += new System.EventHandler(this.ToolStripMenuItemShowAbout_Click);
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
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 536);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowMain";
            this.Style = Sunny.UI.UIStyle.LightBlue;
            this.Text = "SeewoHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowMain_FormClosing);
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.contextNotifyIconMenuStrip.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSubjectStorageInfoListControlButtons;
        private Sunny.UI.UIButton buttonSubjectStorageInfoAdd;
        private Sunny.UI.UIButton buttonSubjectInfoStorageRemove;
        private Sunny.UI.UITabControl tabControl;
        private Sunny.UI.UIButton buttonGettingCoursewareSortingSearchingPath;
        private Sunny.UI.UILabel labelCoursewareSortingSearchingPath;
        private Sunny.UI.UITextBox textBoxCoursewareSortingSearchingPath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private Sunny.UI.UICheckBox checkBoxDisableServiceShellHardwareDetection;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Sunny.UI.UIContextMenuStrip contextNotifyIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private Sunny.UI.UITextBox textBoxLogs;
        private System.Windows.Forms.ListView listViewSubjectStorageInfos;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderName;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderPath;
        private System.Windows.Forms.ColumnHeader listViewSubjectStorageInfosColumnHeaderKeywords;
        private Sunny.UI.UIContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateCheckerShow;
        private Sunny.UI.UIButton buttonStartCoursewareSorting;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIComboBox comboBoxStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel labelStyle;
        private Sunny.UI.UICheckBox checkBoxAutoStart;
    }
}


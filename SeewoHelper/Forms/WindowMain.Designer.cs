namespace SeewoHelper
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OperationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpgradeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewSubjectStorageInfos = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKeywords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubjectStorageInfoAdd = new System.Windows.Forms.Button();
            this.buttonSubjectInfoStorageRemove = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationMenuItem,
            this.HelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // OperationMenuItem
            // 
            this.OperationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingMenuItem});
            this.OperationMenuItem.Name = "OperationMenuItem";
            this.OperationMenuItem.Size = new System.Drawing.Size(44, 21);
            this.OperationMenuItem.Text = "操作";
            // 
            // SettingMenuItem
            // 
            this.SettingMenuItem.Name = "SettingMenuItem";
            this.SettingMenuItem.Size = new System.Drawing.Size(100, 22);
            this.SettingMenuItem.Text = "选项";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpgradeMenuItem,
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 21);
            this.HelpMenuItem.Text = "帮助";
            // 
            // UpgradeMenuItem
            // 
            this.UpgradeMenuItem.Name = "UpgradeMenuItem";
            this.UpgradeMenuItem.Size = new System.Drawing.Size(124, 22);
            this.UpgradeMenuItem.Text = "检查更新";
            this.UpgradeMenuItem.Click += new System.EventHandler(this.UpgradeMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(124, 22);
            this.AboutMenuItem.Text = "关于...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewSubjectStorageInfos);
            this.tabPage1.Controls.Add(this.tableLayoutPanelSubjectStorageInfoListControlButtons);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课件整理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewSubjectStorageInfos
            // 
            this.listViewSubjectStorageInfos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSubjectStorageInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath,
            this.columnHeaderKeywords});
            this.listViewSubjectStorageInfos.FullRowSelect = true;
            this.listViewSubjectStorageInfos.HideSelection = false;
            this.listViewSubjectStorageInfos.Location = new System.Drawing.Point(7, 6);
            this.listViewSubjectStorageInfos.Name = "listViewSubjectStorageInfos";
            this.listViewSubjectStorageInfos.Size = new System.Drawing.Size(755, 315);
            this.listViewSubjectStorageInfos.TabIndex = 2;
            this.listViewSubjectStorageInfos.UseCompatibleStateImageBehavior = false;
            this.listViewSubjectStorageInfos.View = System.Windows.Forms.View.Details;
            this.listViewSubjectStorageInfos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewSubjectStorageInfos_ColumnWidthChanging);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "名称";
            this.columnHeaderName.Width = 55;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "路径";
            this.columnHeaderPath.Width = 400;
            // 
            // columnHeaderKeywords
            // 
            this.columnHeaderKeywords.Text = "关键词";
            this.columnHeaderKeywords.Width = 300;
            // 
            // tableLayoutPanelSubjectStorageInfoListControlButtons
            // 
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnCount = 2;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectStorageInfoAdd, 0, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Controls.Add(this.buttonSubjectInfoStorageRemove, 1, 0);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Location = new System.Drawing.Point(7, 327);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Name = "tableLayoutPanelSubjectStorageInfoListControlButtons";
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowCount = 1;
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.Size = new System.Drawing.Size(161, 50);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.TabIndex = 1;
            // 
            // buttonSubjectStorageInfoAdd
            // 
            this.buttonSubjectStorageInfoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubjectStorageInfoAdd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSubjectStorageInfoAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonSubjectStorageInfoAdd.Name = "buttonSubjectStorageInfoAdd";
            this.buttonSubjectStorageInfoAdd.Size = new System.Drawing.Size(74, 44);
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
            this.buttonSubjectInfoStorageRemove.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSubjectInfoStorageRemove.Location = new System.Drawing.Point(83, 3);
            this.buttonSubjectInfoStorageRemove.Name = "buttonSubjectInfoStorageRemove";
            this.buttonSubjectInfoStorageRemove.Size = new System.Drawing.Size(75, 44);
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
            this.tabControl.Font = new System.Drawing.Font("宋体", 10F);
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 410);
            this.tabControl.TabIndex = 1;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "WindowMain";
            this.ShowIcon = false;
            this.Text = "SeewoHelper";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelSubjectStorageInfoListControlButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem UpgradeMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSubjectStorageInfoListControlButtons;
        private System.Windows.Forms.Button buttonSubjectStorageInfoAdd;
        private System.Windows.Forms.Button buttonSubjectInfoStorageRemove;
        private System.Windows.Forms.ListView listViewSubjectStorageInfos;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderKeywords;
    }
}



namespace SeewoHelper.Forms
{
    partial class KeywordGettingWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMatchingWay = new Sunny.UI.UILabel();
            this.labelPattern = new Sunny.UI.UILabel();
            this.textBoxPattern = new Sunny.UI.UITextBox();
            this.comboBoxMatchingWay = new Sunny.UI.UIComboBox();
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new Sunny.UI.UIButton();
            this.buttonOK = new Sunny.UI.UIButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.69072F));
            this.tableLayoutPanel1.Controls.Add(this.labelMatchingWay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPattern, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPattern, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMatchingWay, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelMatchingWay
            // 
            this.labelMatchingWay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMatchingWay.AutoSize = true;
            this.labelMatchingWay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatchingWay.Location = new System.Drawing.Point(3, 36);
            this.labelMatchingWay.Name = "labelMatchingWay";
            this.labelMatchingWay.Size = new System.Drawing.Size(74, 36);
            this.labelMatchingWay.Style = Sunny.UI.UIStyle.Blue;
            this.labelMatchingWay.TabIndex = 2;
            this.labelMatchingWay.Text = "匹配方式：";
            this.labelMatchingWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPattern
            // 
            this.labelPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPattern.AutoSize = true;
            this.labelPattern.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPattern.Location = new System.Drawing.Point(3, 0);
            this.labelPattern.Name = "labelPattern";
            this.labelPattern.Size = new System.Drawing.Size(74, 36);
            this.labelPattern.Style = Sunny.UI.UIStyle.Blue;
            this.labelPattern.TabIndex = 1;
            this.labelPattern.Text = "关键词：";
            this.labelPattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPattern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPattern.FillColor = System.Drawing.Color.White;
            this.textBoxPattern.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPattern.Location = new System.Drawing.Point(83, 4);
            this.textBoxPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPattern.Maximum = 2147483647D;
            this.textBoxPattern.Minimum = -2147483648D;
            this.textBoxPattern.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPattern.Size = new System.Drawing.Size(694, 28);
            this.textBoxPattern.Style = Sunny.UI.UIStyle.Blue;
            this.textBoxPattern.TabIndex = 2;
            this.textBoxPattern.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxMatchingWay
            // 
            this.comboBoxMatchingWay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMatchingWay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBoxMatchingWay.FillColor = System.Drawing.Color.White;
            this.comboBoxMatchingWay.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMatchingWay.FormattingEnabled = true;
            this.comboBoxMatchingWay.ItemHeight = 30;
            this.comboBoxMatchingWay.Items.AddRange(new object[] {
            "正常",
            "不区分大小写",
            "正则表达式"});
            this.comboBoxMatchingWay.Location = new System.Drawing.Point(83, 40);
            this.comboBoxMatchingWay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMatchingWay.MinimumSize = new System.Drawing.Size(50, 0);
            this.comboBoxMatchingWay.Name = "comboBoxMatchingWay";
            this.comboBoxMatchingWay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxMatchingWay.Size = new System.Drawing.Size(694, 25);
            this.comboBoxMatchingWay.Style = Sunny.UI.UIStyle.Blue;
            this.comboBoxMatchingWay.TabIndex = 3;
            this.comboBoxMatchingWay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.ColumnCount = 2;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelButton.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(573, 112);
            this.tableLayoutPanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 1;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(207, 48);
            this.tableLayoutPanelButton.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Location = new System.Drawing.Point(107, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Size = new System.Drawing.Size(96, 40);
            this.buttonCancel.Style = Sunny.UI.UIStyle.Blue;
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Location = new System.Drawing.Point(3, 4);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Size = new System.Drawing.Size(97, 40);
            this.buttonOK.Style = Sunny.UI.UIStyle.Blue;
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "确定";
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // KeywordGettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(786, 171);
            this.Controls.Add(this.tableLayoutPanelButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KeywordGettingWindow";
            this.Style = Sunny.UI.UIStyle.Blue;
            this.Text = "修改关键词";
            this.Load += new System.EventHandler(this.KeywordGettingWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UILabel labelMatchingWay;
        private Sunny.UI.UILabel labelPattern;
        private Sunny.UI.UITextBox textBoxPattern;
        private Sunny.UI.UIComboBox comboBoxMatchingWay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButton;
        private Sunny.UI.UIButton buttonOK;
        private Sunny.UI.UIButton buttonCancel;
    }
}
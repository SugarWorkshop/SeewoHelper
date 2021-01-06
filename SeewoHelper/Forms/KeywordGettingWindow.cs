﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class KeywordGettingWindow : Form, IReturnableForm<Keyword, Keyword>
    {
        private Keyword _keyword = null;

        private static readonly Dictionary<KeywordMatchingWay, string> _keywordMatchingWayDictionary = new Dictionary<KeywordMatchingWay, string>()
        {
            [KeywordMatchingWay.Normal] = "正常",
            [KeywordMatchingWay.CaseInsensitive] = "不区分大小写",
            [KeywordMatchingWay.Regex] = "正则表达式"
        };

        public KeywordGettingWindow()
        {
            InitializeComponent();
        }

        public Keyword GetInfo(Keyword keyword = null)
        {
            if (keyword != null)
            {
                _keyword = keyword;
                textBoxPattern.Text = keyword.Pattern;
                comboBoxMatchingWay.Text = _keywordMatchingWayDictionary[keyword.MatchingWay];
            }

            ShowDialog();
            return _keyword;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPattern.Text) || comboBoxMatchingWay.SelectedIndex == -1)
            {
                MessageBox.Show("请输入内容！");
            }
            else
            {
                _keyword = new Keyword(textBoxPattern.Text, _keywordMatchingWayDictionary.GetKey(comboBoxMatchingWay.Text));
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

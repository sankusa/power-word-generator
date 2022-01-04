﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerWordGenerator.Model;
using PowerWordGenerator.ViewModel;

namespace PowerWordGenerator.View
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private MainViewModel _mainViewModel;

        public MainForm(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;

            Text = "パワーワード生成器";

            InitializeComponent();

            _mainViewModel.OnActiveCategoryNameChanged += (string _) => RepaintAll();
            _mainViewModel.OnCategorizedContentChanged += () => RepaintCategorizedContents(true);

            RepaintAll();
        }

        private void RepaintAll()
        {
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(_mainViewModel.CategoryNames.ToArray());

            int index = categoryComboBox.Items.IndexOf(_mainViewModel.ActiveCategoryName);

            if (index == -1)
            {
                categoryComboBox.SelectedIndex = 0;
            } else
            {
                categoryComboBox.SelectedIndex = index;
            }

            materialWordAddTextBox.Text = "";
            favoriteWordCopyTextBox.Text = "";

            RepaintCategorizedContents(false);
        }


        private void RepaintCategorizedContents(bool keepSelection)
        {
            int oldMaterialIndex = materialWordListBox.SelectedIndex;
            int oldFavotiteIndex = favoriteWordListBox.SelectedIndex;

            materialWordListBox.Items.Clear();
            materialWordListBox.Items.AddRange(_mainViewModel.MaterialWords.ToArray());

            favoriteWordListBox.Items.Clear();
            favoriteWordListBox.Items.AddRange(_mainViewModel.FavoriteWords.ToArray());

            materialWordTabPage.Text = "単語(" + _mainViewModel.MaterialWords.Count + ")";
            favoriteWordTabPage.Text = "お気に入り(" + _mainViewModel.FavoriteWords.Count + ")";

            if(keepSelection)
            {
                materialWordListBox.SelectedIndex = oldMaterialIndex >= materialWordListBox.Items.Count ? materialWordListBox.Items.Count - 1 : oldMaterialIndex;
                favoriteWordListBox.SelectedIndex = oldFavotiteIndex >= favoriteWordListBox.Items.Count ? favoriteWordListBox.Items.Count - 1 : oldFavotiteIndex;

                // SelectedIndexに-1を設定した場合のみSelectedIndexChangedが発火しないため、手動で起動
                if (materialWordListBox.SelectedIndex == -1) materialWordListBox_SelectedIndexChanged(materialWordListBox, EventArgs.Empty);
                if (favoriteWordListBox.SelectedIndex == -1) favoriteWordListBox_SelectedIndexChanged(favoriteWordListBox, EventArgs.Empty);
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mainViewModel.ActiveCategoryName = (string)categoryComboBox.SelectedItem;
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            using (TextInputDialog dialog = new TextInputDialog("カテゴリ追加"))
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string input = dialog.GetInputText();

                    if(_mainViewModel.CategoryExists(input))
                    {
                        MessageBox.Show("同名カテゴリが存在します。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _mainViewModel.AddCategory(input);
                    _mainViewModel.Save();
                }
            }
        }

        private void categoryDeleteButton_Click(object sender, EventArgs e)
        {
            if(_mainViewModel.CategoryCount == 1)
            {
                MessageBox.Show(this, "カテゴリ数が1であるため削除できません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show(this, "カテゴリを削除しますか？", "確認", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _mainViewModel.RemoveCategory((string)categoryComboBox.SelectedItem);
                _mainViewModel.Save();
            }
        }


        private void materialWordCountTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool success = int.TryParse(((TextBox)sender).Text, out int ret);
            if (!success || ret < 1)
            {
                ((TextBox)sender).Text = 1.ToString();
                //e.Cancel = true;
                //MessageBox.Show(this, "1以上の整数を入力してください。", "入力値エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void wordGenerateButton_Click(object sender, EventArgs e)
        {
            if (_mainViewModel.MaterialWords.Count == 0)
            {
                MessageBox.Show(this, "単語が登録されていません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            resultTextBox.Text = _mainViewModel.GenerateWord(int.Parse(materialWordCountTextBox.Text));
        }

        private void materialWordAddButton_Click(object sender, EventArgs e)
        {
            string addWord = materialWordAddTextBox.Text;

            if (addWord == "")
            {
                MessageBox.Show(this, "単語が入力されていません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mainViewModel.MaterialWordExists(addWord))
            {
                MessageBox.Show(this, "単語が重複しています。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mainViewModel.AddMaterialWord(addWord);
            _mainViewModel.Save();
            materialWordAddTextBox.Text = "";
        }

        private void materialWordDeleteButton_Click(object sender, EventArgs e)
        {
            if(materialWordListBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, "単語が選択されていません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deleteWord = (string)materialWordListBox.SelectedItem;

            _mainViewModel.RemoveMaterialWord(deleteWord);
            _mainViewModel.Save();
        }

        private void favoriteWordAddButton_Click(object sender, EventArgs e)
        {
            string addWord = resultTextBox.Text;

            if (addWord == "")
            {
                MessageBox.Show(this, "単語が入力されていません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mainViewModel.FavoriteWordExists(addWord))
            {
                MessageBox.Show(this, "単語が重複しています。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _mainViewModel.AddFavoriteWord(addWord);
            _mainViewModel.Save();
            resultTextBox.Text = "";
        }

        private void favoriteWordDeleteButton_Click(object sender, EventArgs e)
        {
            if (favoriteWordListBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, "単語が選択されていません。", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deleteWord = (string)favoriteWordListBox.SelectedItem;

            _mainViewModel.RemoveFavoriteWord(deleteWord);
            _mainViewModel.Save();
        }

        private void materialWordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ListBox) sender).SelectedIndex == -1)
            {
                materialWordDeleteButton.Enabled = false;
            } else
            {
                materialWordDeleteButton.Enabled = true;
            }
        }

        private void favoriteWordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex == -1)
            {
                favoriteWordDeleteButton.Enabled = false;
                favoriteWordCopyTextBox.Text = "";
            }
            else
            {
                favoriteWordDeleteButton.Enabled = true;
                favoriteWordCopyTextBox.Text = (string)(((ListBox)sender).SelectedItem);
            }
        }

        private void favoriteWordCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(favoriteWordCopyTextBox.Text);
        }

        private void favoriteWordCopyTextBox_TextChanged(object sender, EventArgs e)
        {
            if(((TextBox) sender).Text == "")
            {
                favoriteWordCopyButton.Enabled = false;
            } else
            {
                favoriteWordCopyButton.Enabled = true;
            }
        }
    }
}

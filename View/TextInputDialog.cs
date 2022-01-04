using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerWordGenerator
{
    public partial class TextInputDialog : Form
    {
        private string _inputText = "";
        public TextInputDialog(string title)
        {
            InitializeComponent();
            Text = title;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            _inputText = this.inputTextBox.Text;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        public string GetInputText()
        {
            return _inputText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using XulusAPI;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void AButton_Click(object sender, EventArgs e)
        {
            XulusAPI.Api.Attach();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt",
                Title = "Open Lua or Text File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }   
         }

        private async void executeButton_Click(object sender, EventArgs e)
        {
            XulusAPI.Api.ExecuteScript(richTextBox1.Text);
        }

        private async void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}

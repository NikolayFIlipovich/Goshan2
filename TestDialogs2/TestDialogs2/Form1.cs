using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestDialogs2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.RichText);
            }

        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = d.Color;
            }

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog d = new FontDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = d.Font;
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                if (MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) !=
               DialogResult.Yes)
                {
                    e.Cancel = true;
                
            }
        }
    }
}

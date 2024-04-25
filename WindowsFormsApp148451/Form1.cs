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

namespace WindowsFormsApp148451
{
    public partial class Form1 : Form
    {
        private object richTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ButtonСopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttoncolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            { richTextBox1.Font = fontDialog1.Font; }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Clear(); //Очищаем richTextBox

                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к                 нему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем                содержимое файла в richTextBox
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";
                saveFileDialog1.DefaultExt = ".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    var name = saveFileDialog1.FileName;
                    File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));

                }
                richTextBox1.Clear();

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Clear(); //Очищаем richTextBox

                string fileName = openFileDialog1.FileName; 
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); 
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";
                saveFileDialog1.DefaultExt = ".txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    var name = saveFileDialog1.FileName;
                    File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));

                }
                richTextBox1.Clear();

            }
        }

        private void seal_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog()==DialogResult.OK)
            { printDocument1.Print(); }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            { richTextBox1.Font = fontDialog1.Font; }
        }

        private void араметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
                        }

        private void preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void alignment_Click(object sender, EventArgs e)
        {
           
            
               
        }

        private void AboutTheProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutBox1 abautBox = new AboutBox1();
            abautBox.ShowDialog();
            }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
       

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B201210025_NDP_ODEV_2_SORU_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int[,] matris;
        private void btnMatris_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            matris = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matris[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".Satır " + (j + 1) + ".Sütuna sayı gir", "Sayı gir", "", 40, 40));
                    textBox2.Text = textBox2.Text + matris[i, j] + " ";
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }

        private void btnTranspoze_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    textBox3.Text = textBox3.Text + "   " + matris[j, i];//transpoze islemi
                }
                textBox3.Text = textBox3.Text + "\r\n";
            }
        }

        private void btnIz_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int toplam = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == j)
                    {
                        toplam += matris[i, j];//iz bulunur(kosegen toplami)
                    }
                }

            }
            textBox4.Text = textBox4.Text + toplam;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richTextBoxSave.Visible = false;
            richTextBoxOpen.Visible = true;
            richTextBoxSave.Text += "matris\n" + textBox2.Text;
            richTextBoxSave.Text += "transpoz\n" + textBox3.Text + "iz\n" + textBox4.Text;
        
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBoxSave.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
       
            label3.Visible = true;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            richTextBoxOpen.Visible = true;
            
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            richTextBoxOpen.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
       
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBoxSave.Clear();
            richTextBoxOpen.Clear();
            label3.Visible = false;
        }
    }
}

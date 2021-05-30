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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int[,] matrisa, matrisb, toplam, carpim;
        private void btnMatris1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            matrisa = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matrisa[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".Satır" + (j + 1) + ".Sütuna sayı gir", "Sayı gir", "", 40, 40));
                    textBox2.Text = textBox2.Text + matrisa[i, j] + " ";
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }
            private void btnMatris2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            matrisb = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matrisb[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".Satır" + (j + 1) + ".Sütuna sayı gir", "Sayı gir", "", 40, 40));
                    textBox3.Text = textBox3.Text + matrisb[i, j] + " ";
                }
                textBox3.Text = textBox3.Text + "\r\n";
            }
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            toplam = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    toplam[i, j] = matrisa[i, j] + matrisb[i, j];//matrisler toplanir
                    textBox4.Text = textBox4.Text + "   " + toplam[i, j];
                }
                textBox4.Text = textBox4.Text + "\r\n";
            }

        }
        private void btnCarp_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            carpim = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    carpim[i, j] = matrisa[i, j] * matrisb[i, j];//matrisler carpilir
                    textBox5.Text = textBox5.Text + "   " + carpim[i, j];
                }
                textBox5.Text = textBox5.Text + "\r\n";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            richTextBoxOpen.Visible = true;
            richTextBoxSave.Text += "1.matris\n"+textBox2.Text+"2.matris\n"+ textBox3.Text;
            richTextBoxSave.Text += "toplama\n"+textBox4.Text + "çarpma\n" + textBox5.Text;

            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBoxSave.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            label3.Visible = true;
            richTextBoxSave.Visible = false;//gorunurlugu gizler

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            richTextBoxOpen.Visible = true;
            richTextBoxSave.Visible = false;
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            richTextBoxOpen.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void btnReset_Click(object sender, EventArgs e)//temizleme
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBoxSave.Clear();
            richTextBoxOpen.Clear();
            label3.Visible = false;
        }
    }
}

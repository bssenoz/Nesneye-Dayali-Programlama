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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[,] matris;
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));//matrisin nxn degerini alir

            matris = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matris[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ".Satır " + (j + 1) + ".Sütuna sayı gir", "Sayı gir", "", 40, 40));//matris girilir
                    textBox2.Text = textBox2.Text + matris[i, j] + " ";//textboxa veriler aktarılır
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richTextBoxSave.Text += textBox2.Text;//textBoxtaki veriler richTextBoxa da eklenir
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBoxSave.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//dosyaya kaydetme
            }
            label2.Visible = true;//dosyanın kaydedildiğini belirten yazı çıkar
            richTextBoxOpen.Visible = true;//gorunur yapar
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            richTextBoxOpen.Visible = true;
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            richTextBoxOpen.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);//dosyayı acma
        }

        private void btnReset_Click(object sender, EventArgs e)//bu butonla girilen veriler temizlenir
        {
            textBox2.Clear();
            richTextBoxOpen.Clear();
            richTextBoxSave.Clear();
            label2.Visible = false;
        }

       
    }
}

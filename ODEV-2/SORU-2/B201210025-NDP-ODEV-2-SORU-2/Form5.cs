using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//dosya islemi icin

namespace B201210025_NDP_ODEV_2_SORU_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnTers_Click(object sender, EventArgs e)
        {
            int[,] matrixA = new int[2, 2];
            matrixA[0, 0] = int.Parse(textBox1.Text);
            matrixA[0, 1] = int.Parse(textBox2.Text);
            matrixA[1, 0] = int.Parse(textBox3.Text);
            matrixA[1, 1] = int.Parse(textBox4.Text);

            float sonucDetarminant = 0;
            float tut = 1;
            float tut2 = 1;

            double[,] tersi = new double[matrixA.GetUpperBound(0) + 1, matrixA.GetUpperBound(1) + 1];

            for (int i = 0; i <= matrixA.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrixA.GetUpperBound(1); j++)
                {
                    if (i == j) //  0x0 ve 1x1 
                    {
                        tut *= matrixA[i, j];
                    }
                    else if (i != j)//  0x1 ve 1x0 
                    {
                        tut2 *= matrixA[i, j];
                    }
                }
            }
            sonucDetarminant = tut - tut2;
           
            if (sonucDetarminant == 0) //Determinant sıfır ise tersini bulunmaz uyari verir
                MessageBox.Show("Bu Matrisin Detarminantı 0 Olduğundan Tersi Yoktur!",
               "Matris Tersini Alma", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            else //Tersini alma işlemi
            {
                for (int i = 0; i <= tersi.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= tersi.GetUpperBound(1); j++)
                    {
                        if (i == j)
                            tersi[i, j] = (matrixA[1 - i, 1 - j]) /sonucDetarminant;
                        
                        else if (i != j)
                            tersi[i, j] = (-matrixA[i, j]) / sonucDetarminant;
                    }
                    
                }
     
                foreach (var item in tersi)//yazdırma işlemi
                {
                    ListBoxTers.Items.Add(item);
                    
                }

            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
         
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
              
                writer.Write(ListBoxTers.Items[0].ToString()+"  ");
                writer.WriteLine(ListBoxTers.Items[1].ToString());
                writer.Write(ListBoxTers.Items[2].ToString()+ "  ");
                writer.WriteLine(ListBoxTers.Items[3].ToString());
              
                label3.Visible = true;
                writer.Dispose();

                writer.Close();

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            ListBoxTers.Items.Clear();
            label3.Visible = false;
        }
    }
}

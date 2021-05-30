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
using System.Threading;

namespace vitamindeposuoyunu
{
    public partial class Form1 : Form
    {
        private List<Meyve> _Meyves;
        private Meyve _aktifMeyve;
        private NarenciyeSikacak _narenciyeSikacak;
        private KatiSikacak _katiSikacak;
        private Portakal _portakal;
        private Mandalina _mandalina;
        private Greyfurt _greyfurt;
        private Elma _elma;
        private Armut _armut;
        private Cilek _cilek;
      

        public Form1()
        {
            InitializeComponent();
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }


        private void btnSonlandir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void YeniOyunBaslat()
        {
            string prefix = Application.StartupPath;
            prefix += "/images/";
            _portakal = new Portakal(prefix + "portakal.jpg");
            _greyfurt = new Greyfurt(prefix + "greyfurt.jpg");
            _mandalina = new Mandalina(prefix + "mandalina.png");
            _elma = new Elma(prefix + "elma.jpg");
            _armut = new Armut(prefix + "armut.jpg");
            _cilek = new Cilek(prefix + "cilek.jpg");

            _narenciyeSikacak = new NarenciyeSikacak();
            _katiSikacak = new KatiSikacak();
        

            lblA.Text = "0";
            lblC.Text = "0";
            lblGram.Text = "0";
            lblGramSon.Text = "0";
            lblOyunSuresi.Text = "60";

            btnBaslat.Enabled = false;
            btnSonlandir.Enabled = true;
            btnKatiSikacak.Enabled = true;
            btnNarenciyeSikacak.Enabled = true;

            MeyveListesiOlustur();
            RastgeleMeyveGoster();

            time.Enabled = true;

        }
        private void OyunBitti()
        {
            time.Enabled = false;

            picMeyveImage.InitialImage = null;

            btnKatiSikacak.Enabled = false;
            btnNarenciyeSikacak.Enabled = false;
            btnSonlandir.Enabled = false;

            btnBaslat.Enabled = true;

        }


        private void MeyveListesiOlustur()
        {

            _Meyves = new List<Meyve>();
            _Meyves.Add(_portakal);
            _Meyves.Add(_greyfurt);
            _Meyves.Add(_mandalina);
            _Meyves.Add(_elma);
            _Meyves.Add(_armut);
            _Meyves.Add(_cilek);
        }

        private void RastgeleMeyveGoster()
        {

            Random rnd = new Random();
            int MeyveOrder = rnd.Next(0, 6);
            _aktifMeyve = _Meyves[MeyveOrder];
            picMeyveImage.Image = _aktifMeyve.getImage();
        }

        private void ZamaniYaz(int saniye)
        {
            int aktifZaman = int.Parse(lblOyunSuresi.Text);
            int yeniZaman = aktifZaman + saniye;

            if (yeniZaman == 0)
                OyunBitti();

            lblOyunSuresi.Text = yeniZaman.ToString();
        }


        private void time_Tick(object sender, EventArgs e)
        {
            ZamaniYaz(-1);
        }


        private void btnKatiSikacak_Click(object sender, EventArgs e)
        {

            if (_aktifMeyve.GetType().BaseType.ToString() == "vitamindeposuoyunu.KatiMeyve")
            {
                _katiSikacak.meyveEkle(_aktifMeyve);

                int gramlbl = int.Parse(lblGram.Text);
                int gramToplam = gramlbl + _aktifMeyve.getGram();
                lblGram.Text = gramToplam.ToString();

                int gramSonlbl = int.Parse(lblGramSon.Text);
                int gramSonToplam = gramSonlbl + _katiSikacak.getGramSon();
                lblGramSon.Text = gramSonToplam.ToString();

                double VitAlbl = Double.Parse(lblA.Text);
                double toplamVitA = VitAlbl + _katiSikacak.getVitA();
                lblA.Text = toplamVitA.ToString();

                double VitClbl = Double.Parse(lblC.Text);
                double toplamVitC = VitClbl + _katiSikacak.getVitC();
                lblC.Text = toplamVitC.ToString();


                MeyveListesiOlustur();
                RastgeleMeyveGoster();
            }

        }

        private void btnNarenciyeSikacak_Click(object sender, EventArgs e)
        {

            if (_aktifMeyve.GetType().BaseType.ToString() == "vitamindeposuoyunu.NarenciyeMeyve")
            {
                _narenciyeSikacak.meyveEkle(_aktifMeyve);

                int lblgram = int.Parse(lblGram.Text);
                int gramToplam = lblgram + _aktifMeyve.getGram();
                lblGram.Text = gramToplam.ToString();

                int lblgramSon = int.Parse(lblGramSon.Text);
                int gramSon = lblgramSon + _narenciyeSikacak.getGramSon();
                lblGramSon.Text = gramSon.ToString();

                double lblAdegeri = Double.Parse(lblA.Text);
                double toplamVitA = lblAdegeri + _narenciyeSikacak.getVitA();
                lblA.Text = toplamVitA.ToString();

                double lblCdegeri = Double.Parse(lblC.Text);
                double toplamVitC = lblCdegeri + _narenciyeSikacak.getVitC();
                lblC.Text = toplamVitC.ToString();

                MeyveListesiOlustur();
                RastgeleMeyveGoster();
            }
        }
    }
}

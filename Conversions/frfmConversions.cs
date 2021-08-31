using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class frfmConversions : Form
    {
        public frfmConversions()
        {
            InitializeComponent();
        }

        private void btnBinaireDecimal_Click(object sender, EventArgs e)
        {
            //lecture
            string sBinaire = txtBinaireADec.Text;
            int nbDecimal = 0;
            int i = 0;
            int exposant = 0;

            //validation
            if (sBinaire.Length > 8)
            {
                MessageBox.Show("doit être sur 8 bits ou moins");
                return;
            }
            while ((i < sBinaire.Length) && (sBinaire[i] == '0' || sBinaire[i] == '1'))
            {
                i++;
            }
            if (i < sBinaire.Length)
            {
                MessageBox.Show("quand c'est binaire, c'est des 1 ou des 0");
                return;
            }

            //traitement
            for (i = sBinaire.Length - 1; i >= 0; i--)
            {
                if ((sBinaire[i] == '1'))
                    nbDecimal += (int)Math.Pow(2, exposant);
                exposant++;
            }

            //affichage
            txtDecimalDeBin.Text = nbDecimal.ToString();

        }

        private void btnDecBin_Click(object sender, EventArgs e)
        {
            //lecture
            string sDecimal = txtDecimalABin.Text;
            int BaseInitiale = 10;
            int BaseFinale = 2;

            //validation
            if (string.IsNullOrEmpty(txtDecimalABin.Text))
            {
                MessageBox.Show("Veuiller entrer un nombre décimal.");
                return;
            }

            //traitement
            string Resultat = Convert.ToString(Convert.ToInt32(sDecimal, BaseInitiale), BaseFinale);

            //affichage
            txtBinaireDeDec.Text = Resultat.ToString();
        }

        private void btnHexaDec_Click(object sender, EventArgs e)
        {
            //lecture
            string sHexa = txtHexaADec.Text;
            int BaseInitiale = 16;
            int BaseFinale = 10;

            //validation
            if (string.IsNullOrEmpty(txtHexaADec.Text))
            {
                MessageBox.Show("Veuiller entrer un nombre hexadécimal.");
                return;
            }

            //traitement
            string Resultat = Convert.ToString(Convert.ToInt32(sHexa, BaseInitiale), BaseFinale);

            //affichage
            txtDecimalDeHexa.Text = Resultat.ToString();
        }

        private void btnDecHexa_Click(object sender, EventArgs e)
        {
            //lecture
            string sHexa = txtDecimalAHexa.Text;
            int BaseInitiale = 10;
            int BaseFinale = 16;

            //validation
            if (string.IsNullOrEmpty(txtDecimalAHexa.Text))
            {
                MessageBox.Show("Veuiller entrer un nombre décimal.");
                return;
            }

            //traitement
            string Resultat = Convert.ToString(Convert.ToInt32(sHexa, BaseInitiale), BaseFinale);

            //affichage
            txtHexaDeDec.Text = Resultat.ToString();
        }

        private void btnBinHexa_Click(object sender, EventArgs e)
        {
            //lecture
            string sHexa = txtBinAHexa.Text;
            int BaseInitiale = 2;
            int BaseFinale = 16;

            //validation
            if (string.IsNullOrEmpty(txtBinAHexa.Text))
            {
                MessageBox.Show("Veuiller entrer un nombre binaire.");
                return;
            }

            //traitement
            string Resultat = Convert.ToString(Convert.ToInt32(sHexa, BaseInitiale), BaseFinale);

            //affichage
            txtHexaDeBin.Text = Resultat.ToString();
        }

        private void btnHexaBin_Click(object sender, EventArgs e)
        {
            //lecture
            string sHexa = txtHexaABin.Text;
            int BaseInitiale = 16;
            int BaseFinale = 2;

            //validation
            if (string.IsNullOrEmpty(txtHexaABin.Text)|| sHexa=System.Globalization.NumberStyles.HexNumber)
            {
                MessageBox.Show("Veuiller entrer un nombre hexadécimal.");
                return;
            }

            //traitement
            string Resultat = Convert.ToString(Convert.ToInt32(sHexa, BaseInitiale), BaseFinale);

            //affichage
            txtBinDeHexa.Text = Resultat.ToString(); 
        }
    }
}


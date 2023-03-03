using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade03032023
{
    public partial class FormPersonagens : Form
    {
        public FormPersonagens()
        {
            InitializeComponent();
        }

        private void FormPersonagens_SelectedIndexChanged(object sender, EventArgs e)
        {
          switch (listBoxPersonagem.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.asta1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.saitama1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.senku1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.madara;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.naruto;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.sasuke;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxPersonagem.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.asta1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.saitama1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.senku1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.madara;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.naruto;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.sasuke;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }
    }
}

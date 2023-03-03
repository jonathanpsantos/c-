using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula030323
{
    public partial class FormPersonagens : Form
    {
        public FormPersonagens()
        {
            InitializeComponent();
        }

        private void ltbPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ltbPersonagem.SelectedIndex)
            {
                case 0:
                    pictureBoxPersonagem.Image = Properties.Resources.goku;
                    break;
                case 1:
                    pictureBoxPersonagem.Image = Properties.Resources.vegeta;
                    break;
                case 2:
                    pictureBoxPersonagem.Image = Properties.Resources.inuyasha;
                    break;
                case 3:
                    pictureBoxPersonagem.Image = Properties.Resources.sesshoumaru;
                    break;
                default:
                    pictureBoxPersonagem.Image = null;
                    break;
            }
        }

        private void cmbPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPersonagem.SelectedIndex)
            {
                case 0:
                    pictureBoxPersonagem.Image = Properties.Resources.goku;
                    break;
                case 1:
                    pictureBoxPersonagem.Image = Properties.Resources.vegeta;
                    break;
                case 2:
                    pictureBoxPersonagem.Image = Properties.Resources.inuyasha;
                    break;
                case 3:
                    pictureBoxPersonagem.Image = Properties.Resources.sesshoumaru;
                    break;
                default:
                    pictureBoxPersonagem.Image = null;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

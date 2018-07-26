using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisTec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja finalizar o SOSTecVip System?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Data Atual: " + DateTime.Now.ToShortDateString()+ "  ";
            toolStripStatusLabel2.Text = "Hora Atual: " + DateTime.Now.ToLongTimeString() + "  ";
            toolStripStatusLabel3.Text = "Usuário Logado: " + "Arnaldo Martins Hidalgo Jr.";
        }
    }
}

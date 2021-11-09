using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_Sorvetes : Form
    {
        SorvetesBLL sorbll = new SorvetesBLL();
        SorvetesDTO sordto = new SorvetesDTO();
        public Frm_Sorvetes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sordto.Sabores = txtSabores.Text;
            sordto.Recheios = txtRecheios.Text;
            sordto.Caldas = txtCaldas.Text;

            sorbll.Inserir(sordto);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }
    }
}

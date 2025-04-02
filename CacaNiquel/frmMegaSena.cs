using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacaNiquel
{
    public partial class frmMegaSena : Form
    {

        /* -------------------- VARIÁVEIS GLOBAIS -------------------- */

        private Random sorteio = new Random();
        private int numeroSorteado;
        private int[] cartao;

        /* -------------------- COMPONENTES -------------------- */

        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void brSortearNumeros_Click(object sender, EventArgs e)
        {
            // consistência de dados - quantidade de cartões
            if (String.IsNullOrWhiteSpace(txtQuantidadeCartoes.Text))
            {
                MessageBox.Show("Informe a quantidade de cartões desejados !!",
                    "Mega Sena",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            }
        }
        
        /* -------------------- FUNÇÕES -------------------- */



    }
}

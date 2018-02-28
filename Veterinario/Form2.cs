using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(animales1);
            bunifuTransition1.HideSync(nuevoCliente1);
            bunifuTransition1.HideSync(nuevaMascota1);
            bunifuTransition2.HideSync(visitas1);
            bunifuTransition2.HideSync(nuevaVisita1);
            bunifuTransition2.ShowSync(clientes1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(clientes1);
            bunifuTransition1.HideSync(nuevoCliente1);
            bunifuTransition2.HideSync(visitas1);
            bunifuTransition1.HideSync(nuevaMascota1);
            bunifuTransition2.HideSync(nuevaVisita1);
            bunifuTransition2.ShowSync(animales1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(clientes1);
            bunifuTransition2.HideSync(animales1);
            bunifuTransition1.HideSync(nuevaMascota1);
            bunifuTransition2.HideSync(nuevaVisita1);
            bunifuTransition2.HideSync(visitas1);
            bunifuTransition1.ShowSync(nuevoCliente1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(clientes1);
            bunifuTransition2.HideSync(animales1);
            bunifuTransition1.HideSync(nuevoCliente1);
            bunifuTransition2.HideSync(visitas1);
            bunifuTransition2.HideSync(nuevaVisita1);
            bunifuTransition1.ShowSync(nuevaMascota1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(clientes1);
            bunifuTransition2.HideSync(animales1);
            bunifuTransition1.HideSync(nuevoCliente1);
            bunifuTransition1.HideSync(nuevaMascota1);
            bunifuTransition2.HideSync(visitas1);
            bunifuTransition2.ShowSync(nuevaVisita1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(clientes1);
            bunifuTransition2.HideSync(animales1);
            bunifuTransition1.HideSync(nuevoCliente1);
            bunifuTransition1.HideSync(nuevaMascota1);
            bunifuTransition2.HideSync(nuevaVisita1);
            bunifuTransition2.ShowSync(visitas1);



        }
    }
}

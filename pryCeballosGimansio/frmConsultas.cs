using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCeballosGimansio
{
    public partial class frmConsultas : Form
    {
        private string[] clientes;
        private string[]? listaClientes;

        public frmConsultas(string[] listaclientes)
        {
            InitializeComponent();

            clientes = listaclientes;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (!string.IsNullOrEmpty(clientes[i]))
                {
                    lstConsultas.Items.Add(clientes[i]);
                }
            }


        }

        private void btnVer_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (!string.IsNullOrEmpty(clientes[i]))
                {
                    lstConsultas.Items.Add(clientes[i]);
                }
            }
        }
    }
}
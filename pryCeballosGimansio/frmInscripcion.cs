using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace pryCeballosGimansio
{
    public partial class frmInscripcion : Form
    {
        //declaron de constantes 

        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;
        const decimal PRECIO_NATACION = 22000;
        const decimal PRECIO_CASILLERO = 3000;

        const int EDAD_MINIMA = 14;

        const decimal RECARGO_TARJETA_3_CUOTAS = 0.10m;
        const decimal RECARGO_TARJETA_6_CUOTAS = 0.20m;


        //delcarar ARRAY 1 dimension-vector

        public string[] arrayClientes = new string[3];
        int IndiceClientes = 0;

        //estructura para SOCIOS
        struct SOCIO
        {
            public string nombre;

            public int edad;

            public string categoria;

            public string plan;

            public string horarioElegido;

            public int meses;
            public string formaPago;

            public decimal total;

            public decimal valorCuota;
        }


        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            //valores por defecto
            txtNombre.Clear();
            txtEdad.Clear();
            cbCasillero.Checked = false;
            cbEstudiante.Checked = false;
            cmbPlan.SelectedIndex = 0;
            cmbTurno.SelectedIndex = 0;
            txtMeses.Text = "1";
            rbEfectivo.Checked = true;
            cmbCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();

        }


        private void frmInscripcion_Load(object sender, EventArgs e)
        {

            {

            }


        }

        //evento para habilitar o deshabilitar el comboBox de cuotas segun la opcion
        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked == true)
            {
                cmbCuotas.Enabled = true;
                cmbCuotas.SelectedIndex = 0;
            }
            else
            {
                cmbCuotas.Enabled = false;
                cmbCuotas.SelectedIndex = -1;
            }

        }

        //evento para solo ppuedan ingresar numeros en el textbox txtmeses y txtedad

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)

            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }


        private void txt_TextChanged(object sender, EventArgs e)
        {



            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {



            string nombre = txtNombre.Text;
            string planElegido = cmbPlan.Text;
            string horarioElegido;
            int cuotas = 1;
            decimal precioMensual = 0;
            decimal subtotal = 0;
            decimal porcentajeDescuento = 0;
            decimal porcentajeAjuste = 0;
            decimal valorCuota = 0;
            decimal total = 0;


            //mostrar un mensaje de error si la edad es menor a 14 años o si el numero de meses es mayor a 12 o menor a 1
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad minima para inscribirse es de 14 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Frena la ejecución de forma segura
            }

            // Validar meses
            if (!int.TryParse(txtMeses.Text, out int meses))
            {
                MessageBox.Show("El numero de meses debe estar entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            switch (planElegido)
            {
                case "Musculacion":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natacion":
                    precioMensual = PRECIO_NATACION;
                    break;

                default:
                    MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            //Estructura para guardar horario elegido

            switch (cmbTurno.SelectedIndex)
            {
                case 0:
                    horarioElegido = "Mañana (7 a 12 hs)";
                    break;
                case 1:
                    horarioElegido = "Tarde (14 a 18 hs)";
                    break;
                case 2:
                    horarioElegido = "Noche (18 a 23 hs)";
                    break;
                default:
                    MessageBox.Show("Debe seleccionar un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            //Validación de casillero seleccionado

            if (cbCasillero.Checked) precioMensual = precioMensual + PRECIO_CASILLERO;

            subtotal = precioMensual * meses;


            //Validación para aplicar descuento correspondiente

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else if (edad >= 65)
            {
                porcentajeDescuento = 0.30m;
                total = subtotal - (subtotal * porcentajeDescuento);

            }
            else if (cbEstudiante.Checked)
            {
                porcentajeDescuento = 0.15m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else
            {
                porcentajeDescuento = 0;
                total = subtotal - (subtotal * porcentajeDescuento);
            }



            //Validación para aplicar recargo correspondiente con tarjeta de crédito
            //y número de cuotas seleccionadas

            if (rbEfectivo.Checked)
            {
                porcentajeAjuste = 0.1m;
                total = total - (total * porcentajeAjuste);
            }
            else if (rbTarjeta.Checked)
            {
                switch (cmbCuotas.SelectedIndex)
                {
                    case 0:
                        porcentajeAjuste = 0;
                        cuotas = 1;
                        break;
                    case 1:
                        porcentajeAjuste = RECARGO_TARJETA_3_CUOTAS;
                        cuotas = 3;
                        total = total + (total * porcentajeAjuste);
                        break;
                    case 2:
                        porcentajeAjuste = RECARGO_TARJETA_6_CUOTAS;
                        cuotas = 6;
                        total = total + (total * porcentajeAjuste);
                        break;
                }

                //Validación de casillero seleccionado

                if (cbCasillero.Checked) precioMensual = precioMensual + PRECIO_CASILLERO;

                subtotal = precioMensual * meses;

            }
            //Validación para aplicar descuento correspondiente

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else if (edad >= 65)
            {
                porcentajeDescuento = 0.30m;
                total = subtotal - (subtotal * porcentajeDescuento);

            }
            else if (cbEstudiante.Checked)
            {
                porcentajeDescuento = 0.15m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else
            {
                porcentajeDescuento = 0;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            //Validación para aplicar recargo correspondiente con tarjeta de crédito
            //y número de cuotas seleccionadas

            if (rbEfectivo.Checked)
            {
                porcentajeAjuste = 0.1m;
                total = total - (total * porcentajeAjuste);
            }
            else if (rbTarjeta.Checked)
            {
                switch (cmbCuotas.SelectedIndex)
                {
                    case 0:
                        porcentajeAjuste = 0;
                        cuotas = 1;
                        break;
                    case 1:
                        porcentajeAjuste = RECARGO_TARJETA_3_CUOTAS;
                        cuotas = 3;
                        total = total + (total * porcentajeAjuste);
                        break;
                    case 2:
                        porcentajeAjuste = RECARGO_TARJETA_6_CUOTAS;
                        cuotas = 6;
                        total = total + (total * porcentajeAjuste);
                        break;
                }

            }




            //Validación para determinar la categoría del socio según su edad

            string categoria = edad < 18 ? "Menor" : "Mayor";


            // Validación para determinar la forma de pago y el valor de la cuota según la opción seleccionada

            string formaPago = rbEfectivo.Checked
                ? "Efectivo"
                : "Tarjeta en " + cuotas + " cuotas";

            valorCuota = rbEfectivo.Checked
                ? total
                : total / cuotas;

            // Creación de la variable socio con los datos ingresados y calculados

            var socio = new SOCIO();

            socio.nombre = nombre;
            socio.edad = edad;
            socio.categoria = categoria;
            socio.plan = planElegido;
            socio.horarioElegido = horarioElegido;
            socio.meses = meses;
            socio.formaPago = formaPago;
            socio.total = total;
            socio.valorCuota = valorCuota;
            string mensaje = "";

            if (rbTarjeta.Checked)
            {
                mensaje =
                    "Nombre: " + socio.nombre + "\n" +
                    "Edad: " + socio.edad + " años\n" +
                    "Categoría: " + socio.categoria + "\n" +
                    "Plan: " + socio.plan + "\n" +
                    "Horario: " + socio.horarioElegido + "\n" +
                    "Meses: " + socio.meses + "\n" +
                    "Forma de pago: " + socio.formaPago + "\n\n" +
                    "Total a pagar: " + socio.total + "\n" +
                    "Valor de cuota: " + socio.valorCuota; ;
            }
            else
            {
                mensaje =
                    "Nombre: " + socio.nombre + "\n" +
                    "Edad: " + socio.edad + " años\n" +
                    "Categoría: " + socio.categoria + "\n" +
                    "Plan: " + socio.plan + "\n" +
                    "Horario: " + socio.horarioElegido + "\n" +
                    "Meses: " + socio.meses + "\n" +
                    "Forma de pago: " + socio.formaPago + "\n\n" +
                    "Total a pagar: " + socio.total + "\n";
            }

            MessageBox.Show(mensaje, "Resumen Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //grabar en array 1 dimensión

            arrayClientes[IndiceClientes] = mensaje;
            IndiceClientes++;

            if (IndiceClientes == arrayClientes.Length)
            {
                btnCalcular.Enabled = false;
            }

            EstadoInicial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmConsultas consulta = new frmConsultas(arrayClientes);
            consulta.ShowDialog();
            this.Show();
        }
    }
}











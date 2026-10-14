namespace pryCeballosGimansio
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbDatosPersonales = new TabControl();
            tbDatos = new TabPage();
            cbEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            tbPlanMensual = new TabPage();
            cbCasillero = new CheckBox();
            cmbPlan = new ComboBox();
            cmbTurno = new ComboBox();
            txtMeses = new TextBox();
            lblTurno = new Label();
            lblMeses = new Label();
            lblPlan = new Label();
            tbPago = new TabPage();
            rbTarjeta = new RadioButton();
            cmbCuotas = new ComboBox();
            rbEfectivo = new RadioButton();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            btnConsultar = new Button();
            tbDatosPersonales.SuspendLayout();
            tbDatos.SuspendLayout();
            tbPlanMensual.SuspendLayout();
            tbPago.SuspendLayout();
            SuspendLayout();
            // 
            // tbDatosPersonales
            // 
            tbDatosPersonales.Controls.Add(tbDatos);
            tbDatosPersonales.Controls.Add(tbPlanMensual);
            tbDatosPersonales.Controls.Add(tbPago);
            tbDatosPersonales.Location = new Point(12, 12);
            tbDatosPersonales.Name = "tbDatosPersonales";
            tbDatosPersonales.SelectedIndex = 0;
            tbDatosPersonales.Size = new Size(306, 193);
            tbDatosPersonales.TabIndex = 0;
            // 
            // tbDatos
            // 
            tbDatos.BackColor = Color.DarkSalmon;
            tbDatos.Controls.Add(cbEstudiante);
            tbDatos.Controls.Add(txtEdad);
            tbDatos.Controls.Add(txtNombre);
            tbDatos.Controls.Add(lblEdad);
            tbDatos.Controls.Add(lblNombre);
            tbDatos.ForeColor = SystemColors.ActiveCaptionText;
            tbDatos.Location = new Point(4, 24);
            tbDatos.Name = "tbDatos";
            tbDatos.Padding = new Padding(3);
            tbDatos.Size = new Size(298, 165);
            tbDatos.TabIndex = 0;
            tbDatos.Text = "Datos Personales";
            // 
            // cbEstudiante
            // 
            cbEstudiante.AutoSize = true;
            cbEstudiante.Location = new Point(83, 116);
            cbEstudiante.Name = "cbEstudiante";
            cbEstudiante.Size = new Size(81, 19);
            cbEstudiante.TabIndex = 4;
            cbEstudiante.Text = "Estudiante";
            cbEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.Coral;
            txtEdad.Location = new Point(74, 71);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            txtEdad.TextChanged += txt_TextChanged;
            txtEdad.KeyPress += txt_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Coral;
            txtNombre.Location = new Point(74, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txt_TextChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(18, 74);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // tbPlanMensual
            // 
            tbPlanMensual.BackColor = Color.DarkSalmon;
            tbPlanMensual.Controls.Add(cbCasillero);
            tbPlanMensual.Controls.Add(cmbPlan);
            tbPlanMensual.Controls.Add(cmbTurno);
            tbPlanMensual.Controls.Add(txtMeses);
            tbPlanMensual.Controls.Add(lblTurno);
            tbPlanMensual.Controls.Add(lblMeses);
            tbPlanMensual.Controls.Add(lblPlan);
            tbPlanMensual.Location = new Point(4, 24);
            tbPlanMensual.Name = "tbPlanMensual";
            tbPlanMensual.Padding = new Padding(3);
            tbPlanMensual.Size = new Size(298, 165);
            tbPlanMensual.TabIndex = 1;
            tbPlanMensual.Text = "Plan Mensual";
            // 
            // cbCasillero
            // 
            cbCasillero.AutoSize = true;
            cbCasillero.Location = new Point(30, 131);
            cbCasillero.Name = "cbCasillero";
            cbCasillero.Size = new Size(147, 19);
            cbCasillero.TabIndex = 6;
            cbCasillero.Text = "Casillero (+3000 x mes)";
            cbCasillero.UseVisualStyleBackColor = true;
            // 
            // cmbPlan
            // 
            cmbPlan.BackColor = Color.Coral;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cmbPlan.Location = new Point(66, 17);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(111, 23);
            cmbPlan.TabIndex = 5;
            // 
            // cmbTurno
            // 
            cmbTurno.BackColor = Color.Coral;
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Mañana (7 a 12 hs)", "Tarde (14 a 18 hs)", "Noche (18 a 23 hs)" });
            cmbTurno.Location = new Point(66, 89);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(111, 23);
            cmbTurno.TabIndex = 4;
            // 
            // txtMeses
            // 
            txtMeses.BackColor = Color.Coral;
            txtMeses.Location = new Point(66, 53);
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(111, 23);
            txtMeses.TabIndex = 3;
            txtMeses.TextChanged += txt_TextChanged;
            txtMeses.KeyPress += txt_KeyPress;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(20, 92);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 2;
            lblTurno.Text = "Turno";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(20, 56);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 1;
            lblMeses.Text = "Meses";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(20, 20);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // tbPago
            // 
            tbPago.BackColor = Color.DarkSalmon;
            tbPago.Controls.Add(rbTarjeta);
            tbPago.Controls.Add(cmbCuotas);
            tbPago.Controls.Add(rbEfectivo);
            tbPago.Location = new Point(4, 24);
            tbPago.Name = "tbPago";
            tbPago.Size = new Size(298, 165);
            tbPago.TabIndex = 3;
            tbPago.Text = "Pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(17, 40);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 4;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbCuotas
            // 
            cmbCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Items.AddRange(new object[] { "1 cuota", "3 cuotas", "6 cuotas" });
            cmbCuotas.Location = new Point(83, 39);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(121, 23);
            cmbCuotas.TabIndex = 3;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Location = new Point(17, 12);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 2;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Coral;
            btnLimpiar.Location = new Point(226, 230);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Coral;
            btnCalcular.Location = new Point(145, 230);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Coral;
            btnConsultar.Location = new Point(33, 230);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(330, 282);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(btnConsultar);
            Controls.Add(tbDatosPersonales);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInscripcion";
            Load += frmInscripcion_Load;
            tbDatosPersonales.ResumeLayout(false);
            tbDatos.ResumeLayout(false);
            tbDatos.PerformLayout();
            tbPlanMensual.ResumeLayout(false);
            tbPlanMensual.PerformLayout();
            tbPago.ResumeLayout(false);
            tbPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbDatosPersonales;
        private TabPage tbDatos;
        private TabPage tbPlanMensual;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtNombre;
        private CheckBox cbEstudiante;
        private TextBox txtEdad;
        private TextBox txtMeses;
        private Label lblTurno;
        private Label lblMeses;
        private Label lblPlan;
        private ComboBox cmbPlan;
        private ComboBox cmbTurno;
        private CheckBox cbCasillero;
        private TabPage tbPago;
        private RadioButton rbTarjeta;
        private ComboBox cmbCuotas;
        private RadioButton rbEfectivo;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Button btnConsultar;
    }
}
namespace pryCeballosGimansio
{
    partial class frmConsultas
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
            lstConsultas = new ListBox();
            btnVer = new Button();
            btnVovler = new Button();
            SuspendLayout();
            // 
            // lstConsultas
            // 
            lstConsultas.FormattingEnabled = true;
            lstConsultas.Location = new Point(12, 12);
            lstConsultas.Name = "lstConsultas";
            lstConsultas.Size = new Size(352, 214);
            lstConsultas.TabIndex = 0;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(195, 253);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click_1;
            // 
            // btnVovler
            // 
            btnVovler.Location = new Point(289, 253);
            btnVovler.Name = "btnVovler";
            btnVovler.Size = new Size(75, 23);
            btnVovler.TabIndex = 2;
            btnVovler.Text = "Volver";
            btnVovler.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 450);
            Controls.Add(btnVovler);
            Controls.Add(btnVer);
            Controls.Add(lstConsultas);
            Name = "frmConsultas";
            Text = "frmConsultas";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstConsultas;
        private Button btnVer;
        private Button btnVovler;
    }
}
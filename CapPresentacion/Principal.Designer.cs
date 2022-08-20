namespace CapPresentacion
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNuevoUsuario = new System.Windows.Forms.Button();
            this.btVisitas = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visitas del Instituto";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(96, 317);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(148, 43);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btNuevoUsuario
            // 
            this.btNuevoUsuario.BackColor = System.Drawing.Color.White;
            this.btNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btNuevoUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoUsuario.Image = global::CapPresentacion.Properties.Resources.anadir_grupo;
            this.btNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNuevoUsuario.Location = new System.Drawing.Point(96, 238);
            this.btNuevoUsuario.Name = "btNuevoUsuario";
            this.btNuevoUsuario.Size = new System.Drawing.Size(148, 46);
            this.btNuevoUsuario.TabIndex = 1;
            this.btNuevoUsuario.Text = "Usuarios";
            this.btNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNuevoUsuario.UseVisualStyleBackColor = false;
            this.btNuevoUsuario.Click += new System.EventHandler(this.btNuevoUsuario_Click);
            // 
            // btVisitas
            // 
            this.btVisitas.BackColor = System.Drawing.Color.White;
            this.btVisitas.FlatAppearance.BorderSize = 0;
            this.btVisitas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisitas.Image = global::CapPresentacion.Properties.Resources.menu;
            this.btVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisitas.Location = new System.Drawing.Point(96, 172);
            this.btVisitas.Name = "btVisitas";
            this.btVisitas.Size = new System.Drawing.Size(148, 46);
            this.btVisitas.TabIndex = 1;
            this.btVisitas.Text = "Consultar ";
            this.btVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVisitas.UseVisualStyleBackColor = false;
            this.btVisitas.Click += new System.EventHandler(this.btVisitas_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.BackColor = System.Drawing.Color.White;
            this.btRegistro.FlatAppearance.BorderSize = 0;
            this.btRegistro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistro.Image = global::CapPresentacion.Properties.Resources.registro_en_linea;
            this.btRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegistro.Location = new System.Drawing.Point(96, 102);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(148, 45);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "Registrar";
            this.btRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegistro.UseVisualStyleBackColor = false;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::CapPresentacion.Properties.Resources.edificio;
            this.pictureBox1.Location = new System.Drawing.Point(-66, -222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btNuevoUsuario);
            this.Controls.Add(this.btVisitas);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVisitas;
        private System.Windows.Forms.Button btNuevoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistro;
    }
}
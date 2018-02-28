namespace Veterinario
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.iniciarSesion.FlatAppearance.BorderSize = 0;
            this.iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iniciarSesion.Location = new System.Drawing.Point(12, 196);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(296, 54);
            this.iniciarSesion.TabIndex = 0;
            this.iniciarSesion.Text = "Iniciar";
            this.iniciarSesion.UseVisualStyleBackColor = false;
            this.iniciarSesion.Click += new System.EventHandler(this.iniciarSesion_Click);
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(12, 92);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(296, 26);
            this.usuario.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(12, 140);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(296, 26);
            this.password.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.Gainsboro;
            this.Titulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(-1, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(322, 52);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "INICIAR SESION";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.iniciarSesion);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarSesion;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Titulo;
    }
}


namespace Veterinario
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.visitas1 = new Veterinario.UserControls.visitas();
            this.animales3 = new Veterinario.UserControls.animales();
            this.nuevaVisita1 = new Veterinario.UserControls.NuevaVisita();
            this.nuevaMascota1 = new Veterinario.UserControls.nuevaMascota();
            this.nuevoCliente1 = new Veterinario.UserControls.nuevoCliente();
            this.animales1 = new Veterinario.UserControls.animales();
            this.clientes1 = new Veterinario.UserControls.clientes();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 94);
            this.panel2.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.bunifuTransition1.SetDecoration(this.exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.exit, BunifuAnimatorNS.DecorationType.None);
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1025, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(77, 82);
            this.exit.TabIndex = 6;
            this.exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinica Veterinaria";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 135);
            this.panel3.TabIndex = 2;
            // 
            // button10
            // 
            this.bunifuTransition1.SetDecoration(this.button10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button10, BunifuAnimatorNS.DecorationType.None);
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(928, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(178, 135);
            this.button10.TabIndex = 8;
            this.button10.Text = "Nueva Visita";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.bunifuTransition1.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(744, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(178, 135);
            this.button9.TabIndex = 8;
            this.button9.Text = "Visitas";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.bunifuTransition1.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button8, BunifuAnimatorNS.DecorationType.None);
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(189, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 135);
            this.button8.TabIndex = 7;
            this.button8.Text = "Nuevo Cliente";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.bunifuTransition1.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button7, BunifuAnimatorNS.DecorationType.None);
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(373, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 135);
            this.button7.TabIndex = 6;
            this.button7.Text = "Nueva Mascota";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.bunifuTransition1.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(562, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 135);
            this.button6.TabIndex = 5;
            this.button6.Text = "Mascotas";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 135);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clientes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.visitas1);
            this.panel4.Controls.Add(this.animales3);
            this.panel4.Controls.Add(this.nuevaVisita1);
            this.panel4.Controls.Add(this.nuevaMascota1);
            this.panel4.Controls.Add(this.nuevoCliente1);
            this.panel4.Controls.Add(this.animales1);
            this.panel4.Controls.Add(this.clientes1);
            this.bunifuTransition2.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1114, 415);
            this.panel4.TabIndex = 3;
            // 
            // visitas1
            // 
            this.bunifuTransition1.SetDecoration(this.visitas1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.visitas1, BunifuAnimatorNS.DecorationType.None);
            this.visitas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitas1.Location = new System.Drawing.Point(0, 0);
            this.visitas1.Name = "visitas1";
            this.visitas1.Size = new System.Drawing.Size(1114, 415);
            this.visitas1.TabIndex = 11;
            this.visitas1.Visible = false;
            // 
            // animales3
            // 
            this.bunifuTransition1.SetDecoration(this.animales3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.animales3, BunifuAnimatorNS.DecorationType.None);
            this.animales3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animales3.Location = new System.Drawing.Point(0, 0);
            this.animales3.Name = "animales3";
            this.animales3.Size = new System.Drawing.Size(1114, 415);
            this.animales3.TabIndex = 10;
            this.animales3.Visible = false;
            // 
            // nuevaVisita1
            // 
            this.bunifuTransition1.SetDecoration(this.nuevaVisita1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.nuevaVisita1, BunifuAnimatorNS.DecorationType.None);
            this.nuevaVisita1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevaVisita1.Location = new System.Drawing.Point(0, 0);
            this.nuevaVisita1.Name = "nuevaVisita1";
            this.nuevaVisita1.Size = new System.Drawing.Size(1114, 415);
            this.nuevaVisita1.TabIndex = 4;
            this.nuevaVisita1.Visible = false;
            // 
            // nuevaMascota1
            // 
            this.bunifuTransition1.SetDecoration(this.nuevaMascota1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.nuevaMascota1, BunifuAnimatorNS.DecorationType.None);
            this.nuevaMascota1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevaMascota1.Location = new System.Drawing.Point(0, 0);
            this.nuevaMascota1.Name = "nuevaMascota1";
            this.nuevaMascota1.Size = new System.Drawing.Size(1114, 415);
            this.nuevaMascota1.TabIndex = 3;
            this.nuevaMascota1.Visible = false;
            // 
            // nuevoCliente1
            // 
            this.bunifuTransition1.SetDecoration(this.nuevoCliente1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.nuevoCliente1, BunifuAnimatorNS.DecorationType.None);
            this.nuevoCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nuevoCliente1.Location = new System.Drawing.Point(0, 0);
            this.nuevoCliente1.Name = "nuevoCliente1";
            this.nuevoCliente1.Size = new System.Drawing.Size(1114, 415);
            this.nuevoCliente1.TabIndex = 2;
            this.nuevoCliente1.Visible = false;
            // 
            // animales1
            // 
            this.bunifuTransition1.SetDecoration(this.animales1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.animales1, BunifuAnimatorNS.DecorationType.None);
            this.animales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animales1.Location = new System.Drawing.Point(0, 0);
            this.animales1.Name = "animales1";
            this.animales1.Size = new System.Drawing.Size(1114, 415);
            this.animales1.TabIndex = 1;
            this.animales1.Visible = false;
            // 
            // clientes1
            // 
            this.bunifuTransition1.SetDecoration(this.clientes1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.clientes1, BunifuAnimatorNS.DecorationType.None);
            this.clientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientes1.Location = new System.Drawing.Point(0, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(1114, 415);
            this.clientes1.TabIndex = 0;
            this.clientes1.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1114, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel4;
        private UserControls.clientes clientes1;
        private UserControls.animales animales1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private UserControls.nuevoCliente nuevoCliente1;
        private UserControls.nuevaMascota nuevaMascota1;
        private UserControls.NuevaVisita nuevaVisita1;
        private UserControls.animales animales3;
        private UserControls.visitas visitas1;
    }
}
namespace MiLectorDeVoz
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Play = new System.Windows.Forms.Button();
            this.Bandeja = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Pause);
            this.panel1.Controls.Add(this.Bandeja);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 161);
            this.panel1.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_de_play;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.Color.Aqua;
            this.Play.Location = new System.Drawing.Point(23, 19);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(117, 119);
            this.Play.TabIndex = 0;
            this.Play.Text = " ";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Bandeja
            // 
            this.Bandeja.BackColor = System.Drawing.Color.Transparent;
            this.Bandeja.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.bandeja_de_entrada;
            this.Bandeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bandeja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bandeja.ForeColor = System.Drawing.Color.Aqua;
            this.Bandeja.Location = new System.Drawing.Point(160, 19);
            this.Bandeja.Name = "Bandeja";
            this.Bandeja.Size = new System.Drawing.Size(117, 119);
            this.Bandeja.TabIndex = 1;
            this.Bandeja.Text = " ";
            this.Bandeja.UseVisualStyleBackColor = false;
            this.Bandeja.Click += new System.EventHandler(this.Bandeja_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_de_pausa_de_video;
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.ForeColor = System.Drawing.Color.Aqua;
            this.Pause.Location = new System.Drawing.Point(297, 19);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(117, 119);
            this.Pause.TabIndex = 2;
            this.Pause.Text = " ";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_detener;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.ForeColor = System.Drawing.Color.Aqua;
            this.Stop.Location = new System.Drawing.Point(434, 19);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(117, 119);
            this.Stop.TabIndex = 3;
            this.Stop.Text = " ";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.conversacion;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(600, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 119);
            this.button5.TabIndex = 4;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-4, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 293);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lector de Texto Avanzado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MiLectorDeVoz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Bandeja;
        private System.Windows.Forms.Label label1;
    }
}


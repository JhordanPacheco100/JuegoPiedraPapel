
namespace Juego
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.buttonPiedra = new System.Windows.Forms.Button();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonTigera = new System.Windows.Forms.Button();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.textBoxPantalla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPantalla);
            this.groupBox1.Controls.Add(this.buttonComenzar);
            this.groupBox1.Controls.Add(this.pictureBoxPC);
            this.groupBox1.Controls.Add(this.buttonTigera);
            this.groupBox1.Controls.Add(this.buttonPapel);
            this.groupBox1.Controls.Add(this.buttonPiedra);
            this.groupBox1.Controls.Add(this.pictureBoxUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Elige una Opcion";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(161, 94);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(240, 220);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 1;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // buttonPiedra
            // 
            this.buttonPiedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPiedra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonPiedra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonPiedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPiedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPiedra.Location = new System.Drawing.Point(59, 356);
            this.buttonPiedra.Name = "buttonPiedra";
            this.buttonPiedra.Size = new System.Drawing.Size(89, 33);
            this.buttonPiedra.TabIndex = 4;
            this.buttonPiedra.Text = "Piedra";
            this.buttonPiedra.UseVisualStyleBackColor = true;
            this.buttonPiedra.Click += new System.EventHandler(this.buttonPiedra_Click);
            // 
            // buttonPapel
            // 
            this.buttonPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPapel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonPapel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPapel.Location = new System.Drawing.Point(188, 355);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(89, 33);
            this.buttonPapel.TabIndex = 5;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.buttonPapel_Click);
            // 
            // buttonTigera
            // 
            this.buttonTigera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTigera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonTigera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonTigera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTigera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTigera.Location = new System.Drawing.Point(312, 356);
            this.buttonTigera.Name = "buttonTigera";
            this.buttonTigera.Size = new System.Drawing.Size(89, 33);
            this.buttonTigera.TabIndex = 6;
            this.buttonTigera.Text = "Tigera";
            this.buttonTigera.UseVisualStyleBackColor = true;
            this.buttonTigera.Click += new System.EventHandler(this.buttonTigera_Click);
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBoxPC.Location = new System.Drawing.Point(458, 94);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(240, 220);
            this.pictureBoxPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPC.TabIndex = 7;
            this.pictureBoxPC.TabStop = false;
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonComenzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonComenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComenzar.Location = new System.Drawing.Point(505, 407);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(164, 68);
            this.buttonComenzar.TabIndex = 8;
            this.buttonComenzar.Text = "Comenzar";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click);
            // 
            // textBoxPantalla
            // 
            this.textBoxPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPantalla.Location = new System.Drawing.Point(59, 407);
            this.textBoxPantalla.Multiline = true;
            this.textBoxPantalla.Name = "textBoxPantalla";
            this.textBoxPantalla.Size = new System.Drawing.Size(423, 68);
            this.textBoxPantalla.TabIndex = 9;
            this.textBoxPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "COMPUTADORA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Piedra, Papel o Tigera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 518);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonPiedra;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPantalla;
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.Button buttonTigera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


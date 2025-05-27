namespace ProyectoVenta.Formularios.Configuracion
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnguardarcambios = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguardartipocodigo = new FontAwesome.Sharp.IconButton();
            this.cbotipobarra = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsubir
            // 
            this.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsubir.IconSize = 16;
            this.btnsubir.Location = new System.Drawing.Point(20, 210);
            this.btnsubir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(181, 28);
            this.btnsubir.TabIndex = 107;
            this.btnsubir.Text = "Subir";
            this.btnsubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 106;
            this.label7.Text = "Logo:";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(20, 49);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(181, 153);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 105;
            this.picLogo.TabStop = false;
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(240, 107);
            this.txtruc.Margin = new System.Windows.Forms.Padding(4);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(365, 22);
            this.txtruc.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "R.U.C:";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(240, 49);
            this.txtrazonsocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(365, 22);
            this.txtrazonsocial.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Razón Social:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.btnguardarcambios);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtrazonsocial);
            this.groupBox2.Controls.Add(this.btnsubir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtruc);
            this.groupBox2.Controls.Add(this.picLogo);
            this.groupBox2.Location = new System.Drawing.Point(15, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(624, 256);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Negocio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "Dirección:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(240, 161);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(365, 22);
            this.txtdireccion.TabIndex = 110;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarcambios.IconColor = System.Drawing.Color.Black;
            this.btnguardarcambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarcambios.IconSize = 16;
            this.btnguardarcambios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardarcambios.Location = new System.Drawing.Point(240, 204);
            this.btnguardarcambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(367, 34);
            this.btnguardarcambios.TabIndex = 108;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarcambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnguardartipocodigo);
            this.groupBox3.Controls.Add(this.cbotipobarra);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(15, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(624, 66);
            this.groupBox3.TabIndex = 110;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Codigo Barra";
            // 
            // btnguardartipocodigo
            // 
            this.btnguardartipocodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardartipocodigo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardartipocodigo.IconColor = System.Drawing.Color.Black;
            this.btnguardartipocodigo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardartipocodigo.IconSize = 17;
            this.btnguardartipocodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardartipocodigo.Location = new System.Drawing.Point(324, 23);
            this.btnguardartipocodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardartipocodigo.Name = "btnguardartipocodigo";
            this.btnguardartipocodigo.Size = new System.Drawing.Size(184, 28);
            this.btnguardartipocodigo.TabIndex = 106;
            this.btnguardartipocodigo.Text = "Guardar Cambios";
            this.btnguardartipocodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardartipocodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardartipocodigo.UseVisualStyleBackColor = true;
            this.btnguardartipocodigo.Click += new System.EventHandler(this.btnguardartipocodigo_Click);
            // 
            // cbotipobarra
            // 
            this.cbotipobarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipobarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipobarra.FormattingEnabled = true;
            this.cbotipobarra.Location = new System.Drawing.Point(64, 26);
            this.cbotipobarra.Margin = new System.Windows.Forms.Padding(4);
            this.cbotipobarra.Name = "cbotipobarra";
            this.cbotipobarra.Size = new System.Drawing.Size(245, 25);
            this.cbotipobarra.TabIndex = 134;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 18);
            this.label12.TabIndex = 133;
            this.label12.Text = "Tipo:";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.IconSize = 24;
            this.btnsalir.Location = new System.Drawing.Point(588, 7);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(51, 38);
            this.btnsalir.TabIndex = 157;
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(653, 50);
            this.label3.TabIndex = 156;
            this.label3.Text = "Otros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(653, 370);
            this.label4.TabIndex = 155;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 414);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(673, 461);
            this.MinimumSize = new System.Drawing.Size(673, 461);
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otros";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnsubir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnguardartipocodigo;
        private System.Windows.Forms.ComboBox cbotipobarra;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnguardarcambios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
    }
}
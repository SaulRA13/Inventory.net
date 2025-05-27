namespace ProyectoVenta.Formularios.Inventario
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexportar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnbusqueda = new FontAwesome.Sharp.IconButton();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoLente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEgresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIngresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clientew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(903, 66);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(132, 26);
            this.btnbuscar.TabIndex = 158;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(489, 70);
            this.txtfechafin.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(128, 22);
            this.txtfechafin.TabIndex = 157;
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(189, 70);
            this.txtfechainicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(128, 22);
            this.txtfechainicio.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 156;
            this.label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 154;
            this.label3.Text = "Fecha Fin:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1520, 12);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            // 
            // btnexportar
            // 
            this.btnexportar.BackColor = System.Drawing.SystemColors.Control;
            this.btnexportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnexportar.IconSize = 17;
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexportar.Location = new System.Drawing.Point(28, 124);
            this.btnexportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(180, 44);
            this.btnexportar.TabIndex = 152;
            this.btnexportar.Text = "Descargar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexportar.UseVisualStyleBackColor = false;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 17;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiar.Location = new System.Drawing.Point(1059, 70);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(49, 26);
            this.btnlimpiar.TabIndex = 151;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Visible = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbusqueda.IconColor = System.Drawing.Color.Black;
            this.btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbusqueda.IconSize = 17;
            this.btnbusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbusqueda.Location = new System.Drawing.Point(1443, 126);
            this.btnbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(49, 26);
            this.btnbusqueda.TabIndex = 150;
            this.btnbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Visible = false;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // cbobuscar
            // 
            this.cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Items.AddRange(new object[] {
            "Test"});
            this.cbobuscar.Location = new System.Drawing.Point(675, 66);
            this.cbobuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(192, 25);
            this.cbobuscar.TabIndex = 148;
            this.cbobuscar.SelectedIndexChanged += new System.EventHandler(this.cbobuscar_SelectedIndexChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(1255, 126);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(179, 24);
            this.txtbuscar.TabIndex = 149;
            this.txtbuscar.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(876, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 147;
            this.label12.Text = "Buscar por:";
            this.label12.Visible = false;
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
            this.btnsalir.Location = new System.Drawing.Point(1500, 10);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 38);
            this.btnsalir.TabIndex = 146;
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1570, 50);
            this.label2.TabIndex = 145;
            this.label2.Text = "RESUMEN DE ENTRADAS Y SALIDAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1570, 641);
            this.label1.TabIndex = 144;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AllowUserToResizeColumns = false;
            this.dgvdata.AllowUserToResizeRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.TipoLente,
            this.Marca,
            this.Color,
            this.Entradas,
            this.Tienda,
            this.Salidas,
            this.Apartados,
            this.Stock,
            this.IdProducto,
            this.IdProducto1,
            this.IdProducto2,
            this.IdProducto3,
            this.TotalEgresos,
            this.TotalIngresos,
            this.Clientew});
            this.dgvdata.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdata.Location = new System.Drawing.Point(28, 198);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(1464, 481);
            this.dgvdata.TabIndex = 160;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 125;
            // 
            // TipoLente
            // 
            this.TipoLente.DataPropertyName = "Descripcion";
            this.TipoLente.HeaderText = "Tipo de lente";
            this.TipoLente.MinimumWidth = 6;
            this.TipoLente.Name = "TipoLente";
            this.TipoLente.ReadOnly = true;
            this.TipoLente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TipoLente.Width = 125;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Categoria";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Marca.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Almacen";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Color.Width = 125;
            // 
            // Entradas
            // 
            this.Entradas.DataPropertyName = "Entradas";
            this.Entradas.HeaderText = "Entradas";
            this.Entradas.MinimumWidth = 6;
            this.Entradas.Name = "Entradas";
            this.Entradas.ReadOnly = true;
            this.Entradas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Entradas.Width = 125;
            // 
            // Tienda
            // 
            this.Tienda.DataPropertyName = "Tienda";
            this.Tienda.HeaderText = "Tienda";
            this.Tienda.MinimumWidth = 6;
            this.Tienda.Name = "Tienda";
            this.Tienda.ReadOnly = true;
            this.Tienda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tienda.Width = 125;
            // 
            // Salidas
            // 
            this.Salidas.DataPropertyName = "Salidas";
            this.Salidas.HeaderText = "Salidas";
            this.Salidas.MinimumWidth = 6;
            this.Salidas.Name = "Salidas";
            this.Salidas.ReadOnly = true;
            this.Salidas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Salidas.Width = 125;
            // 
            // Apartados
            // 
            this.Apartados.DataPropertyName = "Apartados";
            this.Apartados.HeaderText = "Apartados";
            this.Apartados.MinimumWidth = 6;
            this.Apartados.Name = "Apartados";
            this.Apartados.ReadOnly = true;
            this.Apartados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Apartados.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Stock.Width = 125;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // IdProducto1
            // 
            this.IdProducto1.DataPropertyName = "IdProducto1";
            this.IdProducto1.HeaderText = "IdProducto1";
            this.IdProducto1.MinimumWidth = 6;
            this.IdProducto1.Name = "IdProducto1";
            this.IdProducto1.ReadOnly = true;
            this.IdProducto1.Visible = false;
            this.IdProducto1.Width = 125;
            // 
            // IdProducto2
            // 
            this.IdProducto2.DataPropertyName = "IdProducto2";
            this.IdProducto2.HeaderText = "IdProducto2";
            this.IdProducto2.MinimumWidth = 6;
            this.IdProducto2.Name = "IdProducto2";
            this.IdProducto2.ReadOnly = true;
            this.IdProducto2.Visible = false;
            this.IdProducto2.Width = 125;
            // 
            // IdProducto3
            // 
            this.IdProducto3.DataPropertyName = "IdProducto3";
            this.IdProducto3.HeaderText = "IdProducto3";
            this.IdProducto3.MinimumWidth = 6;
            this.IdProducto3.Name = "IdProducto3";
            this.IdProducto3.ReadOnly = true;
            this.IdProducto3.Visible = false;
            this.IdProducto3.Width = 125;
            // 
            // TotalEgresos
            // 
            this.TotalEgresos.DataPropertyName = "TotalEgresos";
            this.TotalEgresos.HeaderText = "TotalEgresos";
            this.TotalEgresos.MinimumWidth = 6;
            this.TotalEgresos.Name = "TotalEgresos";
            this.TotalEgresos.ReadOnly = true;
            this.TotalEgresos.Visible = false;
            this.TotalEgresos.Width = 125;
            // 
            // TotalIngresos
            // 
            this.TotalIngresos.DataPropertyName = "TotalIngresos";
            this.TotalIngresos.HeaderText = "TotalIngresos";
            this.TotalIngresos.MinimumWidth = 6;
            this.TotalIngresos.Name = "TotalIngresos";
            this.TotalIngresos.ReadOnly = true;
            this.TotalIngresos.Visible = false;
            this.TotalIngresos.Width = 125;
            // 
            // Clientew
            // 
            this.Clientew.DataPropertyName = "Clientew";
            this.Clientew.HeaderText = "Clientew";
            this.Clientew.MinimumWidth = 6;
            this.Clientew.Name = "Clientew";
            this.Clientew.ReadOnly = true;
            this.Clientew.Visible = false;
            this.Clientew.Width = 125;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.ControlBox = false;
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbusqueda);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1597, 737);
            this.MinimumSize = new System.Drawing.Size(1533, 737);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESUMEN";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoLente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEgresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientew;
    }
}
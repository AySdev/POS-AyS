namespace POS_AyS
{
    partial class frmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgFacturar = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblPCodProd = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDcto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.cmbCod = new System.Windows.Forms.ComboBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.cmbDcto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbNit = new System.Windows.Forms.ComboBox();
            this.lblComercial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturar)).BeginInit();
            this.grpProducto.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgFacturar
            // 
            this.dtgFacturar.AllowUserToDeleteRows = false;
            this.dtgFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFacturar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descripción,
            this.Valor,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFacturar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFacturar.EnableHeadersVisualStyles = false;
            this.dtgFacturar.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgFacturar.Location = new System.Drawing.Point(26, 77);
            this.dtgFacturar.Name = "dtgFacturar";
            this.dtgFacturar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFacturar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgFacturar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgFacturar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFacturar.Size = new System.Drawing.Size(694, 76);
            this.dtgFacturar.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MaxInputLength = 100;
            this.Código.MinimumWidth = 100;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 200;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 100;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCliente.Location = new System.Drawing.Point(204, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNit.Location = new System.Drawing.Point(24, 21);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(30, 18);
            this.lblNit.TabIndex = 2;
            this.lblNit.Text = "Nit:";
            // 
            // lblPCodProd
            // 
            this.lblPCodProd.AutoSize = true;
            this.lblPCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPCodProd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPCodProd.Location = new System.Drawing.Point(32, 20);
            this.lblPCodProd.Name = "lblPCodProd";
            this.lblPCodProd.Size = new System.Drawing.Size(56, 18);
            this.lblPCodProd.TabIndex = 3;
            this.lblPCodProd.Text = "Código";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProducto.Location = new System.Drawing.Point(227, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(87, 18);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Descripción";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(644, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(452, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor Unitario";
            // 
            // grpProducto
            // 
            this.grpProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProducto.Controls.Add(this.label5);
            this.grpProducto.Controls.Add(this.txtDcto);
            this.grpProducto.Controls.Add(this.lblTotal);
            this.grpProducto.Controls.Add(this.txtTotal);
            this.grpProducto.Controls.Add(this.lblIva);
            this.grpProducto.Controls.Add(this.txtIva);
            this.grpProducto.Controls.Add(this.lblSubtotal);
            this.grpProducto.Controls.Add(this.txtSubtotal);
            this.grpProducto.Controls.Add(this.lblCantidad);
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.cmbValor);
            this.grpProducto.Controls.Add(this.cmbDescripcion);
            this.grpProducto.Controls.Add(this.cmbCod);
            this.grpProducto.Controls.Add(this.label1);
            this.grpProducto.Controls.Add(this.btnAgregar);
            this.grpProducto.Controls.Add(this.btnFacturar);
            this.grpProducto.Controls.Add(this.btnEliminarProd);
            this.grpProducto.Controls.Add(this.lblProducto);
            this.grpProducto.Controls.Add(this.lblPCodProd);
            this.grpProducto.Controls.Add(this.dtgFacturar);
            this.grpProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpProducto.Location = new System.Drawing.Point(28, 146);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(745, 227);
            this.grpProducto.TabIndex = 4;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(415, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dcto:";
            // 
            // txtDcto
            // 
            this.txtDcto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDcto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDcto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDcto.Location = new System.Drawing.Point(461, 182);
            this.txtDcto.Name = "txtDcto";
            this.txtDcto.ReadOnly = true;
            this.txtDcto.Size = new System.Drawing.Size(43, 23);
            this.txtDcto.TabIndex = 31;
            this.txtDcto.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(605, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 18);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(649, 182);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(70, 23);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.Text = "0";
            // 
            // lblIva
            // 
            this.lblIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIva.Location = new System.Drawing.Point(507, 184);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(30, 18);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "Iva:";
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Location = new System.Drawing.Point(536, 182);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(65, 23);
            this.txtIva.TabIndex = 27;
            this.txtIva.Text = "0";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSubtotal.Location = new System.Drawing.Point(284, 184);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(66, 18);
            this.lblSubtotal.TabIndex = 26;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Location = new System.Drawing.Point(350, 182);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(60, 23);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidad.Location = new System.Drawing.Point(565, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(565, 39);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 23);
            this.txtCantidad.TabIndex = 23;
            // 
            // cmbValor
            // 
            this.cmbValor.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.cmbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbValor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbValor.Enabled = false;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbValor.Location = new System.Drawing.Point(448, 40);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbValor.Size = new System.Drawing.Size(105, 24);
            this.cmbValor.TabIndex = 16;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(105, 40);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(331, 24);
            this.cmbDescripcion.TabIndex = 15;
            // 
            // cmbCod
            // 
            this.cmbCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCod.FormattingEnabled = true;
            this.cmbCod.Location = new System.Drawing.Point(27, 40);
            this.cmbCod.Name = "cmbCod";
            this.cmbCod.Size = new System.Drawing.Size(66, 24);
            this.cmbCod.TabIndex = 14;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturar.Location = new System.Drawing.Point(127, 178);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 30);
            this.btnFacturar.TabIndex = 19;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProd.Location = new System.Drawing.Point(27, 178);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarProd.TabIndex = 18;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVendedor.Location = new System.Drawing.Point(630, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(75, 18);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPlazo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlazo.Location = new System.Drawing.Point(448, 52);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(50, 18);
            this.lblPlazo.TabIndex = 16;
            this.lblPlazo.Text = "Plazo:";
            // 
            // txtPlazo
            // 
            this.txtPlazo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlazo.Location = new System.Drawing.Point(500, 51);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(77, 20);
            this.txtPlazo.TabIndex = 17;
            // 
            // grpCliente
            // 
            this.grpCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCliente.Controls.Add(this.cmbCondicion);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.cmbDias);
            this.grpCliente.Controls.Add(this.cmbDcto);
            this.grpCliente.Controls.Add(this.label4);
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.cmbVendedor);
            this.grpCliente.Controls.Add(this.cmbDireccion);
            this.grpCliente.Controls.Add(this.lblCondiciones);
            this.grpCliente.Controls.Add(this.cmbCliente);
            this.grpCliente.Controls.Add(this.cmbNit);
            this.grpCliente.Controls.Add(this.lblComercial);
            this.grpCliente.Controls.Add(this.lblDireccion);
            this.grpCliente.Controls.Add(this.lblCliente);
            this.grpCliente.Controls.Add(this.lblNit);
            this.grpCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpCliente.Location = new System.Drawing.Point(28, 13);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(745, 115);
            this.grpCliente.TabIndex = 10;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCondicion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCondicion.DropDownHeight = 1;
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCondicion.IntegralHeight = false;
            this.cmbCondicion.Location = new System.Drawing.Point(533, 68);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCondicion.Size = new System.Drawing.Size(89, 24);
            this.cmbCondicion.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(683, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Días";
            // 
            // cmbDias
            // 
            this.cmbDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDias.DropDownHeight = 1;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDias.IntegralHeight = false;
            this.cmbDias.Location = new System.Drawing.Point(626, 68);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDias.Size = new System.Drawing.Size(56, 24);
            this.cmbDias.TabIndex = 31;
            // 
            // cmbDcto
            // 
            this.cmbDcto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDcto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDcto.DropDownHeight = 1;
            this.cmbDcto.FormattingEnabled = true;
            this.cmbDcto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDcto.IntegralHeight = false;
            this.cmbDcto.Location = new System.Drawing.Point(454, 68);
            this.cmbDcto.Name = "cmbDcto";
            this.cmbDcto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDcto.Size = new System.Drawing.Size(56, 24);
            this.cmbDcto.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(511, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(411, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dcto:";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.cmbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVendedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbVendedor.Enabled = false;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbVendedor.Location = new System.Drawing.Point(649, 18);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbVendedor.Size = new System.Drawing.Size(70, 24);
            this.cmbVendedor.TabIndex = 27;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.cmbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDireccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDireccion.Enabled = false;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDireccion.Location = new System.Drawing.Point(98, 68);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDireccion.Size = new System.Drawing.Size(216, 24);
            this.cmbDireccion.TabIndex = 28;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCondiciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCondiciones.Location = new System.Drawing.Point(318, 71);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(95, 18);
            this.lblCondiciones.TabIndex = 27;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(267, 18);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(304, 24);
            this.cmbCliente.TabIndex = 26;
            // 
            // cmbNit
            // 
            this.cmbNit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNit.FormattingEnabled = true;
            this.cmbNit.Location = new System.Drawing.Point(55, 18);
            this.cmbNit.Name = "cmbNit";
            this.cmbNit.Size = new System.Drawing.Size(144, 24);
            this.cmbNit.TabIndex = 25;
            // 
            // lblComercial
            // 
            this.lblComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComercial.AutoSize = true;
            this.lblComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblComercial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblComercial.Location = new System.Drawing.Point(577, 21);
            this.lblComercial.Name = "lblComercial";
            this.lblComercial.Size = new System.Drawing.Size(75, 18);
            this.lblComercial.TabIndex = 19;
            this.lblComercial.Text = "Vendedor:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(24, 71);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 18);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección:";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.grpProducto);
            this.Name = "frmFactura";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFacturar)).EndInit();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFacturar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblPCodProd;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.ComboBox cmbCod;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblComercial;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbNit;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.ComboBox cmbDcto;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDcto;
    }
}
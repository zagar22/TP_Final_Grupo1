namespace TP_Final_Grupo1
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_Tipo_Iva = new System.Windows.Forms.Label();
            this.lbl_Razon_Soc = new System.Windows.Forms.Label();
            this.txt_Numero_Factura = new System.Windows.Forms.Label();
            this.txt_Id_Cliente = new System.Windows.Forms.TextBox();
            this.txt_Id_Factura = new System.Windows.Forms.TextBox();
            this.cmb_Lista_Producto = new System.Windows.Forms.ComboBox();
            this.txt_Cantidades_A_Agregar = new System.Windows.Forms.TextBox();
            this.txt_Valor_Con_IVA = new System.Windows.Forms.TextBox();
            this.txt_Valor_Unitario = new System.Windows.Forms.TextBox();
            this.txt_Unidades_Medidas = new System.Windows.Forms.TextBox();
            this.dgv_Productos_seleccionados = new System.Windows.Forms.DataGridView();
            this.btn_Agregar_Productos = new System.Windows.Forms.Button();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.txt_Tipo_Iva = new System.Windows.Forms.TextBox();
            this.txt_Razon_Social = new System.Windows.Forms.TextBox();
            this.txt_Descripcion_Producto_Seleccionado = new System.Windows.Forms.TextBox();
            this.txt_Cantidad_De_Productos = new System.Windows.Forms.TextBox();
            this.txt_IVA_Aplicado = new System.Windows.Forms.TextBox();
            this.txt_Monto_Total_Sin_IVA = new System.Windows.Forms.TextBox();
            this.txt_Monto_Total_Con_IVA = new System.Windows.Forms.TextBox();
            this.txt_Valor_Sumado = new System.Windows.Forms.TextBox();
            this.txt_Suma_Todos_Los_IVA = new System.Windows.Forms.TextBox();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos_seleccionados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(55, 153);
            this.lbl_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(43, 16);
            this.lbl_Cliente.TabIndex = 0;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // lbl_Tipo_Iva
            // 
            this.lbl_Tipo_Iva.AutoSize = true;
            this.lbl_Tipo_Iva.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_Iva.Location = new System.Drawing.Point(55, 217);
            this.lbl_Tipo_Iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tipo_Iva.Name = "lbl_Tipo_Iva";
            this.lbl_Tipo_Iva.Size = new System.Drawing.Size(53, 16);
            this.lbl_Tipo_Iva.TabIndex = 1;
            this.lbl_Tipo_Iva.Text = "Tipo IVA";
            // 
            // lbl_Razon_Soc
            // 
            this.lbl_Razon_Soc.AutoSize = true;
            this.lbl_Razon_Soc.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Razon_Soc.Location = new System.Drawing.Point(55, 185);
            this.lbl_Razon_Soc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Razon_Soc.Name = "lbl_Razon_Soc";
            this.lbl_Razon_Soc.Size = new System.Drawing.Size(73, 16);
            this.lbl_Razon_Soc.TabIndex = 2;
            this.lbl_Razon_Soc.Text = "Razon Social";
            // 
            // txt_Numero_Factura
            // 
            this.txt_Numero_Factura.AutoSize = true;
            this.txt_Numero_Factura.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero_Factura.Location = new System.Drawing.Point(55, 264);
            this.txt_Numero_Factura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Numero_Factura.Name = "txt_Numero_Factura";
            this.txt_Numero_Factura.Size = new System.Drawing.Size(65, 16);
            this.txt_Numero_Factura.TabIndex = 3;
            this.txt_Numero_Factura.Text = "Factura N°";
            // 
            // txt_Id_Cliente
            // 
            this.txt_Id_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Cliente.Location = new System.Drawing.Point(447, 153);
            this.txt_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id_Cliente.Multiline = true;
            this.txt_Id_Cliente.Name = "txt_Id_Cliente";
            this.txt_Id_Cliente.Size = new System.Drawing.Size(116, 59);
            this.txt_Id_Cliente.TabIndex = 0;
            this.txt_Id_Cliente.Text = "Ingrese el numero del cliente";
            // 
            // txt_Id_Factura
            // 
            this.txt_Id_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Factura.Location = new System.Drawing.Point(447, 251);
            this.txt_Id_Factura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id_Factura.Name = "txt_Id_Factura";
            this.txt_Id_Factura.ReadOnly = true;
            this.txt_Id_Factura.Size = new System.Drawing.Size(116, 24);
            this.txt_Id_Factura.TabIndex = 4;
            // 
            // cmb_Lista_Producto
            // 
            this.cmb_Lista_Producto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lista_Producto.FormattingEnabled = true;
            this.cmb_Lista_Producto.Location = new System.Drawing.Point(59, 297);
            this.cmb_Lista_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Lista_Producto.Name = "cmb_Lista_Producto";
            this.cmb_Lista_Producto.Size = new System.Drawing.Size(504, 24);
            this.cmb_Lista_Producto.TabIndex = 5;
            this.cmb_Lista_Producto.Text = "Seleccione los productos";
            // 
            // txt_Cantidades_A_Agregar
            // 
            this.txt_Cantidades_A_Agregar.Location = new System.Drawing.Point(59, 331);
            this.txt_Cantidades_A_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cantidades_A_Agregar.Name = "txt_Cantidades_A_Agregar";
            this.txt_Cantidades_A_Agregar.Size = new System.Drawing.Size(116, 23);
            this.txt_Cantidades_A_Agregar.TabIndex = 6;
            // 
            // txt_Valor_Con_IVA
            // 
            this.txt_Valor_Con_IVA.Location = new System.Drawing.Point(448, 331);
            this.txt_Valor_Con_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Valor_Con_IVA.Name = "txt_Valor_Con_IVA";
            this.txt_Valor_Con_IVA.ReadOnly = true;
            this.txt_Valor_Con_IVA.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor_Con_IVA.TabIndex = 9;
            // 
            // txt_Valor_Unitario
            // 
            this.txt_Valor_Unitario.Location = new System.Drawing.Point(318, 331);
            this.txt_Valor_Unitario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Valor_Unitario.Name = "txt_Valor_Unitario";
            this.txt_Valor_Unitario.ReadOnly = true;
            this.txt_Valor_Unitario.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor_Unitario.TabIndex = 8;
            // 
            // txt_Unidades_Medidas
            // 
            this.txt_Unidades_Medidas.Location = new System.Drawing.Point(189, 331);
            this.txt_Unidades_Medidas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Unidades_Medidas.Name = "txt_Unidades_Medidas";
            this.txt_Unidades_Medidas.ReadOnly = true;
            this.txt_Unidades_Medidas.Size = new System.Drawing.Size(116, 23);
            this.txt_Unidades_Medidas.TabIndex = 7;
            // 
            // dgv_Productos_seleccionados
            // 
            this.dgv_Productos_seleccionados.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgv_Productos_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos_seleccionados.Location = new System.Drawing.Point(59, 503);
            this.dgv_Productos_seleccionados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Productos_seleccionados.Name = "dgv_Productos_seleccionados";
            this.dgv_Productos_seleccionados.ReadOnly = true;
            this.dgv_Productos_seleccionados.Size = new System.Drawing.Size(505, 181);
            this.dgv_Productos_seleccionados.TabIndex = 13;
            // 
            // btn_Agregar_Productos
            // 
            this.btn_Agregar_Productos.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Agregar_Productos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Productos.Location = new System.Drawing.Point(477, 454);
            this.btn_Agregar_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Agregar_Productos.Name = "btn_Agregar_Productos";
            this.btn_Agregar_Productos.Size = new System.Drawing.Size(88, 28);
            this.btn_Agregar_Productos.TabIndex = 12;
            this.btn_Agregar_Productos.Text = "Agregar";
            this.btn_Agregar_Productos.UseVisualStyleBackColor = true;
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.Location = new System.Drawing.Point(141, 153);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.ReadOnly = true;
            this.txt_Cliente.Size = new System.Drawing.Size(292, 23);
            this.txt_Cliente.TabIndex = 1;
            this.txt_Cliente.Visible = false;
            // 
            // txt_Tipo_Iva
            // 
            this.txt_Tipo_Iva.Location = new System.Drawing.Point(141, 217);
            this.txt_Tipo_Iva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tipo_Iva.Name = "txt_Tipo_Iva";
            this.txt_Tipo_Iva.ReadOnly = true;
            this.txt_Tipo_Iva.Size = new System.Drawing.Size(292, 23);
            this.txt_Tipo_Iva.TabIndex = 3;
            this.txt_Tipo_Iva.Visible = false;
            // 
            // txt_Razon_Social
            // 
            this.txt_Razon_Social.Location = new System.Drawing.Point(141, 185);
            this.txt_Razon_Social.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Razon_Social.Name = "txt_Razon_Social";
            this.txt_Razon_Social.ReadOnly = true;
            this.txt_Razon_Social.Size = new System.Drawing.Size(292, 23);
            this.txt_Razon_Social.TabIndex = 2;
            this.txt_Razon_Social.Visible = false;
            // 
            // txt_Descripcion_Producto_Seleccionado
            // 
            this.txt_Descripcion_Producto_Seleccionado.Location = new System.Drawing.Point(59, 363);
            this.txt_Descripcion_Producto_Seleccionado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Descripcion_Producto_Seleccionado.Multiline = true;
            this.txt_Descripcion_Producto_Seleccionado.Name = "txt_Descripcion_Producto_Seleccionado";
            this.txt_Descripcion_Producto_Seleccionado.ReadOnly = true;
            this.txt_Descripcion_Producto_Seleccionado.Size = new System.Drawing.Size(504, 72);
            this.txt_Descripcion_Producto_Seleccionado.TabIndex = 10;
            // 
            // txt_Cantidad_De_Productos
            // 
            this.txt_Cantidad_De_Productos.Location = new System.Drawing.Point(221, 714);
            this.txt_Cantidad_De_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cantidad_De_Productos.Name = "txt_Cantidad_De_Productos";
            this.txt_Cantidad_De_Productos.ReadOnly = true;
            this.txt_Cantidad_De_Productos.Size = new System.Drawing.Size(116, 23);
            this.txt_Cantidad_De_Productos.TabIndex = 14;
            // 
            // txt_IVA_Aplicado
            // 
            this.txt_IVA_Aplicado.Location = new System.Drawing.Point(189, 745);
            this.txt_IVA_Aplicado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IVA_Aplicado.Name = "txt_IVA_Aplicado";
            this.txt_IVA_Aplicado.ReadOnly = true;
            this.txt_IVA_Aplicado.Size = new System.Drawing.Size(116, 23);
            this.txt_IVA_Aplicado.TabIndex = 15;
            // 
            // txt_Monto_Total_Sin_IVA
            // 
            this.txt_Monto_Total_Sin_IVA.Location = new System.Drawing.Point(447, 745);
            this.txt_Monto_Total_Sin_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Monto_Total_Sin_IVA.Name = "txt_Monto_Total_Sin_IVA";
            this.txt_Monto_Total_Sin_IVA.ReadOnly = true;
            this.txt_Monto_Total_Sin_IVA.Size = new System.Drawing.Size(116, 23);
            this.txt_Monto_Total_Sin_IVA.TabIndex = 17;
            // 
            // txt_Monto_Total_Con_IVA
            // 
            this.txt_Monto_Total_Con_IVA.Location = new System.Drawing.Point(447, 776);
            this.txt_Monto_Total_Con_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Monto_Total_Con_IVA.Name = "txt_Monto_Total_Con_IVA";
            this.txt_Monto_Total_Con_IVA.ReadOnly = true;
            this.txt_Monto_Total_Con_IVA.Size = new System.Drawing.Size(116, 23);
            this.txt_Monto_Total_Con_IVA.TabIndex = 18;
            // 
            // txt_Valor_Sumado
            // 
            this.txt_Valor_Sumado.Location = new System.Drawing.Point(59, 457);
            this.txt_Valor_Sumado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Valor_Sumado.Name = "txt_Valor_Sumado";
            this.txt_Valor_Sumado.ReadOnly = true;
            this.txt_Valor_Sumado.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor_Sumado.TabIndex = 11;
            // 
            // txt_Suma_Todos_Los_IVA
            // 
            this.txt_Suma_Todos_Los_IVA.Location = new System.Drawing.Point(447, 714);
            this.txt_Suma_Todos_Los_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Suma_Todos_Los_IVA.Name = "txt_Suma_Todos_Los_IVA";
            this.txt_Suma_Todos_Los_IVA.ReadOnly = true;
            this.txt_Suma_Todos_Los_IVA.Size = new System.Drawing.Size(116, 23);
            this.txt_Suma_Todos_Los_IVA.TabIndex = 16;
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Facturar.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Facturar.Location = new System.Drawing.Point(476, 807);
            this.btn_Facturar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(88, 42);
            this.btn_Facturar.TabIndex = 19;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(234, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 72);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empresa Amapolas S.A";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(300, 19);
            this.label21.TabIndex = 167;
            this.label21.Text = "infoamapolas@gmail.com |  www.amapolas.com";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 19);
            this.label20.TabIndex = 168;
            this.label20.Text = "Colombo 400 - El Dorado - MISIONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 188;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(330, 749);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 19);
            this.label23.TabIndex = 191;
            this.label23.Text = "Total s/ IVA :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(346, 718);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 19);
            this.label22.TabIndex = 190;
            this.label22.Text = "Monto IVA :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(322, 780);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(118, 19);
            this.label34.TabIndex = 189;
            this.label34.Text = "Total con/ IVA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 192;
            this.label1.Text = "IVA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 193;
            this.label2.Text = "Cantidad de productos";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(628, 881);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.txt_Suma_Todos_Los_IVA);
            this.Controls.Add(this.txt_Valor_Sumado);
            this.Controls.Add(this.txt_Monto_Total_Con_IVA);
            this.Controls.Add(this.txt_Monto_Total_Sin_IVA);
            this.Controls.Add(this.txt_IVA_Aplicado);
            this.Controls.Add(this.txt_Cantidad_De_Productos);
            this.Controls.Add(this.txt_Descripcion_Producto_Seleccionado);
            this.Controls.Add(this.txt_Razon_Social);
            this.Controls.Add(this.txt_Tipo_Iva);
            this.Controls.Add(this.txt_Cliente);
            this.Controls.Add(this.btn_Agregar_Productos);
            this.Controls.Add(this.dgv_Productos_seleccionados);
            this.Controls.Add(this.txt_Unidades_Medidas);
            this.Controls.Add(this.txt_Valor_Unitario);
            this.Controls.Add(this.txt_Valor_Con_IVA);
            this.Controls.Add(this.txt_Cantidades_A_Agregar);
            this.Controls.Add(this.cmb_Lista_Producto);
            this.Controls.Add(this.txt_Id_Factura);
            this.Controls.Add(this.txt_Id_Cliente);
            this.Controls.Add(this.txt_Numero_Factura);
            this.Controls.Add(this.lbl_Razon_Soc);
            this.Controls.Add(this.lbl_Tipo_Iva);
            this.Controls.Add(this.lbl_Cliente);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Factura";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos_seleccionados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_Tipo_Iva;
        private System.Windows.Forms.Label lbl_Razon_Soc;
        private System.Windows.Forms.Label txt_Numero_Factura;
        private System.Windows.Forms.TextBox txt_Id_Cliente;
        private System.Windows.Forms.TextBox txt_Id_Factura;
        private System.Windows.Forms.ComboBox cmb_Lista_Producto;
        private System.Windows.Forms.TextBox txt_Cantidades_A_Agregar;
        private System.Windows.Forms.TextBox txt_Valor_Con_IVA;
        private System.Windows.Forms.TextBox txt_Valor_Unitario;
        private System.Windows.Forms.TextBox txt_Unidades_Medidas;
        private System.Windows.Forms.DataGridView dgv_Productos_seleccionados;
        private System.Windows.Forms.Button btn_Agregar_Productos;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.TextBox txt_Tipo_Iva;
        private System.Windows.Forms.TextBox txt_Razon_Social;
        private System.Windows.Forms.TextBox txt_Descripcion_Producto_Seleccionado;
        private System.Windows.Forms.TextBox txt_Cantidad_De_Productos;
        private System.Windows.Forms.TextBox txt_IVA_Aplicado;
        private System.Windows.Forms.TextBox txt_Monto_Total_Sin_IVA;
        private System.Windows.Forms.TextBox txt_Monto_Total_Con_IVA;
        private System.Windows.Forms.TextBox txt_Valor_Sumado;
        private System.Windows.Forms.TextBox txt_Suma_Todos_Los_IVA;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace S4_Compra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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


        private void InitializeComponent()
        {
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            lblDescuento = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(65, 37);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(104, 15);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio unitario ($):";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(191, 34);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 1;
            txtPrecio.Text = "1";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(341, 37);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(414, 35);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(75, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(122, 72);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(229, 70);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 78);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Subtotal";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(65, 119);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 7;
            lblDescuento.Text = "Descuento:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(65, 134);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(52, 30);
            lblIva.TabIndex = 8;
            lblIva.Text = "\r\nIVA 15%:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(65, 184);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(95, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL A PAGAR:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 243);
            Controls.Add(lblTotal);
            Controls.Add(lblIva);
            Controls.Add(lblDescuento);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Name = "Form1";
            Text = "Subtotal:";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label1;
        private Label lblDescuento;
        private Label lblIva;
        private Label lblTotal;
    }
}

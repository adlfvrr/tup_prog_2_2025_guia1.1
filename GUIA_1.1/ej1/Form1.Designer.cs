namespace ej1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbMarca = new TextBox();
            tbValorFabrica = new TextBox();
            tbDepreciacion = new TextBox();
            tbVidaUtil = new TextBox();
            btnCalcular = new Button();
            btnCerrar = new Button();
            nudModelo = new NumericUpDown();
            nudAño = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudModelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 105);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 1;
            label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 163);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 2;
            label3.Text = "Año a calcular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 225);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 3;
            label4.Text = "Valor de fábrica $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 44);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 4;
            label5.Text = "Tasa de depreciación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 105);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 5;
            label6.Text = "Vida útil (Años)";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(225, 41);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(161, 34);
            tbMarca.TabIndex = 6;
            // 
            // tbValorFabrica
            // 
            tbValorFabrica.Location = new Point(225, 222);
            tbValorFabrica.Name = "tbValorFabrica";
            tbValorFabrica.Size = new Size(161, 34);
            tbValorFabrica.TabIndex = 9;
            // 
            // tbDepreciacion
            // 
            tbDepreciacion.Location = new Point(750, 41);
            tbDepreciacion.Name = "tbDepreciacion";
            tbDepreciacion.Size = new Size(161, 34);
            tbDepreciacion.TabIndex = 10;
            // 
            // tbVidaUtil
            // 
            tbVidaUtil.Location = new Point(750, 102);
            tbVidaUtil.Name = "tbVidaUtil";
            tbVidaUtil.Size = new Size(161, 34);
            tbVidaUtil.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(66, 310);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(196, 77);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular Costo";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(332, 310);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(196, 77);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // nudModelo
            // 
            nudModelo.Location = new Point(225, 103);
            nudModelo.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudModelo.Name = "nudModelo";
            nudModelo.Size = new Size(161, 34);
            nudModelo.TabIndex = 14;
            // 
            // nudAño
            // 
            nudAño.Location = new Point(225, 161);
            nudAño.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAño.Name = "nudAño";
            nudAño.Size = new Size(161, 34);
            nudAño.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 432);
            Controls.Add(nudAño);
            Controls.Add(nudModelo);
            Controls.Add(btnCerrar);
            Controls.Add(btnCalcular);
            Controls.Add(tbVidaUtil);
            Controls.Add(tbDepreciacion);
            Controls.Add(tbValorFabrica);
            Controls.Add(tbMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)nudModelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbMarca;
        private TextBox tbValorFabrica;
        private TextBox tbDepreciacion;
        private TextBox tbVidaUtil;
        private Button btnCalcular;
        private Button btnCerrar;
        private NumericUpDown nudModelo;
        private NumericUpDown nudAño;
    }
}

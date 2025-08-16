namespace ej2
{
    partial class ModalDatos
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbHLlegada = new TextBox();
            tbMLlegada = new TextBox();
            tbHSalida = new TextBox();
            tbMSalida = new TextBox();
            tbAscienden = new TextBox();
            tbDescienden = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnIngresarParada = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnIngresarParada);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbDescienden);
            groupBox1.Controls.Add(tbAscienden);
            groupBox1.Controls.Add(tbMSalida);
            groupBox1.Controls.Add(tbHSalida);
            groupBox1.Controls.Add(tbMLlegada);
            groupBox1.Controls.Add(tbHLlegada);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 0;
            label1.Text = "LLegada (HH:MM)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 94);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Salida (HH:MM)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 2;
            label3.Text = "Ascienden";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 199);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 3;
            label4.Text = "Descienden";
            // 
            // tbHLlegada
            // 
            tbHLlegada.Location = new Point(194, 43);
            tbHLlegada.Name = "tbHLlegada";
            tbHLlegada.Size = new Size(94, 34);
            tbHLlegada.TabIndex = 4;
            // 
            // tbMLlegada
            // 
            tbMLlegada.Location = new Point(344, 43);
            tbMLlegada.Name = "tbMLlegada";
            tbMLlegada.Size = new Size(94, 34);
            tbMLlegada.TabIndex = 5;
            // 
            // tbHSalida
            // 
            tbHSalida.Location = new Point(194, 91);
            tbHSalida.Name = "tbHSalida";
            tbHSalida.Size = new Size(94, 34);
            tbHSalida.TabIndex = 6;
            // 
            // tbMSalida
            // 
            tbMSalida.Location = new Point(344, 91);
            tbMSalida.Name = "tbMSalida";
            tbMSalida.Size = new Size(94, 34);
            tbMSalida.TabIndex = 7;
            // 
            // tbAscienden
            // 
            tbAscienden.Location = new Point(194, 150);
            tbAscienden.Name = "tbAscienden";
            tbAscienden.Size = new Size(94, 34);
            tbAscienden.TabIndex = 8;
            // 
            // tbDescienden
            // 
            tbDescienden.Location = new Point(194, 193);
            tbDescienden.Name = "tbDescienden";
            tbDescienden.Size = new Size(94, 34);
            tbDescienden.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 46);
            label5.Name = "label5";
            label5.Size = new Size(16, 28);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 94);
            label6.Name = "label6";
            label6.Size = new Size(16, 28);
            label6.TabIndex = 12;
            label6.Text = ":";
            // 
            // btnIngresarParada
            // 
            btnIngresarParada.DialogResult = DialogResult.OK;
            btnIngresarParada.Location = new Point(84, 285);
            btnIngresarParada.Name = "btnIngresarParada";
            btnIngresarParada.Size = new Size(157, 63);
            btnIngresarParada.TabIndex = 13;
            btnIngresarParada.Text = "Ingresar parada";
            btnIngresarParada.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(330, 285);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 63);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ModalDatos
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 393);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ModalDatos";
            Text = "Ingreso datos parada";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox tbDescienden;
        public TextBox tbAscienden;
        public TextBox tbMSalida;
        public TextBox tbHSalida;
        public TextBox tbMLlegada;
        public TextBox tbHLlegada;
        private Button btnCancelar;
        private Button btnIngresarParada;
        private Label label6;
        private Label label5;
    }
}
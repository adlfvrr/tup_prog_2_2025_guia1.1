namespace ej2
{
    partial class ModalViaje
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
            tbHInicio = new TextBox();
            tbMInicio = new TextBox();
            tbAsientos = new TextBox();
            btnIniciarViaje = new Button();
            button1 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnIniciarViaje);
            groupBox1.Controls.Add(tbAsientos);
            groupBox1.Controls.Add(tbMInicio);
            groupBox1.Controls.Add(tbHInicio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio viaje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 49);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Inicio (HH:MM)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Asientos";
            // 
            // tbHInicio
            // 
            tbHInicio.Location = new Point(185, 46);
            tbHInicio.Name = "tbHInicio";
            tbHInicio.Size = new Size(100, 34);
            tbHInicio.TabIndex = 2;
            // 
            // tbMInicio
            // 
            tbMInicio.Location = new Point(332, 46);
            tbMInicio.Name = "tbMInicio";
            tbMInicio.Size = new Size(100, 34);
            tbMInicio.TabIndex = 3;
            // 
            // tbAsientos
            // 
            tbAsientos.Location = new Point(185, 92);
            tbAsientos.Name = "tbAsientos";
            tbAsientos.Size = new Size(100, 34);
            tbAsientos.TabIndex = 4;
            // 
            // btnIniciarViaje
            // 
            btnIniciarViaje.DialogResult = DialogResult.OK;
            btnIniciarViaje.Location = new Point(44, 152);
            btnIniciarViaje.Name = "btnIniciarViaje";
            btnIniciarViaje.Size = new Size(179, 49);
            btnIniciarViaje.TabIndex = 5;
            btnIniciarViaje.Text = "Iniciar viaje";
            btnIniciarViaje.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(262, 152);
            button1.Name = "button1";
            button1.Size = new Size(179, 49);
            button1.TabIndex = 6;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 49);
            label3.Name = "label3";
            label3.Size = new Size(16, 28);
            label3.TabIndex = 7;
            label3.Text = ":";
            // 
            // ModalViaje
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 231);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ModalViaje";
            Text = "ModalViaje";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public TextBox tbAsientos;
        public TextBox tbMInicio;
        public TextBox tbHInicio;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btnIniciarViaje;
        private Label label3;
    }
}
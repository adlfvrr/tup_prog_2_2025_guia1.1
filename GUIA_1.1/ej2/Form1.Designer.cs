namespace ej2
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
            btnIniciarViaje = new Button();
            btnIngresarParada = new Button();
            groupBox1 = new GroupBox();
            btnFinalizar = new Button();
            tbMinFinalizacion = new TextBox();
            label2 = new Label();
            tbHorFinalizacion = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciarViaje
            // 
            btnIniciarViaje.Location = new Point(83, 29);
            btnIniciarViaje.Name = "btnIniciarViaje";
            btnIniciarViaje.Size = new Size(525, 50);
            btnIniciarViaje.TabIndex = 0;
            btnIniciarViaje.Text = "Iniciar Viaje";
            btnIniciarViaje.UseVisualStyleBackColor = true;
            btnIniciarViaje.Click += btnIniciarViaje_Click;
            // 
            // btnIngresarParada
            // 
            btnIngresarParada.Location = new Point(83, 85);
            btnIngresarParada.Name = "btnIngresarParada";
            btnIngresarParada.Size = new Size(525, 50);
            btnIngresarParada.TabIndex = 1;
            btnIngresarParada.Text = "Ingresar parada";
            btnIngresarParada.UseVisualStyleBackColor = true;
            btnIngresarParada.Click += btnIngresarParada_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(tbMinFinalizacion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbHorFinalizacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(83, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Finalizar parada";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(242, 80);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(277, 50);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Finalizar viaje";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // tbMinFinalizacion
            // 
            tbMinFinalizacion.Location = new Point(420, 39);
            tbMinFinalizacion.Name = "tbMinFinalizacion";
            tbMinFinalizacion.Size = new Size(81, 34);
            tbMinFinalizacion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 42);
            label2.Name = "label2";
            label2.Size = new Size(16, 28);
            label2.TabIndex = 2;
            label2.Text = ":";
            // 
            // tbHorFinalizacion
            // 
            tbHorFinalizacion.Location = new Point(292, 39);
            tbHorFinalizacion.Name = "tbHorFinalizacion";
            tbHorFinalizacion.Size = new Size(81, 34);
            tbHorFinalizacion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 0;
            label1.Text = "Hora de finalización (HH:MM)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 304);
            Controls.Add(groupBox1);
            Controls.Add(btnIngresarParada);
            Controls.Add(btnIniciarViaje);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Empresa de viajes";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciarViaje;
        private Button btnIngresarParada;
        private GroupBox groupBox1;
        private TextBox tbHorFinalizacion;
        private Label label1;
        private TextBox tbMinFinalizacion;
        private Label label2;
        private Button btnFinalizar;
    }
}

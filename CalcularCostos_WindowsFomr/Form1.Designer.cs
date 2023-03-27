namespace CalcularCostos_WindowsFomr
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            CalcularEnvio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 36);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 0;
            label1.Text = "Como desea recibir el pedido?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(210, 108);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(250, 32);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Por correo normal (Q 50)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(210, 154);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(298, 32);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Por paqueteria normal (Q 100)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(210, 196);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(285, 32);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Por Paqueteria Urgente (150)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(210, 256);
            label2.Name = "label2";
            label2.Size = new Size(338, 28);
            label2.TabIndex = 4;
            label2.Text = "Como desea ser notificado del envio?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 294);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 5;
            label3.Text = "Marcar todas las que  aplique";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 64);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 6;
            label4.Text = "Marcar solo una opcion";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(210, 353);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(278, 32);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Por Correo Electronico (Q 5)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(208, 396);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(201, 32);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Por Telefono (Q 15)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(210, 437);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(155, 32);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Por Fax (Q 20)";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // CalcularEnvio
            // 
            CalcularEnvio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalcularEnvio.Location = new Point(175, 518);
            CalcularEnvio.Name = "CalcularEnvio";
            CalcularEnvio.Size = new Size(414, 47);
            CalcularEnvio.TabIndex = 10;
            CalcularEnvio.Text = "Calcular Gastos de Envio";
            CalcularEnvio.UseVisualStyleBackColor = true;
            CalcularEnvio.Click += CalcularEnvio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 659);
            Controls.Add(CalcularEnvio);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button CalcularEnvio;
    }
}
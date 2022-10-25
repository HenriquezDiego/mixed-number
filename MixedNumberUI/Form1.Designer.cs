namespace MixedNumberUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeldiv = new System.Windows.Forms.Label();
            this.labelrest = new System.Windows.Forms.Label();
            this.labelmult = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtDen1 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtDen2 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operador 01:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(326, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operador 02:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(323, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(95, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(412, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resta =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(95, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Multiplicacion =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(412, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Division =";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labeldiv);
            this.panel1.Controls.Add(this.labelrest);
            this.panel1.Controls.Add(this.labelmult);
            this.panel1.Controls.Add(this.labelsum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(34, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 173);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labeldiv
            // 
            this.labeldiv.AutoSize = true;
            this.labeldiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldiv.Location = new System.Drawing.Point(510, 108);
            this.labeldiv.Name = "labeldiv";
            this.labeldiv.Size = new System.Drawing.Size(60, 19);
            this.labeldiv.TabIndex = 10;
            this.labeldiv.Text = "division";
            // 
            // labelrest
            // 
            this.labelrest.AutoSize = true;
            this.labelrest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelrest.Location = new System.Drawing.Point(491, 40);
            this.labelrest.Name = "labelrest";
            this.labelrest.Size = new System.Drawing.Size(43, 19);
            this.labelrest.TabIndex = 9;
            this.labelrest.Text = "resta";
            // 
            // labelmult
            // 
            this.labelmult.AutoSize = true;
            this.labelmult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmult.Location = new System.Drawing.Point(243, 108);
            this.labelmult.Name = "labelmult";
            this.labelmult.Size = new System.Drawing.Size(100, 19);
            this.labelmult.TabIndex = 8;
            this.labelmult.Text = "multiplicacion";
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsum.Location = new System.Drawing.Point(178, 37);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(44, 19);
            this.labelsum.TabIndex = 7;
            this.labelsum.Text = "suma";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNum1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.Location = new System.Drawing.Point(231, 51);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(40, 30);
            this.txtNum1.TabIndex = 14;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDen1
            // 
            this.txtDen1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDen1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDen1.Location = new System.Drawing.Point(231, 87);
            this.txtDen1.Name = "txtDen1";
            this.txtDen1.Size = new System.Drawing.Size(40, 30);
            this.txtDen1.TabIndex = 15;
            this.txtDen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDen1.TextChanged += new System.EventHandler(this.txtDen1_TextChanged);
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNumber1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumber1.Location = new System.Drawing.Point(185, 65);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(40, 30);
            this.txtNumber1.TabIndex = 16;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNumber2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumber2.Location = new System.Drawing.Point(452, 65);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(40, 30);
            this.txtNumber2.TabIndex = 19;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDen2
            // 
            this.txtDen2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDen2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDen2.Location = new System.Drawing.Point(498, 87);
            this.txtDen2.Name = "txtDen2";
            this.txtDen2.Size = new System.Drawing.Size(40, 30);
            this.txtDen2.TabIndex = 18;
            this.txtDen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNum2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.Location = new System.Drawing.Point(498, 51);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(40, 30);
            this.txtNum2.TabIndex = 17;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(609, 68);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 49);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(609, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 49);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MixedNumberUI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(780, 412);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtDen2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtDen1);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numeros Mixtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox txtNum1;
        private Label labeldiv;
        private Label labelrest;
        private Label labelmult;
        private Label labelsum;
        private TextBox txtDen1;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtDen2;
        private TextBox txtNum2;
        private Button btnCalcular;
        private Button btnClear;
    }
}
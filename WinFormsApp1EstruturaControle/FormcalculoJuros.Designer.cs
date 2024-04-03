namespace WinFormsApp1EstruturaControle
{
    partial class FormcalculoJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormcalculoJuros));
            groupBox1 = new GroupBox();
            btnCalcular = new Button();
            txtJuros = new TextBox();
            txtValor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtmes = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtmes);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtJuros);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Juro Composto";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(16, 124);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 54);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtJuros
            // 
            txtJuros.Location = new Point(278, 65);
            txtJuros.Name = "txtJuros";
            txtJuros.Size = new Size(166, 31);
            txtJuros.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(16, 65);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(205, 31);
            txtValor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(278, 37);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 1;
            label2.Text = "Digite o % de Juros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(278, 124);
            label1.Name = "label1";
            label1.Size = new Size(416, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite quantos meses vc quer guardar seu dinheiro";
            // 
            // txtmes
            // 
            txtmes.Location = new Point(278, 152);
            txtmes.Name = "txtmes";
            txtmes.Size = new Size(166, 31);
            txtmes.TabIndex = 5;
         
            // 
            // FormcalculoJuros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 433);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "FormcalculoJuros";
            Text = "Calculo de Juros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCalcular;
        private TextBox txtJuros;
        private TextBox txtValor;
        private Label label2;
        private Label label1;
        private TextBox txtmes;
    }
}
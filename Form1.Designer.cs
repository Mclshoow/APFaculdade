
namespace EPAFaculdade
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
            this.lbl_CalculadoraMPDIV = new System.Windows.Forms.Label();
            this.gpb_Operaçao = new System.Windows.Forms.GroupBox();
            this.rdb_Divisao = new System.Windows.Forms.RadioButton();
            this.rdb_Multiplicaçao = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.nupd_Numero2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Numero2 = new System.Windows.Forms.Label();
            this.lbl_Numero1 = new System.Windows.Forms.Label();
            this.txtb_Numero1 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lb_Resultado = new System.Windows.Forms.ListBox();
            this.gpb_Operaçao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_Numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CalculadoraMPDIV
            // 
            this.lbl_CalculadoraMPDIV.AutoSize = true;
            this.lbl_CalculadoraMPDIV.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_CalculadoraMPDIV.Location = new System.Drawing.Point(67, 22);
            this.lbl_CalculadoraMPDIV.Name = "lbl_CalculadoraMPDIV";
            this.lbl_CalculadoraMPDIV.Size = new System.Drawing.Size(247, 35);
            this.lbl_CalculadoraMPDIV.TabIndex = 0;
            this.lbl_CalculadoraMPDIV.Text = "Calculadora Mp / Div";
            // 
            // gpb_Operaçao
            // 
            this.gpb_Operaçao.Controls.Add(this.rdb_Divisao);
            this.gpb_Operaçao.Controls.Add(this.rdb_Multiplicaçao);
            this.gpb_Operaçao.Controls.Add(this.btn_Calcular);
            this.gpb_Operaçao.Controls.Add(this.nupd_Numero2);
            this.gpb_Operaçao.Controls.Add(this.lbl_Numero2);
            this.gpb_Operaçao.Controls.Add(this.lbl_Numero1);
            this.gpb_Operaçao.Controls.Add(this.txtb_Numero1);
            this.gpb_Operaçao.Location = new System.Drawing.Point(12, 74);
            this.gpb_Operaçao.Name = "gpb_Operaçao";
            this.gpb_Operaçao.Size = new System.Drawing.Size(361, 172);
            this.gpb_Operaçao.TabIndex = 1;
            this.gpb_Operaçao.TabStop = false;
            this.gpb_Operaçao.Text = "Operaçao";
            // 
            // rdb_Divisao
            // 
            this.rdb_Divisao.AutoSize = true;
            this.rdb_Divisao.Location = new System.Drawing.Point(248, 75);
            this.rdb_Divisao.Name = "rdb_Divisao";
            this.rdb_Divisao.Size = new System.Drawing.Size(63, 19);
            this.rdb_Divisao.TabIndex = 5;
            this.rdb_Divisao.TabStop = true;
            this.rdb_Divisao.Text = "Divisao";
            this.rdb_Divisao.UseVisualStyleBackColor = true;
            // 
            // rdb_Multiplicaçao
            // 
            this.rdb_Multiplicaçao.AutoSize = true;
            this.rdb_Multiplicaçao.Location = new System.Drawing.Point(248, 42);
            this.rdb_Multiplicaçao.Name = "rdb_Multiplicaçao";
            this.rdb_Multiplicaçao.Size = new System.Drawing.Size(97, 19);
            this.rdb_Multiplicaçao.TabIndex = 4;
            this.rdb_Multiplicaçao.TabStop = true;
            this.rdb_Multiplicaçao.Text = "Multiplicaçao";
            this.rdb_Multiplicaçao.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calcular.Location = new System.Drawing.Point(118, 111);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(128, 43);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // nupd_Numero2
            // 
            this.nupd_Numero2.Location = new System.Drawing.Point(86, 71);
            this.nupd_Numero2.Name = "nupd_Numero2";
            this.nupd_Numero2.Size = new System.Drawing.Size(142, 23);
            this.nupd_Numero2.TabIndex = 3;
            this.nupd_Numero2.ValueChanged += new System.EventHandler(this.nupd_Numero2_ValueChanged);
            // 
            // lbl_Numero2
            // 
            this.lbl_Numero2.AutoSize = true;
            this.lbl_Numero2.Location = new System.Drawing.Point(20, 73);
            this.lbl_Numero2.Name = "lbl_Numero2";
            this.lbl_Numero2.Size = new System.Drawing.Size(60, 15);
            this.lbl_Numero2.TabIndex = 2;
            this.lbl_Numero2.Text = "Numero 2";
            // 
            // lbl_Numero1
            // 
            this.lbl_Numero1.AutoSize = true;
            this.lbl_Numero1.Location = new System.Drawing.Point(20, 41);
            this.lbl_Numero1.Name = "lbl_Numero1";
            this.lbl_Numero1.Size = new System.Drawing.Size(60, 15);
            this.lbl_Numero1.TabIndex = 1;
            this.lbl_Numero1.Text = "Numero 1";
            // 
            // txtb_Numero1
            // 
            this.txtb_Numero1.Location = new System.Drawing.Point(86, 38);
            this.txtb_Numero1.Name = "txtb_Numero1";
            this.txtb_Numero1.Size = new System.Drawing.Size(142, 23);
            this.txtb_Numero1.TabIndex = 0;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(130, 261);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(128, 36);
            this.lbl_Resultado.TabIndex = 8;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // lb_Resultado
            // 
            this.lb_Resultado.FormattingEnabled = true;
            this.lb_Resultado.ItemHeight = 15;
            this.lb_Resultado.Location = new System.Drawing.Point(12, 300);
            this.lb_Resultado.Name = "lb_Resultado";
            this.lb_Resultado.Size = new System.Drawing.Size(361, 289);
            this.lb_Resultado.TabIndex = 9;
            this.lb_Resultado.SelectedIndexChanged += new System.EventHandler(this.lb_Resultado_SelectedIndexChanged);
            this.lb_Resultado.DoubleClick += new System.EventHandler(this.lb_Resultado_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 594);
            this.Controls.Add(this.lb_Resultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.gpb_Operaçao);
            this.Controls.Add(this.lbl_CalculadoraMPDIV);
            this.Name = "Form1";
            this.Text = "Calculadora AP";
            this.gpb_Operaçao.ResumeLayout(false);
            this.gpb_Operaçao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_Numero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CalculadoraMPDIV;
        private System.Windows.Forms.GroupBox gpb_Operaçao;
        private System.Windows.Forms.RadioButton rdb_Divisao;
        private System.Windows.Forms.RadioButton rdb_Multiplicaçao;
        private System.Windows.Forms.NumericUpDown nupd_Numero2;
        private System.Windows.Forms.Label lbl_Numero2;
        private System.Windows.Forms.Label lbl_Numero1;
        private System.Windows.Forms.TextBox txtb_Numero1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.ListBox lb_Resultado;
    }
}


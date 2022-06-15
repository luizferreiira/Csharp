namespace DomiCalc
{
    partial class Tela_Inicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_JaTenho = new System.Windows.Forms.Button();
            this.txtComecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_domicalc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.txt_JaTenho);
            this.panel1.Controls.Add(this.txtComecar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LBL_domicalc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 461);
            this.panel1.TabIndex = 0;
            // 
            // txt_JaTenho
            // 
            this.txt_JaTenho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_JaTenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_JaTenho.Location = new System.Drawing.Point(80, 375);
            this.txt_JaTenho.Name = "txt_JaTenho";
            this.txt_JaTenho.Size = new System.Drawing.Size(230, 50);
            this.txt_JaTenho.TabIndex = 6;
            this.txt_JaTenho.Text = "Já tenho uma conta";
            this.txt_JaTenho.UseVisualStyleBackColor = true;
            this.txt_JaTenho.Click += new System.EventHandler(this.txt_JaTenho_Click);
            // 
            // txtComecar
            // 
            this.txtComecar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtComecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComecar.Location = new System.Drawing.Point(80, 310);
            this.txtComecar.Name = "txtComecar";
            this.txtComecar.Size = new System.Drawing.Size(230, 50);
            this.txtComecar.TabIndex = 5;
            this.txtComecar.Text = "Começar Agora";
            this.txtComecar.UseVisualStyleBackColor = true;
            this.txtComecar.Click += new System.EventHandler(this.txtComecar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domine o cálculo de graça";
            // 
            // LBL_domicalc
            // 
            this.LBL_domicalc.AutoSize = true;
            this.LBL_domicalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_domicalc.Location = new System.Drawing.Point(123, 152);
            this.LBL_domicalc.Name = "LBL_domicalc";
            this.LBL_domicalc.Size = new System.Drawing.Size(126, 29);
            this.LBL_domicalc.TabIndex = 3;
            this.LBL_domicalc.Text = "DomiCalc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DomiCalc.Properties.Resources.DomiCalc_1;
            this.pictureBox1.Location = new System.Drawing.Point(10, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Inicial";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_domicalc;
        private System.Windows.Forms.Button txt_JaTenho;
        private System.Windows.Forms.Button txtComecar;
        private System.Windows.Forms.Label label1;
    }
}
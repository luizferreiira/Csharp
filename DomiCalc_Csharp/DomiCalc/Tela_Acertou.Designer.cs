namespace DomiCalc
{
    partial class Tela_Acertou
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
            this.BTN_continuar = new System.Windows.Forms.Button();
            this.LBL_acertou = new System.Windows.Forms.Label();
            this.LBL_parabens = new System.Windows.Forms.Label();
            this.PIC_coruja2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.BTN_continuar);
            this.panel1.Controls.Add(this.LBL_acertou);
            this.panel1.Controls.Add(this.LBL_parabens);
            this.panel1.Controls.Add(this.PIC_coruja2);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 464);
            this.panel1.TabIndex = 1;
            // 
            // BTN_continuar
            // 
            this.BTN_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_continuar.Location = new System.Drawing.Point(146, 351);
            this.BTN_continuar.Name = "BTN_continuar";
            this.BTN_continuar.Size = new System.Drawing.Size(100, 50);
            this.BTN_continuar.TabIndex = 6;
            this.BTN_continuar.Text = "Continuar";
            this.BTN_continuar.UseVisualStyleBackColor = true;
            this.BTN_continuar.Click += new System.EventHandler(this.BTN_continuar_Click);
            // 
            // LBL_acertou
            // 
            this.LBL_acertou.AutoSize = true;
            this.LBL_acertou.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_acertou.Location = new System.Drawing.Point(121, 232);
            this.LBL_acertou.Name = "LBL_acertou";
            this.LBL_acertou.Size = new System.Drawing.Size(136, 25);
            this.LBL_acertou.TabIndex = 4;
            this.LBL_acertou.Text = "você acertou";
            // 
            // LBL_parabens
            // 
            this.LBL_parabens.AutoSize = true;
            this.LBL_parabens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_parabens.Location = new System.Drawing.Point(141, 203);
            this.LBL_parabens.Name = "LBL_parabens";
            this.LBL_parabens.Size = new System.Drawing.Size(110, 25);
            this.LBL_parabens.TabIndex = 2;
            this.LBL_parabens.Text = "Parabéns!";
            // 
            // PIC_coruja2
            // 
            this.PIC_coruja2.Image = global::DomiCalc.Properties.Resources.MicrosoftTeams_image;
            this.PIC_coruja2.Location = new System.Drawing.Point(43, 44);
            this.PIC_coruja2.Name = "PIC_coruja2";
            this.PIC_coruja2.Size = new System.Drawing.Size(307, 182);
            this.PIC_coruja2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_coruja2.TabIndex = 3;
            this.PIC_coruja2.TabStop = false;
            // 
            // Tela_Acertou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Acertou";
            this.Text = "Acertou! :)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_parabens;
        private System.Windows.Forms.PictureBox PIC_coruja2;
        private System.Windows.Forms.Label LBL_acertou;
        private System.Windows.Forms.Button BTN_continuar;
    }
}
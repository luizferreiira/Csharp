namespace DomiCalc
{
    partial class Tela_TentarDNV
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
            this.LBL_consegue = new System.Windows.Forms.Label();
            this.BTN_tentar = new System.Windows.Forms.Button();
            this.BTN_sair = new System.Windows.Forms.Button();
            this.LBL_tenteNov = new System.Windows.Forms.Label();
            this.LBL_triste = new System.Windows.Forms.Label();
            this.PIC_coruja3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.LBL_consegue);
            this.panel1.Controls.Add(this.BTN_tentar);
            this.panel1.Controls.Add(this.BTN_sair);
            this.panel1.Controls.Add(this.LBL_tenteNov);
            this.panel1.Controls.Add(this.LBL_triste);
            this.panel1.Controls.Add(this.PIC_coruja3);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 464);
            this.panel1.TabIndex = 2;
            // 
            // LBL_consegue
            // 
            this.LBL_consegue.AutoSize = true;
            this.LBL_consegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_consegue.Location = new System.Drawing.Point(123, 258);
            this.LBL_consegue.Name = "LBL_consegue";
            this.LBL_consegue.Size = new System.Drawing.Size(157, 25);
            this.LBL_consegue.TabIndex = 7;
            this.LBL_consegue.Text = "você consegue!!";
            // 
            // BTN_tentar
            // 
            this.BTN_tentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_tentar.Location = new System.Drawing.Point(215, 336);
            this.BTN_tentar.Name = "BTN_tentar";
            this.BTN_tentar.Size = new System.Drawing.Size(100, 50);
            this.BTN_tentar.TabIndex = 6;
            this.BTN_tentar.Text = "Tentar outra vez";
            this.BTN_tentar.UseVisualStyleBackColor = true;
            this.BTN_tentar.Click += new System.EventHandler(this.BTN_tentar_Click);
            // 
            // BTN_sair
            // 
            this.BTN_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_sair.Location = new System.Drawing.Point(73, 336);
            this.BTN_sair.Name = "BTN_sair";
            this.BTN_sair.Size = new System.Drawing.Size(100, 50);
            this.BTN_sair.TabIndex = 5;
            this.BTN_sair.Text = "Sair";
            this.BTN_sair.UseVisualStyleBackColor = true;
            this.BTN_sair.Click += new System.EventHandler(this.BTN_sair_Click);
            // 
            // LBL_tenteNov
            // 
            this.LBL_tenteNov.AutoSize = true;
            this.LBL_tenteNov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_tenteNov.Location = new System.Drawing.Point(116, 229);
            this.LBL_tenteNov.Name = "LBL_tenteNov";
            this.LBL_tenteNov.Size = new System.Drawing.Size(170, 25);
            this.LBL_tenteNov.TabIndex = 4;
            this.LBL_tenteNov.Text = "Tente novamente,";
            // 
            // LBL_triste
            // 
            this.LBL_triste.AutoSize = true;
            this.LBL_triste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_triste.Location = new System.Drawing.Point(183, 200);
            this.LBL_triste.Name = "LBL_triste";
            this.LBL_triste.Size = new System.Drawing.Size(25, 25);
            this.LBL_triste.TabIndex = 2;
            this.LBL_triste.Text = ":(";
            // 
            // PIC_coruja3
            // 
            this.PIC_coruja3.Image = global::DomiCalc.Properties.Resources.MicrosoftTeams_image;
            this.PIC_coruja3.Location = new System.Drawing.Point(43, 44);
            this.PIC_coruja3.Name = "PIC_coruja3";
            this.PIC_coruja3.Size = new System.Drawing.Size(307, 182);
            this.PIC_coruja3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_coruja3.TabIndex = 3;
            this.PIC_coruja3.TabStop = false;
            // 
            // Tela_TentarDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_TentarDNV";
            this.Text = "Tente de novo :(";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_tentar;
        private System.Windows.Forms.Button BTN_sair;
        private System.Windows.Forms.Label LBL_tenteNov;
        private System.Windows.Forms.Label LBL_triste;
        private System.Windows.Forms.PictureBox PIC_coruja3;
        private System.Windows.Forms.Label LBL_consegue;
    }
}
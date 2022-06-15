namespace DomiCalc
{
    partial class Dica
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
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.LBL_parabens = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.LBL_parabens);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 462);
            this.panel1.TabIndex = 1;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Location = new System.Drawing.Point(28, 381);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(100, 50);
            this.btn_Voltar.TabIndex = 11;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // LBL_parabens
            // 
            this.LBL_parabens.AutoSize = true;
            this.LBL_parabens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_parabens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_parabens.Location = new System.Drawing.Point(33, 204);
            this.LBL_parabens.Name = "LBL_parabens";
            this.LBL_parabens.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_parabens.Size = new System.Drawing.Size(322, 112);
            this.LBL_parabens.TabIndex = 12;
            this.LBL_parabens.Text = "Seja bem-vindo a primeira fase deste mundo!\r\n\r\nAntes de cada nível eu irei lhe co" +
    "nceder\r\n\r\numa dica para que você seja capaz de\r\n\r\nconcluir os desafios propostos" +
    ".";
            this.LBL_parabens.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_parabens.Click += new System.EventHandler(this.LBL_parabens_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Location = new System.Drawing.Point(256, 381);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(100, 50);
            this.btn_Confirmar.TabIndex = 13;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DomiCalc.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox3.Location = new System.Drawing.Point(102, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Dica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Dica";
            this.Text = "Dica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LBL_parabens;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}
namespace DomiCalc
{
    partial class DicaContinuacao2
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
            this.btn_IrExercicio = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btn_IrExercicio);
            this.panel1.Controls.Add(this.btn_Voltar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 462);
            this.panel1.TabIndex = 3;
            // 
            // btn_IrExercicio
            // 
            this.btn_IrExercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IrExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IrExercicio.Location = new System.Drawing.Point(256, 381);
            this.btn_IrExercicio.Name = "btn_IrExercicio";
            this.btn_IrExercicio.Size = new System.Drawing.Size(100, 50);
            this.btn_IrExercicio.TabIndex = 13;
            this.btn_IrExercicio.Text = "Ir para Exercicio";
            this.btn_IrExercicio.UseVisualStyleBackColor = true;
            this.btn_IrExercicio.Click += new System.EventHandler(this.btn_IrExercicio_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DomiCalc.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox3.Location = new System.Drawing.Point(130, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 175);
            this.label3.TabIndex = 17;
            this.label3.Text = "45 * 5% = x * 100%\r\n\r\n   225% = 100%x\r\n\r\n       x = 225/100\r\n\r\n       x = 2,25";
            // 
            // DicaContinuacao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "DicaContinuacao2";
            this.Text = "DicaContinuacao2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_IrExercicio;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label3;
    }
}
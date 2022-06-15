namespace DomiCalc
{
    partial class Tela_Jogar
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
            this.btn_Jogar = new System.Windows.Forms.Button();
            this.LBL_domicalc = new System.Windows.Forms.Label();
            this.MENU_jogar = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_VideoAula = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.domiCalcPremiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreDomiCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PIC_coruja = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.MENU_jogar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btn_Jogar);
            this.panel1.Controls.Add(this.LBL_domicalc);
            this.panel1.Controls.Add(this.MENU_jogar);
            this.panel1.Controls.Add(this.PIC_coruja);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 464);
            this.panel1.TabIndex = 0;
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jogar.Location = new System.Drawing.Point(105, 375);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Size = new System.Drawing.Size(180, 50);
            this.btn_Jogar.TabIndex = 0;
            this.btn_Jogar.Text = "Jogar";
            this.btn_Jogar.UseVisualStyleBackColor = true;
            this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
            // 
            // LBL_domicalc
            // 
            this.LBL_domicalc.AutoSize = true;
            this.LBL_domicalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_domicalc.Location = new System.Drawing.Point(122, 149);
            this.LBL_domicalc.Name = "LBL_domicalc";
            this.LBL_domicalc.Size = new System.Drawing.Size(126, 29);
            this.LBL_domicalc.TabIndex = 2;
            this.LBL_domicalc.Text = "DomiCalc";
            // 
            // MENU_jogar
            // 
            this.MENU_jogar.BackColor = System.Drawing.Color.Transparent;
            this.MENU_jogar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem10,
            this.toolStripMenuItem12});
            this.MENU_jogar.Location = new System.Drawing.Point(0, 0);
            this.MENU_jogar.Name = "MENU_jogar";
            this.MENU_jogar.Size = new System.Drawing.Size(393, 24);
            this.MENU_jogar.TabIndex = 1;
            this.MENU_jogar.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressoToolStripMenuItem,
            this.dicasToolStripMenuItem,
            this.btn_VideoAula,
            this.toolStripSeparator1,
            this.domiCalcPremiumToolStripMenuItem,
            this.toolStripSeparator2,
            this.btn_Sair});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // progressoToolStripMenuItem
            // 
            this.progressoToolStripMenuItem.Name = "progressoToolStripMenuItem";
            this.progressoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.progressoToolStripMenuItem.Text = "Progresso";
            // 
            // dicasToolStripMenuItem
            // 
            this.dicasToolStripMenuItem.Name = "dicasToolStripMenuItem";
            this.dicasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dicasToolStripMenuItem.Text = "Dicas";
            // 
            // btn_VideoAula
            // 
            this.btn_VideoAula.Name = "btn_VideoAula";
            this.btn_VideoAula.Size = new System.Drawing.Size(182, 22);
            this.btn_VideoAula.Text = "Video Aula";
            this.btn_VideoAula.Click += new System.EventHandler(this.btn_VideoAula_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // domiCalcPremiumToolStripMenuItem
            // 
            this.domiCalcPremiumToolStripMenuItem.Name = "domiCalcPremiumToolStripMenuItem";
            this.domiCalcPremiumToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.domiCalcPremiumToolStripMenuItem.Text = "DomiCalc Premium";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(182, 22);
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(175, 20);
            this.toolStripMenuItem10.Text = "                                                    ";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator3,
            this.sobreDomiCalcToolStripMenuItem});
            this.toolStripMenuItem12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(141, 20);
            this.toolStripMenuItem12.Text = "                            Config.";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // sobreDomiCalcToolStripMenuItem
            // 
            this.sobreDomiCalcToolStripMenuItem.Name = "sobreDomiCalcToolStripMenuItem";
            this.sobreDomiCalcToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sobreDomiCalcToolStripMenuItem.Text = "Sobre DomiCalc..";
            // 
            // PIC_coruja
            // 
            this.PIC_coruja.Image = global::DomiCalc.Properties.Resources.MicrosoftTeams_image;
            this.PIC_coruja.Location = new System.Drawing.Point(41, 13);
            this.PIC_coruja.Name = "PIC_coruja";
            this.PIC_coruja.Size = new System.Drawing.Size(307, 182);
            this.PIC_coruja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_coruja.TabIndex = 3;
            this.PIC_coruja.TabStop = false;
            // 
            // Tela_Jogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Jogar";
            this.Text = "Jogar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MENU_jogar.ResumeLayout(false);
            this.MENU_jogar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_coruja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Jogar;
        private System.Windows.Forms.MenuStrip MENU_jogar;
        private System.Windows.Forms.Label LBL_domicalc;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_VideoAula;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem domiCalcPremiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btn_Sair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sobreDomiCalcToolStripMenuItem;
        private System.Windows.Forms.PictureBox PIC_coruja;
    }
}
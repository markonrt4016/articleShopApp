namespace DrugiProjekatTVP
{
    partial class FrmGrupa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstRacun = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.noviArtikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledSvihRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutnoVremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(832, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaš račun:";
            // 
            // lstRacun
            // 
            this.lstRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRacun.FormattingEnabled = true;
            this.lstRacun.HorizontalScrollbar = true;
            this.lstRacun.ItemHeight = 20;
            this.lstRacun.Location = new System.Drawing.Point(714, 69);
            this.lstRacun.Name = "lstRacun";
            this.lstRacun.Size = new System.Drawing.Size(332, 444);
            this.lstRacun.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ukupno:";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.Location = new System.Drawing.Point(866, 526);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(19, 20);
            this.lblUkupnaCena.TabIndex = 4;
            this.lblUkupnaCena.Text = "0";
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(714, 594);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(146, 58);
            this.btnStorniraj.TabIndex = 5;
            this.btnStorniraj.Text = "Storniraj stavku";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdaj.Location = new System.Drawing.Point(900, 594);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(146, 58);
            this.btnIzdaj.TabIndex = 6;
            this.btnIzdaj.Text = "Izdaj račun";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(609, 506);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Odaberite artikal";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 594);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 12;
            this.button3.Text = "Nazad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviArtikalToolStripMenuItem,
            this.pregledSvihRačunaToolStripMenuItem,
            this.trenutnoVremeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 26);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // noviArtikalToolStripMenuItem
            // 
            this.noviArtikalToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noviArtikalToolStripMenuItem.Name = "noviArtikalToolStripMenuItem";
            this.noviArtikalToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.noviArtikalToolStripMenuItem.Text = "Novi Artikal";
            this.noviArtikalToolStripMenuItem.Click += new System.EventHandler(this.noviArtikalToolStripMenuItem_Click);
            // 
            // pregledSvihRačunaToolStripMenuItem
            // 
            this.pregledSvihRačunaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.pregledSvihRačunaToolStripMenuItem.Name = "pregledSvihRačunaToolStripMenuItem";
            this.pregledSvihRačunaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pregledSvihRačunaToolStripMenuItem.Text = "Pregled svih Računa";
            this.pregledSvihRačunaToolStripMenuItem.Click += new System.EventHandler(this.pregledSvihRačunaToolStripMenuItem_Click);
            // 
            // trenutnoVremeToolStripMenuItem
            // 
            this.trenutnoVremeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.trenutnoVremeToolStripMenuItem.Name = "trenutnoVremeToolStripMenuItem";
            this.trenutnoVremeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.trenutnoVremeToolStripMenuItem.Text = "Trenutno vreme";
            // 
            // FrmGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 662);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.lblUkupnaCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRacun);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrupa";
            this.Text = "FrmGrupa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGrupa_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noviArtikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledSvihRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutnoVremeToolStripMenuItem;
    }
}


namespace DrugiProjekatTVP
{
    partial class FrmPregledRacuna
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtmOd = new System.Windows.Forms.DateTimePicker();
            this.dtmDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.vrmDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.vrmOd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblObavestenje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite period za prikaz računa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum od:";
            // 
            // dtmOd
            // 
            this.dtmOd.CustomFormat = "dd.MM.yyyy.";
            this.dtmOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmOd.Location = new System.Drawing.Point(124, 77);
            this.dtmOd.Margin = new System.Windows.Forms.Padding(5);
            this.dtmOd.Name = "dtmOd";
            this.dtmOd.Size = new System.Drawing.Size(166, 26);
            this.dtmOd.TabIndex = 2;
            // 
            // dtmDo
            // 
            this.dtmDo.CustomFormat = "dd.MM.yyyy.";
            this.dtmDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDo.Location = new System.Drawing.Point(124, 140);
            this.dtmDo.Margin = new System.Windows.Forms.Padding(5);
            this.dtmDo.Name = "dtmDo";
            this.dtmDo.Size = new System.Drawing.Size(166, 26);
            this.dtmDo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum do:";
            // 
            // vrmDo
            // 
            this.vrmDo.CustomFormat = "HH:mm:ss";
            this.vrmDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrmDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vrmDo.Location = new System.Drawing.Point(444, 139);
            this.vrmDo.Margin = new System.Windows.Forms.Padding(5);
            this.vrmDo.Name = "vrmDo";
            this.vrmDo.ShowUpDown = true;
            this.vrmDo.Size = new System.Drawing.Size(166, 26);
            this.vrmDo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vreme do:";
            // 
            // vrmOd
            // 
            this.vrmOd.CustomFormat = "HH:mm:ss";
            this.vrmOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrmOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vrmOd.Location = new System.Drawing.Point(444, 76);
            this.vrmOd.Margin = new System.Windows.Forms.Padding(5);
            this.vrmOd.Name = "vrmOd";
            this.vrmOd.ShowUpDown = true;
            this.vrmOd.Size = new System.Drawing.Size(166, 26);
            this.vrmOd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vreme od:";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(224, 580);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(178, 47);
            this.btnNazad.TabIndex = 10;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 364);
            this.dataGridView1.TabIndex = 11;
            // 
            // lblObavestenje
            // 
            this.lblObavestenje.AutoSize = true;
            this.lblObavestenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavestenje.Location = new System.Drawing.Point(49, 182);
            this.lblObavestenje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObavestenje.Name = "lblObavestenje";
            this.lblObavestenje.Size = new System.Drawing.Size(127, 18);
            this.lblObavestenje.TabIndex = 12;
            this.lblObavestenje.Text = "Računi u periodu: ";
            // 
            // FrmPregledRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 639);
            this.Controls.Add(this.lblObavestenje);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.vrmDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vrmOd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtmDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPregledRacuna";
            this.Text = "FrmPregledRacuna";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmOd;
        private System.Windows.Forms.DateTimePicker dtmDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker vrmDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker vrmOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblObavestenje;
    }
}
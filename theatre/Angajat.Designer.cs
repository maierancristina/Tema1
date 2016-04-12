namespace theatre
{
    partial class Angajat
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
            this.bBack = new System.Windows.Forms.Button();
            this.bAddBilet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_spectacol = new System.Windows.Forms.TextBox();
            this.tb_rand = new System.Windows.Forms.TextBox();
            this.tb_numar = new System.Windows.Forms.TextBox();
            this.bLoadSoldTickets = new System.Windows.Forms.Button();
            this.dgv_soldTickets = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_specIdSoldTickets = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_soldTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(28, 443);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(149, 57);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bAddBilet
            // 
            this.bAddBilet.Location = new System.Drawing.Point(775, 442);
            this.bAddBilet.Name = "bAddBilet";
            this.bAddBilet.Size = new System.Drawing.Size(136, 57);
            this.bAddBilet.TabIndex = 1;
            this.bAddBilet.Text = "Add bilet";
            this.bAddBilet.UseVisualStyleBackColor = true;
            this.bAddBilet.Click += new System.EventHandler(this.bAddBilet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spectacol: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rand: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numar: ";
            // 
            // tb_spectacol
            // 
            this.tb_spectacol.Location = new System.Drawing.Point(811, 56);
            this.tb_spectacol.Name = "tb_spectacol";
            this.tb_spectacol.Size = new System.Drawing.Size(100, 22);
            this.tb_spectacol.TabIndex = 5;
            // 
            // tb_rand
            // 
            this.tb_rand.Location = new System.Drawing.Point(811, 106);
            this.tb_rand.Name = "tb_rand";
            this.tb_rand.Size = new System.Drawing.Size(100, 22);
            this.tb_rand.TabIndex = 6;
            // 
            // tb_numar
            // 
            this.tb_numar.Location = new System.Drawing.Point(811, 153);
            this.tb_numar.Name = "tb_numar";
            this.tb_numar.Size = new System.Drawing.Size(100, 22);
            this.tb_numar.TabIndex = 7;
            // 
            // bLoadSoldTickets
            // 
            this.bLoadSoldTickets.Location = new System.Drawing.Point(419, 443);
            this.bLoadSoldTickets.Name = "bLoadSoldTickets";
            this.bLoadSoldTickets.Size = new System.Drawing.Size(134, 56);
            this.bLoadSoldTickets.TabIndex = 8;
            this.bLoadSoldTickets.Text = "Load sold tickets";
            this.bLoadSoldTickets.UseVisualStyleBackColor = true;
            this.bLoadSoldTickets.Click += new System.EventHandler(this.bLoadSoldTickets_Click);
            // 
            // dgv_soldTickets
            // 
            this.dgv_soldTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_soldTickets.Location = new System.Drawing.Point(28, 20);
            this.dgv_soldTickets.Name = "dgv_soldTickets";
            this.dgv_soldTickets.RowTemplate.Height = 24;
            this.dgv_soldTickets.Size = new System.Drawing.Size(525, 358);
            this.dgv_soldTickets.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Insert Spectacol ID: ";
            // 
            // tb_specIdSoldTickets
            // 
            this.tb_specIdSoldTickets.Location = new System.Drawing.Point(419, 398);
            this.tb_specIdSoldTickets.Name = "tb_specIdSoldTickets";
            this.tb_specIdSoldTickets.Size = new System.Drawing.Size(134, 22);
            this.tb_specIdSoldTickets.TabIndex = 11;
            // 
            // Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 525);
            this.Controls.Add(this.tb_specIdSoldTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_soldTickets);
            this.Controls.Add(this.bLoadSoldTickets);
            this.Controls.Add(this.tb_numar);
            this.Controls.Add(this.tb_rand);
            this.Controls.Add(this.tb_spectacol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddBilet);
            this.Controls.Add(this.bBack);
            this.Name = "Angajat";
            this.Text = "Angajat";
            this.Load += new System.EventHandler(this.Angajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_soldTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAddBilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_spectacol;
        private System.Windows.Forms.TextBox tb_rand;
        private System.Windows.Forms.TextBox tb_numar;
        private System.Windows.Forms.Button bLoadSoldTickets;
        private System.Windows.Forms.DataGridView dgv_soldTickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_specIdSoldTickets;
    }
}
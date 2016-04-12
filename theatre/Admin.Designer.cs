namespace theatre
{
    partial class Admin
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
            this.bBackAdm = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nameAng = new System.Windows.Forms.TextBox();
            this.tb_usernameAng = new System.Windows.Forms.TextBox();
            this.tb_passAng = new System.Windows.Forms.TextBox();
            this.bAddSpec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_titlu = new System.Windows.Forms.TextBox();
            this.tb_regia = new System.Windows.Forms.TextBox();
            this.tb_distrib = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_bilete = new System.Windows.Forms.TextBox();
            this.bViewSpec = new System.Windows.Forms.Button();
            this.bLoadSpec = new System.Windows.Forms.Button();
            this.dgv_spec = new System.Windows.Forms.DataGridView();
            this.bDeleteSpec = new System.Windows.Forms.Button();
            this.bUpdateSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spec)).BeginInit();
            this.SuspendLayout();
            // 
            // bBackAdm
            // 
            this.bBackAdm.Location = new System.Drawing.Point(22, 434);
            this.bBackAdm.Name = "bBackAdm";
            this.bBackAdm.Size = new System.Drawing.Size(178, 66);
            this.bBackAdm.TabIndex = 0;
            this.bBackAdm.Text = "Back";
            this.bBackAdm.UseVisualStyleBackColor = true;
            this.bBackAdm.Click += new System.EventHandler(this.bBackAdm_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(903, 340);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(189, 66);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Add angajat";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // tb_nameAng
            // 
            this.tb_nameAng.Location = new System.Drawing.Point(644, 31);
            this.tb_nameAng.Name = "tb_nameAng";
            this.tb_nameAng.Size = new System.Drawing.Size(100, 22);
            this.tb_nameAng.TabIndex = 5;
            // 
            // tb_usernameAng
            // 
            this.tb_usernameAng.Location = new System.Drawing.Point(644, 76);
            this.tb_usernameAng.Name = "tb_usernameAng";
            this.tb_usernameAng.Size = new System.Drawing.Size(100, 22);
            this.tb_usernameAng.TabIndex = 6;
            // 
            // tb_passAng
            // 
            this.tb_passAng.Location = new System.Drawing.Point(644, 120);
            this.tb_passAng.Name = "tb_passAng";
            this.tb_passAng.Size = new System.Drawing.Size(100, 22);
            this.tb_passAng.TabIndex = 7;
            this.tb_passAng.UseSystemPasswordChar = true;
            // 
            // bAddSpec
            // 
            this.bAddSpec.Location = new System.Drawing.Point(903, 434);
            this.bAddSpec.Name = "bAddSpec";
            this.bAddSpec.Size = new System.Drawing.Size(189, 65);
            this.bAddSpec.TabIndex = 8;
            this.bAddSpec.Text = "Add spectacol";
            this.bAddSpec.UseVisualStyleBackColor = true;
            this.bAddSpec.Click += new System.EventHandler(this.bAddSpec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Titlul: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regia: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distributia: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(801, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data premierei: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Numarul biletelor: ";
            // 
            // tb_titlu
            // 
            this.tb_titlu.Location = new System.Drawing.Point(930, 31);
            this.tb_titlu.Name = "tb_titlu";
            this.tb_titlu.Size = new System.Drawing.Size(100, 22);
            this.tb_titlu.TabIndex = 14;
            // 
            // tb_regia
            // 
            this.tb_regia.Location = new System.Drawing.Point(930, 76);
            this.tb_regia.Name = "tb_regia";
            this.tb_regia.Size = new System.Drawing.Size(100, 22);
            this.tb_regia.TabIndex = 15;
            // 
            // tb_distrib
            // 
            this.tb_distrib.Location = new System.Drawing.Point(930, 120);
            this.tb_distrib.Name = "tb_distrib";
            this.tb_distrib.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_distrib.Size = new System.Drawing.Size(100, 22);
            this.tb_distrib.TabIndex = 16;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(930, 180);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(100, 22);
            this.tb_data.TabIndex = 17;
            // 
            // tb_bilete
            // 
            this.tb_bilete.Location = new System.Drawing.Point(930, 221);
            this.tb_bilete.Name = "tb_bilete";
            this.tb_bilete.Size = new System.Drawing.Size(100, 22);
            this.tb_bilete.TabIndex = 18;
            this.tb_bilete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bViewSpec
            // 
            this.bViewSpec.Location = new System.Drawing.Point(690, 434);
            this.bViewSpec.Name = "bViewSpec";
            this.bViewSpec.Size = new System.Drawing.Size(190, 66);
            this.bViewSpec.TabIndex = 19;
            this.bViewSpec.Text = "View ";
            this.bViewSpec.UseVisualStyleBackColor = true;
            this.bViewSpec.Click += new System.EventHandler(this.bViewSpec_Click);
            // 
            // bLoadSpec
            // 
            this.bLoadSpec.Location = new System.Drawing.Point(544, 434);
            this.bLoadSpec.Name = "bLoadSpec";
            this.bLoadSpec.Size = new System.Drawing.Size(125, 65);
            this.bLoadSpec.TabIndex = 20;
            this.bLoadSpec.Text = "Load";
            this.bLoadSpec.UseVisualStyleBackColor = true;
            this.bLoadSpec.Click += new System.EventHandler(this.bLoadSpec_Click);
            // 
            // dgv_spec
            // 
            this.dgv_spec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spec.Location = new System.Drawing.Point(12, 12);
            this.dgv_spec.Name = "dgv_spec";
            this.dgv_spec.RowTemplate.Height = 24;
            this.dgv_spec.Size = new System.Drawing.Size(525, 394);
            this.dgv_spec.TabIndex = 21;
            // 
            // bDeleteSpec
            // 
            this.bDeleteSpec.Location = new System.Drawing.Point(382, 434);
            this.bDeleteSpec.Name = "bDeleteSpec";
            this.bDeleteSpec.Size = new System.Drawing.Size(127, 65);
            this.bDeleteSpec.TabIndex = 22;
            this.bDeleteSpec.Text = "Delete";
            this.bDeleteSpec.UseVisualStyleBackColor = true;
            this.bDeleteSpec.Click += new System.EventHandler(this.bDeleteSpec_Click);
            // 
            // bUpdateSpec
            // 
            this.bUpdateSpec.Location = new System.Drawing.Point(222, 434);
            this.bUpdateSpec.Name = "bUpdateSpec";
            this.bUpdateSpec.Size = new System.Drawing.Size(134, 65);
            this.bUpdateSpec.TabIndex = 23;
            this.bUpdateSpec.Text = "Update";
            this.bUpdateSpec.UseVisualStyleBackColor = true;
            this.bUpdateSpec.Click += new System.EventHandler(this.bUpdateSpec_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 524);
            this.Controls.Add(this.bUpdateSpec);
            this.Controls.Add(this.bDeleteSpec);
            this.Controls.Add(this.dgv_spec);
            this.Controls.Add(this.bLoadSpec);
            this.Controls.Add(this.bViewSpec);
            this.Controls.Add(this.tb_bilete);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_distrib);
            this.Controls.Add(this.tb_regia);
            this.Controls.Add(this.tb_titlu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAddSpec);
            this.Controls.Add(this.tb_passAng);
            this.Controls.Add(this.tb_usernameAng);
            this.Controls.Add(this.tb_nameAng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bBackAdm);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBackAdm;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nameAng;
        private System.Windows.Forms.TextBox tb_usernameAng;
        private System.Windows.Forms.TextBox tb_passAng;
        private System.Windows.Forms.Button bAddSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_titlu;
        private System.Windows.Forms.TextBox tb_regia;
        private System.Windows.Forms.TextBox tb_distrib;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_bilete;
        private System.Windows.Forms.Button bViewSpec;
        private System.Windows.Forms.Button bLoadSpec;
        private System.Windows.Forms.DataGridView dgv_spec;
        private System.Windows.Forms.Button bDeleteSpec;
        private System.Windows.Forms.Button bUpdateSpec;
    }
}
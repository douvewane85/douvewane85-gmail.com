namespace TP_Cargaison_LIAGE3_GLRS3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxCargaison = new System.Windows.Forms.ListBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMarchandises = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVolumeTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoidsTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpMarchandise = new System.Windows.Forms.Button();
            this.btnAddMarchandise = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandises)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxCargaison);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(527, 684);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargaison";
            // 
            // lbxCargaison
            // 
            this.lbxCargaison.FormattingEnabled = true;
            this.lbxCargaison.ItemHeight = 29;
            this.lbxCargaison.Location = new System.Drawing.Point(27, 346);
            this.lbxCargaison.Name = "lbxCargaison";
            this.lbxCargaison.Size = new System.Drawing.Size(476, 323);
            this.lbxCargaison.TabIndex = 8;
            this.lbxCargaison.SelectedIndexChanged += new System.EventHandler(this.lbxCargaison_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Aerienne",
            "Routiere"});
            this.cboType.Location = new System.Drawing.Point(135, 151);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(262, 37);
            this.cboType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste des Cargaisons";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(135, 65);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(262, 34);
            this.txtDistance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvMarchandises);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(562, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 667);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marchandises";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Liste Des Marchandises";
            // 
            // dgvMarchandises
            // 
            this.dgvMarchandises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarchandises.Location = new System.Drawing.Point(17, 329);
            this.dgvMarchandises.Name = "dgvMarchandises";
            this.dgvMarchandises.RowTemplate.Height = 24;
            this.dgvMarchandises.Size = new System.Drawing.Size(668, 323);
            this.dgvMarchandises.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCout);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtVolumeTotal);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtPoidsTotal);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(354, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 215);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // txtCout
            // 
            this.txtCout.Enabled = false;
            this.txtCout.Location = new System.Drawing.Point(132, 142);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(162, 34);
            this.txtCout.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cout";
            // 
            // txtVolumeTotal
            // 
            this.txtVolumeTotal.Enabled = false;
            this.txtVolumeTotal.Location = new System.Drawing.Point(132, 84);
            this.txtVolumeTotal.Name = "txtVolumeTotal";
            this.txtVolumeTotal.Size = new System.Drawing.Size(162, 34);
            this.txtVolumeTotal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Poids";
            // 
            // txtPoidsTotal
            // 
            this.txtPoidsTotal.Enabled = false;
            this.txtPoidsTotal.Location = new System.Drawing.Point(132, 31);
            this.txtPoidsTotal.Name = "txtPoidsTotal";
            this.txtPoidsTotal.Size = new System.Drawing.Size(162, 34);
            this.txtPoidsTotal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Volume";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnUpMarchandise);
            this.groupBox3.Controls.Add(this.btnAddMarchandise);
            this.groupBox3.Controls.Add(this.txtVolume);
            this.groupBox3.Controls.Add(this.txtPoids);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(17, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 215);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nouvelle";
            // 
            // btnUpMarchandise
            // 
            this.btnUpMarchandise.Location = new System.Drawing.Point(132, 139);
            this.btnUpMarchandise.Name = "btnUpMarchandise";
            this.btnUpMarchandise.Size = new System.Drawing.Size(75, 41);
            this.btnUpMarchandise.TabIndex = 12;
            this.btnUpMarchandise.Text = "UP";
            this.btnUpMarchandise.UseVisualStyleBackColor = true;
            // 
            // btnAddMarchandise
            // 
            this.btnAddMarchandise.Location = new System.Drawing.Point(219, 138);
            this.btnAddMarchandise.Name = "btnAddMarchandise";
            this.btnAddMarchandise.Size = new System.Drawing.Size(75, 41);
            this.btnAddMarchandise.TabIndex = 9;
            this.btnAddMarchandise.Text = "ADD";
            this.btnAddMarchandise.UseVisualStyleBackColor = true;
            this.btnAddMarchandise.Click += new System.EventHandler(this.btnAddMarchandise_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(132, 87);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(162, 34);
            this.txtVolume.TabIndex = 11;
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(132, 34);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(162, 34);
            this.txtPoids.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poids";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "DEL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP Cargaison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandises)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVolumeTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoidsTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddMarchandise;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvMarchandises;
        private System.Windows.Forms.ListBox lbxCargaison;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpMarchandise;
        private System.Windows.Forms.Button button1;
    }
}


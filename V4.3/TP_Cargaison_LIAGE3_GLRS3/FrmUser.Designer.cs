namespace TP_Cargaison_LIAGE3_GLRS3
{
    partial class FrmUser
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
            this.pnelNewUser = new System.Windows.Forms.GroupBox();
            this.btnRefrech = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.radProfil2 = new System.Windows.Forms.RadioButton();
            this.radProfil1 = new System.Windows.Forms.RadioButton();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.bntPrec = new System.Windows.Forms.Button();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.pnelNewUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnelNewUser
            // 
            this.pnelNewUser.Controls.Add(this.btnRefrech);
            this.pnelNewUser.Controls.Add(this.btnUp);
            this.pnelNewUser.Controls.Add(this.btnAdd);
            this.pnelNewUser.Controls.Add(this.label5);
            this.pnelNewUser.Controls.Add(this.btnClear);
            this.pnelNewUser.Controls.Add(this.radProfil2);
            this.pnelNewUser.Controls.Add(this.radProfil1);
            this.pnelNewUser.Controls.Add(this.txtConfirmPwd);
            this.pnelNewUser.Controls.Add(this.label4);
            this.pnelNewUser.Controls.Add(this.txtPwd);
            this.pnelNewUser.Controls.Add(this.label3);
            this.pnelNewUser.Controls.Add(this.txtLogin);
            this.pnelNewUser.Controls.Add(this.label2);
            this.pnelNewUser.Controls.Add(this.txtNom);
            this.pnelNewUser.Controls.Add(this.label1);
            this.pnelNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnelNewUser.Location = new System.Drawing.Point(46, 28);
            this.pnelNewUser.Name = "pnelNewUser";
            this.pnelNewUser.Size = new System.Drawing.Size(598, 693);
            this.pnelNewUser.TabIndex = 0;
            this.pnelNewUser.TabStop = false;
            this.pnelNewUser.Text = "Nouvel Utilisateur";
            // 
            // btnRefrech
            // 
            this.btnRefrech.Location = new System.Drawing.Point(434, 29);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(142, 40);
            this.btnRefrech.TabIndex = 14;
            this.btnRefrech.Text = "Actualiser";
            this.btnRefrech.UseVisualStyleBackColor = true;
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(394, 529);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(121, 40);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Modifier";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 529);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Profil";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(31, 529);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radProfil2
            // 
            this.radProfil2.AutoSize = true;
            this.radProfil2.Location = new System.Drawing.Point(394, 423);
            this.radProfil2.Name = "radProfil2";
            this.radProfil2.Size = new System.Drawing.Size(94, 29);
            this.radProfil2.TabIndex = 9;
            this.radProfil2.Text = "Admin";
            this.radProfil2.UseVisualStyleBackColor = true;
            // 
            // radProfil1
            // 
            this.radProfil1.AutoSize = true;
            this.radProfil1.Checked = true;
            this.radProfil1.Location = new System.Drawing.Point(156, 423);
            this.radProfil1.Name = "radProfil1";
            this.radProfil1.Size = new System.Drawing.Size(183, 29);
            this.radProfil1.TabIndex = 8;
            this.radProfil1.TabStop = true;
            this.radProfil1.Text = "Gest Cargaison";
            this.radProfil1.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(256, 331);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(320, 30);
            this.txtConfirmPwd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmation";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(256, 252);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(320, 30);
            this.txtPwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de Passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(256, 173);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(320, 30);
            this.txtLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(256, 90);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(320, 30);
            this.txtNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom et Prenom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.bntPrec);
            this.groupBox2.Controls.Add(this.dtgvUser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(664, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 693);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Users";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(507, 44);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(141, 40);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Supprimer";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(270, 44);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 40);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // bntPrec
            // 
            this.bntPrec.Location = new System.Drawing.Point(35, 44);
            this.bntPrec.Name = "bntPrec";
            this.bntPrec.Size = new System.Drawing.Size(168, 40);
            this.bntPrec.TabIndex = 15;
            this.bntPrec.Text = "Precedent";
            this.bntPrec.UseVisualStyleBackColor = true;
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(35, 90);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(629, 567);
            this.dtgvUser.TabIndex = 0;
            this.dtgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellClick);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnelNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.pnelNewUser.ResumeLayout(false);
            this.pnelNewUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnelNewUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radProfil2;
        private System.Windows.Forms.RadioButton radProfil1;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrech;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button bntPrec;
        private System.Windows.Forms.DataGridView dtgvUser;
    }
}
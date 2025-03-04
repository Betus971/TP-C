
namespace TP_C
{
    partial class Inscription
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
            this.btninscrip = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.pseudo = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textmdp = new System.Windows.Forms.TextBox();
            this.textpseudo = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninscrip
            // 
            this.btninscrip.Location = new System.Drawing.Point(250, 323);
            this.btninscrip.Name = "btninscrip";
            this.btninscrip.Size = new System.Drawing.Size(190, 23);
            this.btninscrip.TabIndex = 0;
            this.btninscrip.Text = "inscription";
            this.btninscrip.UseVisualStyleBackColor = true;
            this.btninscrip.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(309, 25);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(34, 15);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            this.Nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(313, 81);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(49, 15);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prenom";
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Location = new System.Drawing.Point(313, 157);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(46, 15);
            this.pseudo.TabIndex = 3;
            this.pseudo.Text = "Pseudo";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Location = new System.Drawing.Point(309, 242);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(82, 15);
            this.mdp.TabIndex = 4;
            this.mdp.Text = "mots de passe";
            this.mdp.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(250, 43);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(190, 23);
            this.textNom.TabIndex = 5;
            // 
            // textmdp
            // 
            this.textmdp.Location = new System.Drawing.Point(250, 278);
            this.textmdp.Name = "textmdp";
            this.textmdp.Size = new System.Drawing.Size(190, 23);
            this.textmdp.TabIndex = 7;
            this.textmdp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textpseudo
            // 
            this.textpseudo.Location = new System.Drawing.Point(250, 193);
            this.textpseudo.Name = "textpseudo";
            this.textpseudo.Size = new System.Drawing.Size(190, 23);
            this.textpseudo.TabIndex = 8;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(250, 118);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(190, 23);
            this.textPrenom.TabIndex = 9;
            // 
            // labellogin
            // 
            this.labellogin.Location = new System.Drawing.Point(250, 377);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(190, 23);
            this.labellogin.TabIndex = 11;
            this.labellogin.Text = "login";
            this.labellogin.UseVisualStyleBackColor = true;
            this.labellogin.Click += new System.EventHandler(this.labellogin_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textpseudo);
            this.Controls.Add(this.textmdp);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.pseudo);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.btninscrip);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninscrip;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label pseudo;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textmdp;
        private System.Windows.Forms.TextBox textpseudo;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.Button labellogin;
    }
}

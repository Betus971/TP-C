
using System;

namespace TP_C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Textmdp = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ButtonCo = new System.Windows.Forms.Button();
            textPseudo = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Textmdp
            // 
            Textmdp.Location = new System.Drawing.Point(320, 223);
            Textmdp.Name = "Textmdp";
            Textmdp.PasswordChar = '*';
            Textmdp.Size = new System.Drawing.Size(156, 23);
            Textmdp.TabIndex = 5;
            Textmdp.TextChanged += mdp_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(320, 205);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Mots de passe ";
            label4.Click += label4_Click;
            // 
            // ButtonCo
            // 
            ButtonCo.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            ButtonCo.Location = new System.Drawing.Point(320, 275);
            ButtonCo.Name = "ButtonCo";
            ButtonCo.Size = new System.Drawing.Size(156, 52);
            ButtonCo.TabIndex = 8;
            ButtonCo.Text = "connexion";
            ButtonCo.UseVisualStyleBackColor = false;
            ButtonCo.Click += button1_Click_1;
            // 
            // textPseudo
            // 
            textPseudo.Location = new System.Drawing.Point(320, 165);
            textPseudo.Name = "textPseudo";
            textPseudo.Size = new System.Drawing.Size(156, 23);
            textPseudo.TabIndex = 9;
            textPseudo.TextChanged += textBox1_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(320, 138);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 15);
            label6.TabIndex = 11;
            label6.Text = "Pseudo";
            label6.Click += label6_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textPseudo);
            Controls.Add(ButtonCo);
            Controls.Add(label4);
            Controls.Add(Textmdp);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox Textmdp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCo;
        private System.Windows.Forms.TextBox textPseudo;
        private System.Windows.Forms.Label label6;
    }
}


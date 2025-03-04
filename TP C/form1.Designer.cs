
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textmdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCo = new System.Windows.Forms.Button();
            this.textPseudo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.forget = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(320, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Textmdp
            // 
            this.Textmdp.Location = new System.Drawing.Point(320, 223);
            this.Textmdp.Name = "Textmdp";
            this.Textmdp.PasswordChar = '*';
            this.Textmdp.Size = new System.Drawing.Size(156, 23);
            this.Textmdp.TabIndex = 5;
            this.Textmdp.TextChanged += new System.EventHandler(this.mdp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mots de passe ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ButtonCo
            // 
            this.ButtonCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonCo.Location = new System.Drawing.Point(320, 275);
            this.ButtonCo.Name = "ButtonCo";
            this.ButtonCo.Size = new System.Drawing.Size(129, 52);
            this.ButtonCo.TabIndex = 8;
            this.ButtonCo.Text = "connexion";
            this.ButtonCo.UseVisualStyleBackColor = false;
            this.ButtonCo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textPseudo
            // 
            this.textPseudo.Location = new System.Drawing.Point(320, 165);
            this.textPseudo.Name = "textPseudo";
            this.textPseudo.Size = new System.Drawing.Size(156, 23);
            this.textPseudo.TabIndex = 9;
            this.textPseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.BackColor = System.Drawing.Color.Chartreuse;
            this.forget.Location = new System.Drawing.Point(257, 311);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(60, 15);
            this.forget.TabIndex = 11;
            this.forget.TabStop = true;
            this.forget.Text = "linkLabel1";
            this.forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPseudo);
            this.Controls.Add(this.ButtonCo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Textmdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox Textmdp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCo;
        private System.Windows.Forms.TextBox textPseudo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel forget;
    }
}


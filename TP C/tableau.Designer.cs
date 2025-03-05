
namespace TP_C
{
    partial class tableau
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
            textBox1 = new System.Windows.Forms.TextBox();
            afficher = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            modifier = new System.Windows.Forms.Button();
            update = new System.Windows.Forms.Button();
            crée_table = new System.Windows.Forms.Button();
            textBoxNom = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            update1 = new System.Windows.Forms.Button();
            textBoxID = new System.Windows.Forms.TextBox();
            Delete = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            afficherLaTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mettreAJoursLaTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reserverEquiepementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(688, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // afficher
            // 
            afficher.Location = new System.Drawing.Point(607, 43);
            afficher.Name = "afficher";
            afficher.Size = new System.Drawing.Size(75, 23);
            afficher.TabIndex = 1;
            afficher.Text = "afficher";
            afficher.UseVisualStyleBackColor = true;
            afficher.Click += afficher_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(111, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(677, 243);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // modifier
            // 
            modifier.Location = new System.Drawing.Point(12, 249);
            modifier.Name = "modifier";
            modifier.Size = new System.Drawing.Size(75, 23);
            modifier.TabIndex = 3;
            modifier.Text = "modifier";
            modifier.UseVisualStyleBackColor = true;
            modifier.Click += modifier_Click;
            // 
            // update
            // 
            update.Location = new System.Drawing.Point(12, 147);
            update.Name = "update";
            update.Size = new System.Drawing.Size(75, 23);
            update.TabIndex = 4;
            update.Text = "inseré";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // crée_table
            // 
            crée_table.Location = new System.Drawing.Point(12, 106);
            crée_table.Name = "crée_table";
            crée_table.Size = new System.Drawing.Size(75, 23);
            crée_table.TabIndex = 5;
            crée_table.Text = "crée table";
            crée_table.UseVisualStyleBackColor = true;
            crée_table.Click += crée_table_Click;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new System.Drawing.Point(133, 61);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new System.Drawing.Size(100, 23);
            textBoxNom.TabIndex = 6;
            textBoxNom.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(133, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(133, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(-2, 176);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(107, 23);
            button1.TabIndex = 9;
            button1.Text = "afficher table";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // update1
            // 
            update1.Location = new System.Drawing.Point(12, 299);
            update1.Name = "update1";
            update1.Size = new System.Drawing.Size(75, 23);
            update1.TabIndex = 10;
            update1.Text = "update";
            update1.UseVisualStyleBackColor = true;
            update1.Click += update1_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new System.Drawing.Point(252, 81);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(100, 23);
            textBoxID.TabIndex = 11;
            // 
            // Delete
            // 
            Delete.Location = new System.Drawing.Point(12, 205);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(75, 23);
            Delete.TabIndex = 12;
            Delete.Text = "supprimer";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { afficherLaTableToolStripMenuItem, modifierToolStripMenuItem, mettreAJoursLaTableToolStripMenuItem, reserverEquiepementToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // afficherLaTableToolStripMenuItem
            // 
            afficherLaTableToolStripMenuItem.Name = "afficherLaTableToolStripMenuItem";
            afficherLaTableToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            afficherLaTableToolStripMenuItem.Text = "Afficher la table";
            afficherLaTableToolStripMenuItem.Click += afficherLaTableToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.AccessibleName = "";
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            modifierToolStripMenuItem.Text = "modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // mettreAJoursLaTableToolStripMenuItem
            // 
            mettreAJoursLaTableToolStripMenuItem.Name = "mettreAJoursLaTableToolStripMenuItem";
            mettreAJoursLaTableToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            mettreAJoursLaTableToolStripMenuItem.Text = "Mettre a Jours la table";
            // 
            // reserverEquiepementToolStripMenuItem
            // 
            reserverEquiepementToolStripMenuItem.Name = "reserverEquiepementToolStripMenuItem";
            reserverEquiepementToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            reserverEquiepementToolStripMenuItem.Text = "Reserver Equiepement";
            reserverEquiepementToolStripMenuItem.Click += reserverEquiepementToolStripMenuItem_Click;
            // 
            // tableau
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(textBoxID);
            Controls.Add(update1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBoxNom);
            Controls.Add(crée_table);
            Controls.Add(update);
            Controls.Add(modifier);
            Controls.Add(dataGridView1);
            Controls.Add(afficher);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "tableau";
            Text = "Formulaire";
            Load += Formulaire_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button crée_table;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button update1;
        private System.Windows.Forms.TextBox textBoxID;
       // private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afficherLaTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mettreAJoursLaTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserverEquiepementToolStripMenuItem;
    }
}
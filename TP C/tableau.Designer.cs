
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.afficher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modifier = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.crée_table = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.update1 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afficherLaTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreAJoursLaTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(607, 43);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(75, 23);
            this.afficher.TabIndex = 1;
            this.afficher.Text = "afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(677, 243);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(12, 249);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 3;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 147);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 4;
            this.update.Text = "inseré";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // crée_table
            // 
            this.crée_table.Location = new System.Drawing.Point(12, 106);
            this.crée_table.Name = "crée_table";
            this.crée_table.Size = new System.Drawing.Size(75, 23);
            this.crée_table.TabIndex = 5;
            this.crée_table.Text = "crée table";
            this.crée_table.UseVisualStyleBackColor = true;
            this.crée_table.Click += new System.EventHandler(this.crée_table_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(133, 61);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 6;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "afficher table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(12, 299);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(75, 23);
            this.update1.TabIndex = 10;
            this.update1.Text = "update";
            this.update1.UseVisualStyleBackColor = true;
            this.update1.Click += new System.EventHandler(this.update1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(252, 81);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 11;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 205);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "supprimer";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLaTableToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.mettreAJoursLaTableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afficherLaTableToolStripMenuItem
            // 
            this.afficherLaTableToolStripMenuItem.Name = "afficherLaTableToolStripMenuItem";
            this.afficherLaTableToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.afficherLaTableToolStripMenuItem.Text = "Afficher la table";
            this.afficherLaTableToolStripMenuItem.Click += new System.EventHandler(this.afficherLaTableToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.AccessibleName = "";
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // mettreAJoursLaTableToolStripMenuItem
            // 
            this.mettreAJoursLaTableToolStripMenuItem.Name = "mettreAJoursLaTableToolStripMenuItem";
            this.mettreAJoursLaTableToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.mettreAJoursLaTableToolStripMenuItem.Text = "Mettre a Jours la table";
            // 
            // tableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.update1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.crée_table);
            this.Controls.Add(this.update);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tableau";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Formulaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
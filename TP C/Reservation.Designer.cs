
namespace TP_C
{
    partial class Reservation
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.equipement = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // equipement
            // 
            this.equipement.AutoSize = true;
            this.equipement.Location = new System.Drawing.Point(330, 127);
            this.equipement.Name = "equipement";
            this.equipement.Size = new System.Drawing.Size(71, 15);
            this.equipement.TabIndex = 1;
            this.equipement.Text = "equipement";
            this.equipement.Click += new System.EventHandler(this.equipement_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // reserver
            // 
            this.reserver.Location = new System.Drawing.Point(296, 213);
            this.reserver.Name = "reserver";
            this.reserver.Size = new System.Drawing.Size(146, 23);
            this.reserver.TabIndex = 3;
            this.reserver.Text = "Reserver";
            this.reserver.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserver);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.equipement);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label equipement;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button reserver;
    }
}
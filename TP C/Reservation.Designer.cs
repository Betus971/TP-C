
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
            dateTimeReservation = new System.Windows.Forms.DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            equipement = new System.Windows.Forms.Label();
            ButtonReserver = new System.Windows.Forms.Button();
            SelectEquipement = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // dateTimeReservation
            // 
            dateTimeReservation.Location = new System.Drawing.Point(272, 88);
            dateTimeReservation.Name = "dateTimeReservation";
            dateTimeReservation.Size = new System.Drawing.Size(200, 23);
            dateTimeReservation.TabIndex = 0;
            // 
            // equipement
            // 
            equipement.AutoSize = true;
            equipement.Location = new System.Drawing.Point(330, 127);
            equipement.Name = "equipement";
            equipement.Size = new System.Drawing.Size(71, 15);
            equipement.TabIndex = 1;
            equipement.Text = "equipement";
            equipement.Click += equipement_Click;
            // 
            // ButtonReserver
            // 
            ButtonReserver.Location = new System.Drawing.Point(296, 213);
            ButtonReserver.Name = "ButtonReserver";
            ButtonReserver.Size = new System.Drawing.Size(146, 23);
            ButtonReserver.TabIndex = 3;
            ButtonReserver.Text = "Reserver";
            ButtonReserver.UseVisualStyleBackColor = true;
            ButtonReserver.Click += ButtonReserver_Click;
            // 
            // SelectEquipement
            // 
            SelectEquipement.FormattingEnabled = true;
            SelectEquipement.Location = new System.Drawing.Point(306, 167);
            SelectEquipement.Name = "SelectEquipement";
            SelectEquipement.Size = new System.Drawing.Size(121, 23);
            SelectEquipement.TabIndex = 4;
            SelectEquipement.SelectedIndexChanged += SelectEquipement_SelectedIndexChanged;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(SelectEquipement);
            Controls.Add(ButtonReserver);
            Controls.Add(equipement);
            Controls.Add(dateTimeReservation);
            Name = "Reservation";
            Text = "Reservation";
            Load += Reservation_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeReservation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label equipement;
        private System.Windows.Forms.Button ButtonReserver;
        private System.Windows.Forms.ComboBox SelectEquipement;
    }
}
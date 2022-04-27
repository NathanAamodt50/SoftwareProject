
namespace JackrabbitPromotionSoftware
{
    partial class ReservationGUI
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.SearchCoup = new System.Windows.Forms.Button();
            this.SearchCust = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(171, 169);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(457, 20);
            this.dateTimePicker3.TabIndex = 0;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(265, 124);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jackrabbit Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(168, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Party Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(148, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Reservation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Inventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory.Location = new System.Drawing.Point(33, 297);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(104, 42);
            this.Inventory.TabIndex = 15;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = false;
            // 
            // Reservation
            // 
            this.Reservation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Reservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reservation.Location = new System.Drawing.Point(33, 195);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(104, 42);
            this.Reservation.TabIndex = 14;
            this.Reservation.Text = "Reservations";
            this.Reservation.UseVisualStyleBackColor = false;
            // 
            // SearchCoup
            // 
            this.SearchCoup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchCoup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCoup.Location = new System.Drawing.Point(33, 147);
            this.SearchCoup.Name = "SearchCoup";
            this.SearchCoup.Size = new System.Drawing.Size(104, 42);
            this.SearchCoup.TabIndex = 13;
            this.SearchCoup.Text = "Search Promotions";
            this.SearchCoup.UseVisualStyleBackColor = false;
            this.SearchCoup.Click += new System.EventHandler(this.SearchCoup_Click);
            // 
            // SearchCust
            // 
            this.SearchCust.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCust.Location = new System.Drawing.Point(33, 99);
            this.SearchCust.Name = "SearchCust";
            this.SearchCust.Size = new System.Drawing.Size(104, 42);
            this.SearchCust.TabIndex = 12;
            this.SearchCust.Text = "Search Customer";
            this.SearchCust.UseVisualStyleBackColor = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeButton.Location = new System.Drawing.Point(33, 51);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(104, 42);
            this.HomeButton.TabIndex = 11;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(164, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reservation Name";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(359, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 75);
            this.button2.TabIndex = 18;
            this.button2.Text = "View Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReservationGUI
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(705, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Reservation);
            this.Controls.Add(this.SearchCoup);
            this.Controls.Add(this.SearchCust);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker3);
            this.Name = "ReservationGUI";
            this.Text = "Create Reservation";
            this.Load += new System.EventHandler(this.ReservationGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.Button SearchCoup;
        private System.Windows.Forms.Button SearchCust;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

namespace JackrabbitPromotionSoftware
{
    partial class GUI
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.SearchCust = new System.Windows.Forms.Button();
            this.SearchCoup = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeButton.Location = new System.Drawing.Point(50, 46);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(104, 42);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchCust
            // 
            this.SearchCust.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCust.Location = new System.Drawing.Point(50, 94);
            this.SearchCust.Name = "SearchCust";
            this.SearchCust.Size = new System.Drawing.Size(104, 42);
            this.SearchCust.TabIndex = 1;
            this.SearchCust.Text = "Search Customer";
            this.SearchCust.UseVisualStyleBackColor = false;
            this.SearchCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchCoup
            // 
            this.SearchCoup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchCoup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCoup.Location = new System.Drawing.Point(50, 142);
            this.SearchCoup.Name = "SearchCoup";
            this.SearchCoup.Size = new System.Drawing.Size(104, 42);
            this.SearchCoup.TabIndex = 2;
            this.SearchCoup.Text = "Search Coupons";
            this.SearchCoup.UseVisualStyleBackColor = false;
            this.SearchCoup.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reservation
            // 
            this.Reservation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Reservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reservation.Location = new System.Drawing.Point(50, 190);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(104, 42);
            this.Reservation.TabIndex = 3;
            this.Reservation.Text = "Reservations";
            this.Reservation.UseVisualStyleBackColor = false;
            this.Reservation.Click += new System.EventHandler(this.button4_Click);
            // 
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Inventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory.Location = new System.Drawing.Point(50, 292);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(104, 42);
            this.Inventory.TabIndex = 4;
            this.Inventory.Text = "Inventory";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jackrabbit Restaurant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(211, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Home Page";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Reservation);
            this.Controls.Add(this.SearchCoup);
            this.Controls.Add(this.SearchCust);
            this.Controls.Add(this.HomeButton);
            this.Name = "GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button SearchCust;
        private System.Windows.Forms.Button SearchCoup;
        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


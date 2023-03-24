namespace Data_Base_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mainHeadLbl = new System.Windows.Forms.Label();
            this.ResBtn = new System.Windows.Forms.Button();
            this.CafeBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.locateBtn = new System.Windows.Forms.Button();
            this.BillBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHeadLbl
            // 
            this.mainHeadLbl.AutoSize = true;
            this.mainHeadLbl.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeadLbl.Location = new System.Drawing.Point(334, 63);
            this.mainHeadLbl.Name = "mainHeadLbl";
            this.mainHeadLbl.Size = new System.Drawing.Size(533, 55);
            this.mainHeadLbl.TabIndex = 0;
            this.mainHeadLbl.Text = "Welcome to Hotel Online";
            // 
            // ResBtn
            // 
            this.ResBtn.BackColor = System.Drawing.Color.Teal;
            this.ResBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResBtn.Location = new System.Drawing.Point(27, 148);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(176, 68);
            this.ResBtn.TabIndex = 1;
            this.ResBtn.Text = "Reserve a Room";
            this.ResBtn.UseVisualStyleBackColor = false;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // CafeBtn
            // 
            this.CafeBtn.BackColor = System.Drawing.Color.Teal;
            this.CafeBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CafeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CafeBtn.Location = new System.Drawing.Point(125, 233);
            this.CafeBtn.Name = "CafeBtn";
            this.CafeBtn.Size = new System.Drawing.Size(176, 68);
            this.CafeBtn.TabIndex = 1;
            this.CafeBtn.Text = "Cafe";
            this.CafeBtn.UseVisualStyleBackColor = false;
            this.CafeBtn.Click += new System.EventHandler(this.CafeBtn_Click);
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.Teal;
            this.ContactBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContactBtn.Location = new System.Drawing.Point(27, 323);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(176, 68);
            this.ContactBtn.TabIndex = 1;
            this.ContactBtn.Text = "Contact Us";
            this.ContactBtn.UseVisualStyleBackColor = false;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // locateBtn
            // 
            this.locateBtn.BackColor = System.Drawing.Color.Teal;
            this.locateBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.locateBtn.Location = new System.Drawing.Point(125, 397);
            this.locateBtn.Name = "locateBtn";
            this.locateBtn.Size = new System.Drawing.Size(176, 68);
            this.locateBtn.TabIndex = 1;
            this.locateBtn.Text = "Locate Us";
            this.locateBtn.UseVisualStyleBackColor = false;
            this.locateBtn.Click += new System.EventHandler(this.locateBtn_Click);
            // 
            // BillBtn
            // 
            this.BillBtn.BackColor = System.Drawing.Color.Teal;
            this.BillBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BillBtn.Location = new System.Drawing.Point(27, 491);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(176, 68);
            this.BillBtn.TabIndex = 1;
            this.BillBtn.Text = "Billing";
            this.BillBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Teal;
            this.ExitBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitBtn.Location = new System.Drawing.Point(1049, 544);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(124, 68);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1185, 624);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BillBtn);
            this.Controls.Add(this.locateBtn);
            this.Controls.Add(this.ContactBtn);
            this.Controls.Add(this.CafeBtn);
            this.Controls.Add(this.ResBtn);
            this.Controls.Add(this.mainHeadLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeadLbl;
        private System.Windows.Forms.Button ResBtn;
        private System.Windows.Forms.Button CafeBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button locateBtn;
        private System.Windows.Forms.Button BillBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}
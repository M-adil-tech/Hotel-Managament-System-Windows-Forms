namespace Data_Base_Project
{
    partial class Cafe
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteUC1 = new Data_Base_Project.UserControls.DeleteUC();
            this.updateItemUC1 = new Data_Base_Project.UserControls.updateItemUC();
            this.placeOrderUC1 = new Data_Base_Project.UserControls.PlaceOrderUC();
            this.addItemUC1 = new Data_Base_Project.UserControls.AddItemUC();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.RemoveBtn);
            this.panel1.Controls.Add(this.OrderBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 635);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(116, 43);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.RemoveBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(33, 484);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(196, 53);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove Items";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.OrderBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(33, 208);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrderBtn.Size = new System.Drawing.Size(196, 53);
            this.OrderBtn.TabIndex = 0;
            this.OrderBtn.Text = "Place Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(33, 299);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(196, 53);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add Items";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(33, 397);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(196, 53);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update Items";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.deleteUC1);
            this.panel2.Controls.Add(this.updateItemUC1);
            this.panel2.Controls.Add(this.placeOrderUC1);
            this.panel2.Controls.Add(this.addItemUC1);
            this.panel2.Location = new System.Drawing.Point(281, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 635);
            this.panel2.TabIndex = 0;
            // 
            // deleteUC1
            // 
            this.deleteUC1.Location = new System.Drawing.Point(0, 0);
            this.deleteUC1.Name = "deleteUC1";
            this.deleteUC1.Size = new System.Drawing.Size(954, 635);
            this.deleteUC1.TabIndex = 3;
            // 
            // updateItemUC1
            // 
            this.updateItemUC1.BackColor = System.Drawing.Color.White;
            this.updateItemUC1.Location = new System.Drawing.Point(0, 0);
            this.updateItemUC1.Name = "updateItemUC1";
            this.updateItemUC1.Size = new System.Drawing.Size(954, 635);
            this.updateItemUC1.TabIndex = 2;
            // 
            // placeOrderUC1
            // 
            this.placeOrderUC1.BackColor = System.Drawing.Color.White;
            this.placeOrderUC1.Location = new System.Drawing.Point(3, 0);
            this.placeOrderUC1.Name = "placeOrderUC1";
            this.placeOrderUC1.Size = new System.Drawing.Size(951, 635);
            this.placeOrderUC1.TabIndex = 1;
            this.placeOrderUC1.Load += new System.EventHandler(this.placeOrderUC1_Load);
            // 
            // addItemUC1
            // 
            this.addItemUC1.BackColor = System.Drawing.Color.DarkMagenta;
            this.addItemUC1.Location = new System.Drawing.Point(3, 0);
            this.addItemUC1.Name = "addItemUC1";
            this.addItemUC1.Size = new System.Drawing.Size(951, 633);
            this.addItemUC1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 1;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 1;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1237, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.Cafe_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button backBtn;
        private UserControls.AddItemUC addItemUC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.PlaceOrderUC placeOrderUC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UserControls.updateItemUC updateItemUC1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UserControls.DeleteUC deleteUC1;
    }
}
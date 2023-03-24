namespace Data_Base_Project.UserControls
{
    partial class AddItemUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cateLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.AddLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // cateLbl
            // 
            this.cateLbl.AutoSize = true;
            this.cateLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateLbl.Location = new System.Drawing.Point(323, 195);
            this.cateLbl.Name = "cateLbl";
            this.cateLbl.Size = new System.Drawing.Size(78, 21);
            this.cateLbl.TabIndex = 0;
            this.cateLbl.Text = "Category";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.Location = new System.Drawing.Point(323, 298);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(91, 21);
            this.itemLbl.TabIndex = 0;
            this.itemLbl.Text = "Item Name";
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLbl.Location = new System.Drawing.Point(361, 88);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(173, 31);
            this.AddLbl.TabIndex = 0;
            this.AddLbl.Text = "Add New Item";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(323, 393);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(48, 21);
            this.PriceLbl.TabIndex = 0;
            this.PriceLbl.Text = "Price";
            // 
            // itemBox
            // 
            this.itemBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBox.ForeColor = System.Drawing.Color.Black;
            this.itemBox.Location = new System.Drawing.Point(327, 322);
            this.itemBox.Multiline = true;
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(263, 36);
            this.itemBox.TabIndex = 1;
            this.itemBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CategoryBox
            // 
            this.CategoryBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.ForeColor = System.Drawing.Color.Black;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Fast Food",
            "Desi",
            "Chinese",
            "Turkish",
            "Soft Drinks",
            "Deserts"});
            this.CategoryBox.Location = new System.Drawing.Point(327, 219);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(263, 29);
            this.CategoryBox.TabIndex = 2;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.ForeColor = System.Drawing.Color.Black;
            this.PriceBox.Location = new System.Drawing.Point(327, 417);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(263, 36);
            this.PriceBox.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.Location = new System.Drawing.Point(372, 490);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(162, 48);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 1;
            this.guna2Elipse1.TargetControl = this;
            // 
            // AddItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.AddLbl);
            this.Controls.Add(this.cateLbl);
            this.Name = "AddItemUC";
            this.Size = new System.Drawing.Size(946, 690);
            this.Load += new System.EventHandler(this.AddItemUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cateLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button AddBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

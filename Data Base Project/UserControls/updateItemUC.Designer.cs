namespace Data_Base_Project.UserControls
{
    partial class updateItemUC
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UpdateLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.UpdateitemBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.UpdatedDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 1;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UpdateLbl
            // 
            this.UpdateLbl.AutoSize = true;
            this.UpdateLbl.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLbl.Location = new System.Drawing.Point(356, 15);
            this.UpdateLbl.Name = "UpdateLbl";
            this.UpdateLbl.Size = new System.Drawing.Size(184, 39);
            this.UpdateLbl.TabIndex = 0;
            this.UpdateLbl.Text = "Update Item";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLbl.Location = new System.Drawing.Point(62, 68);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(106, 23);
            this.itemLbl.TabIndex = 0;
            this.itemLbl.Text = " Item Name";
            // 
            // UpdateitemBox
            // 
            this.UpdateitemBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateitemBox.Location = new System.Drawing.Point(66, 94);
            this.UpdateitemBox.Multiline = true;
            this.UpdateitemBox.Name = "UpdateitemBox";
            this.UpdateitemBox.Size = new System.Drawing.Size(203, 46);
            this.UpdateitemBox.TabIndex = 1;
            this.UpdateitemBox.TextChanged += new System.EventHandler(this.UpdateitemBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(579, 458);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(203, 46);
            this.PriceBox.TabIndex = 4;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(575, 432);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(53, 23);
            this.PriceLbl.TabIndex = 3;
            this.PriceLbl.Text = "Price";
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameBox.Location = new System.Drawing.Point(87, 551);
            this.ItemNameBox.Multiline = true;
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(203, 46);
            this.ItemNameBox.TabIndex = 6;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.Location = new System.Drawing.Point(83, 525);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(101, 23);
            this.itemNameLbl.TabIndex = 5;
            this.itemNameLbl.Text = "Item Name";
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(87, 458);
            this.categoryBox.Multiline = true;
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(203, 46);
            this.categoryBox.TabIndex = 8;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.Location = new System.Drawing.Point(83, 432);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(85, 23);
            this.CategoryLbl.TabIndex = 7;
            this.CategoryLbl.Text = "Category";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(595, 525);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(171, 51);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdatedDataGrid
            // 
            this.UpdatedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdatedDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UpdatedDataGrid.Location = new System.Drawing.Point(199, 181);
            this.UpdatedDataGrid.Name = "UpdatedDataGrid";
            this.UpdatedDataGrid.Size = new System.Drawing.Size(461, 210);
            this.UpdatedDataGrid.TabIndex = 10;
            this.UpdatedDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdatedDataGrid_CellClick);
            this.UpdatedDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdatedDataGrid_CellContentClick);
            // 
            // updateItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UpdatedDataGrid);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.UpdateitemBox);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.UpdateLbl);
            this.Name = "updateItemUC";
            this.Size = new System.Drawing.Size(946, 690);
            this.Load += new System.EventHandler(this.updateItemUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label UpdateLbl;
        private System.Windows.Forms.TextBox UpdateitemBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridView UpdatedDataGrid;
    }
}

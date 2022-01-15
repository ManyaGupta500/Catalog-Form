
namespace Assignment__4
{
    partial class Product
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
            this.gbNewProduct = new System.Windows.Forms.GroupBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewProduct
            // 
            this.gbNewProduct.Controls.Add(this.numPrice);
            this.gbNewProduct.Controls.Add(this.txtName);
            this.gbNewProduct.Controls.Add(this.lblName);
            this.gbNewProduct.Controls.Add(this.lblPrice);
            this.gbNewProduct.Controls.Add(this.txtCategory);
            this.gbNewProduct.Controls.Add(this.lblcategory);
            this.gbNewProduct.Location = new System.Drawing.Point(12, 12);
            this.gbNewProduct.Name = "gbNewProduct";
            this.gbNewProduct.Size = new System.Drawing.Size(298, 202);
            this.gbNewProduct.TabIndex = 0;
            this.gbNewProduct.TabStop = false;
            this.gbNewProduct.Text = "Product";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(72, 80);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 23);
            this.numPrice.TabIndex = 6;
            this.numPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(72, 51);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(151, 23);
            this.txtCategory.TabIndex = 4;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(10, 59);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(55, 15);
            this.lblcategory.TabIndex = 3;
            this.lblcategory.Text = "Category";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(104, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(314, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(104, 321);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(314, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbNewProduct);
            this.Controls.Add(this.btnCreate);
            this.Name = "Product";
            this.Text = "Product";
            this.gbNewProduct.ResumeLayout(false);
            this.gbNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewProduct;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}
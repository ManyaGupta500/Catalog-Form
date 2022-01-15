
namespace Assignment__4
{
    partial class Catalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDataStore = new System.Windows.Forms.GroupBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.chAutosave = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDataStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataStore
            // 
            this.gbDataStore.Controls.Add(this.lblFilePath);
            this.gbDataStore.Controls.Add(this.btnLoad);
            this.gbDataStore.Controls.Add(this.numTimer);
            this.gbDataStore.Controls.Add(this.txtFilename);
            this.gbDataStore.Controls.Add(this.chAutosave);
            this.gbDataStore.Location = new System.Drawing.Point(27, 12);
            this.gbDataStore.Name = "gbDataStore";
            this.gbDataStore.Size = new System.Drawing.Size(343, 100);
            this.gbDataStore.TabIndex = 1;
            this.gbDataStore.TabStop = false;
            this.gbDataStore.Text = "Data Store";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 27);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(52, 15);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(262, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(195, 54);
            this.numTimer.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTimer.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(48, 23);
            this.numTimer.TabIndex = 6;
            this.numTimer.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(80, 24);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(163, 23);
            this.txtFilename.TabIndex = 3;
            this.txtFilename.Text = "Catalog.txt";
            // 
            // chAutosave
            // 
            this.chAutosave.AutoSize = true;
            this.chAutosave.Location = new System.Drawing.Point(80, 58);
            this.chAutosave.Name = "chAutosave";
            this.chAutosave.Size = new System.Drawing.Size(109, 19);
            this.chAutosave.TabIndex = 5;
            this.chAutosave.Text = "Auto save Every";
            this.chAutosave.UseVisualStyleBackColor = true;
            this.chAutosave.CheckedChanged += new System.EventHandler(this.chAutosave_CheckedChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilter.Location = new System.Drawing.Point(591, 142);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 23);
            this.txtFilter.TabIndex = 9;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(541, 150);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(33, 15);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(27, 141);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(104, 23);
            this.btnCreateProduct.TabIndex = 7;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDepartment,
            this.colPrice});
            this.dgvCatalog.Location = new System.Drawing.Point(27, 182);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowTemplate.Height = 25;
            this.dgvCatalog.Size = new System.Drawing.Size(664, 183);
            this.dgvCatalog.TabIndex = 10;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCatalog);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.gbDataStore);
            this.Name = "Catalog";
            this.Text = "Form1";
            this.gbDataStore.ResumeLayout(false);
            this.gbDataStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataStore;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.CheckBox chAutosave;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}


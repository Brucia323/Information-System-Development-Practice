
namespace 用户客户端2._1
{
    partial class 购物车
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supermarketDataSet = new 用户客户端2._1.supermarketDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new 用户客户端2._1.supermarketDataSetTableAdapters.cartTableAdapter();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.telDataGridViewTextBoxColumn,
            this.itemnumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.cstateDataGridViewTextBoxColumn,
            this.jointimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.supermarketDataSet;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemnumberDataGridViewTextBoxColumn
            // 
            this.itemnumberDataGridViewTextBoxColumn.DataPropertyName = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.HeaderText = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemnumberDataGridViewTextBoxColumn.Name = "itemnumberDataGridViewTextBoxColumn";
            this.itemnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // cstateDataGridViewTextBoxColumn
            // 
            this.cstateDataGridViewTextBoxColumn.DataPropertyName = "c_state";
            this.cstateDataGridViewTextBoxColumn.HeaderText = "c_state";
            this.cstateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cstateDataGridViewTextBoxColumn.Name = "cstateDataGridViewTextBoxColumn";
            this.cstateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstateDataGridViewTextBoxColumn.Width = 125;
            // 
            // jointimeDataGridViewTextBoxColumn
            // 
            this.jointimeDataGridViewTextBoxColumn.DataPropertyName = "jointime";
            this.jointimeDataGridViewTextBoxColumn.HeaderText = "jointime";
            this.jointimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jointimeDataGridViewTextBoxColumn.Name = "jointimeDataGridViewTextBoxColumn";
            this.jointimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.jointimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // 购物车
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "购物车";
            this.Text = "购物车";
            this.Load += new System.EventHandler(this.购物车_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private supermarketDataSetTableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
    }
}
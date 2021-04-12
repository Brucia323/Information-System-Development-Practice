
namespace 用户客户端2._2
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
            this.cart1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSet = new 用户客户端2._2.supermarketDataSet();
            this.cart_1TableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.cart_1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cart1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.telDataGridViewTextBoxColumn,
            this.itemnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sell,
            this.cstateDataGridViewTextBoxColumn,
            this.jointimeDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.cart1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cart1BindingSource
            // 
            this.cart1BindingSource.DataMember = "cart_1";
            this.cart1BindingSource.DataSource = this.supermarketDataSet;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cart_1TableAdapter
            // 
            this.cart_1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(713, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "去结算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cart1BindingSource1
            // 
            this.cart1BindingSource1.DataMember = "cart_1";
            this.cart1BindingSource1.DataSource = this.supermarketDataSet;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemnumberDataGridViewTextBoxColumn
            // 
            this.itemnumberDataGridViewTextBoxColumn.DataPropertyName = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.HeaderText = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemnumberDataGridViewTextBoxColumn.Name = "itemnumberDataGridViewTextBoxColumn";
            this.itemnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sell
            // 
            this.sell.DataPropertyName = "sell";
            this.sell.HeaderText = "价格";
            this.sell.MinimumWidth = 6;
            this.sell.Name = "sell";
            this.sell.ReadOnly = true;
            // 
            // cstateDataGridViewTextBoxColumn
            // 
            this.cstateDataGridViewTextBoxColumn.DataPropertyName = "c_state";
            this.cstateDataGridViewTextBoxColumn.FalseValue = "F";
            this.cstateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.cstateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cstateDataGridViewTextBoxColumn.Name = "cstateDataGridViewTextBoxColumn";
            this.cstateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cstateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cstateDataGridViewTextBoxColumn.TrueValue = "T";
            // 
            // jointimeDataGridViewTextBoxColumn
            // 
            this.jointimeDataGridViewTextBoxColumn.DataPropertyName = "jointime";
            this.jointimeDataGridViewTextBoxColumn.HeaderText = "jointime";
            this.jointimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jointimeDataGridViewTextBoxColumn.Name = "jointimeDataGridViewTextBoxColumn";
            this.jointimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.jointimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "-";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "+";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // 购物车
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "购物车";
            this.Text = "购物车";
            this.Load += new System.EventHandler(this.购物车_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource cart1BindingSource;
        private supermarketDataSetTableAdapters.cart_1TableAdapter cart_1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.BindingSource cart1BindingSource1;
    }
}
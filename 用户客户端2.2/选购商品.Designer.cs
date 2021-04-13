
namespace 用户客户端2._2
{
    partial class 选购商品
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSet = new 用户客户端2._2.supermarketDataSet();
            this.sortTableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.sortTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gettimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commodityTableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.commodityTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cart1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cart_1TableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.cart_1TableAdapter();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(713, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "去结算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.sortBindingSource;
            this.comboBox1.DisplayMember = "sort_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "sort_number";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // sortBindingSource
            // 
            this.sortBindingSource.DataMember = "sort";
            this.sortBindingSource.DataSource = this.supermarketDataSet;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortTableAdapter
            // 
            this.sortTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.sellDataGridViewTextBoxColumn,
            this.stocknumberDataGridViewTextBoxColumn,
            this.sortnumberDataGridViewTextBoxColumn,
            this.expirationdateDataGridViewTextBoxColumn,
            this.productionDataGridViewTextBoxColumn,
            this.gettimeDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.commodityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 194);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellDataGridViewTextBoxColumn
            // 
            this.sellDataGridViewTextBoxColumn.DataPropertyName = "sell";
            this.sellDataGridViewTextBoxColumn.HeaderText = "价格";
            this.sellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellDataGridViewTextBoxColumn.Name = "sellDataGridViewTextBoxColumn";
            this.sellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocknumberDataGridViewTextBoxColumn
            // 
            this.stocknumberDataGridViewTextBoxColumn.DataPropertyName = "stocknumber";
            this.stocknumberDataGridViewTextBoxColumn.HeaderText = "stocknumber";
            this.stocknumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stocknumberDataGridViewTextBoxColumn.Name = "stocknumberDataGridViewTextBoxColumn";
            this.stocknumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortnumberDataGridViewTextBoxColumn
            // 
            this.sortnumberDataGridViewTextBoxColumn.DataPropertyName = "sort_number";
            this.sortnumberDataGridViewTextBoxColumn.HeaderText = "sort_number";
            this.sortnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sortnumberDataGridViewTextBoxColumn.Name = "sortnumberDataGridViewTextBoxColumn";
            this.sortnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.sortnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // expirationdateDataGridViewTextBoxColumn
            // 
            this.expirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.HeaderText = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationdateDataGridViewTextBoxColumn.Name = "expirationdateDataGridViewTextBoxColumn";
            this.expirationdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // productionDataGridViewTextBoxColumn
            // 
            this.productionDataGridViewTextBoxColumn.DataPropertyName = "production";
            this.productionDataGridViewTextBoxColumn.HeaderText = "production";
            this.productionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionDataGridViewTextBoxColumn.Name = "productionDataGridViewTextBoxColumn";
            this.productionDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDataGridViewTextBoxColumn.Visible = false;
            // 
            // gettimeDataGridViewTextBoxColumn
            // 
            this.gettimeDataGridViewTextBoxColumn.DataPropertyName = "gettime";
            this.gettimeDataGridViewTextBoxColumn.HeaderText = "gettime";
            this.gettimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gettimeDataGridViewTextBoxColumn.Name = "gettimeDataGridViewTextBoxColumn";
            this.gettimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gettimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "添加到购物车";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // commodityBindingSource
            // 
            this.commodityBindingSource.DataMember = "commodity";
            this.commodityBindingSource.DataSource = this.supermarketDataSet;
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.telDataGridViewTextBoxColumn,
            this.itemnumberDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.sellDataGridViewTextBoxColumn1,
            this.cstateDataGridViewTextBoxColumn,
            this.jointimeDataGridViewTextBoxColumn,
            this.Column2,
            this.Column3});
            this.dataGridView2.DataSource = this.cart1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 241);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(776, 166);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cart1BindingSource
            // 
            this.cart1BindingSource.DataMember = "cart_1";
            this.cart1BindingSource.DataSource = this.supermarketDataSet;
            // 
            // cart_1TableAdapter
            // 
            this.cart_1TableAdapter.ClearBeforeFill = true;
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
            // itemnumberDataGridViewTextBoxColumn1
            // 
            this.itemnumberDataGridViewTextBoxColumn1.DataPropertyName = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn1.HeaderText = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.itemnumberDataGridViewTextBoxColumn1.Name = "itemnumberDataGridViewTextBoxColumn1";
            this.itemnumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemnumberDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellDataGridViewTextBoxColumn1
            // 
            this.sellDataGridViewTextBoxColumn1.DataPropertyName = "sell";
            this.sellDataGridViewTextBoxColumn1.HeaderText = "价格";
            this.sellDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sellDataGridViewTextBoxColumn1.Name = "sellDataGridViewTextBoxColumn1";
            this.sellDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // Column2
            // 
            this.Column2.HeaderText = "操作";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "-";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "+";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // 选购商品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "选购商品";
            this.Text = "选购商品";
            this.Load += new System.EventHandler(this.选购商品_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource sortBindingSource;
        private supermarketDataSetTableAdapters.sortTableAdapter sortTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource commodityBindingSource;
        private supermarketDataSetTableAdapters.commodityTableAdapter commodityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gettimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cart1BindingSource;
        private supermarketDataSetTableAdapters.cart_1TableAdapter cart_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}


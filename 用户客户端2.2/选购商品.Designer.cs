
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
            this.nowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityTableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.commodityTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jointimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.production = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cart_1TableAdapter = new 用户客户端2._2.supermarketDataSetTableAdapters.cart_1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cartTableAdapter1 = new 用户客户端2._2.supermarketDataSetTableAdapters.cartTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
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
            this.comboBox1.Location = new System.Drawing.Point(327, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(461, 23);
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
            this.nowPrice,
            this.sortnumberDataGridViewTextBoxColumn,
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
            // nowPrice
            // 
            this.nowPrice.DataPropertyName = "nowPrice";
            this.nowPrice.HeaderText = "现价";
            this.nowPrice.MinimumWidth = 6;
            this.nowPrice.Name = "nowPrice";
            this.nowPrice.ReadOnly = true;
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
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Visible = false;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // commodityTableAdapter
            // 
            this.commodityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
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
            this.dataGridViewTextBoxColumn1,
            this.cstateDataGridViewTextBoxColumn,
            this.jointimeDataGridViewTextBoxColumn,
            this.Column2,
            this.Column3,
            this.production});
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nowPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "价格";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // production
            // 
            this.production.DataPropertyName = "production";
            this.production.HeaderText = "production";
            this.production.MinimumWidth = 6;
            this.production.Name = "production";
            this.production.ReadOnly = true;
            this.production.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "搜索";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "个人中心";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 选购商品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cart1BindingSource;
        private supermarketDataSetTableAdapters.cart_1TableAdapter cart_1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private supermarketDataSetTableAdapters.cartTableAdapter cartTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gettimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cstateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn production;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button button2;
    }
}


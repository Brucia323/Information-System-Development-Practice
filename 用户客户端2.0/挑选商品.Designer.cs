﻿
namespace 用户客户端给2._0
{
    partial class 挑选商品
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
            this.supermarketDataSet1 = new 用户客户端给2._0.supermarketDataSet1();
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
            this.sortnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.selectionOfGoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSet = new 用户客户端给2._0.supermarketDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.selection_of_goodsTableAdapter = new 用户客户端给2._0.supermarketDataSetTableAdapters.Selection_of_goodsTableAdapter();
            this.sortTableAdapter = new 用户客户端给2._0.supermarketDataSet1TableAdapters.sortTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionOfGoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "个人信息";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.sortBindingSource;
            this.comboBox1.DisplayMember = "sort_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(693, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // sortBindingSource
            // 
            this.sortBindingSource.DataMember = "sort";
            this.sortBindingSource.DataSource = this.supermarketDataSet1;
            // 
            // supermarketDataSet1
            // 
            this.supermarketDataSet1.DataSetName = "supermarketDataSet1";
            this.supermarketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.sortnameDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.selectionOfGoodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 364);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemnumberDataGridViewTextBoxColumn
            // 
            this.itemnumberDataGridViewTextBoxColumn.DataPropertyName = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.HeaderText = "itemnumber";
            this.itemnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemnumberDataGridViewTextBoxColumn.Name = "itemnumberDataGridViewTextBoxColumn";
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
            this.stocknumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortnumberDataGridViewTextBoxColumn
            // 
            this.sortnumberDataGridViewTextBoxColumn.DataPropertyName = "sort_number";
            this.sortnumberDataGridViewTextBoxColumn.HeaderText = "sort_number";
            this.sortnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sortnumberDataGridViewTextBoxColumn.Name = "sortnumberDataGridViewTextBoxColumn";
            this.sortnumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // expirationdateDataGridViewTextBoxColumn
            // 
            this.expirationdateDataGridViewTextBoxColumn.DataPropertyName = "expiration_date";
            this.expirationdateDataGridViewTextBoxColumn.HeaderText = "保质期";
            this.expirationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationdateDataGridViewTextBoxColumn.Name = "expirationdateDataGridViewTextBoxColumn";
            this.expirationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDataGridViewTextBoxColumn
            // 
            this.productionDataGridViewTextBoxColumn.DataPropertyName = "production";
            this.productionDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionDataGridViewTextBoxColumn.Name = "productionDataGridViewTextBoxColumn";
            this.productionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gettimeDataGridViewTextBoxColumn
            // 
            this.gettimeDataGridViewTextBoxColumn.DataPropertyName = "gettime";
            this.gettimeDataGridViewTextBoxColumn.HeaderText = "gettime";
            this.gettimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gettimeDataGridViewTextBoxColumn.Name = "gettimeDataGridViewTextBoxColumn";
            this.gettimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sortnameDataGridViewTextBoxColumn
            // 
            this.sortnameDataGridViewTextBoxColumn.DataPropertyName = "sort_name";
            this.sortnameDataGridViewTextBoxColumn.HeaderText = "sort_name";
            this.sortnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sortnameDataGridViewTextBoxColumn.Name = "sortnameDataGridViewTextBoxColumn";
            this.sortnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "添加到购物车";
            this.Column1.ToolTipText = "添加到购物车";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // selectionOfGoodsBindingSource
            // 
            this.selectionOfGoodsBindingSource.DataMember = "Selection of goods";
            this.selectionOfGoodsBindingSource.DataSource = this.supermarketDataSet;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(713, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "购物车";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selection_of_goodsTableAdapter
            // 
            this.selection_of_goodsTableAdapter.ClearBeforeFill = true;
            // 
            // sortTableAdapter
            // 
            this.sortTableAdapter.ClearBeforeFill = true;
            // 
            // 挑选商品
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "挑选商品";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.挑选商品_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionOfGoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource selectionOfGoodsBindingSource;
        private supermarketDataSetTableAdapters.Selection_of_goodsTableAdapter selection_of_goodsTableAdapter;
        private supermarketDataSet1 supermarketDataSet1;
        private System.Windows.Forms.BindingSource sortBindingSource;
        private supermarketDataSet1TableAdapters.sortTableAdapter sortTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gettimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}


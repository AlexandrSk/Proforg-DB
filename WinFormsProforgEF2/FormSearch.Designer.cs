namespace WinFormsProforgEF2
{
    partial class FormSearch
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
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.taborderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            this.Search_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstudentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabstudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taborderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabstudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSearch
            // 
            this.DGVSearch.AllowUserToAddRows = false;
            this.DGVSearch.AllowUserToDeleteRows = false;
            this.DGVSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVSearch.AutoGenerateColumns = false;
            this.DGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Search_NAME,
            this.Search_TYPE,
            this.orderIDDataGridViewTextBoxColumn,
            this.orderstudentIDDataGridViewTextBoxColumn,
            this.orderticketIDDataGridViewTextBoxColumn,
            this.ordercountDataGridViewTextBoxColumn,
            this.tabstudentsDataGridViewTextBoxColumn,
            this.tabticketsDataGridViewTextBoxColumn});
            this.DGVSearch.DataSource = this.taborderBindingSource;
            this.DGVSearch.Location = new System.Drawing.Point(1, 32);
            this.DGVSearch.Name = "DGVSearch";
            this.DGVSearch.ReadOnly = true;
            this.DGVSearch.Size = new System.Drawing.Size(797, 419);
            this.DGVSearch.TabIndex = 0;
            // 
            // taborderBindingSource
            // 
            this.taborderBindingSource.DataSource = typeof(ProforgDataEF.tab_order);
            // 
            // tabstudentsBindingSource
            // 
            this.tabstudentsBindingSource.DataSource = typeof(ProforgDataEF.tab_students);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Яку групу виділити?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.Location = new System.Drawing.Point(276, 4);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(216, 23);
            this.btnSearchGroup.TabIndex = 3;
            this.btnSearchGroup.Text = "Знайти";
            this.btnSearchGroup.UseVisualStyleBackColor = true;
            this.btnSearchGroup.Click += new System.EventHandler(this.btnSearchGroup_Click);
            // 
            // Search_NAME
            // 
            this.Search_NAME.DataPropertyName = "order_student_ID";
            this.Search_NAME.HeaderText = "ПІБ";
            this.Search_NAME.Name = "Search_NAME";
            // 
            // Search_TYPE
            // 
            this.Search_TYPE.DataPropertyName = "order_ticket_ID";
            this.Search_TYPE.HeaderText = "Тип";
            this.Search_TYPE.Name = "Search_TYPE";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderstudentIDDataGridViewTextBoxColumn
            // 
            this.orderstudentIDDataGridViewTextBoxColumn.DataPropertyName = "order_student_ID";
            this.orderstudentIDDataGridViewTextBoxColumn.HeaderText = "order_student_ID";
            this.orderstudentIDDataGridViewTextBoxColumn.Name = "orderstudentIDDataGridViewTextBoxColumn";
            this.orderstudentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderticketIDDataGridViewTextBoxColumn
            // 
            this.orderticketIDDataGridViewTextBoxColumn.DataPropertyName = "order_ticket_ID";
            this.orderticketIDDataGridViewTextBoxColumn.HeaderText = "order_ticket_ID";
            this.orderticketIDDataGridViewTextBoxColumn.Name = "orderticketIDDataGridViewTextBoxColumn";
            this.orderticketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ordercountDataGridViewTextBoxColumn
            // 
            this.ordercountDataGridViewTextBoxColumn.DataPropertyName = "order_count";
            this.ordercountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.ordercountDataGridViewTextBoxColumn.Name = "ordercountDataGridViewTextBoxColumn";
            // 
            // tabstudentsDataGridViewTextBoxColumn
            // 
            this.tabstudentsDataGridViewTextBoxColumn.DataPropertyName = "tab_students";
            this.tabstudentsDataGridViewTextBoxColumn.HeaderText = "tab_students";
            this.tabstudentsDataGridViewTextBoxColumn.Name = "tabstudentsDataGridViewTextBoxColumn";
            this.tabstudentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabticketsDataGridViewTextBoxColumn
            // 
            this.tabticketsDataGridViewTextBoxColumn.DataPropertyName = "tab_tickets";
            this.tabticketsDataGridViewTextBoxColumn.HeaderText = "tab_tickets";
            this.tabticketsDataGridViewTextBoxColumn.Name = "tabticketsDataGridViewTextBoxColumn";
            this.tabticketsDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchGroup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVSearch);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taborderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabstudentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearchGroup;
        private System.Windows.Forms.BindingSource taborderBindingSource;
        private System.Windows.Forms.BindingSource tabstudentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstudentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabstudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabticketsDataGridViewTextBoxColumn;
    }
}
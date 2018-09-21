namespace WinFormsProforgEF2
{
    partial class FrmProforg
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCntrlProforg = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.btnDelStud = new System.Windows.Forms.Button();
            this.btnSaveStud = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_NAME = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taborderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabstudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.btnDelTick = new System.Windows.Forms.Button();
            this.btnSaveTick = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tickettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_NAME = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tickettypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketpriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickettypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taborderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabtickets1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabtickets2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.btnGroupStud = new System.Windows.Forms.Button();
            this.btnDelOrd = new System.Windows.Forms.Button();
            this.btnSaveOrd = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_NAME = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.order_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderstudentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabstudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taborderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCntrlProforg.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabstudentsBindingSource)).BeginInit();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickettypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabticketsBindingSource)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taborderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCntrlProforg
            // 
            this.tabCntrlProforg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCntrlProforg.Controls.Add(this.tabStudents);
            this.tabCntrlProforg.Controls.Add(this.tabTickets);
            this.tabCntrlProforg.Controls.Add(this.tabOrder);
            this.tabCntrlProforg.Location = new System.Drawing.Point(2, 7);
            this.tabCntrlProforg.Name = "tabCntrlProforg";
            this.tabCntrlProforg.SelectedIndex = 0;
            this.tabCntrlProforg.Size = new System.Drawing.Size(796, 443);
            this.tabCntrlProforg.TabIndex = 0;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.btnDelStud);
            this.tabStudents.Controls.Add(this.btnSaveStud);
            this.tabStudents.Controls.Add(this.dataGridView1);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(788, 417);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Студенты";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // btnDelStud
            // 
            this.btnDelStud.Location = new System.Drawing.Point(85, 2);
            this.btnDelStud.Name = "btnDelStud";
            this.btnDelStud.Size = new System.Drawing.Size(75, 23);
            this.btnDelStud.TabIndex = 2;
            this.btnDelStud.Text = "Видалити";
            this.btnDelStud.UseVisualStyleBackColor = true;
            this.btnDelStud.Click += new System.EventHandler(this.btnDelStud_Click);
            // 
            // btnSaveStud
            // 
            this.btnSaveStud.Location = new System.Drawing.Point(3, 3);
            this.btnSaveStud.Name = "btnSaveStud";
            this.btnSaveStud.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStud.TabIndex = 1;
            this.btnSaveStud.Text = "Save";
            this.btnSaveStud.UseVisualStyleBackColor = true;
            this.btnSaveStud.Click += new System.EventHandler(this.btnSaveStud_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentgroupIDDataGridViewTextBoxColumn,
            this.groupsDataGridViewTextBoxColumn,
            this.Group_NAME,
            this.taborderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabstudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // studentgroupIDDataGridViewTextBoxColumn
            // 
            this.studentgroupIDDataGridViewTextBoxColumn.DataPropertyName = "student_group_ID";
            this.studentgroupIDDataGridViewTextBoxColumn.HeaderText = "student_group_ID";
            this.studentgroupIDDataGridViewTextBoxColumn.Name = "studentgroupIDDataGridViewTextBoxColumn";
            this.studentgroupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupsDataGridViewTextBoxColumn
            // 
            this.groupsDataGridViewTextBoxColumn.DataPropertyName = "groups";
            this.groupsDataGridViewTextBoxColumn.HeaderText = "groups";
            this.groupsDataGridViewTextBoxColumn.Name = "groupsDataGridViewTextBoxColumn";
            this.groupsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Group_NAME
            // 
            this.Group_NAME.DataPropertyName = "student_group_ID";
            this.Group_NAME.DataSource = this.groupsBindingSource;
            this.Group_NAME.DisplayMember = "group_name";
            this.Group_NAME.HeaderText = "Група";
            this.Group_NAME.Name = "Group_NAME";
            this.Group_NAME.ValueMember = "group_ID";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(ProforgDataEF.groups);
            // 
            // taborderDataGridViewTextBoxColumn
            // 
            this.taborderDataGridViewTextBoxColumn.DataPropertyName = "tab_order";
            this.taborderDataGridViewTextBoxColumn.HeaderText = "tab_order";
            this.taborderDataGridViewTextBoxColumn.Name = "taborderDataGridViewTextBoxColumn";
            this.taborderDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabstudentsBindingSource
            // 
            this.tabstudentsBindingSource.DataSource = typeof(ProforgDataEF.tab_students);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.btnDelTick);
            this.tabTickets.Controls.Add(this.btnSaveTick);
            this.tabTickets.Controls.Add(this.dataGridView2);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(788, 417);
            this.tabTickets.TabIndex = 1;
            this.tabTickets.Text = "Квитки";
            // 
            // btnDelTick
            // 
            this.btnDelTick.Location = new System.Drawing.Point(84, 6);
            this.btnDelTick.Name = "btnDelTick";
            this.btnDelTick.Size = new System.Drawing.Size(75, 23);
            this.btnDelTick.TabIndex = 3;
            this.btnDelTick.Text = "Видалити";
            this.btnDelTick.UseVisualStyleBackColor = true;
            this.btnDelTick.Click += new System.EventHandler(this.btnDelTick_Click);
            // 
            // btnSaveTick
            // 
            this.btnSaveTick.Location = new System.Drawing.Point(3, 6);
            this.btnSaveTick.Name = "btnSaveTick";
            this.btnSaveTick.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTick.TabIndex = 2;
            this.btnSaveTick.Text = "Save";
            this.btnSaveTick.UseVisualStyleBackColor = true;
            this.btnSaveTick.Click += new System.EventHandler(this.btnSaveTick_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickettypeDataGridViewTextBoxColumn,
            this.Type_NAME,
            this.ticketpriseDataGridViewTextBoxColumn,
            this.ticketcountDataGridViewTextBoxColumn,
            this.ticketIDDataGridViewTextBoxColumn,
            this.tickettypeIDDataGridViewTextBoxColumn,
            this.taborderDataGridViewTextBoxColumn1,
            this.tabtickets1DataGridViewTextBoxColumn,
            this.tabtickets2DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabticketsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(789, 386);
            this.dataGridView2.TabIndex = 1;
            // 
            // tickettypeDataGridViewTextBoxColumn
            // 
            this.tickettypeDataGridViewTextBoxColumn.DataPropertyName = "ticket_type";
            this.tickettypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.tickettypeDataGridViewTextBoxColumn.Name = "tickettypeDataGridViewTextBoxColumn";
            this.tickettypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Type_NAME
            // 
            this.Type_NAME.DataPropertyName = "ticket_type_ID";
            this.Type_NAME.DataSource = this.tickettypeBindingSource;
            this.Type_NAME.DisplayMember = "ticket_name";
            this.Type_NAME.HeaderText = "Тип";
            this.Type_NAME.Name = "Type_NAME";
            this.Type_NAME.ValueMember = "ticket_ID";
            // 
            // tickettypeBindingSource
            // 
            this.tickettypeBindingSource.DataSource = typeof(ProforgDataEF.ticket_type);
            // 
            // ticketpriseDataGridViewTextBoxColumn
            // 
            this.ticketpriseDataGridViewTextBoxColumn.DataPropertyName = "ticket_prise";
            this.ticketpriseDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.ticketpriseDataGridViewTextBoxColumn.Name = "ticketpriseDataGridViewTextBoxColumn";
            // 
            // ticketcountDataGridViewTextBoxColumn
            // 
            this.ticketcountDataGridViewTextBoxColumn.DataPropertyName = "ticket_count";
            this.ticketcountDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.ticketcountDataGridViewTextBoxColumn.Name = "ticketcountDataGridViewTextBoxColumn";
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tickettypeIDDataGridViewTextBoxColumn
            // 
            this.tickettypeIDDataGridViewTextBoxColumn.DataPropertyName = "ticket_type_ID";
            this.tickettypeIDDataGridViewTextBoxColumn.HeaderText = "ticket_type_ID";
            this.tickettypeIDDataGridViewTextBoxColumn.Name = "tickettypeIDDataGridViewTextBoxColumn";
            this.tickettypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // taborderDataGridViewTextBoxColumn1
            // 
            this.taborderDataGridViewTextBoxColumn1.DataPropertyName = "tab_order";
            this.taborderDataGridViewTextBoxColumn1.HeaderText = "tab_order";
            this.taborderDataGridViewTextBoxColumn1.Name = "taborderDataGridViewTextBoxColumn1";
            this.taborderDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tabtickets1DataGridViewTextBoxColumn
            // 
            this.tabtickets1DataGridViewTextBoxColumn.DataPropertyName = "tab_tickets1";
            this.tabtickets1DataGridViewTextBoxColumn.HeaderText = "tab_tickets1";
            this.tabtickets1DataGridViewTextBoxColumn.Name = "tabtickets1DataGridViewTextBoxColumn";
            this.tabtickets1DataGridViewTextBoxColumn.Visible = false;
            // 
            // tabtickets2DataGridViewTextBoxColumn
            // 
            this.tabtickets2DataGridViewTextBoxColumn.DataPropertyName = "tab_tickets2";
            this.tabtickets2DataGridViewTextBoxColumn.HeaderText = "tab_tickets2";
            this.tabtickets2DataGridViewTextBoxColumn.Name = "tabtickets2DataGridViewTextBoxColumn";
            this.tabtickets2DataGridViewTextBoxColumn.Visible = false;
            // 
            // tabticketsBindingSource
            // 
            this.tabticketsBindingSource.DataSource = typeof(ProforgDataEF.tab_tickets);
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.btnGroupStud);
            this.tabOrder.Controls.Add(this.btnDelOrd);
            this.tabOrder.Controls.Add(this.btnSaveOrd);
            this.tabOrder.Controls.Add(this.dataGridView3);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(788, 417);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Замовлення";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // btnGroupStud
            // 
            this.btnGroupStud.Location = new System.Drawing.Point(637, 3);
            this.btnGroupStud.Name = "btnGroupStud";
            this.btnGroupStud.Size = new System.Drawing.Size(145, 23);
            this.btnGroupStud.TabIndex = 4;
            this.btnGroupStud.Text = "Студенти групи";
            this.btnGroupStud.UseVisualStyleBackColor = true;
            this.btnGroupStud.Click += new System.EventHandler(this.btnGroupStud_Click);
            // 
            // btnDelOrd
            // 
            this.btnDelOrd.Location = new System.Drawing.Point(84, 3);
            this.btnDelOrd.Name = "btnDelOrd";
            this.btnDelOrd.Size = new System.Drawing.Size(75, 23);
            this.btnDelOrd.TabIndex = 3;
            this.btnDelOrd.Text = "Видалити";
            this.btnDelOrd.UseVisualStyleBackColor = true;
            this.btnDelOrd.Click += new System.EventHandler(this.btnDelOrd_Click);
            // 
            // btnSaveOrd
            // 
            this.btnSaveOrd.Location = new System.Drawing.Point(3, 3);
            this.btnSaveOrd.Name = "btnSaveOrd";
            this.btnSaveOrd.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrd.TabIndex = 2;
            this.btnSaveOrd.Text = "Save";
            this.btnSaveOrd.UseVisualStyleBackColor = true;
            this.btnSaveOrd.Click += new System.EventHandler(this.btnSaveOrd_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.Order_NAME,
            this.order_TYPE,
            this.orderstudentIDDataGridViewTextBoxColumn,
            this.orderticketIDDataGridViewTextBoxColumn,
            this.ordercountDataGridViewTextBoxColumn,
            this.tabstudentsDataGridViewTextBoxColumn,
            this.tabticketsDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.taborderBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 29);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(789, 387);
            this.dataGridView3.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Order_NAME
            // 
            this.Order_NAME.DataPropertyName = "order_student_ID";
            this.Order_NAME.DataSource = this.tabstudentsBindingSource;
            this.Order_NAME.DisplayMember = "student_name";
            this.Order_NAME.HeaderText = "ПІБ";
            this.Order_NAME.Name = "Order_NAME";
            this.Order_NAME.ValueMember = "student_ID";
            // 
            // order_TYPE
            // 
            this.order_TYPE.DataPropertyName = "order_ticket_ID";
            this.order_TYPE.DataSource = this.tickettypeBindingSource;
            this.order_TYPE.DisplayMember = "ticket_name";
            this.order_TYPE.HeaderText = "Тип";
            this.order_TYPE.Name = "order_TYPE";
            this.order_TYPE.ValueMember = "ticket_ID";
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
            this.ordercountDataGridViewTextBoxColumn.HeaderText = "Кількість квитків";
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
            // taborderBindingSource
            // 
            this.taborderBindingSource.DataSource = typeof(ProforgDataEF.tab_order);
            // 
            // FrmProforg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCntrlProforg);
            this.Name = "FrmProforg";
            this.Text = "Proforg";
            this.tabCntrlProforg.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabstudentsBindingSource)).EndInit();
            this.tabTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickettypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabticketsBindingSource)).EndInit();
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taborderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlProforg;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.Button btnSaveStud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Button btnSaveTick;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Button btnSaveOrd;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Group_NAME;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn taborderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabstudentsBindingSource;
        private System.Windows.Forms.BindingSource tabticketsBindingSource;
        private System.Windows.Forms.BindingSource taborderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type_NAME;
        private System.Windows.Forms.BindingSource tickettypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketpriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taborderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabtickets1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabtickets2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Order_NAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn order_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstudentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabstudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelStud;
        private System.Windows.Forms.Button btnDelTick;
        private System.Windows.Forms.Button btnDelOrd;
        private System.Windows.Forms.Button btnGroupStud;
    }
}


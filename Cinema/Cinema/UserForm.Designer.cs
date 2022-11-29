namespace Cinema
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rcDeleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.kinoDataSet = new Cinema.kinoDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Cinema.kinoDataSetTableAdapters.ФильмыTableAdapter();
            this.filmsSessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsTableAdapter = new Cinema.kinoDataSetTableAdapters.СеансыTableAdapter();
            this.mainPanel = new System.Windows.Forms.SplitContainer();
            this.ordersListLBL = new System.Windows.Forms.Label();
            this.ordersList = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPanel = new System.Windows.Forms.SplitContainer();
            this.addFilmLBL = new System.Windows.Forms.Label();
            this.filmsList = new System.Windows.Forms.DataGridView();
            this.кодфильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsList = new System.Windows.Forms.DataGridView();
            this.кодсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодфильмаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSessionLBL = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.addOrderBTN = new System.Windows.Forms.Button();
            this.просмотрСеансовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.rcMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.Panel1.SuspendLayout();
            this.mainPanel.Panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPanel)).BeginInit();
            this.addPanel.Panel1.SuspendLayout();
            this.addPanel.Panel2.SuspendLayout();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.просмотрСеансовToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedBTN,
            this.toolStripMenuItem1,
            this.exitBTN});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // deleteSelectedBTN
            // 
            this.deleteSelectedBTN.Name = "deleteSelectedBTN";
            this.deleteSelectedBTN.Size = new System.Drawing.Size(217, 22);
            this.deleteSelectedBTN.Text = "Удалить выбранный заказ";
            this.deleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
            // 
            // exitBTN
            // 
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(217, 22);
            this.exitBTN.Text = "Выход";
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rcDeleteSelectedBTN});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(218, 26);
            // 
            // rcDeleteSelectedBTN
            // 
            this.rcDeleteSelectedBTN.Name = "rcDeleteSelectedBTN";
            this.rcDeleteSelectedBTN.Size = new System.Drawing.Size(217, 22);
            this.rcDeleteSelectedBTN.Text = "Удалить выбранный заказ";
            this.rcDeleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Фильмы";
            this.filmsBindingSource.DataSource = this.kinoDataSet;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // filmsSessionsBindingSource
            // 
            this.filmsSessionsBindingSource.DataMember = "ФильмыСеансы";
            this.filmsSessionsBindingSource.DataSource = this.filmsBindingSource;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            // 
            // mainPanel.Panel1
            // 
            this.mainPanel.Panel1.Controls.Add(this.ordersListLBL);
            this.mainPanel.Panel1.Controls.Add(this.ordersList);
            // 
            // mainPanel.Panel2
            // 
            this.mainPanel.Panel2.Controls.Add(this.addPanel);
            this.mainPanel.Panel2.Controls.Add(this.actionPanel);
            this.mainPanel.Size = new System.Drawing.Size(1000, 563);
            this.mainPanel.SplitterDistance = 500;
            this.mainPanel.TabIndex = 1;
            // 
            // ordersListLBL
            // 
            this.ordersListLBL.AutoSize = true;
            this.ordersListLBL.Location = new System.Drawing.Point(3, 0);
            this.ordersListLBL.Name = "ordersListLBL";
            this.ordersListLBL.Size = new System.Drawing.Size(119, 13);
            this.ordersListLBL.TabIndex = 9;
            this.ordersListLBL.Text = "Ваши заказы билетов";
            // 
            // ordersList
            // 
            this.ordersList.AllowUserToAddRows = false;
            this.ordersList.AllowUserToDeleteRows = false;
            this.ordersList.AllowUserToResizeColumns = false;
            this.ordersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ordersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.orderDate,
            this.orderType,
            this.orderCost,
            this.orderFilm});
            this.ordersList.ContextMenuStrip = this.rcMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersList.DefaultCellStyle = dataGridViewCellStyle4;
            this.ordersList.GridColor = System.Drawing.SystemColors.Window;
            this.ordersList.Location = new System.Drawing.Point(3, 16);
            this.ordersList.MultiSelect = false;
            this.ordersList.Name = "ordersList";
            this.ordersList.ReadOnly = true;
            this.ordersList.RowHeadersVisible = false;
            this.ordersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ordersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersList.Size = new System.Drawing.Size(494, 544);
            this.ordersList.TabIndex = 8;
            // 
            // orderID
            // 
            this.orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderID.HeaderText = "Код заказа";
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderID.Width = 83;
            // 
            // orderDate
            // 
            this.orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderDate.HeaderText = "Дата";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderDate.Width = 58;
            // 
            // orderType
            // 
            this.orderType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderType.HeaderText = "Вид";
            this.orderType.Name = "orderType";
            this.orderType.ReadOnly = true;
            this.orderType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderType.Width = 51;
            // 
            // orderCost
            // 
            this.orderCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderCost.HeaderText = "Стоимость";
            this.orderCost.Name = "orderCost";
            this.orderCost.ReadOnly = true;
            this.orderCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.orderCost.Width = 87;
            // 
            // orderFilm
            // 
            this.orderFilm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderFilm.HeaderText = "Название фильма";
            this.orderFilm.Name = "orderFilm";
            this.orderFilm.ReadOnly = true;
            this.orderFilm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // addPanel
            // 
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // addPanel.Panel1
            // 
            this.addPanel.Panel1.Controls.Add(this.addFilmLBL);
            this.addPanel.Panel1.Controls.Add(this.filmsList);
            // 
            // addPanel.Panel2
            // 
            this.addPanel.Panel2.Controls.Add(this.sessionsList);
            this.addPanel.Panel2.Controls.Add(this.addSessionLBL);
            this.addPanel.Size = new System.Drawing.Size(496, 534);
            this.addPanel.SplitterDistance = 267;
            this.addPanel.TabIndex = 13;
            // 
            // addFilmLBL
            // 
            this.addFilmLBL.AutoSize = true;
            this.addFilmLBL.Location = new System.Drawing.Point(3, 0);
            this.addFilmLBL.Name = "addFilmLBL";
            this.addFilmLBL.Size = new System.Drawing.Size(263, 13);
            this.addFilmLBL.TabIndex = 13;
            this.addFilmLBL.Text = "Для добавления заказа сначала выберите фильм";
            // 
            // filmsList
            // 
            this.filmsList.AllowUserToAddRows = false;
            this.filmsList.AllowUserToDeleteRows = false;
            this.filmsList.AllowUserToResizeColumns = false;
            this.filmsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmsList.AutoGenerateColumns = false;
            this.filmsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.filmsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.filmsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.filmsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодфильмаDataGridViewTextBoxColumn,
            this.названиефильмаDataGridViewTextBoxColumn,
            this.продолжительностьDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.filmsList.DataSource = this.filmsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filmsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.filmsList.GridColor = System.Drawing.SystemColors.Window;
            this.filmsList.Location = new System.Drawing.Point(3, 16);
            this.filmsList.MultiSelect = false;
            this.filmsList.Name = "filmsList";
            this.filmsList.ReadOnly = true;
            this.filmsList.RowHeadersVisible = false;
            this.filmsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.filmsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmsList.Size = new System.Drawing.Size(490, 241);
            this.filmsList.TabIndex = 12;
            // 
            // кодфильмаDataGridViewTextBoxColumn
            // 
            this.кодфильмаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.кодфильмаDataGridViewTextBoxColumn.DataPropertyName = "Код_фильма";
            this.кодфильмаDataGridViewTextBoxColumn.HeaderText = "№";
            this.кодфильмаDataGridViewTextBoxColumn.Name = "кодфильмаDataGridViewTextBoxColumn";
            this.кодфильмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодфильмаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодфильмаDataGridViewTextBoxColumn.Visible = false;
            // 
            // названиефильмаDataGridViewTextBoxColumn
            // 
            this.названиефильмаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.названиефильмаDataGridViewTextBoxColumn.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.названиефильмаDataGridViewTextBoxColumn.Name = "названиефильмаDataGridViewTextBoxColumn";
            this.названиефильмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.названиефильмаDataGridViewTextBoxColumn.Width = 114;
            // 
            // продолжительностьDataGridViewTextBoxColumn
            // 
            this.продолжительностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.продолжительностьDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.продолжительностьDataGridViewTextBoxColumn.Name = "продолжительностьDataGridViewTextBoxColumn";
            this.продолжительностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.продолжительностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.продолжительностьDataGridViewTextBoxColumn.Width = 105;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.жанрDataGridViewTextBoxColumn.Width = 61;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sessionsList
            // 
            this.sessionsList.AllowUserToAddRows = false;
            this.sessionsList.AllowUserToDeleteRows = false;
            this.sessionsList.AllowUserToResizeColumns = false;
            this.sessionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionsList.AutoGenerateColumns = false;
            this.sessionsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sessionsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sessionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sessionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсеансаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.кодфильмаDataGridViewTextBoxColumn1,
            this.видсеансаDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.sessionsList.DataSource = this.filmsSessionsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.sessionsList.GridColor = System.Drawing.SystemColors.Window;
            this.sessionsList.Location = new System.Drawing.Point(3, 16);
            this.sessionsList.MultiSelect = false;
            this.sessionsList.Name = "sessionsList";
            this.sessionsList.ReadOnly = true;
            this.sessionsList.RowHeadersVisible = false;
            this.sessionsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sessionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionsList.Size = new System.Drawing.Size(490, 241);
            this.sessionsList.TabIndex = 12;
            // 
            // кодсеансаDataGridViewTextBoxColumn
            // 
            this.кодсеансаDataGridViewTextBoxColumn.DataPropertyName = "Код_сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.HeaderText = "Код сеанса";
            this.кодсеансаDataGridViewTextBoxColumn.Name = "кодсеансаDataGridViewTextBoxColumn";
            this.кодсеансаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодсеансаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодсеансаDataGridViewTextBoxColumn.Visible = false;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.датаDataGridViewTextBoxColumn.Width = 58;
            // 
            // кодфильмаDataGridViewTextBoxColumn1
            // 
            this.кодфильмаDataGridViewTextBoxColumn1.DataPropertyName = "Код_фильма";
            this.кодфильмаDataGridViewTextBoxColumn1.HeaderText = "Код фильма";
            this.кодфильмаDataGridViewTextBoxColumn1.Name = "кодфильмаDataGridViewTextBoxColumn1";
            this.кодфильмаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодфильмаDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодфильмаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // видсеансаDataGridViewTextBoxColumn
            // 
            this.видсеансаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.видсеансаDataGridViewTextBoxColumn.DataPropertyName = "Вид_сеанса";
            this.видсеансаDataGridViewTextBoxColumn.HeaderText = "Вид сеанса";
            this.видсеансаDataGridViewTextBoxColumn.Name = "видсеансаDataGridViewTextBoxColumn";
            this.видсеансаDataGridViewTextBoxColumn.ReadOnly = true;
            this.видсеансаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.видсеансаDataGridViewTextBoxColumn.Width = 90;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // addSessionLBL
            // 
            this.addSessionLBL.AutoSize = true;
            this.addSessionLBL.Location = new System.Drawing.Point(3, 0);
            this.addSessionLBL.Name = "addSessionLBL";
            this.addSessionLBL.Size = new System.Drawing.Size(181, 13);
            this.addSessionLBL.TabIndex = 11;
            this.addSessionLBL.Text = "Затем выберите желаемый сеанс";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.addOrderBTN);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 534);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(496, 29);
            this.actionPanel.TabIndex = 12;
            // 
            // addOrderBTN
            // 
            this.addOrderBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderBTN.Location = new System.Drawing.Point(3, 3);
            this.addOrderBTN.Name = "addOrderBTN";
            this.addOrderBTN.Size = new System.Drawing.Size(490, 23);
            this.addOrderBTN.TabIndex = 0;
            this.addOrderBTN.Text = "Добавить заказ!";
            this.addOrderBTN.UseVisualStyleBackColor = true;
            this.addOrderBTN.Click += new System.EventHandler(this.addOrderBTN_Click);
            // 
            // просмотрСеансовToolStripMenuItem
            // 
            this.просмотрСеансовToolStripMenuItem.Name = "просмотрСеансовToolStripMenuItem";
            this.просмотрСеансовToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.просмотрСеансовToolStripMenuItem.Text = "Просмотр сеансов";
            this.просмотрСеансовToolStripMenuItem.Click += new System.EventHandler(this.просмотрСеансовToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 587);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система бронирования билетов кинотеатра";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.VisibleChanged += new System.EventHandler(this.UserForm_VisibleChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.rcMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).EndInit();
            this.mainPanel.Panel1.ResumeLayout(false);
            this.mainPanel.Panel1.PerformLayout();
            this.mainPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).EndInit();
            this.addPanel.Panel1.ResumeLayout(false);
            this.addPanel.Panel1.PerformLayout();
            this.addPanel.Panel2.ResumeLayout(false);
            this.addPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPanel)).EndInit();
            this.addPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBTN;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rcDeleteSelectedBTN;
        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private kinoDataSetTableAdapters.ФильмыTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource filmsSessionsBindingSource;
        private kinoDataSetTableAdapters.СеансыTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.SplitContainer mainPanel;
        private System.Windows.Forms.Label ordersListLBL;
        private System.Windows.Forms.DataGridView ordersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderFilm;
        private System.Windows.Forms.SplitContainer addPanel;
        private System.Windows.Forms.Label addFilmLBL;
        private System.Windows.Forms.DataGridView filmsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView sessionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label addSessionLBL;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button addOrderBTN;
        private System.Windows.Forms.ToolStripMenuItem просмотрСеансовToolStripMenuItem;
    }
}
namespace Cinema
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHallBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeThisFormBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.kinoDataSet = new Cinema.kinoDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Cinema.kinoDataSetTableAdapters.ФильмыTableAdapter();
            this.filmsSessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsTableAdapter = new Cinema.kinoDataSetTableAdapters.СеансыTableAdapter();
            this.sessionsOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Cinema.kinoDataSetTableAdapters.ЗаказыTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoProfitLBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoProfitTB = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.filmsList = new System.Windows.Forms.DataGridView();
            this.кодфильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sessionsList = new System.Windows.Forms.DataGridView();
            this.кодсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодфильмаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видсеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersList = new System.Windows.Forms.DataGridView();
            this.Код_заказа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_клиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rcDeleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsOrderBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).BeginInit();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHallBTN,
            this.toolStripMenuItem2,
            this.deleteSelectedBTN,
            this.toolStripMenuItem1,
            this.closeThisFormBTN});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // showHallBTN
            // 
            this.showHallBTN.Name = "showHallBTN";
            this.showHallBTN.Size = new System.Drawing.Size(339, 22);
            this.showHallBTN.Text = "Посмотреть заполняемость выбранного сеанса";
            this.showHallBTN.Click += new System.EventHandler(this.showHallBTN_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(336, 6);
            // 
            // deleteSelectedBTN
            // 
            this.deleteSelectedBTN.Name = "deleteSelectedBTN";
            this.deleteSelectedBTN.Size = new System.Drawing.Size(339, 22);
            this.deleteSelectedBTN.Text = "Удалить выбранный заказ";
            this.deleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(336, 6);
            // 
            // closeThisFormBTN
            // 
            this.closeThisFormBTN.Name = "closeThisFormBTN";
            this.closeThisFormBTN.Size = new System.Drawing.Size(339, 22);
            this.closeThisFormBTN.Text = "Вернуться к главному окну";
            this.closeThisFormBTN.Click += new System.EventHandler(this.closeThisFormBTN_Click);
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
            // sessionsOrderBindingSource
            // 
            this.sessionsOrderBindingSource.DataMember = "СеансыЗаказы";
            this.sessionsOrderBindingSource.DataSource = this.filmsSessionsBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoProfitLBL,
            this.infoProfitTB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1019, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoProfitLBL
            // 
            this.infoProfitLBL.Name = "infoProfitLBL";
            this.infoProfitLBL.Size = new System.Drawing.Size(215, 17);
            this.infoProfitLBL.Text = "Общая выручка за выбранный сеанс:";
            // 
            // infoProfitTB
            // 
            this.infoProfitTB.Name = "infoProfitTB";
            this.infoProfitTB.Size = new System.Drawing.Size(13, 17);
            this.infoProfitTB.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filmsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1019, 548);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 17;
            // 
            // filmsList
            // 
            this.filmsList.AllowUserToAddRows = false;
            this.filmsList.AllowUserToDeleteRows = false;
            this.filmsList.AllowUserToResizeColumns = false;
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
            this.filmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsList.GridColor = System.Drawing.SystemColors.Window;
            this.filmsList.Location = new System.Drawing.Point(0, 0);
            this.filmsList.MultiSelect = false;
            this.filmsList.Name = "filmsList";
            this.filmsList.ReadOnly = true;
            this.filmsList.RowHeadersVisible = false;
            this.filmsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.filmsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmsList.Size = new System.Drawing.Size(171, 548);
            this.filmsList.TabIndex = 5;
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
            this.названиефильмаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиефильмаDataGridViewTextBoxColumn.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.названиефильмаDataGridViewTextBoxColumn.Name = "названиефильмаDataGridViewTextBoxColumn";
            this.названиефильмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // продолжительностьDataGridViewTextBoxColumn
            // 
            this.продолжительностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.продолжительностьDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.HeaderText = "Длительность";
            this.продолжительностьDataGridViewTextBoxColumn.Name = "продолжительностьDataGridViewTextBoxColumn";
            this.продолжительностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.продолжительностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.продолжительностьDataGridViewTextBoxColumn.Visible = false;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.жанрDataGridViewTextBoxColumn.Visible = false;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.описаниеDataGridViewTextBoxColumn.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sessionsList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ordersList);
            this.splitContainer2.Size = new System.Drawing.Size(844, 548);
            this.splitContainer2.SplitterDistance = 267;
            this.splitContainer2.TabIndex = 0;
            // 
            // sessionsList
            // 
            this.sessionsList.AllowUserToAddRows = false;
            this.sessionsList.AllowUserToDeleteRows = false;
            this.sessionsList.AllowUserToResizeColumns = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessionsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.sessionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionsList.GridColor = System.Drawing.SystemColors.Window;
            this.sessionsList.Location = new System.Drawing.Point(0, 0);
            this.sessionsList.MultiSelect = false;
            this.sessionsList.Name = "sessionsList";
            this.sessionsList.ReadOnly = true;
            this.sessionsList.RowHeadersVisible = false;
            this.sessionsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sessionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionsList.Size = new System.Drawing.Size(267, 548);
            this.sessionsList.TabIndex = 14;
            this.sessionsList.SelectionChanged += new System.EventHandler(this.sessionsList_SelectionChanged);
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
            // ordersList
            // 
            this.ordersList.AllowUserToAddRows = false;
            this.ordersList.AllowUserToDeleteRows = false;
            this.ordersList.AllowUserToResizeColumns = false;
            this.ordersList.AutoGenerateColumns = false;
            this.ordersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ordersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_заказа,
            this.dataGridViewTextBoxColumn1,
            this.Код_клиента,
            this.orderLogin,
            this.orderName,
            this.orderPassport});
            this.ordersList.ContextMenuStrip = this.rcMenu;
            this.ordersList.DataSource = this.sessionsOrderBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersList.DefaultCellStyle = dataGridViewCellStyle4;
            this.ordersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersList.GridColor = System.Drawing.SystemColors.Window;
            this.ordersList.Location = new System.Drawing.Point(0, 0);
            this.ordersList.MultiSelect = false;
            this.ordersList.Name = "ordersList";
            this.ordersList.ReadOnly = true;
            this.ordersList.RowHeadersVisible = false;
            this.ordersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ordersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersList.Size = new System.Drawing.Size(573, 548);
            this.ordersList.TabIndex = 15;
            // 
            // Код_заказа
            // 
            this.Код_заказа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Код_заказа.DataPropertyName = "Код_заказа";
            this.Код_заказа.HeaderText = "Код заказа";
            this.Код_заказа.Name = "Код_заказа";
            this.Код_заказа.ReadOnly = true;
            this.Код_заказа.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Код_заказа.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_сеанса";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сеанса";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Код_клиента
            // 
            this.Код_клиента.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Код_клиента.DataPropertyName = "Код_клиента";
            this.Код_клиента.HeaderText = "Код_клиента";
            this.Код_клиента.Name = "Код_клиента";
            this.Код_клиента.ReadOnly = true;
            this.Код_клиента.Visible = false;
            // 
            // orderLogin
            // 
            this.orderLogin.HeaderText = "Логин";
            this.orderLogin.Name = "orderLogin";
            this.orderLogin.ReadOnly = true;
            this.orderLogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // orderName
            // 
            this.orderName.HeaderText = "ФИО";
            this.orderName.Name = "orderName";
            this.orderName.ReadOnly = true;
            this.orderName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // orderPassport
            // 
            this.orderPassport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderPassport.HeaderText = "Номер паспорта";
            this.orderPassport.Name = "orderPassport";
            this.orderPassport.ReadOnly = true;
            this.orderPassport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 594);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1035, 632);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsOrderBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).EndInit();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeThisFormBTN;
        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private kinoDataSetTableAdapters.ФильмыTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource filmsSessionsBindingSource;
        private kinoDataSetTableAdapters.СеансыTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.BindingSource sessionsOrderBindingSource;
        private kinoDataSetTableAdapters.ЗаказыTableAdapter ordersTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoProfitLBL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView filmsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView sessionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView ordersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_заказа;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_клиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPassport;
        private System.Windows.Forms.ToolStripStatusLabel infoProfitTB;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rcDeleteSelectedBTN;
        private System.Windows.Forms.ToolStripMenuItem showHallBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}
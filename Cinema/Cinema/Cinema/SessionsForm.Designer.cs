namespace Cinema
{
    partial class SessionsForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.editShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeThisForm = new System.Windows.Forms.ToolStripMenuItem();
            this.kinoDataSet = new Cinema.kinoDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Cinema.kinoDataSetTableAdapters.ФильмыTableAdapter();
            this.sessionsTableAdapter = new Cinema.kinoDataSetTableAdapters.СеансыTableAdapter();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
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
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rcEditShow = new System.Windows.Forms.ToolStripMenuItem();
            this.rcDeleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsSessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editPanel = new System.Windows.Forms.Panel();
            this.editCostNUD = new System.Windows.Forms.NumericUpDown();
            this.editSessionBTN = new System.Windows.Forms.Button();
            this.editCostLBL = new System.Windows.Forms.Label();
            this.editTypeCB = new System.Windows.Forms.ComboBox();
            this.editTypeLBL = new System.Windows.Forms.Label();
            this.editDateTP = new System.Windows.Forms.DateTimePicker();
            this.editDateLBL = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addCostTB = new System.Windows.Forms.NumericUpDown();
            this.addSessionBTN = new System.Windows.Forms.Button();
            this.addCostLBL = new System.Windows.Forms.Label();
            this.addTypeCB = new System.Windows.Forms.ComboBox();
            this.addTypeLBL = new System.Windows.Forms.Label();
            this.addDateTP = new System.Windows.Forms.DateTimePicker();
            this.addDateLBL = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).BeginInit();
            this.rcMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editCostNUD)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCostTB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(615, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShowBTN,
            this.editShowBTN,
            this.toolStripMenuItem1,
            this.deleteSelectedBTN,
            this.toolStripMenuItem2,
            this.closeThisForm});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // addShowBTN
            // 
            this.addShowBTN.Name = "addShowBTN";
            this.addShowBTN.Size = new System.Drawing.Size(224, 22);
            this.addShowBTN.Text = "Добавление";
            this.addShowBTN.Click += new System.EventHandler(this.addShowBTN_Click);
            // 
            // editShowBTN
            // 
            this.editShowBTN.Checked = true;
            this.editShowBTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editShowBTN.Name = "editShowBTN";
            this.editShowBTN.Size = new System.Drawing.Size(224, 22);
            this.editShowBTN.Text = "Редактирование";
            this.editShowBTN.Click += new System.EventHandler(this.editShowBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // deleteSelectedBTN
            // 
            this.deleteSelectedBTN.Name = "deleteSelectedBTN";
            this.deleteSelectedBTN.Size = new System.Drawing.Size(224, 22);
            this.deleteSelectedBTN.Text = "Удалить выбранный сеанс";
            this.deleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // closeThisForm
            // 
            this.closeThisForm.Name = "closeThisForm";
            this.closeThisForm.Size = new System.Drawing.Size(224, 22);
            this.closeThisForm.Text = "Вернуться к главному окну";
            this.closeThisForm.Click += new System.EventHandler(this.closeThisForm_Click);
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
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.filmsList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.sessionsList);
            this.splitContainer.Panel2.Controls.Add(this.editPanel);
            this.splitContainer.Panel2.Controls.Add(this.addPanel);
            this.splitContainer.Size = new System.Drawing.Size(615, 417);
            this.splitContainer.SplitterDistance = 161;
            this.splitContainer.TabIndex = 10;
            // 
            // filmsList
            // 
            this.filmsList.AllowUserToAddRows = false;
            this.filmsList.AllowUserToDeleteRows = false;
            this.filmsList.AllowUserToResizeColumns = false;
            this.filmsList.AutoGenerateColumns = false;
            this.filmsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.filmsList.Size = new System.Drawing.Size(161, 417);
            this.filmsList.TabIndex = 6;
            // 
            // кодфильмаDataGridViewTextBoxColumn
            // 
            this.кодфильмаDataGridViewTextBoxColumn.DataPropertyName = "Код_фильма";
            this.кодфильмаDataGridViewTextBoxColumn.HeaderText = "Код фильма";
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
            this.продолжительностьDataGridViewTextBoxColumn.DataPropertyName = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.продолжительностьDataGridViewTextBoxColumn.Name = "продолжительностьDataGridViewTextBoxColumn";
            this.продолжительностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.продолжительностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.продолжительностьDataGridViewTextBoxColumn.Visible = false;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.жанрDataGridViewTextBoxColumn.Visible = false;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.описаниеDataGridViewTextBoxColumn.Visible = false;
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
            this.sessionsList.ContextMenuStrip = this.rcMenu;
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
            this.sessionsList.Location = new System.Drawing.Point(0, 142);
            this.sessionsList.MultiSelect = false;
            this.sessionsList.Name = "sessionsList";
            this.sessionsList.ReadOnly = true;
            this.sessionsList.RowHeadersVisible = false;
            this.sessionsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.sessionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionsList.Size = new System.Drawing.Size(450, 275);
            this.sessionsList.TabIndex = 11;
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
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rcEditShow,
            this.rcDeleteSelectedBTN});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(236, 48);
            // 
            // rcEditShow
            // 
            this.rcEditShow.Name = "rcEditShow";
            this.rcEditShow.Size = new System.Drawing.Size(235, 22);
            this.rcEditShow.Text = "Изменить выделенный сеанс";
            this.rcEditShow.Click += new System.EventHandler(this.rcEditShow_Click);
            // 
            // rcDeleteSelectedBTN
            // 
            this.rcDeleteSelectedBTN.Name = "rcDeleteSelectedBTN";
            this.rcDeleteSelectedBTN.Size = new System.Drawing.Size(235, 22);
            this.rcDeleteSelectedBTN.Text = "Удалить выделенный сеанс";
            this.rcDeleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // filmsSessionsBindingSource
            // 
            this.filmsSessionsBindingSource.DataMember = "ФильмыСеансы";
            this.filmsSessionsBindingSource.DataSource = this.filmsBindingSource;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editCostNUD);
            this.editPanel.Controls.Add(this.editSessionBTN);
            this.editPanel.Controls.Add(this.editCostLBL);
            this.editPanel.Controls.Add(this.editTypeCB);
            this.editPanel.Controls.Add(this.editTypeLBL);
            this.editPanel.Controls.Add(this.editDateTP);
            this.editPanel.Controls.Add(this.editDateLBL);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 71);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(450, 71);
            this.editPanel.TabIndex = 10;
            // 
            // editCostNUD
            // 
            this.editCostNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editCostNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmsSessionsBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editCostNUD.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editCostNUD.Location = new System.Drawing.Point(300, 16);
            this.editCostNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.editCostNUD.Name = "editCostNUD";
            this.editCostNUD.Size = new System.Drawing.Size(138, 20);
            this.editCostNUD.TabIndex = 14;
            this.editCostNUD.ThousandsSeparator = true;
            // 
            // editSessionBTN
            // 
            this.editSessionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editSessionBTN.Location = new System.Drawing.Point(12, 42);
            this.editSessionBTN.Name = "editSessionBTN";
            this.editSessionBTN.Size = new System.Drawing.Size(426, 23);
            this.editSessionBTN.TabIndex = 13;
            this.editSessionBTN.Text = "Изменить сеанс";
            this.editSessionBTN.UseVisualStyleBackColor = true;
            this.editSessionBTN.Click += new System.EventHandler(this.editSessionBTN_Click);
            // 
            // editCostLBL
            // 
            this.editCostLBL.AutoSize = true;
            this.editCostLBL.Location = new System.Drawing.Point(300, 0);
            this.editCostLBL.Name = "editCostLBL";
            this.editCostLBL.Size = new System.Drawing.Size(62, 13);
            this.editCostLBL.TabIndex = 12;
            this.editCostLBL.Text = "Стоимость";
            // 
            // editTypeCB
            // 
            this.editTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editTypeCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsSessionsBindingSource, "Вид_сеанса", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editTypeCB.FormattingEnabled = true;
            this.editTypeCB.Items.AddRange(new object[] {
            "Утренний",
            "Дневной",
            "Вечерний"});
            this.editTypeCB.Location = new System.Drawing.Point(156, 16);
            this.editTypeCB.Name = "editTypeCB";
            this.editTypeCB.Size = new System.Drawing.Size(138, 21);
            this.editTypeCB.TabIndex = 11;
            this.editTypeCB.Text = "Утренний";
            // 
            // editTypeLBL
            // 
            this.editTypeLBL.AutoSize = true;
            this.editTypeLBL.Location = new System.Drawing.Point(156, 0);
            this.editTypeLBL.Name = "editTypeLBL";
            this.editTypeLBL.Size = new System.Drawing.Size(65, 13);
            this.editTypeLBL.TabIndex = 10;
            this.editTypeLBL.Text = "Вид сеанса";
            // 
            // editDateTP
            // 
            this.editDateTP.CustomFormat = "";
            this.editDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmsSessionsBindingSource, "Дата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.editDateTP.Location = new System.Drawing.Point(12, 16);
            this.editDateTP.Name = "editDateTP";
            this.editDateTP.Size = new System.Drawing.Size(138, 20);
            this.editDateTP.TabIndex = 9;
            // 
            // editDateLBL
            // 
            this.editDateLBL.AutoSize = true;
            this.editDateLBL.Location = new System.Drawing.Point(12, 0);
            this.editDateLBL.Name = "editDateLBL";
            this.editDateLBL.Size = new System.Drawing.Size(72, 13);
            this.editDateLBL.TabIndex = 8;
            this.editDateLBL.Text = "Дата сеанса";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addCostTB);
            this.addPanel.Controls.Add(this.addSessionBTN);
            this.addPanel.Controls.Add(this.addCostLBL);
            this.addPanel.Controls.Add(this.addTypeCB);
            this.addPanel.Controls.Add(this.addTypeLBL);
            this.addPanel.Controls.Add(this.addDateTP);
            this.addPanel.Controls.Add(this.addDateLBL);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(450, 71);
            this.addPanel.TabIndex = 8;
            this.addPanel.Visible = false;
            // 
            // addCostTB
            // 
            this.addCostTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCostTB.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addCostTB.Location = new System.Drawing.Point(300, 16);
            this.addCostTB.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.addCostTB.Name = "addCostTB";
            this.addCostTB.Size = new System.Drawing.Size(138, 20);
            this.addCostTB.TabIndex = 7;
            this.addCostTB.ThousandsSeparator = true;
            // 
            // addSessionBTN
            // 
            this.addSessionBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addSessionBTN.Location = new System.Drawing.Point(12, 42);
            this.addSessionBTN.Name = "addSessionBTN";
            this.addSessionBTN.Size = new System.Drawing.Size(426, 23);
            this.addSessionBTN.TabIndex = 6;
            this.addSessionBTN.Text = "Добавить сеанс";
            this.addSessionBTN.UseVisualStyleBackColor = true;
            this.addSessionBTN.Click += new System.EventHandler(this.addSessionBTN_Click);
            // 
            // addCostLBL
            // 
            this.addCostLBL.AutoSize = true;
            this.addCostLBL.Location = new System.Drawing.Point(300, 0);
            this.addCostLBL.Name = "addCostLBL";
            this.addCostLBL.Size = new System.Drawing.Size(62, 13);
            this.addCostLBL.TabIndex = 4;
            this.addCostLBL.Text = "Стоимость";
            // 
            // addTypeCB
            // 
            this.addTypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addTypeCB.FormattingEnabled = true;
            this.addTypeCB.Items.AddRange(new object[] {
            "Утренний",
            "Дневной",
            "Вечерний"});
            this.addTypeCB.Location = new System.Drawing.Point(156, 16);
            this.addTypeCB.Name = "addTypeCB";
            this.addTypeCB.Size = new System.Drawing.Size(138, 21);
            this.addTypeCB.TabIndex = 3;
            this.addTypeCB.Text = "Утренний";
            // 
            // addTypeLBL
            // 
            this.addTypeLBL.AutoSize = true;
            this.addTypeLBL.Location = new System.Drawing.Point(156, 0);
            this.addTypeLBL.Name = "addTypeLBL";
            this.addTypeLBL.Size = new System.Drawing.Size(65, 13);
            this.addTypeLBL.TabIndex = 2;
            this.addTypeLBL.Text = "Вид сеанса";
            // 
            // addDateTP
            // 
            this.addDateTP.CustomFormat = "";
            this.addDateTP.Location = new System.Drawing.Point(12, 16);
            this.addDateTP.Name = "addDateTP";
            this.addDateTP.Size = new System.Drawing.Size(138, 20);
            this.addDateTP.TabIndex = 1;
            // 
            // addDateLBL
            // 
            this.addDateLBL.AutoSize = true;
            this.addDateLBL.Location = new System.Drawing.Point(12, 0);
            this.addDateLBL.Name = "addDateLBL";
            this.addDateLBL.Size = new System.Drawing.Size(72, 13);
            this.addDateLBL.TabIndex = 0;
            this.addDateLBL.Text = "Дата сеанса";
            // 
            // SessionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 441);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(631, 479);
            this.Name = "SessionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сеансами";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SessionsForm_FormClosing);
            this.Load += new System.EventHandler(this.SessionsForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsList)).EndInit();
            this.rcMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsSessionsBindingSource)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editCostNUD)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCostTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private kinoDataSetTableAdapters.ФильмыTableAdapter filmsTableAdapter;
        private System.Windows.Forms.BindingSource filmsSessionsBindingSource;
        private kinoDataSetTableAdapters.СеансыTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem addShowBTN;
        private System.Windows.Forms.ToolStripMenuItem editShowBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeThisForm;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView filmsList;
        private System.Windows.Forms.DataGridView sessionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видсеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.NumericUpDown editCostNUD;
        private System.Windows.Forms.Button editSessionBTN;
        private System.Windows.Forms.Label editCostLBL;
        private System.Windows.Forms.ComboBox editTypeCB;
        private System.Windows.Forms.Label editTypeLBL;
        private System.Windows.Forms.DateTimePicker editDateTP;
        private System.Windows.Forms.Label editDateLBL;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.NumericUpDown addCostTB;
        private System.Windows.Forms.Button addSessionBTN;
        private System.Windows.Forms.Label addCostLBL;
        private System.Windows.Forms.ComboBox addTypeCB;
        private System.Windows.Forms.Label addTypeLBL;
        private System.Windows.Forms.DateTimePicker addDateTP;
        private System.Windows.Forms.Label addDateLBL;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rcEditShow;
        private System.Windows.Forms.ToolStripMenuItem rcDeleteSelectedBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
    }
}
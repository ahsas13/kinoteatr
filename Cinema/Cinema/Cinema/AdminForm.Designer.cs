namespace Cinema
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.editShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsControlBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.usersControlShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersControlShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.hallPropShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.kinoDataSet = new Cinema.kinoDataSet();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPanel = new System.Windows.Forms.Panel();
            this.addGenreCB = new System.Windows.Forms.ComboBox();
            this.addFilmBTN = new System.Windows.Forms.Button();
            this.addDescrTB = new System.Windows.Forms.TextBox();
            this.addDescrLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.addLengthLBL = new System.Windows.Forms.Label();
            this.addNameTB = new System.Windows.Forms.TextBox();
            this.addNameLBL = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editFilmBTN = new System.Windows.Forms.Button();
            this.editGenreCB = new System.Windows.Forms.ComboBox();
            this.editDescrTB = new System.Windows.Forms.TextBox();
            this.editDescrLBL = new System.Windows.Forms.Label();
            this.editGenreLBL = new System.Windows.Forms.Label();
            this.editLengthNUD = new System.Windows.Forms.NumericUpDown();
            this.editLengthLBL = new System.Windows.Forms.Label();
            this.editNameTB = new System.Windows.Forms.TextBox();
            this.editNameLBL = new System.Windows.Forms.Label();
            this.listsPanel = new System.Windows.Forms.Panel();
            this.filmsList = new System.Windows.Forms.DataGridView();
            this.кодфильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продолжительностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rcEditShow = new System.Windows.Forms.ToolStripMenuItem();
            this.rcDeleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsTableAdapter = new Cinema.kinoDataSetTableAdapters.ФильмыTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.просмотрСеансовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLengthNUD)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editLengthNUD)).BeginInit();
            this.listsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).BeginInit();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.sessionsControlBTN,
            this.usersControlShowBTN,
            this.ordersControlShowBTN,
            this.hallPropShowBTN,
            this.просмотрСеансовToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(765, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShowBTN,
            this.editShowBTN,
            this.toolStripMenuItem1,
            this.deleteSelectedBTN,
            this.toolStripMenuItem2,
            this.exitBTN});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // addShowBTN
            // 
            this.addShowBTN.Name = "addShowBTN";
            this.addShowBTN.Size = new System.Drawing.Size(232, 22);
            this.addShowBTN.Text = "Добавление";
            this.addShowBTN.Click += new System.EventHandler(this.addShowBTN_Click);
            // 
            // editShowBTN
            // 
            this.editShowBTN.Checked = true;
            this.editShowBTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editShowBTN.Name = "editShowBTN";
            this.editShowBTN.Size = new System.Drawing.Size(232, 22);
            this.editShowBTN.Text = "Редактирование";
            this.editShowBTN.Click += new System.EventHandler(this.editShowBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // deleteSelectedBTN
            // 
            this.deleteSelectedBTN.Name = "deleteSelectedBTN";
            this.deleteSelectedBTN.Size = new System.Drawing.Size(232, 22);
            this.deleteSelectedBTN.Text = "Удалить выделенный фильм";
            this.deleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // exitBTN
            // 
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(232, 22);
            this.exitBTN.Text = "Выход";
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // sessionsControlBTN
            // 
            this.sessionsControlBTN.Name = "sessionsControlBTN";
            this.sessionsControlBTN.Size = new System.Drawing.Size(141, 20);
            this.sessionsControlBTN.Text = "Управление сеансами";
            this.sessionsControlBTN.Click += new System.EventHandler(this.sessionsControlBTN_Click);
            // 
            // usersControlShowBTN
            // 
            this.usersControlShowBTN.Name = "usersControlShowBTN";
            this.usersControlShowBTN.Size = new System.Drawing.Size(179, 20);
            this.usersControlShowBTN.Text = "Управление пользователями";
            this.usersControlShowBTN.Click += new System.EventHandler(this.usersControlShowBTN_Click);
            // 
            // ordersControlShowBTN
            // 
            this.ordersControlShowBTN.Name = "ordersControlShowBTN";
            this.ordersControlShowBTN.Size = new System.Drawing.Size(120, 20);
            this.ordersControlShowBTN.Text = "Просмотр заказов";
            this.ordersControlShowBTN.Click += new System.EventHandler(this.ordersControlShowBTN_Click);
            // 
            // hallPropShowBTN
            // 
            this.hallPropShowBTN.Name = "hallPropShowBTN";
            this.hallPropShowBTN.Size = new System.Drawing.Size(110, 20);
            this.hallPropShowBTN.Text = "Параметры зала";
            this.hallPropShowBTN.Click += new System.EventHandler(this.hallPropShowBTN_Click);
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
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addGenreCB);
            this.addPanel.Controls.Add(this.addFilmBTN);
            this.addPanel.Controls.Add(this.addDescrTB);
            this.addPanel.Controls.Add(this.addDescrLBL);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.addLengthNUD);
            this.addPanel.Controls.Add(this.addLengthLBL);
            this.addPanel.Controls.Add(this.addNameTB);
            this.addPanel.Controls.Add(this.addNameLBL);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 24);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(765, 149);
            this.addPanel.TabIndex = 3;
            this.addPanel.Visible = false;
            // 
            // addGenreCB
            // 
            this.addGenreCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addGenreCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addGenreCB.FormattingEnabled = true;
            this.addGenreCB.Items.AddRange(new object[] {
            "Биографический",
            "Боевик",
            "Вестерн",
            "Военный",
            "Детектив",
            "Детский",
            "Документальный",
            "Драма",
            "Исторический",
            "Кинокомикс",
            "Комедия",
            "Концерт",
            "Короткометражный",
            "Криминал",
            "Мелодрама",
            "Мистика",
            "Музыка",
            "Мультфильм",
            "Мюзикл",
            "Научный",
            "Нуар",
            "Приключения",
            "Семейный",
            "Спорт",
            "Триллер",
            "Ужасы",
            "Фантастика",
            "Фэнтези"});
            this.addGenreCB.Location = new System.Drawing.Point(12, 93);
            this.addGenreCB.Name = "addGenreCB";
            this.addGenreCB.Size = new System.Drawing.Size(164, 21);
            this.addGenreCB.TabIndex = 9;
            this.addGenreCB.Text = "Боевик";
            // 
            // addFilmBTN
            // 
            this.addFilmBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addFilmBTN.Location = new System.Drawing.Point(12, 120);
            this.addFilmBTN.Name = "addFilmBTN";
            this.addFilmBTN.Size = new System.Drawing.Size(741, 23);
            this.addFilmBTN.TabIndex = 8;
            this.addFilmBTN.Text = "Добавить";
            this.addFilmBTN.UseVisualStyleBackColor = true;
            this.addFilmBTN.Click += new System.EventHandler(this.addFilmBTN_Click);
            // 
            // addDescrTB
            // 
            this.addDescrTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDescrTB.Location = new System.Drawing.Point(182, 16);
            this.addDescrTB.Multiline = true;
            this.addDescrTB.Name = "addDescrTB";
            this.addDescrTB.Size = new System.Drawing.Size(571, 98);
            this.addDescrTB.TabIndex = 7;
            // 
            // addDescrLBL
            // 
            this.addDescrLBL.AutoSize = true;
            this.addDescrLBL.Location = new System.Drawing.Point(182, 0);
            this.addDescrLBL.Name = "addDescrLBL";
            this.addDescrLBL.Size = new System.Drawing.Size(57, 13);
            this.addDescrLBL.TabIndex = 6;
            this.addDescrLBL.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жанр:";
            // 
            // addLengthNUD
            // 
            this.addLengthNUD.Location = new System.Drawing.Point(12, 55);
            this.addLengthNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addLengthNUD.Name = "addLengthNUD";
            this.addLengthNUD.Size = new System.Drawing.Size(164, 20);
            this.addLengthNUD.TabIndex = 3;
            // 
            // addLengthLBL
            // 
            this.addLengthLBL.AutoSize = true;
            this.addLengthLBL.Location = new System.Drawing.Point(12, 39);
            this.addLengthLBL.Name = "addLengthLBL";
            this.addLengthLBL.Size = new System.Drawing.Size(119, 13);
            this.addLengthLBL.TabIndex = 2;
            this.addLengthLBL.Text = "Длительность (минут)";
            // 
            // addNameTB
            // 
            this.addNameTB.Location = new System.Drawing.Point(12, 16);
            this.addNameTB.Name = "addNameTB";
            this.addNameTB.Size = new System.Drawing.Size(164, 20);
            this.addNameTB.TabIndex = 1;
            // 
            // addNameLBL
            // 
            this.addNameLBL.AutoSize = true;
            this.addNameLBL.Location = new System.Drawing.Point(12, 0);
            this.addNameLBL.Name = "addNameLBL";
            this.addNameLBL.Size = new System.Drawing.Size(103, 13);
            this.addNameLBL.TabIndex = 0;
            this.addNameLBL.Text = "Название фильма:";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(765, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editFilmBTN);
            this.editPanel.Controls.Add(this.editGenreCB);
            this.editPanel.Controls.Add(this.editDescrTB);
            this.editPanel.Controls.Add(this.editDescrLBL);
            this.editPanel.Controls.Add(this.editGenreLBL);
            this.editPanel.Controls.Add(this.editLengthNUD);
            this.editPanel.Controls.Add(this.editLengthLBL);
            this.editPanel.Controls.Add(this.editNameTB);
            this.editPanel.Controls.Add(this.editNameLBL);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 173);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(765, 149);
            this.editPanel.TabIndex = 6;
            // 
            // editFilmBTN
            // 
            this.editFilmBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editFilmBTN.Location = new System.Drawing.Point(12, 120);
            this.editFilmBTN.Name = "editFilmBTN";
            this.editFilmBTN.Size = new System.Drawing.Size(741, 23);
            this.editFilmBTN.TabIndex = 10;
            this.editFilmBTN.Text = "Изменить";
            this.editFilmBTN.UseVisualStyleBackColor = true;
            this.editFilmBTN.Click += new System.EventHandler(this.editFilmBTN_Click);
            // 
            // editGenreCB
            // 
            this.editGenreCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editGenreCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editGenreCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Жанр", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editGenreCB.FormattingEnabled = true;
            this.editGenreCB.Items.AddRange(new object[] {
            "Биографический",
            "Боевик",
            "Вестерн",
            "Военный",
            "Детектив",
            "Детский",
            "Документальный",
            "Драма",
            "Исторический",
            "Кинокомикс",
            "Комедия",
            "Концерт",
            "Короткометражный",
            "Криминал",
            "Мелодрама",
            "Мистика",
            "Музыка",
            "Мультфильм",
            "Мюзикл",
            "Научный",
            "Нуар",
            "Приключения",
            "Семейный",
            "Спорт",
            "Триллер",
            "Ужасы",
            "Фантастика",
            "Фэнтези"});
            this.editGenreCB.Location = new System.Drawing.Point(12, 93);
            this.editGenreCB.Name = "editGenreCB";
            this.editGenreCB.Size = new System.Drawing.Size(164, 21);
            this.editGenreCB.TabIndex = 9;
            this.editGenreCB.Text = "Боевик";
            // 
            // editDescrTB
            // 
            this.editDescrTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editDescrTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Описание", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editDescrTB.Location = new System.Drawing.Point(182, 16);
            this.editDescrTB.Multiline = true;
            this.editDescrTB.Name = "editDescrTB";
            this.editDescrTB.Size = new System.Drawing.Size(571, 98);
            this.editDescrTB.TabIndex = 7;
            // 
            // editDescrLBL
            // 
            this.editDescrLBL.AutoSize = true;
            this.editDescrLBL.Location = new System.Drawing.Point(182, 0);
            this.editDescrLBL.Name = "editDescrLBL";
            this.editDescrLBL.Size = new System.Drawing.Size(57, 13);
            this.editDescrLBL.TabIndex = 6;
            this.editDescrLBL.Text = "Описание";
            // 
            // editGenreLBL
            // 
            this.editGenreLBL.AutoSize = true;
            this.editGenreLBL.Location = new System.Drawing.Point(12, 77);
            this.editGenreLBL.Name = "editGenreLBL";
            this.editGenreLBL.Size = new System.Drawing.Size(39, 13);
            this.editGenreLBL.TabIndex = 4;
            this.editGenreLBL.Text = "Жанр:";
            // 
            // editLengthNUD
            // 
            this.editLengthNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filmsBindingSource, "Продолжительность", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N0"));
            this.editLengthNUD.Location = new System.Drawing.Point(12, 55);
            this.editLengthNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editLengthNUD.Name = "editLengthNUD";
            this.editLengthNUD.Size = new System.Drawing.Size(164, 20);
            this.editLengthNUD.TabIndex = 3;
            // 
            // editLengthLBL
            // 
            this.editLengthLBL.AutoSize = true;
            this.editLengthLBL.Location = new System.Drawing.Point(12, 39);
            this.editLengthLBL.Name = "editLengthLBL";
            this.editLengthLBL.Size = new System.Drawing.Size(119, 13);
            this.editLengthLBL.TabIndex = 2;
            this.editLengthLBL.Text = "Длительность (минут)";
            // 
            // editNameTB
            // 
            this.editNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmsBindingSource, "Название_фильма", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editNameTB.Location = new System.Drawing.Point(12, 16);
            this.editNameTB.Name = "editNameTB";
            this.editNameTB.Size = new System.Drawing.Size(164, 20);
            this.editNameTB.TabIndex = 1;
            // 
            // editNameLBL
            // 
            this.editNameLBL.AutoSize = true;
            this.editNameLBL.Location = new System.Drawing.Point(12, 0);
            this.editNameLBL.Name = "editNameLBL";
            this.editNameLBL.Size = new System.Drawing.Size(103, 13);
            this.editNameLBL.TabIndex = 0;
            this.editNameLBL.Text = "Название фильма:";
            // 
            // listsPanel
            // 
            this.listsPanel.Controls.Add(this.filmsList);
            this.listsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listsPanel.Location = new System.Drawing.Point(0, 322);
            this.listsPanel.Name = "listsPanel";
            this.listsPanel.Size = new System.Drawing.Size(765, 218);
            this.listsPanel.TabIndex = 7;
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
            this.filmsList.ContextMenuStrip = this.rcMenu;
            this.filmsList.DataSource = this.filmsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filmsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.filmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsList.GridColor = System.Drawing.SystemColors.Window;
            this.filmsList.Location = new System.Drawing.Point(0, 0);
            this.filmsList.MultiSelect = false;
            this.filmsList.Name = "filmsList";
            this.filmsList.ReadOnly = true;
            this.filmsList.RowHeadersVisible = false;
            this.filmsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.filmsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmsList.Size = new System.Drawing.Size(765, 218);
            this.filmsList.TabIndex = 3;
            this.filmsList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.filmsList_RowsAdded);
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
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rcEditShow,
            this.rcDeleteSelectedBTN});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(243, 48);
            // 
            // rcEditShow
            // 
            this.rcEditShow.Name = "rcEditShow";
            this.rcEditShow.Size = new System.Drawing.Size(242, 22);
            this.rcEditShow.Text = "Изменить выделенный фильм";
            this.rcEditShow.Click += new System.EventHandler(this.rcEditShow_Click);
            // 
            // rcDeleteSelectedBTN
            // 
            this.rcDeleteSelectedBTN.Name = "rcDeleteSelectedBTN";
            this.rcDeleteSelectedBTN.Size = new System.Drawing.Size(242, 22);
            this.rcDeleteSelectedBTN.Text = "Удалить выделенный фильм";
            this.rcDeleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // просмотрСеансовToolStripMenuItem
            // 
            this.просмотрСеансовToolStripMenuItem.Name = "просмотрСеансовToolStripMenuItem";
            this.просмотрСеансовToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.просмотрСеансовToolStripMenuItem.Text = "Просмотр сеансов";
            this.просмотрСеансовToolStripMenuItem.Click += new System.EventHandler(this.просмотрСеансовToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 562);
            this.Controls.Add(this.listsPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления кинотеатром";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.AdminForm_VisibleChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLengthNUD)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editLengthNUD)).EndInit();
            this.listsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsList)).EndInit();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBTN;
        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.ComboBox addGenreCB;
        private System.Windows.Forms.Button addFilmBTN;
        private System.Windows.Forms.TextBox addDescrTB;
        private System.Windows.Forms.Label addDescrLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addLengthNUD;
        private System.Windows.Forms.Label addLengthLBL;
        private System.Windows.Forms.TextBox addNameTB;
        private System.Windows.Forms.Label addNameLBL;
        private System.Windows.Forms.ToolStripMenuItem addShowBTN;
        private System.Windows.Forms.ToolStripMenuItem editShowBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.ComboBox editGenreCB;
        private System.Windows.Forms.TextBox editDescrTB;
        private System.Windows.Forms.Label editDescrLBL;
        private System.Windows.Forms.Label editGenreLBL;
        private System.Windows.Forms.NumericUpDown editLengthNUD;
        private System.Windows.Forms.Label editLengthLBL;
        private System.Windows.Forms.TextBox editNameTB;
        private System.Windows.Forms.Label editNameLBL;
        private System.Windows.Forms.Panel listsPanel;
        private System.Windows.Forms.DataGridView filmsList;
        private System.Windows.Forms.Button editFilmBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодфильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продолжительностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private kinoDataSetTableAdapters.ФильмыTableAdapter filmsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sessionsControlBTN;
        private System.Windows.Forms.ToolStripMenuItem usersControlShowBTN;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rcEditShow;
        private System.Windows.Forms.ToolStripMenuItem rcDeleteSelectedBTN;
        private System.Windows.Forms.ToolStripMenuItem ordersControlShowBTN;
        private System.Windows.Forms.ToolStripMenuItem hallPropShowBTN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem просмотрСеансовToolStripMenuItem;
    }
}
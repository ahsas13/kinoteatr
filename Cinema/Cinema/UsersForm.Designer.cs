namespace Cinema
{
    partial class UsersForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.editShowBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeThisForm = new System.Windows.Forms.ToolStripMenuItem();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addPassConfirmTB = new System.Windows.Forms.MaskedTextBox();
            this.addPassTB = new System.Windows.Forms.MaskedTextBox();
            this.addUserBTN = new System.Windows.Forms.Button();
            this.addPassportTB = new System.Windows.Forms.TextBox();
            this.addPassportLBL = new System.Windows.Forms.Label();
            this.addNameTB = new System.Windows.Forms.TextBox();
            this.addNameLBL = new System.Windows.Forms.Label();
            this.addPassConfirmLBL = new System.Windows.Forms.Label();
            this.addPassLBL = new System.Windows.Forms.Label();
            this.addLoginTB = new System.Windows.Forms.TextBox();
            this.addLoginLBL = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new Cinema.kinoDataSet();
            this.editPassConfirmTB = new System.Windows.Forms.MaskedTextBox();
            this.editPassTB = new System.Windows.Forms.MaskedTextBox();
            this.editUserBTN = new System.Windows.Forms.Button();
            this.editPassportTB = new System.Windows.Forms.TextBox();
            this.editPassportLBL = new System.Windows.Forms.Label();
            this.editNameTB = new System.Windows.Forms.TextBox();
            this.editNameLBL = new System.Windows.Forms.Label();
            this.editPassConfirmLBL = new System.Windows.Forms.Label();
            this.editPassLBL = new System.Windows.Forms.Label();
            this.editLoginTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.DataGridView();
            this.rcMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rcEditShow = new System.Windows.Forms.ToolStripMenuItem();
            this.rcDeleteSelectedBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTableAdapter = new Cinema.kinoDataSetTableAdapters.КлиентыTableAdapter();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
            this.rcMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(490, 24);
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
            this.addShowBTN.Size = new System.Drawing.Size(267, 22);
            this.addShowBTN.Text = "Добавление";
            this.addShowBTN.Click += new System.EventHandler(this.addShowBTN_Click);
            // 
            // editShowBTN
            // 
            this.editShowBTN.Checked = true;
            this.editShowBTN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editShowBTN.Name = "editShowBTN";
            this.editShowBTN.Size = new System.Drawing.Size(267, 22);
            this.editShowBTN.Text = "Редактирование";
            this.editShowBTN.Click += new System.EventHandler(this.editShowBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
            // 
            // deleteSelectedBTN
            // 
            this.deleteSelectedBTN.Name = "deleteSelectedBTN";
            this.deleteSelectedBTN.Size = new System.Drawing.Size(267, 22);
            this.deleteSelectedBTN.Text = "Удалить выбранного пользователя";
            this.deleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
            // 
            // closeThisForm
            // 
            this.closeThisForm.Name = "closeThisForm";
            this.closeThisForm.Size = new System.Drawing.Size(267, 22);
            this.closeThisForm.Text = "Вернуться к главному окну";
            this.closeThisForm.Click += new System.EventHandler(this.closeThisForm_Click);
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addPassConfirmTB);
            this.addPanel.Controls.Add(this.addPassTB);
            this.addPanel.Controls.Add(this.addUserBTN);
            this.addPanel.Controls.Add(this.addPassportTB);
            this.addPanel.Controls.Add(this.addPassportLBL);
            this.addPanel.Controls.Add(this.addNameTB);
            this.addPanel.Controls.Add(this.addNameLBL);
            this.addPanel.Controls.Add(this.addPassConfirmLBL);
            this.addPanel.Controls.Add(this.addPassLBL);
            this.addPanel.Controls.Add(this.addLoginTB);
            this.addPanel.Controls.Add(this.addLoginLBL);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel.Location = new System.Drawing.Point(0, 24);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(490, 149);
            this.addPanel.TabIndex = 1;
            this.addPanel.Visible = false;
            // 
            // addPassConfirmTB
            // 
            this.addPassConfirmTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPassConfirmTB.Location = new System.Drawing.Point(248, 55);
            this.addPassConfirmTB.Name = "addPassConfirmTB";
            this.addPassConfirmTB.Size = new System.Drawing.Size(230, 20);
            this.addPassConfirmTB.TabIndex = 12;
            this.addPassConfirmTB.UseSystemPasswordChar = true;
            // 
            // addPassTB
            // 
            this.addPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPassTB.Location = new System.Drawing.Point(248, 16);
            this.addPassTB.Name = "addPassTB";
            this.addPassTB.Size = new System.Drawing.Size(230, 20);
            this.addPassTB.TabIndex = 11;
            this.addPassTB.UseSystemPasswordChar = true;
            // 
            // addUserBTN
            // 
            this.addUserBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBTN.Location = new System.Drawing.Point(12, 120);
            this.addUserBTN.Name = "addUserBTN";
            this.addUserBTN.Size = new System.Drawing.Size(466, 23);
            this.addUserBTN.TabIndex = 10;
            this.addUserBTN.Text = "Добавить пользователя";
            this.addUserBTN.UseVisualStyleBackColor = true;
            this.addUserBTN.Click += new System.EventHandler(this.addUserBTN_Click);
            // 
            // addPassportTB
            // 
            this.addPassportTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPassportTB.Location = new System.Drawing.Point(12, 94);
            this.addPassportTB.Name = "addPassportTB";
            this.addPassportTB.Size = new System.Drawing.Size(466, 20);
            this.addPassportTB.TabIndex = 9;
            // 
            // addPassportLBL
            // 
            this.addPassportLBL.AutoSize = true;
            this.addPassportLBL.Location = new System.Drawing.Point(12, 78);
            this.addPassportLBL.Name = "addPassportLBL";
            this.addPassportLBL.Size = new System.Drawing.Size(94, 13);
            this.addPassportLBL.TabIndex = 8;
            this.addPassportLBL.Text = "Номер паспорта:";
            // 
            // addNameTB
            // 
            this.addNameTB.Location = new System.Drawing.Point(12, 55);
            this.addNameTB.Name = "addNameTB";
            this.addNameTB.Size = new System.Drawing.Size(230, 20);
            this.addNameTB.TabIndex = 7;
            // 
            // addNameLBL
            // 
            this.addNameLBL.AutoSize = true;
            this.addNameLBL.Location = new System.Drawing.Point(12, 39);
            this.addNameLBL.Name = "addNameLBL";
            this.addNameLBL.Size = new System.Drawing.Size(34, 13);
            this.addNameLBL.TabIndex = 6;
            this.addNameLBL.Text = "ФИО";
            // 
            // addPassConfirmLBL
            // 
            this.addPassConfirmLBL.AutoSize = true;
            this.addPassConfirmLBL.Location = new System.Drawing.Point(248, 39);
            this.addPassConfirmLBL.Name = "addPassConfirmLBL";
            this.addPassConfirmLBL.Size = new System.Drawing.Size(96, 13);
            this.addPassConfirmLBL.TabIndex = 4;
            this.addPassConfirmLBL.Text = "Пароль (ещё раз)";
            // 
            // addPassLBL
            // 
            this.addPassLBL.AutoSize = true;
            this.addPassLBL.Location = new System.Drawing.Point(248, 0);
            this.addPassLBL.Name = "addPassLBL";
            this.addPassLBL.Size = new System.Drawing.Size(45, 13);
            this.addPassLBL.TabIndex = 2;
            this.addPassLBL.Text = "Пароль";
            // 
            // addLoginTB
            // 
            this.addLoginTB.Location = new System.Drawing.Point(12, 16);
            this.addLoginTB.Name = "addLoginTB";
            this.addLoginTB.Size = new System.Drawing.Size(230, 20);
            this.addLoginTB.TabIndex = 1;
            // 
            // addLoginLBL
            // 
            this.addLoginLBL.AutoSize = true;
            this.addLoginLBL.Location = new System.Drawing.Point(12, 0);
            this.addLoginLBL.Name = "addLoginLBL";
            this.addLoginLBL.Size = new System.Drawing.Size(38, 13);
            this.addLoginLBL.TabIndex = 0;
            this.addLoginLBL.Text = "Логин";
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editPassConfirmTB);
            this.editPanel.Controls.Add(this.editPassTB);
            this.editPanel.Controls.Add(this.editUserBTN);
            this.editPanel.Controls.Add(this.editPassportTB);
            this.editPanel.Controls.Add(this.editPassportLBL);
            this.editPanel.Controls.Add(this.editNameTB);
            this.editPanel.Controls.Add(this.editNameLBL);
            this.editPanel.Controls.Add(this.editPassConfirmLBL);
            this.editPanel.Controls.Add(this.editPassLBL);
            this.editPanel.Controls.Add(this.editLoginTB);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPanel.Location = new System.Drawing.Point(0, 173);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(490, 149);
            this.editPanel.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Клиенты";
            this.usersBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editPassConfirmTB
            // 
            this.editPassConfirmTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPassConfirmTB.Location = new System.Drawing.Point(247, 55);
            this.editPassConfirmTB.Name = "editPassConfirmTB";
            this.editPassConfirmTB.Size = new System.Drawing.Size(230, 20);
            this.editPassConfirmTB.TabIndex = 23;
            this.editPassConfirmTB.UseSystemPasswordChar = true;
            // 
            // editPassTB
            // 
            this.editPassTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPassTB.Location = new System.Drawing.Point(248, 16);
            this.editPassTB.Name = "editPassTB";
            this.editPassTB.Size = new System.Drawing.Size(230, 20);
            this.editPassTB.TabIndex = 22;
            this.editPassTB.UseSystemPasswordChar = true;
            // 
            // editUserBTN
            // 
            this.editUserBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editUserBTN.Location = new System.Drawing.Point(12, 120);
            this.editUserBTN.Name = "editUserBTN";
            this.editUserBTN.Size = new System.Drawing.Size(466, 23);
            this.editUserBTN.TabIndex = 21;
            this.editUserBTN.Text = "Изменить пользователя";
            this.editUserBTN.UseVisualStyleBackColor = true;
            this.editUserBTN.Click += new System.EventHandler(this.editUserBTN_Click);
            // 
            // editPassportTB
            // 
            this.editPassportTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Номер_паспорта", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editPassportTB.Location = new System.Drawing.Point(12, 94);
            this.editPassportTB.Name = "editPassportTB";
            this.editPassportTB.Size = new System.Drawing.Size(230, 20);
            this.editPassportTB.TabIndex = 20;
            // 
            // editPassportLBL
            // 
            this.editPassportLBL.AutoSize = true;
            this.editPassportLBL.Location = new System.Drawing.Point(12, 78);
            this.editPassportLBL.Name = "editPassportLBL";
            this.editPassportLBL.Size = new System.Drawing.Size(94, 13);
            this.editPassportLBL.TabIndex = 19;
            this.editPassportLBL.Text = "Номер паспорта:";
            // 
            // editNameTB
            // 
            this.editNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "ФИО", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editNameTB.Location = new System.Drawing.Point(12, 55);
            this.editNameTB.Name = "editNameTB";
            this.editNameTB.Size = new System.Drawing.Size(230, 20);
            this.editNameTB.TabIndex = 18;
            // 
            // editNameLBL
            // 
            this.editNameLBL.AutoSize = true;
            this.editNameLBL.Location = new System.Drawing.Point(12, 39);
            this.editNameLBL.Name = "editNameLBL";
            this.editNameLBL.Size = new System.Drawing.Size(34, 13);
            this.editNameLBL.TabIndex = 17;
            this.editNameLBL.Text = "ФИО";
            // 
            // editPassConfirmLBL
            // 
            this.editPassConfirmLBL.AutoSize = true;
            this.editPassConfirmLBL.Location = new System.Drawing.Point(248, 39);
            this.editPassConfirmLBL.Name = "editPassConfirmLBL";
            this.editPassConfirmLBL.Size = new System.Drawing.Size(131, 13);
            this.editPassConfirmLBL.TabIndex = 16;
            this.editPassConfirmLBL.Text = "Новый пароль (ещё раз)";
            // 
            // editPassLBL
            // 
            this.editPassLBL.AutoSize = true;
            this.editPassLBL.Location = new System.Drawing.Point(248, 0);
            this.editPassLBL.Name = "editPassLBL";
            this.editPassLBL.Size = new System.Drawing.Size(80, 13);
            this.editPassLBL.TabIndex = 15;
            this.editPassLBL.Text = "Новый пароль";
            // 
            // editLoginTB
            // 
            this.editLoginTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Логин", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.editLoginTB.Location = new System.Drawing.Point(12, 16);
            this.editLoginTB.Name = "editLoginTB";
            this.editLoginTB.Size = new System.Drawing.Size(230, 20);
            this.editLoginTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Логин";
            // 
            // usersList
            // 
            this.usersList.AllowUserToAddRows = false;
            this.usersList.AllowUserToDeleteRows = false;
            this.usersList.AllowUserToResizeColumns = false;
            this.usersList.AutoGenerateColumns = false;
            this.usersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn});
            this.usersList.ContextMenuStrip = this.rcMenu;
            this.usersList.DataSource = this.usersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersList.DefaultCellStyle = dataGridViewCellStyle1;
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.GridColor = System.Drawing.SystemColors.Window;
            this.usersList.Location = new System.Drawing.Point(0, 322);
            this.usersList.MultiSelect = false;
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.RowHeadersVisible = false;
            this.usersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersList.Size = new System.Drawing.Size(490, 180);
            this.usersList.TabIndex = 4;
            this.usersList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.usersList_RowsAdded);
            // 
            // rcMenu
            // 
            this.rcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rcEditShow,
            this.rcDeleteSelectedBTN});
            this.rcMenu.Name = "rcMenu";
            this.rcMenu.Size = new System.Drawing.Size(283, 48);
            // 
            // rcEditShow
            // 
            this.rcEditShow.Name = "rcEditShow";
            this.rcEditShow.Size = new System.Drawing.Size(282, 22);
            this.rcEditShow.Text = "Изменить выделенного пользователя";
            this.rcEditShow.Click += new System.EventHandler(this.rcEditShow_Click);
            // 
            // rcDeleteSelectedBTN
            // 
            this.rcDeleteSelectedBTN.Name = "rcDeleteSelectedBTN";
            this.rcDeleteSelectedBTN.Size = new System.Drawing.Size(282, 22);
            this.rcDeleteSelectedBTN.Text = "Удалить выделенного пользователя";
            this.rcDeleteSelectedBTN.Click += new System.EventHandler(this.deleteSelectedBTN_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодклиентаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.кодклиентаDataGridViewTextBoxColumn.Visible = false;
            this.кодклиентаDataGridViewTextBoxColumn.Width = 76;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            this.логинDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.логинDataGridViewTextBoxColumn.Width = 63;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            this.парольDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.парольDataGridViewTextBoxColumn.Width = 70;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.фИОDataGridViewTextBoxColumn.Width = 59;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерпаспортаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 502);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(506, 540);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление пользователями";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersForm_FormClosing);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.rcMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShowBTN;
        private System.Windows.Forms.ToolStripMenuItem editShowBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeThisForm;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.DataGridView usersList;
        private kinoDataSet kinoDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private kinoDataSetTableAdapters.КлиентыTableAdapter usersTableAdapter;
        private System.Windows.Forms.TextBox addLoginTB;
        private System.Windows.Forms.Label addLoginLBL;
        private System.Windows.Forms.Label addPassLBL;
        private System.Windows.Forms.Label addPassConfirmLBL;
        private System.Windows.Forms.MaskedTextBox addPassConfirmTB;
        private System.Windows.Forms.MaskedTextBox addPassTB;
        private System.Windows.Forms.Button addUserBTN;
        private System.Windows.Forms.TextBox addPassportTB;
        private System.Windows.Forms.Label addPassportLBL;
        private System.Windows.Forms.TextBox addNameTB;
        private System.Windows.Forms.Label addNameLBL;
        private System.Windows.Forms.MaskedTextBox editPassConfirmTB;
        private System.Windows.Forms.MaskedTextBox editPassTB;
        private System.Windows.Forms.Button editUserBTN;
        private System.Windows.Forms.TextBox editPassportTB;
        private System.Windows.Forms.Label editPassportLBL;
        private System.Windows.Forms.TextBox editNameTB;
        private System.Windows.Forms.Label editNameLBL;
        private System.Windows.Forms.Label editPassConfirmLBL;
        private System.Windows.Forms.Label editPassLBL;
        private System.Windows.Forms.TextBox editLoginTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip rcMenu;
        private System.Windows.Forms.ToolStripMenuItem rcEditShow;
        private System.Windows.Forms.ToolStripMenuItem rcDeleteSelectedBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
    }
}
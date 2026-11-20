namespace RealEstateCRM
{
    partial class PropertiesControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFilterDistrict = new System.Windows.Forms.Label();
            this.cmbFilterDistrict = new System.Windows.Forms.ComboBox();
            this.lblPriceFrom = new System.Windows.Forms.Label();
            this.nudPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.lblPriceTo = new System.Windows.Forms.Label();
            this.nudPriceTo = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblArea = new System.Windows.Forms.Label();
            this.nudArea = new System.Windows.Forms.NumericUpDown();
            this.lblRooms = new System.Windows.Forms.Label();
            this.nudRooms = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.btnRemovePhoto = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlFilter.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.grpProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblFilterType);
            this.pnlFilter.Controls.Add(this.cmbFilterType);
            this.pnlFilter.Controls.Add(this.lblFilterDistrict);
            this.pnlFilter.Controls.Add(this.cmbFilterDistrict);
            this.pnlFilter.Controls.Add(this.lblPriceFrom);
            this.pnlFilter.Controls.Add(this.nudPriceFrom);
            this.pnlFilter.Controls.Add(this.lblPriceTo);
            this.pnlFilter.Controls.Add(this.nudPriceTo);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1030, 72);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSearch.Location = new System.Drawing.Point(15, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Пошук (назва, адреса)";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(15, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFilterType.Location = new System.Drawing.Point(215, 8);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Text = "Тип";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.Items.AddRange(new object[] {
            "Всі типи",
            "Квартира",
            "Будинок",
            "Земельна ділянка"});
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(215, 32);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(155, 25);
            this.cmbFilterType.TabIndex = 1;
            // 
            // lblFilterDistrict
            // 
            this.lblFilterDistrict.AutoSize = true;
            this.lblFilterDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFilterDistrict.Location = new System.Drawing.Point(385, 8);
            this.lblFilterDistrict.Name = "lblFilterDistrict";
            this.lblFilterDistrict.Text = "Район";
            // 
            // cmbFilterDistrict
            // 
            this.cmbFilterDistrict.Items.AddRange(new object[] {
            "Всі райони",
            "Центральний",
            "Північний",
            "Південний",
            "Східний",
            "Західний",
            "Приміський"});
            this.cmbFilterDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFilterDistrict.FormattingEnabled = true;
            this.cmbFilterDistrict.Location = new System.Drawing.Point(385, 32);
            this.cmbFilterDistrict.Name = "cmbFilterDistrict";
            this.cmbFilterDistrict.Size = new System.Drawing.Size(150, 25);
            this.cmbFilterDistrict.TabIndex = 2;
            // 
            // lblPriceFrom
            // 
            this.lblPriceFrom.AutoSize = true;
            this.lblPriceFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPriceFrom.Location = new System.Drawing.Point(550, 8);
            this.lblPriceFrom.Name = "lblPriceFrom";
            this.lblPriceFrom.Text = "Ціна від, $";
            // 
            // nudPriceFrom
            // 
            this.nudPriceFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPriceFrom.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPriceFrom.Location = new System.Drawing.Point(550, 33);
            this.nudPriceFrom.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudPriceFrom.Name = "nudPriceFrom";
            this.nudPriceFrom.Size = new System.Drawing.Size(110, 25);
            this.nudPriceFrom.TabIndex = 3;
            this.nudPriceFrom.ThousandsSeparator = true;
            // 
            // lblPriceTo
            // 
            this.lblPriceTo.AutoSize = true;
            this.lblPriceTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPriceTo.Location = new System.Drawing.Point(675, 8);
            this.lblPriceTo.Name = "lblPriceTo";
            this.lblPriceTo.Text = "Ціна до, $";
            // 
            // nudPriceTo
            // 
            this.nudPriceTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPriceTo.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPriceTo.Location = new System.Drawing.Point(675, 33);
            this.nudPriceTo.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudPriceTo.Name = "nudPriceTo";
            this.nudPriceTo.Size = new System.Drawing.Size(110, 25);
            this.nudPriceTo.TabIndex = 4;
            this.nudPriceTo.ThousandsSeparator = true;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(800, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(105, 34);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Знайти";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(912, 28);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(105, 34);
            this.btnResetFilter.TabIndex = 6;
            this.btnResetFilter.Text = "Скинути";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvProperties);
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Location = new System.Drawing.Point(0, 82);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(640, 588);
            this.pnlList.TabIndex = 1;
            // 
            // dgvProperties
            // 
            this.dgvProperties.AllowUserToAddRows = false;
            this.dgvProperties.AllowUserToDeleteRows = false;
            this.dgvProperties.AllowUserToResizeRows = false;
            this.dgvProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProperties.BackgroundColor = System.Drawing.Color.White;
            this.dgvProperties.Location = new System.Drawing.Point(10, 10);
            this.dgvProperties.MultiSelect = false;
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.RowHeadersVisible = false;
            this.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProperties.Size = new System.Drawing.Size(620, 568);
            this.dgvProperties.TabIndex = 0;
            this.dgvProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProperties_CellClick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.grpProperty);
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Location = new System.Drawing.Point(650, 82);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(380, 588);
            this.pnlEdit.TabIndex = 2;
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.lblSelectedId);
            this.grpProperty.Controls.Add(this.lblTitle);
            this.grpProperty.Controls.Add(this.txtTitle);
            this.grpProperty.Controls.Add(this.lblType);
            this.grpProperty.Controls.Add(this.cmbType);
            this.grpProperty.Controls.Add(this.lblDistrict);
            this.grpProperty.Controls.Add(this.cmbDistrict);
            this.grpProperty.Controls.Add(this.lblAddress);
            this.grpProperty.Controls.Add(this.txtAddress);
            this.grpProperty.Controls.Add(this.lblPrice);
            this.grpProperty.Controls.Add(this.nudPrice);
            this.grpProperty.Controls.Add(this.lblArea);
            this.grpProperty.Controls.Add(this.nudArea);
            this.grpProperty.Controls.Add(this.lblRooms);
            this.grpProperty.Controls.Add(this.nudRooms);
            this.grpProperty.Controls.Add(this.lblDescription);
            this.grpProperty.Controls.Add(this.txtDescription);
            this.grpProperty.Controls.Add(this.picPhoto);
            this.grpProperty.Controls.Add(this.btnChoosePhoto);
            this.grpProperty.Controls.Add(this.btnRemovePhoto);
            this.grpProperty.Controls.Add(this.btnAdd);
            this.grpProperty.Controls.Add(this.btnSave);
            this.grpProperty.Controls.Add(this.btnDelete);
            this.grpProperty.Controls.Add(this.btnClear);
            this.grpProperty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpProperty.Location = new System.Drawing.Point(8, 5);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(364, 576);
            this.grpProperty.TabIndex = 0;
            this.grpProperty.Text = "Об'єкт нерухомості";
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSelectedId.Location = new System.Drawing.Point(12, 24);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Text = "Новий запис";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Назва *";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(12, 68);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(338, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblType.Location = new System.Drawing.Point(12, 98);
            this.lblType.Name = "lblType";
            this.lblType.Text = "Тип *";
            // 
            // cmbType
            // 
            this.cmbType.Items.AddRange(new object[] {
            "Квартира",
            "Будинок",
            "Земельна ділянка"});
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(12, 120);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(163, 25);
            this.cmbType.TabIndex = 1;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDistrict.Location = new System.Drawing.Point(187, 98);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Text = "Район *";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Items.AddRange(new object[] {
            "Центральний",
            "Північний",
            "Південний",
            "Східний",
            "Західний",
            "Приміський"});
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(187, 120);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(163, 25);
            this.cmbDistrict.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblAddress.Location = new System.Drawing.Point(12, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Адреса";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(12, 172);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(338, 25);
            this.txtAddress.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPrice.Location = new System.Drawing.Point(12, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Ціна, $ *";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPrice.Location = new System.Drawing.Point(12, 224);
            this.nudPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 25);
            this.nudPrice.TabIndex = 4;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblArea.Location = new System.Drawing.Point(140, 202);
            this.lblArea.Name = "lblArea";
            this.lblArea.Text = "Площа, м² *";
            // 
            // nudArea
            // 
            this.nudArea.DecimalPlaces = 1;
            this.nudArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudArea.Location = new System.Drawing.Point(140, 224);
            this.nudArea.Maximum = new decimal(new int[] { 999999, 0, 0, 0});
            this.nudArea.Name = "nudArea";
            this.nudArea.Size = new System.Drawing.Size(105, 25);
            this.nudArea.TabIndex = 5;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRooms.Location = new System.Drawing.Point(253, 202);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Text = "Кімнат";
            // 
            // nudRooms
            // 
            this.nudRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRooms.Location = new System.Drawing.Point(253, 224);
            this.nudRooms.Maximum = new decimal(new int[] { 50, 0, 0, 0});
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.Size = new System.Drawing.Size(97, 25);
            this.nudRooms.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDescription.Location = new System.Drawing.Point(12, 254);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "Опис";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(12, 276);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(338, 55);
            this.txtDescription.TabIndex = 7;
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(12, 340);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(215, 140);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.FlatAppearance.BorderSize = 0;
            this.btnChoosePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChoosePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChoosePhoto.Location = new System.Drawing.Point(235, 340);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(115, 40);
            this.btnChoosePhoto.TabIndex = 8;
            this.btnChoosePhoto.Text = "Обрати фото";
            this.btnChoosePhoto.UseVisualStyleBackColor = false;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // btnRemovePhoto
            // 
            this.btnRemovePhoto.FlatAppearance.BorderSize = 0;
            this.btnRemovePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnRemovePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePhoto.ForeColor = System.Drawing.Color.White;
            this.btnRemovePhoto.Location = new System.Drawing.Point(235, 388);
            this.btnRemovePhoto.Name = "btnRemovePhoto";
            this.btnRemovePhoto.Size = new System.Drawing.Size(115, 40);
            this.btnRemovePhoto.TabIndex = 9;
            this.btnRemovePhoto.Text = "Прибрати фото";
            this.btnRemovePhoto.UseVisualStyleBackColor = false;
            this.btnRemovePhoto.Click += new System.EventHandler(this.btnRemovePhoto_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 38);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(98, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(184, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 38);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(270, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 38);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Зображення (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            this.openFileDialog.Title = "Оберіть фотографію об'єкта";
            // 
            // PropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Name = "PropertiesControl";
            this.Load += new System.EventHandler(this.PropertiesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Label lblFilterDistrict;
        private System.Windows.Forms.ComboBox cmbFilterDistrict;
        private System.Windows.Forms.Label lblPriceFrom;
        private System.Windows.Forms.NumericUpDown nudPriceFrom;
        private System.Windows.Forms.Label lblPriceTo;
        private System.Windows.Forms.NumericUpDown nudPriceTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown nudArea;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.NumericUpDown nudRooms;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.Button btnRemovePhoto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

namespace RealEstateCRM
{
    partial class RequestsControl
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblMinArea = new System.Windows.Forms.Label();
            this.nudMinArea = new System.Windows.Forms.NumericUpDown();
            this.lblMaxArea = new System.Windows.Forms.Label();
            this.nudMaxArea = new System.Windows.Forms.NumericUpDown();
            this.lblMinBudget = new System.Windows.Forms.Label();
            this.nudMinBudget = new System.Windows.Forms.NumericUpDown();
            this.lblMaxBudget = new System.Windows.Forms.Label();
            this.nudMaxBudget = new System.Windows.Forms.NumericUpDown();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.nudRooms = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.grpRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.lblList);
            this.pnlList.Controls.Add(this.dgvRequests);
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(650, 670);
            this.pnlList.TabIndex = 0;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblList.Location = new System.Drawing.Point(12, 12);
            this.lblList.Name = "lblList";
            this.lblList.Text = "Список заявок клієнтів";
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AllowUserToResizeRows = false;
            this.dgvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.Location = new System.Drawing.Point(12, 45);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(626, 612);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellClick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.grpRequest);
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Location = new System.Drawing.Point(660, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(370, 670);
            this.pnlEdit.TabIndex = 1;
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.lblSelectedId);
            this.grpRequest.Controls.Add(this.lblClient);
            this.grpRequest.Controls.Add(this.cmbClient);
            this.grpRequest.Controls.Add(this.lblType);
            this.grpRequest.Controls.Add(this.cmbType);
            this.grpRequest.Controls.Add(this.lblMinArea);
            this.grpRequest.Controls.Add(this.nudMinArea);
            this.grpRequest.Controls.Add(this.lblMaxArea);
            this.grpRequest.Controls.Add(this.nudMaxArea);
            this.grpRequest.Controls.Add(this.lblMinBudget);
            this.grpRequest.Controls.Add(this.nudMinBudget);
            this.grpRequest.Controls.Add(this.lblMaxBudget);
            this.grpRequest.Controls.Add(this.nudMaxBudget);
            this.grpRequest.Controls.Add(this.lblDistrict);
            this.grpRequest.Controls.Add(this.cmbDistrict);
            this.grpRequest.Controls.Add(this.lblRooms);
            this.grpRequest.Controls.Add(this.nudRooms);
            this.grpRequest.Controls.Add(this.lblStatus);
            this.grpRequest.Controls.Add(this.cmbStatus);
            this.grpRequest.Controls.Add(this.lblHint);
            this.grpRequest.Controls.Add(this.btnAdd);
            this.grpRequest.Controls.Add(this.btnSave);
            this.grpRequest.Controls.Add(this.btnDelete);
            this.grpRequest.Controls.Add(this.btnClear);
            this.grpRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpRequest.Location = new System.Drawing.Point(10, 10);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(350, 570);
            this.grpRequest.TabIndex = 0;
            this.grpRequest.Text = "Заявка клієнта";
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSelectedId.Location = new System.Drawing.Point(12, 25);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Text = "Новий запис";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblClient.Location = new System.Drawing.Point(12, 50);
            this.lblClient.Name = "lblClient";
            this.lblClient.Text = "Клієнт *";
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(12, 72);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(325, 25);
            this.cmbClient.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblType.Location = new System.Drawing.Point(12, 105);
            this.lblType.Name = "lblType";
            this.lblType.Text = "Тип нерухомості *";
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
            this.cmbType.Location = new System.Drawing.Point(12, 127);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(325, 25);
            this.cmbType.TabIndex = 1;
            // 
            // lblMinArea
            // 
            this.lblMinArea.AutoSize = true;
            this.lblMinArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMinArea.Location = new System.Drawing.Point(12, 160);
            this.lblMinArea.Name = "lblMinArea";
            this.lblMinArea.Text = "Площа від, м²";
            // 
            // nudMinArea
            // 
            this.nudMinArea.DecimalPlaces = 1;
            this.nudMinArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMinArea.Location = new System.Drawing.Point(12, 182);
            this.nudMinArea.Maximum = new decimal(new int[] { 999999, 0, 0, 0});
            this.nudMinArea.Name = "nudMinArea";
            this.nudMinArea.Size = new System.Drawing.Size(155, 25);
            this.nudMinArea.TabIndex = 2;
            // 
            // lblMaxArea
            // 
            this.lblMaxArea.AutoSize = true;
            this.lblMaxArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMaxArea.Location = new System.Drawing.Point(182, 160);
            this.lblMaxArea.Name = "lblMaxArea";
            this.lblMaxArea.Text = "Площа до, м²";
            // 
            // nudMaxArea
            // 
            this.nudMaxArea.DecimalPlaces = 1;
            this.nudMaxArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMaxArea.Location = new System.Drawing.Point(182, 182);
            this.nudMaxArea.Maximum = new decimal(new int[] { 999999, 0, 0, 0});
            this.nudMaxArea.Name = "nudMaxArea";
            this.nudMaxArea.Size = new System.Drawing.Size(155, 25);
            this.nudMaxArea.TabIndex = 3;
            // 
            // lblMinBudget
            // 
            this.lblMinBudget.AutoSize = true;
            this.lblMinBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMinBudget.Location = new System.Drawing.Point(12, 215);
            this.lblMinBudget.Name = "lblMinBudget";
            this.lblMinBudget.Text = "Бюджет від, $";
            // 
            // nudMinBudget
            // 
            this.nudMinBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMinBudget.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudMinBudget.Location = new System.Drawing.Point(12, 237);
            this.nudMinBudget.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudMinBudget.Name = "nudMinBudget";
            this.nudMinBudget.Size = new System.Drawing.Size(155, 25);
            this.nudMinBudget.TabIndex = 4;
            this.nudMinBudget.ThousandsSeparator = true;
            // 
            // lblMaxBudget
            // 
            this.lblMaxBudget.AutoSize = true;
            this.lblMaxBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblMaxBudget.Location = new System.Drawing.Point(182, 215);
            this.lblMaxBudget.Name = "lblMaxBudget";
            this.lblMaxBudget.Text = "Бюджет до, $";
            // 
            // nudMaxBudget
            // 
            this.nudMaxBudget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMaxBudget.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudMaxBudget.Location = new System.Drawing.Point(182, 237);
            this.nudMaxBudget.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudMaxBudget.Name = "nudMaxBudget";
            this.nudMaxBudget.Size = new System.Drawing.Size(155, 25);
            this.nudMaxBudget.TabIndex = 5;
            this.nudMaxBudget.ThousandsSeparator = true;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDistrict.Location = new System.Drawing.Point(12, 270);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Text = "Бажаний район";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Items.AddRange(new object[] {
            "Будь-який",
            "Центральний",
            "Північний",
            "Південний",
            "Східний",
            "Західний",
            "Приміський"});
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(12, 292);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(155, 25);
            this.cmbDistrict.TabIndex = 6;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRooms.Location = new System.Drawing.Point(182, 270);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Text = "Кількість кімнат";
            // 
            // nudRooms
            // 
            this.nudRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRooms.Location = new System.Drawing.Point(182, 292);
            this.nudRooms.Maximum = new decimal(new int[] { 50, 0, 0, 0});
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.Size = new System.Drawing.Size(155, 25);
            this.nudRooms.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Статус заявки";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Активна",
            "Виконана",
            "Скасована"});
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(12, 347);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(155, 25);
            this.cmbStatus.TabIndex = 8;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = false;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHint.Location = new System.Drawing.Point(12, 382);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(325, 40);
            this.lblHint.Text = "Значення 0 або «Будь-який» означає, що критерій не важливий і не враховується при підборі.";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 38);
            this.btnAdd.TabIndex = 9;
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(179, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Зберегти зміни";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 38);
            this.btnDelete.TabIndex = 11;
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
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(179, 481);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистити поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RequestsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Name = "RequestsControl";
            this.Load += new System.EventHandler(this.RequestsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblMinArea;
        private System.Windows.Forms.NumericUpDown nudMinArea;
        private System.Windows.Forms.Label lblMaxArea;
        private System.Windows.Forms.NumericUpDown nudMaxArea;
        private System.Windows.Forms.Label lblMinBudget;
        private System.Windows.Forms.NumericUpDown nudMinBudget;
        private System.Windows.Forms.Label lblMaxBudget;
        private System.Windows.Forms.NumericUpDown nudMaxBudget;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.NumericUpDown nudRooms;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

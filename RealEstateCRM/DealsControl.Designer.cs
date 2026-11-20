namespace RealEstateCRM
{
    partial class DealsControl
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
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.grpDeal = new System.Windows.Forms.GroupBox();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.grpDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.lblList);
            this.pnlList.Controls.Add(this.dgvDeals);
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
            this.lblList.Text = "Усі угоди";
            // 
            // dgvDeals
            // 
            this.dgvDeals.AllowUserToAddRows = false;
            this.dgvDeals.AllowUserToDeleteRows = false;
            this.dgvDeals.AllowUserToResizeRows = false;
            this.dgvDeals.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvDeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeals.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeals.Location = new System.Drawing.Point(12, 45);
            this.dgvDeals.MultiSelect = false;
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.ReadOnly = true;
            this.dgvDeals.RowHeadersVisible = false;
            this.dgvDeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeals.Size = new System.Drawing.Size(626, 612);
            this.dgvDeals.TabIndex = 0;
            this.dgvDeals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeals_CellClick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.grpDeal);
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Location = new System.Drawing.Point(660, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(370, 670);
            this.pnlEdit.TabIndex = 1;
            // 
            // grpDeal
            // 
            this.grpDeal.Controls.Add(this.lblSelectedId);
            this.grpDeal.Controls.Add(this.lblClient);
            this.grpDeal.Controls.Add(this.cmbClient);
            this.grpDeal.Controls.Add(this.lblProperty);
            this.grpDeal.Controls.Add(this.cmbProperty);
            this.grpDeal.Controls.Add(this.lblDate);
            this.grpDeal.Controls.Add(this.dtpDate);
            this.grpDeal.Controls.Add(this.lblPrice);
            this.grpDeal.Controls.Add(this.nudPrice);
            this.grpDeal.Controls.Add(this.lblStatus);
            this.grpDeal.Controls.Add(this.cmbStatus);
            this.grpDeal.Controls.Add(this.lblHint);
            this.grpDeal.Controls.Add(this.btnAdd);
            this.grpDeal.Controls.Add(this.btnSave);
            this.grpDeal.Controls.Add(this.btnDelete);
            this.grpDeal.Controls.Add(this.btnClear);
            this.grpDeal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpDeal.Location = new System.Drawing.Point(10, 10);
            this.grpDeal.Name = "grpDeal";
            this.grpDeal.Size = new System.Drawing.Size(350, 500);
            this.grpDeal.TabIndex = 0;
            this.grpDeal.Text = "Угода";
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
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblProperty.Location = new System.Drawing.Point(12, 105);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Text = "Об'єкт нерухомості *";
            // 
            // cmbProperty
            // 
            this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProperty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(12, 127);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(325, 25);
            this.cmbProperty.TabIndex = 1;
            this.cmbProperty.SelectionChangeCommitted += new System.EventHandler(this.cmbProperty_SelectionChangeCommitted);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDate.Location = new System.Drawing.Point(12, 160);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Дата створення";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 182);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(155, 25);
            this.dtpDate.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPrice.Location = new System.Drawing.Point(182, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Ціна угоди, $ *";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPrice.Location = new System.Drawing.Point(182, 182);
            this.nudPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(155, 25);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.ThousandsSeparator = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Статус угоди";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "В пошуку",
            "Перегляд",
            "Завдаток",
            "Продано"});
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(12, 237);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(325, 25);
            this.cmbStatus.TabIndex = 4;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = false;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHint.Location = new System.Drawing.Point(12, 272);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(325, 40);
            this.lblHint.Text = "Щоб змінити етап угоди: оберіть її в таблиці, змініть статус і натисніть «Зберегти зміни».";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 38);
            this.btnAdd.TabIndex = 5;
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
            this.btnSave.Location = new System.Drawing.Point(179, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 38);
            this.btnSave.TabIndex = 6;
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
            this.btnDelete.Location = new System.Drawing.Point(12, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 38);
            this.btnDelete.TabIndex = 7;
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
            this.btnClear.Location = new System.Drawing.Point(179, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистити поля";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DealsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Name = "DealsControl";
            this.Load += new System.EventHandler(this.DealsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.grpDeal.ResumeLayout(false);
            this.grpDeal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dgvDeals;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox grpDeal;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

namespace RealEstateCRM
{
    partial class StatisticsControl
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
            this.pnlTotalDeals = new System.Windows.Forms.Panel();
            this.lblTotalDealsTitle = new System.Windows.Forms.Label();
            this.lblTotalDealsValue = new System.Windows.Forms.Label();
            this.pnlSold = new System.Windows.Forms.Panel();
            this.lblSoldTitle = new System.Windows.Forms.Label();
            this.lblSoldValue = new System.Windows.Forms.Label();
            this.pnlSum = new System.Windows.Forms.Panel();
            this.lblSumTitle = new System.Windows.Forms.Label();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.pnlByStatus = new System.Windows.Forms.Panel();
            this.lblByStatus = new System.Windows.Forms.Label();
            this.dgvByStatus = new System.Windows.Forms.DataGridView();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.lblExportTitle = new System.Windows.Forms.Label();
            this.lblExportInfo = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlTotalDeals.SuspendLayout();
            this.pnlSold.SuspendLayout();
            this.pnlSum.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.pnlByStatus.SuspendLayout();
            this.pnlExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTotalDeals
            // 
            this.pnlTotalDeals.Controls.Add(this.lblTotalDealsTitle);
            this.pnlTotalDeals.Controls.Add(this.lblTotalDealsValue);
            this.pnlTotalDeals.BackColor = System.Drawing.Color.White;
            this.pnlTotalDeals.Location = new System.Drawing.Point(0, 0);
            this.pnlTotalDeals.Name = "pnlTotalDeals";
            this.pnlTotalDeals.Size = new System.Drawing.Size(240, 105);
            this.pnlTotalDeals.TabIndex = 0;
            // 
            // lblTotalDealsTitle
            // 
            this.lblTotalDealsTitle.AutoSize = true;
            this.lblTotalDealsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDealsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalDealsTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTotalDealsTitle.Name = "lblTotalDealsTitle";
            this.lblTotalDealsTitle.Text = "Усього угод";
            // 
            // lblTotalDealsValue
            // 
            this.lblTotalDealsValue.AutoSize = true;
            this.lblTotalDealsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDealsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTotalDealsValue.Location = new System.Drawing.Point(15, 40);
            this.lblTotalDealsValue.Name = "lblTotalDealsValue";
            this.lblTotalDealsValue.Text = "0";
            // 
            // pnlSold
            // 
            this.pnlSold.Controls.Add(this.lblSoldTitle);
            this.pnlSold.Controls.Add(this.lblSoldValue);
            this.pnlSold.BackColor = System.Drawing.Color.White;
            this.pnlSold.Location = new System.Drawing.Point(260, 0);
            this.pnlSold.Name = "pnlSold";
            this.pnlSold.Size = new System.Drawing.Size(240, 105);
            this.pnlSold.TabIndex = 1;
            // 
            // lblSoldTitle
            // 
            this.lblSoldTitle.AutoSize = true;
            this.lblSoldTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoldTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSoldTitle.Location = new System.Drawing.Point(15, 12);
            this.lblSoldTitle.Name = "lblSoldTitle";
            this.lblSoldTitle.Text = "Продано об'єктів";
            // 
            // lblSoldValue
            // 
            this.lblSoldValue.AutoSize = true;
            this.lblSoldValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoldValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblSoldValue.Location = new System.Drawing.Point(15, 40);
            this.lblSoldValue.Name = "lblSoldValue";
            this.lblSoldValue.Text = "0";
            // 
            // pnlSum
            // 
            this.pnlSum.Controls.Add(this.lblSumTitle);
            this.pnlSum.Controls.Add(this.lblSumValue);
            this.pnlSum.BackColor = System.Drawing.Color.White;
            this.pnlSum.Location = new System.Drawing.Point(520, 0);
            this.pnlSum.Name = "pnlSum";
            this.pnlSum.Size = new System.Drawing.Size(240, 105);
            this.pnlSum.TabIndex = 2;
            // 
            // lblSumTitle
            // 
            this.lblSumTitle.AutoSize = true;
            this.lblSumTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSumTitle.Location = new System.Drawing.Point(15, 12);
            this.lblSumTitle.Name = "lblSumTitle";
            this.lblSumTitle.Text = "Сума продажів, $";
            // 
            // lblSumValue
            // 
            this.lblSumValue.AutoSize = true;
            this.lblSumValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSumValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblSumValue.Location = new System.Drawing.Point(15, 40);
            this.lblSumValue.Name = "lblSumValue";
            this.lblSumValue.Text = "0";
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.lblActiveTitle);
            this.pnlActive.Controls.Add(this.lblActiveValue);
            this.pnlActive.BackColor = System.Drawing.Color.White;
            this.pnlActive.Location = new System.Drawing.Point(780, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(240, 105);
            this.pnlActive.TabIndex = 3;
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblActiveTitle.Location = new System.Drawing.Point(15, 12);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Text = "Активних угод";
            // 
            // lblActiveValue
            // 
            this.lblActiveValue.AutoSize = true;
            this.lblActiveValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActiveValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblActiveValue.Location = new System.Drawing.Point(15, 40);
            this.lblActiveValue.Name = "lblActiveValue";
            this.lblActiveValue.Text = "0";
            // 
            // pnlByStatus
            // 
            this.pnlByStatus.Controls.Add(this.lblByStatus);
            this.pnlByStatus.Controls.Add(this.dgvByStatus);
            this.pnlByStatus.BackColor = System.Drawing.Color.White;
            this.pnlByStatus.Location = new System.Drawing.Point(0, 125);
            this.pnlByStatus.Name = "pnlByStatus";
            this.pnlByStatus.Size = new System.Drawing.Size(640, 330);
            this.pnlByStatus.TabIndex = 4;
            // 
            // lblByStatus
            // 
            this.lblByStatus.AutoSize = true;
            this.lblByStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblByStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblByStatus.Location = new System.Drawing.Point(15, 12);
            this.lblByStatus.Name = "lblByStatus";
            this.lblByStatus.Text = "Угоди за етапами";
            // 
            // dgvByStatus
            // 
            this.dgvByStatus.AllowUserToAddRows = false;
            this.dgvByStatus.AllowUserToDeleteRows = false;
            this.dgvByStatus.AllowUserToResizeRows = false;
            this.dgvByStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.dgvByStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvByStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvByStatus.Location = new System.Drawing.Point(15, 45);
            this.dgvByStatus.MultiSelect = false;
            this.dgvByStatus.Name = "dgvByStatus";
            this.dgvByStatus.ReadOnly = true;
            this.dgvByStatus.RowHeadersVisible = false;
            this.dgvByStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvByStatus.Size = new System.Drawing.Size(610, 270);
            this.dgvByStatus.TabIndex = 0;
            // 
            // pnlExport
            // 
            this.pnlExport.Controls.Add(this.lblExportTitle);
            this.pnlExport.Controls.Add(this.lblExportInfo);
            this.pnlExport.Controls.Add(this.btnExport);
            this.pnlExport.Controls.Add(this.btnRefresh);
            this.pnlExport.BackColor = System.Drawing.Color.White;
            this.pnlExport.Location = new System.Drawing.Point(660, 125);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(370, 330);
            this.pnlExport.TabIndex = 5;
            // 
            // lblExportTitle
            // 
            this.lblExportTitle.AutoSize = true;
            this.lblExportTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblExportTitle.Location = new System.Drawing.Point(15, 12);
            this.lblExportTitle.Name = "lblExportTitle";
            this.lblExportTitle.Text = "Звіт";
            // 
            // lblExportInfo
            // 
            this.lblExportInfo.AutoSize = false;
            this.lblExportInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExportInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblExportInfo.Location = new System.Drawing.Point(15, 45);
            this.lblExportInfo.Name = "lblExportInfo";
            this.lblExportInfo.Size = new System.Drawing.Size(340, 70);
            this.lblExportInfo.Text = "Excel-файл міститиме аркуш «Статистика» з основними показниками та аркуш «Угоди» зі списком усіх угод.";
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(15, 130);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(340, 45);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Експорт в Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(15, 185);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(340, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Оновити дані";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            this.saveFileDialog.Title = "Збереження статистики";
            // 
            // StatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnlTotalDeals);
            this.Controls.Add(this.pnlSold);
            this.Controls.Add(this.pnlSum);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.pnlByStatus);
            this.Controls.Add(this.pnlExport);
            this.Name = "StatisticsControl";
            this.Load += new System.EventHandler(this.StatisticsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByStatus)).EndInit();
            this.pnlTotalDeals.ResumeLayout(false);
            this.pnlTotalDeals.PerformLayout();
            this.pnlSold.ResumeLayout(false);
            this.pnlSold.PerformLayout();
            this.pnlSum.ResumeLayout(false);
            this.pnlSum.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.pnlByStatus.ResumeLayout(false);
            this.pnlByStatus.PerformLayout();
            this.pnlExport.ResumeLayout(false);
            this.pnlExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTotalDeals;
        private System.Windows.Forms.Label lblTotalDealsTitle;
        private System.Windows.Forms.Label lblTotalDealsValue;
        private System.Windows.Forms.Panel pnlSold;
        private System.Windows.Forms.Label lblSoldTitle;
        private System.Windows.Forms.Label lblSoldValue;
        private System.Windows.Forms.Panel pnlSum;
        private System.Windows.Forms.Label lblSumTitle;
        private System.Windows.Forms.Label lblSumValue;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Panel pnlByStatus;
        private System.Windows.Forms.Label lblByStatus;
        private System.Windows.Forms.DataGridView dgvByStatus;
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Label lblExportTitle;
        private System.Windows.Forms.Label lblExportInfo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

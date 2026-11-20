namespace RealEstateCRM
{
    partial class MatchingControl
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblRequest = new System.Windows.Forms.Label();
            this.cmbRequest = new System.Windows.Forms.ComboBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.lblRequestInfo = new System.Windows.Forms.Label();
            this.lblScoring = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblRequest);
            this.pnlTop.Controls.Add(this.cmbRequest);
            this.pnlTop.Controls.Add(this.btnMatch);
            this.pnlTop.Controls.Add(this.lblRequestInfo);
            this.pnlTop.Controls.Add(this.lblScoring);
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1030, 145);
            this.pnlTop.TabIndex = 0;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRequest.Location = new System.Drawing.Point(15, 12);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Text = "Оберіть активну заявку клієнта:";
            // 
            // cmbRequest
            // 
            this.cmbRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRequest.FormattingEnabled = true;
            this.cmbRequest.Location = new System.Drawing.Point(15, 38);
            this.cmbRequest.Name = "cmbRequest";
            this.cmbRequest.Size = new System.Drawing.Size(520, 25);
            this.cmbRequest.TabIndex = 0;
            // 
            // btnMatch
            // 
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMatch.ForeColor = System.Drawing.Color.White;
            this.btnMatch.Location = new System.Drawing.Point(550, 32);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(220, 38);
            this.btnMatch.TabIndex = 1;
            this.btnMatch.Text = "Підібрати об'єкти";
            this.btnMatch.UseVisualStyleBackColor = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // lblRequestInfo
            // 
            this.lblRequestInfo.AutoSize = false;
            this.lblRequestInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequestInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRequestInfo.Location = new System.Drawing.Point(15, 82);
            this.lblRequestInfo.Name = "lblRequestInfo";
            this.lblRequestInfo.Size = new System.Drawing.Size(1000, 25);
            this.lblRequestInfo.Text = "Вимоги заявки з'являться тут після підбору.";
            // 
            // lblScoring
            // 
            this.lblScoring.AutoSize = false;
            this.lblScoring.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblScoring.Location = new System.Drawing.Point(15, 110);
            this.lblScoring.Name = "lblScoring";
            this.lblScoring.Size = new System.Drawing.Size(1000, 22);
            this.lblScoring.Text = "Бали: бюджет — 40, площа — 25, район — 20, кімнати — 15. Тип нерухомості має збігатися обов'язково.";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblResults);
            this.pnlResults.Controls.Add(this.dgvResults);
            this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlResults.BackColor = System.Drawing.Color.White;
            this.pnlResults.Location = new System.Drawing.Point(0, 155);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(1030, 515);
            this.pnlResults.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblResults.Location = new System.Drawing.Point(15, 12);
            this.lblResults.Name = "lblResults";
            this.lblResults.Text = "Результати підбору";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.Location = new System.Drawing.Point(15, 45);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1000, 455);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvResults_DataBindingComplete);
            // 
            // MatchingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlResults);
            this.Name = "MatchingControl";
            this.Load += new System.EventHandler(this.MatchingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.ComboBox cmbRequest;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label lblRequestInfo;
        private System.Windows.Forms.Label lblScoring;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}

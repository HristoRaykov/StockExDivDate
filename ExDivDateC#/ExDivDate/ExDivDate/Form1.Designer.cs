using System.Windows.Forms;

namespace ExDivDate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tickers = new System.Windows.Forms.TextBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.stockGridView = new System.Windows.Forms.DataGridView();
            this.tickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exDivDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dividendColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tickers
            // 
            this.tickers.AcceptsReturn = true;
            this.tickers.AcceptsTab = true;
            this.tickers.AllowDrop = true;
            resources.ApplyResources(this.tickers, "tickers");
            this.tickers.Name = "tickers";
            // 
            // getDataButton
            // 
            resources.ApplyResources(this.getDataButton, "getDataButton");
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // stockGridView
            // 
            this.stockGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.stockGridView, "stockGridView");
            this.stockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.stockGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.stockGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stockGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stockGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickerColumn,
            this.exDivDateColumn,
            this.dividendColumn});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.ReadOnly = true;
            this.stockGridView.RowHeadersVisible = false;
            this.stockGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGridView.StandardTab = true;
            // 
            // tickerColumn
            // 
            this.tickerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tickerColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.tickerColumn.FillWeight = 96.99647F;
            resources.ApplyResources(this.tickerColumn, "tickerColumn");
            this.tickerColumn.Name = "tickerColumn";
            this.tickerColumn.ReadOnly = true;
            // 
            // exDivDateColumn
            // 
            this.exDivDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exDivDateColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.exDivDateColumn.FillWeight = 106.0071F;
            resources.ApplyResources(this.exDivDateColumn, "exDivDateColumn");
            this.exDivDateColumn.Name = "exDivDateColumn";
            this.exDivDateColumn.ReadOnly = true;
            // 
            // dividendColumn
            // 
            this.dividendColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dividendColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.dividendColumn.FillWeight = 96.99647F;
            resources.ApplyResources(this.dividendColumn, "dividendColumn");
            this.dividendColumn.Name = "dividendColumn";
            this.dividendColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.getDataButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.stockGridView);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.tickers);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tickers;
        private System.Windows.Forms.Button getDataButton;
        private DataGridView stockGridView;
        private DataGridViewTextBoxColumn tickerColumn;
        private DataGridViewTextBoxColumn exDivDateColumn;
        private DataGridViewTextBoxColumn dividendColumn;
    }
}


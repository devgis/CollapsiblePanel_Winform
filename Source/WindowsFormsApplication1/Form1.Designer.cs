namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.collapsiblePanel1 = new OVT.CustomControls.CollapsiblePanel();
            this.collapsiblePanel2 = new OVT.CustomControls.CollapsiblePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel1.Controls.Add(this.dataGridView1);
            this.collapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsiblePanel1.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.collapsiblePanel1.HeaderImage = null;
            this.collapsiblePanel1.HeaderText = "CollapsiblePanel";
            this.collapsiblePanel1.HeaderTextColor = System.Drawing.Color.Black;
            this.collapsiblePanel1.Location = new System.Drawing.Point(0, 0);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.Size = new System.Drawing.Size(467, 117);
            this.collapsiblePanel1.TabIndex = 0;
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapsiblePanel2.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.collapsiblePanel2.HeaderImage = null;
            this.collapsiblePanel2.HeaderText = "CollapsiblePanel";
            this.collapsiblePanel2.HeaderTextColor = System.Drawing.Color.Black;
            this.collapsiblePanel2.Location = new System.Drawing.Point(0, 117);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.Size = new System.Drawing.Size(467, 156);
            this.collapsiblePanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(467, 87);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 273);
            this.Controls.Add(this.collapsiblePanel2);
            this.Controls.Add(this.collapsiblePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.collapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OVT.CustomControls.CollapsiblePanel collapsiblePanel1;
        private OVT.CustomControls.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}


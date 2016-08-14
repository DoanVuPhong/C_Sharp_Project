namespace DXApp
{
    partial class frmOrder
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
            this.panel0 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChoiceSearch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchByDate = new System.Windows.Forms.Button();
            this.chDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchByRangeDate = new System.Windows.Forms.Button();
            this.chDateTo = new System.Windows.Forms.DateTimePicker();
            this.chDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errID = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.label11);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Controls.Add(this.btnSearchByName);
            this.panel0.Controls.Add(this.txtSearchByName);
            this.panel0.Location = new System.Drawing.Point(12, 70);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(350, 95);
            this.panel0.TabIndex = 0;
            this.panel0.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(270, 35);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByName.TabIndex = 1;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(73, 38);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(165, 20);
            this.txtSearchByName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbChoiceSearch
            // 
            this.cbbChoiceSearch.FormattingEnabled = true;
            this.cbbChoiceSearch.Items.AddRange(new object[] {
            "Customer Name",
            "Date",
            "Range Date",
            "ID Order"});
            this.cbbChoiceSearch.Location = new System.Drawing.Point(113, 46);
            this.cbbChoiceSearch.Name = "cbbChoiceSearch";
            this.cbbChoiceSearch.Size = new System.Drawing.Size(121, 21);
            this.cbbChoiceSearch.TabIndex = 2;
            this.cbbChoiceSearch.SelectedIndexChanged += new System.EventHandler(this.cbbChoiceSearch_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearchByDate);
            this.panel1.Controls.Add(this.chDate);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 116);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search by Date";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearchByDate
            // 
            this.txtSearchByDate.Location = new System.Drawing.Point(270, 41);
            this.txtSearchByDate.Name = "txtSearchByDate";
            this.txtSearchByDate.Size = new System.Drawing.Size(75, 23);
            this.txtSearchByDate.TabIndex = 3;
            this.txtSearchByDate.Text = "Search";
            this.txtSearchByDate.UseVisualStyleBackColor = true;
            this.txtSearchByDate.Click += new System.EventHandler(this.txtSearchByDate_Click);
            // 
            // chDate
            // 
            this.chDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDate.Location = new System.Drawing.Point(73, 44);
            this.chDate.Name = "chDate";
            this.chDate.Size = new System.Drawing.Size(165, 20);
            this.chDate.TabIndex = 2;
            this.chDate.ValueChanged += new System.EventHandler(this.chDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSearchByRangeDate);
            this.panel2.Controls.Add(this.chDateTo);
            this.panel2.Controls.Add(this.chDateFrom);
            this.panel2.Location = new System.Drawing.Point(1, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 116);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search by Range Date";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearchByRangeDate
            // 
            this.btnSearchByRangeDate.Location = new System.Drawing.Point(330, 47);
            this.btnSearchByRangeDate.Name = "btnSearchByRangeDate";
            this.btnSearchByRangeDate.Size = new System.Drawing.Size(75, 34);
            this.btnSearchByRangeDate.TabIndex = 1;
            this.btnSearchByRangeDate.Text = "Search";
            this.btnSearchByRangeDate.UseVisualStyleBackColor = true;
            this.btnSearchByRangeDate.Click += new System.EventHandler(this.btnSearchByRangeDate_Click);
            // 
            // chDateTo
            // 
            this.chDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateTo.Location = new System.Drawing.Point(112, 71);
            this.chDateTo.Name = "chDateTo";
            this.chDateTo.Size = new System.Drawing.Size(160, 20);
            this.chDateTo.TabIndex = 0;
            // 
            // chDateFrom
            // 
            this.chDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateFrom.Location = new System.Drawing.Point(112, 37);
            this.chDateFrom.Name = "chDateFrom";
            this.chDateFrom.Size = new System.Drawing.Size(160, 20);
            this.chDateFrom.TabIndex = 0;
            this.chDateFrom.ValueChanged += new System.EventHandler(this.chDateFrom_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnSearchByID);
            this.panel3.Controls.Add(this.txtSearchByID);
            this.panel3.Location = new System.Drawing.Point(12, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 84);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Search by ID";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(188, 38);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByID.TabIndex = 1;
            this.btnSearchByID.Text = "Search";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(73, 40);
            this.txtSearchByID.MaxLength = 250;
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(82, 20);
            this.txtSearchByID.TabIndex = 0;
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrder.Location = new System.Drawing.Point(29, 192);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(377, 184);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(24, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Order Manager";
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // errID
            // 
            this.errID.ContainerControl = this;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrderDetail.Location = new System.Drawing.Point(470, 101);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(369, 275);
            this.dgvOrderDetail.TabIndex = 5;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            this.dgvOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(466, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Order Detail";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 402);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbbChoiceSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmOrder";
            this.Text = "Order Manager";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChoiceSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DateTimePicker chDate;
        private System.Windows.Forms.Button txtSearchByDate;
        private System.Windows.Forms.Button btnSearchByRangeDate;
        private System.Windows.Forms.DateTimePicker chDateTo;
        private System.Windows.Forms.DateTimePicker chDateFrom;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errID;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label12;
    }
}
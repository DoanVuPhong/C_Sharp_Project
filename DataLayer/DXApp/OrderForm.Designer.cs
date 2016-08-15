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
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chDateTo = new System.Windows.Forms.DateTimePicker();
            this.chDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errID = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Customer Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(121, 47);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(148, 20);
            this.txtSearchByName.TabIndex = 0;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(7, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "From Date";
            // 
            // chDateTo
            // 
            this.chDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateTo.Location = new System.Drawing.Point(121, 102);
            this.chDateTo.Name = "chDateTo";
            this.chDateTo.Size = new System.Drawing.Size(148, 20);
            this.chDateTo.TabIndex = 0;
            // 
            // chDateFrom
            // 
            this.chDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chDateFrom.Location = new System.Drawing.Point(121, 75);
            this.chDateFrom.Name = "chDateFrom";
            this.chDateFrom.Size = new System.Drawing.Size(148, 20);
            this.chDateFrom.TabIndex = 0;
            this.chDateFrom.ValueChanged += new System.EventHandler(this.chDateFrom_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Order ID";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(121, 21);
            this.txtSearchByID.MaxLength = 250;
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(88, 20);
            this.txtSearchByID.TabIndex = 0;
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrder.Location = new System.Drawing.Point(29, 225);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(340, 151);
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
            this.dgvOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderDetail.Location = new System.Drawing.Point(420, 75);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.Size = new System.Drawing.Size(446, 301);
            this.dgvOrderDetail.TabIndex = 5;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            this.dgvOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(416, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Order Detail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCustomSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSearchByName);
            this.groupBox1.Controls.Add(this.txtSearchByID);
            this.groupBox1.Controls.Add(this.chDateFrom);
            this.groupBox1.Controls.Add(this.chDateTo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(29, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Search";
            // 
            // btnCustomSearch
            // 
            this.btnCustomSearch.Location = new System.Drawing.Point(121, 143);
            this.btnCustomSearch.Name = "btnCustomSearch";
            this.btnCustomSearch.Size = new System.Drawing.Size(88, 23);
            this.btnCustomSearch.TabIndex = 5;
            this.btnCustomSearch.Text = "Search";
            this.btnCustomSearch.UseVisualStyleBackColor = true;
            this.btnCustomSearch.Click += new System.EventHandler(this.btnCustomSearch_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOrder);
            this.Name = "frmOrder";
            this.Text = "Order Manager";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DateTimePicker chDateTo;
        private System.Windows.Forms.DateTimePicker chDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errID;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomSearch;
    }
}
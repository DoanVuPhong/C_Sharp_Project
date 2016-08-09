namespace DXApp
{
    partial class PublisherForm
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
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.AllowUserToAddRows = false;
            this.dgvPublisher.AllowUserToDeleteRows = false;
            this.dgvPublisher.AllowUserToResizeColumns = false;
            this.dgvPublisher.AllowUserToResizeRows = false;
            this.dgvPublisher.Location = new System.Drawing.Point(12, 57);
            this.dgvPublisher.MultiSelect = false;
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.Size = new System.Drawing.Size(236, 161);
            this.dgvPublisher.TabIndex = 0;
            this.dgvPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPublisher_CellClick);
            this.dgvPublisher.Leave += new System.EventHandler(this.dgvPublisher_Leave);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(339, 57);
            this.txtID.MaxLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(159, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(339, 101);
            this.txtName.MaxLength = 249;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(339, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add new Publisher";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher Manager";
            // 
            // errID
            // 
            this.errID.ContainerControl = this;
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvPublisher);
            this.Name = "PublisherForm";
            this.Text = "Publisher Manager";
            this.Load += new System.EventHandler(this.PublisherForm_Load);
            this.Click += new System.EventHandler(this.PublisherForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublisher;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errID;
        private System.Windows.Forms.ErrorProvider errName;
    }
}
namespace DXApp
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.btnCategory = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.AppearanceGroupText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCategory.AppearanceGroupText.Options.UseFont = true;
            this.btnCategory.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCategory.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnCategory.AppearanceItem.Normal.Options.UseFont = true;
            this.btnCategory.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.btnCategory.AppearanceItem.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCategory.AppearanceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCategory.AppearanceText.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCategory.AppearanceText.Options.UseFont = true;
            this.btnCategory.AppearanceText.Options.UseTextOptions = true;
            this.btnCategory.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnCategory.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategory.BackgroundImage")));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategory.DragSize = new System.Drawing.Size(0, 0);
            this.btnCategory.Groups.Add(this.tileGroup3);
            this.btnCategory.Groups.Add(this.tileGroup2);
            this.btnCategory.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btnCategory.Location = new System.Drawing.Point(0, 0);
            this.btnCategory.MaxId = 18;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(790, 511);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Category";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem2);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.Text = "";
            this.tileItem2.Elements.Add(tileItemElement1);
            this.tileItem2.Id = 8;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem1
            // 
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "Book Order";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 17;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Padding = new System.Windows.Forms.Padding(0);
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 511);
            this.Controls.Add(this.btnCategory);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl btnCategory;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}
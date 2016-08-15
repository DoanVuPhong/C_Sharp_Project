namespace DXApp
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
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.btnCategory = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btnBookManager = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.btnCagatory = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
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
            this.btnCategory.Size = new System.Drawing.Size(812, 478);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.btnBookManager);
            this.tileGroup3.Items.Add(this.tileItem2);
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // btnBookManager
            // 
            this.btnBookManager.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBookManager.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookManager.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnBookManager.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement7.Image")));
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement7.Text = "Book Management";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.btnBookManager.Elements.Add(tileItemElement7);
            this.btnBookManager.Id = 9;
            this.btnBookManager.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.btnBookManager.Name = "btnBookManager";
            this.btnBookManager.Padding = new System.Windows.Forms.Padding(0);
            this.btnBookManager.CheckedChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnBookManager_CheckedChanged);
            this.btnBookManager.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnBookManager_ItemClick);
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement8.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement8.Image")));
            tileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement8.Text = "";
            this.tileItem2.Elements.Add(tileItemElement8);
            this.tileItem2.Id = 8;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick_1);
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement9.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement9.Image")));
            tileItemElement9.Text = "Author Management";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem4.Elements.Add(tileItemElement9);
            this.tileItem4.Id = 11;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.Padding = new System.Windows.Forms.Padding(0);
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.btnCagatory);
            this.tileGroup2.Items.Add(this.tileItem5);
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // btnCagatory
            // 
            tileItemElement10.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement10.Image")));
            tileItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement10.Text = "Category";
            this.btnCagatory.Elements.Add(tileItemElement10);
            this.btnCagatory.Id = 15;
            this.btnCagatory.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.btnCagatory.Name = "btnCagatory";
            this.btnCagatory.Padding = new System.Windows.Forms.Padding(0);
            this.btnCagatory.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnCagatory_ItemClick);
            // 
            // tileItem5
            // 
            this.tileItem5.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItem5.AppearanceItem.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tileItem5.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileItem5.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileItem5.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem5.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileItem5.AppearanceItem.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            tileItemElement11.Image = global::DXApp.Properties.Resources.print;
            tileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement11.Text = "Publisher";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem5.Elements.Add(tileItemElement11);
            this.tileItem5.Id = 12;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // tileItem1
            // 
            tileItemElement12.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement12.Image")));
            tileItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement12.Text = "Book Order";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem1.Elements.Add(tileItemElement12);
            this.tileItem1.Id = 17;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Padding = new System.Windows.Forms.Padding(0);
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 478);
            this.Controls.Add(this.btnCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl btnCategory;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem btnBookManager;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem btnCagatory;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}


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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.btnBookOrder = new System.Windows.Forms.Button();
            this.btnCategory = new DevExpress.XtraEditors.TileControl();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btnBookManager = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.btnCagatory = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // btnBookOrder
            // 
            this.btnBookOrder.Location = new System.Drawing.Point(571, 322);
            this.btnBookOrder.Name = "btnBookOrder";
            this.btnBookOrder.Size = new System.Drawing.Size(75, 23);
            this.btnBookOrder.TabIndex = 1;
            this.btnBookOrder.Text = "Book Order";
            this.btnBookOrder.UseVisualStyleBackColor = true;
            this.btnBookOrder.Click += new System.EventHandler(this.btnBookOrder_Click);
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
            this.btnCategory.MaxId = 17;
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
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            tileItemElement1.Text = "Book Management";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.btnBookManager.Elements.Add(tileItemElement1);
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
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.Text = "";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 8;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick_1);
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileItem4.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.Text = "Author Management";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem4.Elements.Add(tileItemElement3);
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
            this.tileGroup2.Name = "tileGroup2";
            // 
            // btnCagatory
            // 
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement4.Text = "Category";
            this.btnCagatory.Elements.Add(tileItemElement4);
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
            tileItemElement5.Image = global::DXApp.Properties.Resources.print;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.Text = "Publisher";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItem5.Elements.Add(tileItemElement5);
            this.tileItem5.Id = 12;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 478);
            this.Controls.Add(this.btnBookOrder);
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
        private System.Windows.Forms.Button btnBookOrder;
    }
}


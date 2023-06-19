namespace MotoBikeDealer
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton8 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton9 = new ToolStripButton();
            listView3 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            toolStrip3 = new ToolStrip();
            toolStripLabel3 = new ToolStripLabel();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(0, 49);
            listView1.Name = "listView1";
            listView1.Size = new Size(354, 186);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += SegmentleriListele;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MARKALAR";
            columnHeader1.Width = 330;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = Color.SlateGray;
            toolStrip2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator7, toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripSeparator5, toolStripButton3 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.Professional;
            toolStrip2.Size = new Size(340, 46);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(55, 43);
            toolStripLabel1.Text = "1. Adım";
            toolStripLabel1.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 46);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.vehicle_motorcycle_add;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(68, 43);
            toolStripButton1.Text = "Marka Ekle";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += MarkaEkle;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = SystemColors.ActiveCaptionText;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 46);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.vehicle_motorcycle_update;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(91, 43);
            toolStripButton2.Text = "Marka Düzenle";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.Click += MarkaDüzenle;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 46);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.vehicle_motorcycle_cancel;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(60, 43);
            toolStripButton3.Text = "Marka Sil";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton3.Click += MarkaSil;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.FullRowSelect = true;
            listView2.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView2.Location = new Point(0, 49);
            listView2.Name = "listView2";
            listView2.Size = new Size(354, 273);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += ModelleriListele;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SEGMENTLER";
            columnHeader2.Width = 330;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.SlateGray;
            toolStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripSeparator8, toolStripButton7, toolStripSeparator2, toolStripButton8, toolStripSeparator4, toolStripButton9 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(340, 46);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(55, 43);
            toolStripLabel2.Text = "2. Adım";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 46);
            // 
            // toolStripButton7
            // 
            toolStripButton7.Image = Properties.Resources.dashboard_add;
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(83, 43);
            toolStripButton7.Text = "Segment Ekle";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton7.Click += SegmentEkle;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 46);
            // 
            // toolStripButton8
            // 
            toolStripButton8.Image = Properties.Resources.dashboard_refresh;
            toolStripButton8.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(106, 43);
            toolStripButton8.Text = "Segment Düzenle";
            toolStripButton8.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton8.Click += SegmentDüzenle;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 46);
            // 
            // toolStripButton9
            // 
            toolStripButton9.Image = Properties.Resources.dashboard_cancel;
            toolStripButton9.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(75, 43);
            toolStripButton9.Text = "Segment Sil";
            toolStripButton9.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton9.Click += SegmentSil;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.FullRowSelect = true;
            listView3.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView3.Location = new Point(-1, 49);
            listView3.Name = "listView3";
            listView3.Size = new Size(682, 511);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MODEL ADI";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "YILI";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "BEYGIRI";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "HACIMI";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "RENGI";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "FIYATI";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "STOK";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "TANIMI";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 170;
            // 
            // toolStrip3
            // 
            toolStrip3.AllowMerge = false;
            toolStrip3.BackColor = Color.SlateGray;
            toolStrip3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripLabel3, toolStripSeparator9, toolStripButton4, toolStripSeparator6, toolStripButton5, toolStripSeparator3, toolStripButton6 });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RenderMode = ToolStripRenderMode.Professional;
            toolStrip3.Size = new Size(681, 46);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(55, 43);
            toolStripLabel3.Text = "3. Adım";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 46);
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.list_add;
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(69, 43);
            toolStripButton4.Text = "Model Ekle";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton4.Click += ModelEkle;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 46);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.list_update;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(92, 43);
            toolStripButton5.Text = "Model Düzenle";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton5.Click += ModelDüzenle;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 46);
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.list_cancel;
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(61, 43);
            toolStripButton6.Text = "Model Sil";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton6.Click += ModelSil;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.SlateGray;
            statusStrip1.Location = new Point(0, 563);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1025, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView3);
            splitContainer1.Panel2.Controls.Add(toolStrip3);
            splitContainer1.Size = new Size(1025, 560);
            splitContainer1.SplitterDistance = 340;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listView1);
            splitContainer2.Panel1.Controls.Add(toolStrip2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(toolStrip1);
            splitContainer2.Panel2.Controls.Add(listView2);
            splitContainer2.Size = new Size(340, 560);
            splitContainer2.SplitterDistance = 234;
            splitContainer2.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1025, 585);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1041, 624);
            MinimumSize = new Size(1041, 624);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xMeGaHertz Motorsiklet Bayisi";
            Load += MarkalarıListele;
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip1;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabel3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ListView listView3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
    }
}
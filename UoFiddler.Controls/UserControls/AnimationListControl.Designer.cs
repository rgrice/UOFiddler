/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

namespace UoFiddler.Controls.UserControls
{
    partial class AnimationListControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            TreeViewMobs = new System.Windows.Forms.TreeView();
            contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(components);
            removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportAllFramesAsPngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportAllAnimationsAsPngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            MainPictureBox = new AnimatedPictureBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            extractImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asBMpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asTiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asJpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asPngToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            extractAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asBmpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            asTiffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            asJpgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            asPngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            asAnimatedGifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asAnimatedGifnoLoopingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            listView1 = new ListViewWithScrollbar();
            contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(components);
            exportFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            asBmpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            asTiffToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            asJpgToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            asPngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBoxSettings = new System.Windows.Forms.GroupBox();
            directionLabel = new System.Windows.Forms.Label();
            ShowFrameBoundsCheckBox = new System.Windows.Forms.CheckBox();
            AnimateCheckBox = new System.Windows.Forms.CheckBox();
            FacingBar = new System.Windows.Forms.TrackBar();
            tabPage2 = new System.Windows.Forms.TabPage();
            listView = new System.Windows.Forms.ListView();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            SettingsButton = new System.Windows.Forms.ToolStripDropDownButton();
            sortAlphaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            rewriteXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tryToFindNewGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            animationEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            GraphicLabel = new System.Windows.Forms.ToolStripStatusLabel();
            BaseGraphicLabel = new System.Windows.Forms.ToolStripStatusLabel();
            HueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FacingBar).BeginInit();
            tabPage2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TreeViewMobs);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Size = new System.Drawing.Size(740, 400);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // TreeViewMobs
            // 
            TreeViewMobs.ContextMenuStrip = contextMenuStrip2;
            TreeViewMobs.Dock = System.Windows.Forms.DockStyle.Fill;
            TreeViewMobs.HideSelection = false;
            TreeViewMobs.LabelEdit = true;
            TreeViewMobs.Location = new System.Drawing.Point(0, 0);
            TreeViewMobs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TreeViewMobs.Name = "TreeViewMobs";
            TreeViewMobs.ShowNodeToolTips = true;
            TreeViewMobs.Size = new System.Drawing.Size(239, 400);
            TreeViewMobs.TabIndex = 0;
            TreeViewMobs.AfterSelect += TreeViewMobs_AfterSelect;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { removeToolStripMenuItem, exportAllFramesAsPngToolStripMenuItem, exportAllAnimationsAsPngToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new System.Drawing.Size(230, 70);
            contextMenuStrip2.Opening += ContextMenuStrip2_Opening;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += OnClickRemove;
            // 
            // exportAllFramesAsPngToolStripMenuItem
            // 
            exportAllFramesAsPngToolStripMenuItem.Name = "exportAllFramesAsPngToolStripMenuItem";
            exportAllFramesAsPngToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            exportAllFramesAsPngToolStripMenuItem.Text = "Export All Frames as PNG";
            exportAllFramesAsPngToolStripMenuItem.Click += OnClickExportAllFramesAsPng;
            // 
            // exportAllAnimationsAsPngToolStripMenuItem
            // 
            exportAllAnimationsAsPngToolStripMenuItem.Name = "exportAllAnimationsAsPngToolStripMenuItem";
            exportAllAnimationsAsPngToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            exportAllAnimationsAsPngToolStripMenuItem.Text = "Export All Animations as PNG";
            exportAllAnimationsAsPngToolStripMenuItem.Click += OnClickExportAllAnimationsAsPng;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(496, 378);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(488, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Animation";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxSettings, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(480, 344);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new System.Drawing.Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(MainPictureBox);
            splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listView1);
            splitContainer2.Panel2MinSize = 150;
            splitContainer2.Size = new System.Drawing.Size(314, 338);
            splitContainer2.SplitterDistance = 184;
            splitContainer2.TabIndex = 3;
            // 
            // MainPictureBox
            // 
            MainPictureBox.Animate = false;
            MainPictureBox.ContextMenuStrip = contextMenuStrip1;
            MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPictureBox.FrameDelay = 150;
            MainPictureBox.FrameIndex = 0;
            MainPictureBox.Location = new System.Drawing.Point(0, 0);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.ShowFrameBounds = false;
            MainPictureBox.Size = new System.Drawing.Size(314, 184);
            MainPictureBox.TabIndex = 1;
            MainPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { extractImageToolStripMenuItem, extractAnimationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(174, 48);
            // 
            // extractImageToolStripMenuItem
            // 
            extractImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { asBMpToolStripMenuItem, asTiffToolStripMenuItem, asJpgToolStripMenuItem, asPngToolStripMenuItem2 });
            extractImageToolStripMenuItem.Name = "extractImageToolStripMenuItem";
            extractImageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            extractImageToolStripMenuItem.Text = "Export Image..";
            // 
            // asBMpToolStripMenuItem
            // 
            asBMpToolStripMenuItem.Name = "asBMpToolStripMenuItem";
            asBMpToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            asBMpToolStripMenuItem.Text = "As Bmp";
            asBMpToolStripMenuItem.Click += Extract_Image_ClickBmp;
            // 
            // asTiffToolStripMenuItem
            // 
            asTiffToolStripMenuItem.Name = "asTiffToolStripMenuItem";
            asTiffToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            asTiffToolStripMenuItem.Text = "As Tiff";
            asTiffToolStripMenuItem.Click += Extract_Image_ClickTiff;
            // 
            // asJpgToolStripMenuItem
            // 
            asJpgToolStripMenuItem.Name = "asJpgToolStripMenuItem";
            asJpgToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            asJpgToolStripMenuItem.Text = "As Jpg";
            asJpgToolStripMenuItem.Click += Extract_Image_ClickJpg;
            // 
            // asPngToolStripMenuItem2
            // 
            asPngToolStripMenuItem2.Name = "asPngToolStripMenuItem2";
            asPngToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            asPngToolStripMenuItem2.Text = "As Png";
            asPngToolStripMenuItem2.Click += Extract_Image_ClickPng;
            // 
            // extractAnimationToolStripMenuItem
            // 
            extractAnimationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { asBmpToolStripMenuItem1, asTiffToolStripMenuItem1, asJpgToolStripMenuItem1, asPngToolStripMenuItem1, asAnimatedGifToolStripMenuItem, asAnimatedGifnoLoopingToolStripMenuItem });
            extractAnimationToolStripMenuItem.Name = "extractAnimationToolStripMenuItem";
            extractAnimationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            extractAnimationToolStripMenuItem.Text = "Export Animation..";
            // 
            // asBmpToolStripMenuItem1
            // 
            asBmpToolStripMenuItem1.Name = "asBmpToolStripMenuItem1";
            asBmpToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            asBmpToolStripMenuItem1.Text = "As Bmp";
            asBmpToolStripMenuItem1.Click += OnClickExtractAnimBmp;
            // 
            // asTiffToolStripMenuItem1
            // 
            asTiffToolStripMenuItem1.Name = "asTiffToolStripMenuItem1";
            asTiffToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            asTiffToolStripMenuItem1.Text = "As Tiff";
            asTiffToolStripMenuItem1.Click += OnClickExtractAnimTiff;
            // 
            // asJpgToolStripMenuItem1
            // 
            asJpgToolStripMenuItem1.Name = "asJpgToolStripMenuItem1";
            asJpgToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            asJpgToolStripMenuItem1.Text = "As Jpg";
            asJpgToolStripMenuItem1.Click += OnClickExtractAnimJpg;
            // 
            // asPngToolStripMenuItem1
            // 
            asPngToolStripMenuItem1.Name = "asPngToolStripMenuItem1";
            asPngToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            asPngToolStripMenuItem1.Text = "As Png";
            asPngToolStripMenuItem1.Click += OnClickExtractAnimPng;
            // 
            // asAnimatedGifToolStripMenuItem
            // 
            asAnimatedGifToolStripMenuItem.Name = "asAnimatedGifToolStripMenuItem";
            asAnimatedGifToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            asAnimatedGifToolStripMenuItem.Text = "As animated Gif (looping)";
            asAnimatedGifToolStripMenuItem.Click += OnClickExtractAnimGifLooping;
            // 
            // asAnimatedGifnoLoopingToolStripMenuItem
            // 
            asAnimatedGifnoLoopingToolStripMenuItem.Name = "asAnimatedGifnoLoopingToolStripMenuItem";
            asAnimatedGifnoLoopingToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            asAnimatedGifnoLoopingToolStripMenuItem.Text = "As animated Gif (no looping)";
            asAnimatedGifnoLoopingToolStripMenuItem.Click += OnClickExtractAnimGifNoLooping;
            // 
            // listView1
            // 
            listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            listView1.ContextMenuStrip = contextMenuStrip3;
            listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            listView1.Location = new System.Drawing.Point(0, 32);
            listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.OwnerDraw = true;
            listView1.Size = new System.Drawing.Size(314, 118);
            listView1.TabIndex = 0;
            listView1.TileSize = new System.Drawing.Size(81, 110);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Tile;
            listView1.DrawItem += Frames_ListView_DrawItem;
            listView1.Click += Frames_ListView_Click;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exportFrameToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new System.Drawing.Size(151, 26);
            // 
            // exportFrameToolStripMenuItem
            // 
            exportFrameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { asBmpToolStripMenuItem2, asTiffToolStripMenuItem2, asJpgToolStripMenuItem2, asPngToolStripMenuItem });
            exportFrameToolStripMenuItem.Name = "exportFrameToolStripMenuItem";
            exportFrameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            exportFrameToolStripMenuItem.Text = "Export Frame..";
            // 
            // asBmpToolStripMenuItem2
            // 
            asBmpToolStripMenuItem2.Name = "asBmpToolStripMenuItem2";
            asBmpToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            asBmpToolStripMenuItem2.Text = "As Bmp";
            asBmpToolStripMenuItem2.Click += OnClickExportFrameBmp;
            // 
            // asTiffToolStripMenuItem2
            // 
            asTiffToolStripMenuItem2.Name = "asTiffToolStripMenuItem2";
            asTiffToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            asTiffToolStripMenuItem2.Text = "As Tiff";
            asTiffToolStripMenuItem2.Click += OnClickExportFrameTiff;
            // 
            // asJpgToolStripMenuItem2
            // 
            asJpgToolStripMenuItem2.Name = "asJpgToolStripMenuItem2";
            asJpgToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            asJpgToolStripMenuItem2.Text = "As Jpg";
            asJpgToolStripMenuItem2.Click += OnClickExportFrameJpg;
            // 
            // asPngToolStripMenuItem
            // 
            asPngToolStripMenuItem.Name = "asPngToolStripMenuItem";
            asPngToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            asPngToolStripMenuItem.Text = "As Png";
            asPngToolStripMenuItem.Click += OnClickExportFramePng;
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.Controls.Add(directionLabel);
            groupBoxSettings.Controls.Add(ShowFrameBoundsCheckBox);
            groupBoxSettings.Controls.Add(AnimateCheckBox);
            groupBoxSettings.Controls.Add(FacingBar);
            groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBoxSettings.Location = new System.Drawing.Point(323, 218);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new System.Drawing.Size(154, 123);
            groupBoxSettings.TabIndex = 4;
            groupBoxSettings.TabStop = false;
            groupBoxSettings.Text = "Frames";
            // 
            // directionLabel
            // 
            directionLabel.AutoSize = true;
            directionLabel.Location = new System.Drawing.Point(7, 69);
            directionLabel.Name = "directionLabel";
            directionLabel.Size = new System.Drawing.Size(55, 15);
            directionLabel.TabIndex = 8;
            directionLabel.Text = "Direction";
            // 
            // ShowFrameBoundsCheckBox
            // 
            ShowFrameBoundsCheckBox.AutoSize = true;
            ShowFrameBoundsCheckBox.Location = new System.Drawing.Point(7, 47);
            ShowFrameBoundsCheckBox.Name = "ShowFrameBoundsCheckBox";
            ShowFrameBoundsCheckBox.Size = new System.Drawing.Size(132, 19);
            ShowFrameBoundsCheckBox.TabIndex = 7;
            ShowFrameBoundsCheckBox.Text = "Show frame bounds";
            ShowFrameBoundsCheckBox.UseVisualStyleBackColor = true;
            ShowFrameBoundsCheckBox.Click += ShowFrameBoundsCheckBox_Click;
            // 
            // AnimateCheckBox
            // 
            AnimateCheckBox.AutoSize = true;
            AnimateCheckBox.Location = new System.Drawing.Point(7, 22);
            AnimateCheckBox.Name = "AnimateCheckBox";
            AnimateCheckBox.Size = new System.Drawing.Size(71, 19);
            AnimateCheckBox.TabIndex = 6;
            AnimateCheckBox.Text = "Animate";
            AnimateCheckBox.UseVisualStyleBackColor = true;
            AnimateCheckBox.Click += AnimateCheckBox_Click;
            // 
            // FacingBar
            // 
            FacingBar.AutoSize = false;
            FacingBar.LargeChange = 1;
            FacingBar.Location = new System.Drawing.Point(7, 87);
            FacingBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FacingBar.Maximum = 7;
            FacingBar.Name = "FacingBar";
            FacingBar.Size = new System.Drawing.Size(140, 23);
            FacingBar.TabIndex = 5;
            FacingBar.Scroll += OnScrollFacing;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(488, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thumbnail List";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            listView.Location = new System.Drawing.Point(4, 3);
            listView.Margin = new System.Windows.Forms.Padding(0);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.OwnerDraw = true;
            listView.Size = new System.Drawing.Size(480, 344);
            listView.TabIndex = 0;
            listView.TileSize = new System.Drawing.Size(81, 110);
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Tile;
            listView.DrawItem += ListViewDrawItem;
            listView.SelectedIndexChanged += SelectChanged_listView;
            listView.MouseDoubleClick += ListView_DoubleClick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SettingsButton, GraphicLabel, BaseGraphicLabel, HueLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 378);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            statusStrip1.Size = new System.Drawing.Size(496, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // SettingsButton
            // 
            SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            SettingsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { sortAlphaToolStripMenuItem, hueToolStripMenuItem, toolStripSeparator1, rewriteXmlToolStripMenuItem, tryToFindNewGraphicsToolStripMenuItem, animationEditToolStripMenuItem });
            SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(62, 20);
            SettingsButton.Text = "Settings";
            // 
            // sortAlphaToolStripMenuItem
            // 
            sortAlphaToolStripMenuItem.CheckOnClick = true;
            sortAlphaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            sortAlphaToolStripMenuItem.Name = "sortAlphaToolStripMenuItem";
            sortAlphaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            sortAlphaToolStripMenuItem.Text = "Sort alphabetically";
            sortAlphaToolStripMenuItem.Click += OnClick_Sort;
            // 
            // hueToolStripMenuItem
            // 
            hueToolStripMenuItem.Name = "hueToolStripMenuItem";
            hueToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            hueToolStripMenuItem.Text = "Hue";
            hueToolStripMenuItem.Click += OnClick_Hue;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // rewriteXmlToolStripMenuItem
            // 
            rewriteXmlToolStripMenuItem.Name = "rewriteXmlToolStripMenuItem";
            rewriteXmlToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            rewriteXmlToolStripMenuItem.Text = "Rewrite xml";
            rewriteXmlToolStripMenuItem.Click += RewriteXml;
            // 
            // tryToFindNewGraphicsToolStripMenuItem
            // 
            tryToFindNewGraphicsToolStripMenuItem.Name = "tryToFindNewGraphicsToolStripMenuItem";
            tryToFindNewGraphicsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            tryToFindNewGraphicsToolStripMenuItem.Text = "Try to find new Graphics";
            tryToFindNewGraphicsToolStripMenuItem.Click += OnClickFindNewEntries;
            // 
            // animationEditToolStripMenuItem
            // 
            animationEditToolStripMenuItem.Name = "animationEditToolStripMenuItem";
            animationEditToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            animationEditToolStripMenuItem.Text = "Animation Edit";
            animationEditToolStripMenuItem.Click += OnClickAnimationEdit;
            // 
            // GraphicLabel
            // 
            GraphicLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            GraphicLabel.Name = "GraphicLabel";
            GraphicLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            GraphicLabel.Size = new System.Drawing.Size(54, 17);
            GraphicLabel.Text = "Graphic: ";
            GraphicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseGraphicLabel
            // 
            BaseGraphicLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            BaseGraphicLabel.Name = "BaseGraphicLabel";
            BaseGraphicLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            BaseGraphicLabel.Size = new System.Drawing.Size(75, 17);
            BaseGraphicLabel.Text = "BaseGraphic:";
            BaseGraphicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HueLabel
            // 
            HueLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            HueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            HueLabel.Name = "HueLabel";
            HueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            HueLabel.Size = new System.Drawing.Size(32, 17);
            HueLabel.Text = "Hue:";
            HueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnimationListControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AnimationListControl";
            Size = new System.Drawing.Size(740, 400);
            Load += OnLoad;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FacingBar).EndInit();
            tabPage2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem animationEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBMpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBmpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asBmpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asJpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asJpgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asJpgToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asPngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asPngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asPngToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asTiffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTiffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asTiffToolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel BaseGraphicLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem exportAllAnimationsAsPngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllFramesAsPngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel GraphicLabel;
        private System.Windows.Forms.ToolStripStatusLabel HueLabel;
        private System.Windows.Forms.ToolStripMenuItem hueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewriteXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem sortAlphaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView TreeViewMobs;
        private System.Windows.Forms.ToolStripMenuItem tryToFindNewGraphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asAnimatedGifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asAnimatedGifnoLoopingToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AnimatedPictureBox MainPictureBox;
        private ListViewWithScrollbar listView1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TrackBar FacingBar;
        private System.Windows.Forms.CheckBox AnimateCheckBox;
        private System.Windows.Forms.CheckBox ShowFrameBoundsCheckBox;
        private System.Windows.Forms.Label directionLabel;
    }
}

namespace LocManager
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainSplitContainer = new SplitContainer();
            treeViewPanel1 = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newGroupToolStripMenuItem = new ToolStripMenuItem();
            newSubGroupToolStripMenuItem = new ToolStripMenuItem();
            deleteGroupToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            tabControlPanel2 = new TabControl();
            searchTabPage = new TabPage();
            searchTableLayoutPanel = new TableLayoutPanel();
            searchInnerTableLayoutPanel = new TableLayoutPanel();
            searchButton = new Button();
            searchTextBox = new TextBox();
            searchListView = new ListView();
            locKeyColumn = new ColumnHeader();
            pathColumn = new ColumnHeader();
            debugColumn = new ColumnHeader();
            detailTabPage = new TabPage();
            groupBoxLower = new GroupBox();
            listViewLower = new ListView();
            LanguageInListView = new ColumnHeader();
            TranslationInListView = new ColumnHeader();
            groupBoxUpper = new GroupBox();
            translationTextBox = new TextBox();
            directoryTextBox = new TextBox();
            mainMenuStrip = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            newEntryToolStripMenuItem = new ToolStripMenuItem();
            deleteEntryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            englishToolStripMenuItem = new ToolStripMenuItem();
            polishToolStripMenuItem = new ToolStripMenuItem();
            spanishToolStripMenuItem = new ToolStripMenuItem();
            portogueseToolStripMenuItem = new ToolStripMenuItem();
            chineseToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabControlPanel2.SuspendLayout();
            searchTabPage.SuspendLayout();
            searchTableLayoutPanel.SuspendLayout();
            searchInnerTableLayoutPanel.SuspendLayout();
            detailTabPage.SuspendLayout();
            groupBoxLower.SuspendLayout();
            groupBoxUpper.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.Location = new Point(0, 28);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(treeViewPanel1);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(tabControlPanel2);
            mainSplitContainer.Size = new Size(782, 425);
            mainSplitContainer.SplitterDistance = 260;
            mainSplitContainer.TabIndex = 0;
            // 
            // treeViewPanel1
            // 
            treeViewPanel1.ContextMenuStrip = contextMenuStrip1;
            treeViewPanel1.Dock = DockStyle.Fill;
            treeViewPanel1.ImageIndex = 0;
            treeViewPanel1.ImageList = imageList1;
            treeViewPanel1.Location = new Point(0, 0);
            treeViewPanel1.Name = "treeViewPanel1";
            treeViewPanel1.SelectedImageIndex = 0;
            treeViewPanel1.Size = new Size(260, 425);
            treeViewPanel1.TabIndex = 0;
            treeViewPanel1.AfterSelect += treeViewPanel1_AfterSelect;
            treeViewPanel1.MouseClick += treeViewPanel1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newGroupToolStripMenuItem, newSubGroupToolStripMenuItem, deleteGroupToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 76);
            // 
            // newGroupToolStripMenuItem
            // 
            newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            newGroupToolStripMenuItem.Size = new Size(182, 24);
            newGroupToolStripMenuItem.Text = "New Group";
            newGroupToolStripMenuItem.Click += newGroupToolStripMenuItem_Click;
            // 
            // newSubGroupToolStripMenuItem
            // 
            newSubGroupToolStripMenuItem.Name = "newSubGroupToolStripMenuItem";
            newSubGroupToolStripMenuItem.Size = new Size(182, 24);
            newSubGroupToolStripMenuItem.Text = "New Sub Group";
            newSubGroupToolStripMenuItem.Click += newSubGroupToolStripMenuItem_Click;
            // 
            // deleteGroupToolStripMenuItem
            // 
            deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            deleteGroupToolStripMenuItem.Size = new Size(182, 24);
            deleteGroupToolStripMenuItem.Text = "Delete Group";
            deleteGroupToolStripMenuItem.Click += deleteGroupToolStripMenuItem_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "file.ico");
            imageList1.Images.SetKeyName(1, "folder.ico");
            // 
            // tabControlPanel2
            // 
            tabControlPanel2.Controls.Add(searchTabPage);
            tabControlPanel2.Controls.Add(detailTabPage);
            tabControlPanel2.Dock = DockStyle.Fill;
            tabControlPanel2.Location = new Point(0, 0);
            tabControlPanel2.Name = "tabControlPanel2";
            tabControlPanel2.SelectedIndex = 0;
            tabControlPanel2.Size = new Size(518, 425);
            tabControlPanel2.TabIndex = 2;
            // 
            // searchTabPage
            // 
            searchTabPage.Controls.Add(searchTableLayoutPanel);
            searchTabPage.Location = new Point(4, 29);
            searchTabPage.Name = "searchTabPage";
            searchTabPage.Padding = new Padding(3);
            searchTabPage.Size = new Size(510, 392);
            searchTabPage.TabIndex = 0;
            searchTabPage.Text = "Search";
            searchTabPage.UseVisualStyleBackColor = true;
            // 
            // searchTableLayoutPanel
            // 
            searchTableLayoutPanel.ColumnCount = 1;
            searchTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            searchTableLayoutPanel.Controls.Add(searchInnerTableLayoutPanel, 0, 0);
            searchTableLayoutPanel.Controls.Add(searchListView, 0, 1);
            searchTableLayoutPanel.Dock = DockStyle.Fill;
            searchTableLayoutPanel.Location = new Point(3, 3);
            searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            searchTableLayoutPanel.RowCount = 2;
            searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6580315F));
            searchTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88.34197F));
            searchTableLayoutPanel.Size = new Size(504, 386);
            searchTableLayoutPanel.TabIndex = 0;
            // 
            // searchInnerTableLayoutPanel
            // 
            searchInnerTableLayoutPanel.ColumnCount = 2;
            searchInnerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.91968F));
            searchInnerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.08032F));
            searchInnerTableLayoutPanel.Controls.Add(searchButton, 1, 0);
            searchInnerTableLayoutPanel.Controls.Add(searchTextBox, 0, 0);
            searchInnerTableLayoutPanel.Dock = DockStyle.Fill;
            searchInnerTableLayoutPanel.Location = new Point(3, 3);
            searchInnerTableLayoutPanel.Name = "searchInnerTableLayoutPanel";
            searchInnerTableLayoutPanel.RowCount = 1;
            searchInnerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            searchInnerTableLayoutPanel.Size = new Size(498, 39);
            searchInnerTableLayoutPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Dock = DockStyle.Top;
            searchButton.Location = new Point(401, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 33);
            searchButton.TabIndex = 0;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Dock = DockStyle.Fill;
            searchTextBox.Location = new Point(3, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(392, 27);
            searchTextBox.TabIndex = 1;
            searchTextBox.KeyDown += searchTextBox_KeyDown;
            // 
            // searchListView
            // 
            searchListView.Columns.AddRange(new ColumnHeader[] { locKeyColumn, pathColumn, debugColumn });
            searchListView.Dock = DockStyle.Fill;
            searchListView.Location = new Point(3, 48);
            searchListView.Name = "searchListView";
            searchListView.Size = new Size(498, 335);
            searchListView.TabIndex = 1;
            searchListView.UseCompatibleStateImageBehavior = false;
            searchListView.View = View.Details;
            searchListView.MouseDoubleClick += searchListView_MouseDoubleClick;
            // 
            // locKeyColumn
            // 
            locKeyColumn.Text = "LocKey";
            // 
            // pathColumn
            // 
            pathColumn.Text = "Path";
            // 
            // debugColumn
            // 
            debugColumn.Text = "Debug";
            // 
            // detailTabPage
            // 
            detailTabPage.Controls.Add(groupBoxLower);
            detailTabPage.Controls.Add(groupBoxUpper);
            detailTabPage.Location = new Point(4, 29);
            detailTabPage.Name = "detailTabPage";
            detailTabPage.Padding = new Padding(3);
            detailTabPage.Size = new Size(510, 392);
            detailTabPage.TabIndex = 1;
            detailTabPage.Text = "Detail";
            detailTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxLower
            // 
            groupBoxLower.Controls.Add(listViewLower);
            groupBoxLower.Dock = DockStyle.Fill;
            groupBoxLower.Location = new Point(3, 199);
            groupBoxLower.Name = "groupBoxLower";
            groupBoxLower.Size = new Size(504, 190);
            groupBoxLower.TabIndex = 1;
            groupBoxLower.TabStop = false;
            // 
            // listViewLower
            // 
            listViewLower.Columns.AddRange(new ColumnHeader[] { LanguageInListView, TranslationInListView });
            listViewLower.Dock = DockStyle.Fill;
            listViewLower.Location = new Point(3, 23);
            listViewLower.Name = "listViewLower";
            listViewLower.Size = new Size(498, 164);
            listViewLower.TabIndex = 0;
            listViewLower.UseCompatibleStateImageBehavior = false;
            listViewLower.View = View.Details;
            // 
            // LanguageInListView
            // 
            LanguageInListView.Text = "Language";
            LanguageInListView.Width = 100;
            // 
            // TranslationInListView
            // 
            TranslationInListView.Tag = "TranslationData";
            TranslationInListView.Text = "Translation";
            TranslationInListView.Width = 100;
            // 
            // groupBoxUpper
            // 
            groupBoxUpper.Controls.Add(translationTextBox);
            groupBoxUpper.Controls.Add(directoryTextBox);
            groupBoxUpper.Dock = DockStyle.Top;
            groupBoxUpper.Location = new Point(3, 3);
            groupBoxUpper.Name = "groupBoxUpper";
            groupBoxUpper.Size = new Size(504, 196);
            groupBoxUpper.TabIndex = 0;
            groupBoxUpper.TabStop = false;
            groupBoxUpper.Text = "Translation Details";
            // 
            // translationTextBox
            // 
            translationTextBox.Dock = DockStyle.Fill;
            translationTextBox.Location = new Point(3, 50);
            translationTextBox.Multiline = true;
            translationTextBox.Name = "translationTextBox";
            translationTextBox.Size = new Size(498, 143);
            translationTextBox.TabIndex = 1;
            translationTextBox.TextChanged += translationTextBox_TextChanged;
            // 
            // directoryTextBox
            // 
            directoryTextBox.BackColor = SystemColors.ControlDark;
            directoryTextBox.Dock = DockStyle.Top;
            directoryTextBox.Location = new Point(3, 23);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.ReadOnly = true;
            directoryTextBox.Size = new Size(498, 27);
            directoryTextBox.TabIndex = 0;
            directoryTextBox.TextAlign = HorizontalAlignment.Center;
            directoryTextBox.KeyDown += directoryTextBox_KeyDown;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(782, 28);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            mainMenuStrip.ItemClicked += mainMenuStrip_ItemClicked;
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(46, 24);
            fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(139, 26);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(139, 26);
            saveAsToolStripMenuItem.Text = "save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newEntryToolStripMenuItem, deleteEntryToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // newEntryToolStripMenuItem
            // 
            newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            newEntryToolStripMenuItem.Size = new Size(205, 26);
            newEntryToolStripMenuItem.Text = "New Entry";
            newEntryToolStripMenuItem.Click += newEntryToolStripMenuItem_Click;
            // 
            // deleteEntryToolStripMenuItem
            // 
            deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            deleteEntryToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteEntryToolStripMenuItem.Size = new Size(205, 26);
            deleteEntryToolStripMenuItem.Text = "Delete Entry";
            deleteEntryToolStripMenuItem.Click += deleteEntryToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2, toolStripStatusLabel1, toolStripDropDownButton1, toolStripStatusLabel2, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 427);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(14, 24);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(68, 20);
            toolStripStatusLabel1.Text = "Translate";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.None;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, polishToolStripMenuItem, spanishToolStripMenuItem, portogueseToolStripMenuItem, chineseToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(14, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(166, 26);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // polishToolStripMenuItem
            // 
            polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            polishToolStripMenuItem.Size = new Size(166, 26);
            polishToolStripMenuItem.Text = "Polish";
            // 
            // spanishToolStripMenuItem
            // 
            spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            spanishToolStripMenuItem.Size = new Size(166, 26);
            spanishToolStripMenuItem.Text = "Spanish";
            // 
            // portogueseToolStripMenuItem
            // 
            portogueseToolStripMenuItem.Name = "portogueseToolStripMenuItem";
            portogueseToolStripMenuItem.Size = new Size(166, 26);
            portogueseToolStripMenuItem.Text = "Portoguese";
            // 
            // chineseToolStripMenuItem
            // 
            chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            chineseToolStripMenuItem.Size = new Size(166, 26);
            chineseToolStripMenuItem.Text = "Chinese";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(530, 20);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(statusStrip1);
            Controls.Add(mainSplitContainer);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocManager";
            KeyDown += Form1_KeyDown;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tabControlPanel2.ResumeLayout(false);
            searchTabPage.ResumeLayout(false);
            searchTableLayoutPanel.ResumeLayout(false);
            searchInnerTableLayoutPanel.ResumeLayout(false);
            searchInnerTableLayoutPanel.PerformLayout();
            detailTabPage.ResumeLayout(false);
            groupBoxLower.ResumeLayout(false);
            groupBoxUpper.ResumeLayout(false);
            groupBoxUpper.PerformLayout();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer mainSplitContainer;
        private TreeView treeViewPanel1;
        private TabControl tabControlPanel2;
        private TabPage searchTabPage;
        private TabPage detailTabPage;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newEntryToolStripMenuItem;
        private ToolStripMenuItem deleteEntryToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBoxLower;
        private GroupBox groupBoxUpper;
        private ListView listViewLower;
        private ColumnHeader LanguageInListView;
        private ColumnHeader TranslationInListView;
        private TextBox translationTextBox;
        private TextBox directoryTextBox;
        private ImageList imageList1;
        private TableLayoutPanel searchTableLayoutPanel;
        private TableLayoutPanel searchInnerTableLayoutPanel;
        private Button searchButton;
        private TextBox searchTextBox;
        private ListView searchListView;
        private ColumnHeader locKeyColumn;
        private ColumnHeader pathColumn;
        private ColumnHeader debugColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem polishToolStripMenuItem;
        private ToolStripMenuItem spanishToolStripMenuItem;
        private ToolStripMenuItem portogueseToolStripMenuItem;
        private ToolStripMenuItem chineseToolStripMenuItem;
        private ToolStripProgressBar toolStripProgressBar1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newGroupToolStripMenuItem;
        private ToolStripMenuItem newSubGroupToolStripMenuItem;
        private ToolStripMenuItem deleteGroupToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
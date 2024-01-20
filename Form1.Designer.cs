namespace TextVault
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            pageSetupToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            findNextToolStripMenuItem = new ToolStripMenuItem();
            findPreviousToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            timeDateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            restoreDefaultZoomToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator2, pageSetupToolStripMenuItem, printToolStripMenuItem, toolStripSeparator1, closeToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(166, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(166, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(166, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(163, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            pageSetupToolStripMenuItem.Size = new Size(166, 26);
            pageSetupToolStripMenuItem.Text = "Page Setup";
            pageSetupToolStripMenuItem.Click += pageSetupToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(166, 26);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(166, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(166, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator4, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator5, findToolStripMenuItem, findNextToolStripMenuItem, findPreviousToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator6, selectAllToolStripMenuItem, timeDateToolStripMenuItem, toolStripSeparator3, fontToolStripMenuItem, colorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(224, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(221, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(224, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(224, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(224, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(224, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(221, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(224, 26);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Enabled = false;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.Size = new Size(224, 26);
            findNextToolStripMenuItem.Text = "Find next";
            findNextToolStripMenuItem.Click += findNextToolStripMenuItem_Click;
            // 
            // findPreviousToolStripMenuItem
            // 
            findPreviousToolStripMenuItem.Enabled = false;
            findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            findPreviousToolStripMenuItem.Size = new Size(224, 26);
            findPreviousToolStripMenuItem.Text = "Find previous";
            findPreviousToolStripMenuItem.Click += findPreviousToolStripMenuItem_Click_1;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Enabled = false;
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(224, 26);
            replaceToolStripMenuItem.Text = "Replace";
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new Size(224, 26);
            goToToolStripMenuItem.Text = "Go to";
            goToToolStripMenuItem.Click += goToToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(221, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(224, 26);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // timeDateToolStripMenuItem
            // 
            timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            timeDateToolStripMenuItem.Size = new Size(224, 26);
            timeDateToolStripMenuItem.Text = "Time/Date";
            timeDateToolStripMenuItem.Click += timeDateToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(224, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(224, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, statusBarToolStripMenuItem, wordWrapToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, restoreDefaultZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(224, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(235, 26);
            zoomInToolStripMenuItem.Text = "Zoom in";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(235, 26);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // restoreDefaultZoomToolStripMenuItem
            // 
            restoreDefaultZoomToolStripMenuItem.Name = "restoreDefaultZoomToolStripMenuItem";
            restoreDefaultZoomToolStripMenuItem.Size = new Size(235, 26);
            restoreDefaultZoomToolStripMenuItem.Text = "Restore default zoom";
            restoreDefaultZoomToolStripMenuItem.Click += restoreDefaultZoomToolStripMenuItem_Click;
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(224, 26);
            statusBarToolStripMenuItem.Text = "Status bar";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Checked = true;
            wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(224, 26);
            wordWrapToolStripMenuItem.Text = "Word wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(89, 24);
            aboutToolStripMenuItem.Text = "About Me";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.Yes;
            toolStripStatusLabel1.Size = new Size(112, 20);
            toolStripStatusLabel1.Text = "textvault v010.0";
            toolStripStatusLabel1.TextAlign = ContentAlignment.BottomRight;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 396);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Text Vault";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem pageSetupToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findNextToolStripMenuItem;
        private ToolStripMenuItem findPreviousToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem timeDateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem restoreDefaultZoomToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}

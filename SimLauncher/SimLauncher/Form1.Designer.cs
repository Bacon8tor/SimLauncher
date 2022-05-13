
namespace SimLauncher
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
            this.components = new System.ComponentModel.Container();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mainFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.addWebPage = new MetroFramework.Controls.MetroButton();
            this.addDelay = new MetroFramework.Controls.MetroButton();
            this.programNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.programAdd = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.createShortcut = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.styleBox = new MetroFramework.Controls.MetroComboBox();
            this.themeBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.prgmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.mainFLP.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msm
            // 
            this.msm.Owner = this;
            // 
            // mainFLP
            // 
            this.mainFLP.BackColor = System.Drawing.Color.Transparent;
            this.mainFLP.Controls.Add(this.controlPanel);
            this.mainFLP.Controls.Add(this.prgmPanel);
            this.mainFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFLP.Location = new System.Drawing.Point(20, 60);
            this.mainFLP.Name = "mainFLP";
            this.mainFLP.Size = new System.Drawing.Size(748, 416);
            this.mainFLP.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.metroPanel1);
            this.controlPanel.Controls.Add(this.metroPanel3);
            this.controlPanel.Controls.Add(this.metroPanel2);
            this.controlPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.controlPanel.Location = new System.Drawing.Point(3, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 410);
            this.controlPanel.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.iconAdd);
            this.metroPanel1.Controls.Add(this.addWebPage);
            this.metroPanel1.Controls.Add(this.addDelay);
            this.metroPanel1.Controls.Add(this.programNameTextBox);
            this.metroPanel1.Controls.Add(this.programAdd);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(197, 159);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // addWebPage
            // 
            this.addWebPage.Location = new System.Drawing.Point(3, 90);
            this.addWebPage.Name = "addWebPage";
            this.addWebPage.Size = new System.Drawing.Size(191, 23);
            this.addWebPage.TabIndex = 5;
            this.addWebPage.Text = "Add WebPage";
            this.addWebPage.Click += new System.EventHandler(this.addWebPage_Click);
            // 
            // addDelay
            // 
            this.addDelay.Location = new System.Drawing.Point(3, 61);
            this.addDelay.Name = "addDelay";
            this.addDelay.Size = new System.Drawing.Size(191, 23);
            this.addDelay.TabIndex = 4;
            this.addDelay.Text = "Add Delay";
            this.addDelay.Click += new System.EventHandler(this.addPrgmDelay);
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(191, 23);
            this.programNameTextBox.TabIndex = 2;
            this.programNameTextBox.Text = "Program Name";
            // 
            // programAdd
            // 
            this.programAdd.Location = new System.Drawing.Point(3, 32);
            this.programAdd.Name = "programAdd";
            this.programAdd.Size = new System.Drawing.Size(191, 23);
            this.programAdd.TabIndex = 3;
            this.programAdd.Text = "Add Program";
            this.programAdd.Click += new System.EventHandler(this.addPrgm);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.createShortcut);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 168);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(200, 60);
            this.metroPanel3.TabIndex = 7;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // createShortcut
            // 
            this.createShortcut.Location = new System.Drawing.Point(3, 3);
            this.createShortcut.Name = "createShortcut";
            this.createShortcut.Size = new System.Drawing.Size(191, 23);
            this.createShortcut.TabIndex = 6;
            this.createShortcut.Text = "Create Shortcut";
            this.createShortcut.Click += new System.EventHandler(this.createShortcut_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.styleBox);
            this.metroPanel2.Controls.Add(this.themeBox);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 234);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(197, 126);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.ItemHeight = 23;
            this.styleBox.Location = new System.Drawing.Point(17, 58);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(121, 29);
            this.styleBox.TabIndex = 4;
            this.styleBox.SelectedIndexChanged += new System.EventHandler(this.styleBox_SelectedValueChanged);
            // 
            // themeBox
            // 
            this.themeBox.FormattingEnabled = true;
            this.themeBox.ItemHeight = 23;
            this.themeBox.Location = new System.Drawing.Point(17, 23);
            this.themeBox.Name = "themeBox";
            this.themeBox.Size = new System.Drawing.Size(121, 29);
            this.themeBox.TabIndex = 3;
            this.themeBox.SelectedIndexChanged += new System.EventHandler(this.themeBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme";
            // 
            // prgmPanel
            // 
            this.prgmPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.prgmPanel.Location = new System.Drawing.Point(209, 3);
            this.prgmPanel.Name = "prgmPanel";
            this.prgmPanel.Size = new System.Drawing.Size(536, 410);
            this.prgmPanel.TabIndex = 1;
            // 
            // iconAdd
            // 
            this.iconAdd.Location = new System.Drawing.Point(3, 119);
            this.iconAdd.Name = "iconAdd";
            this.iconAdd.Size = new System.Drawing.Size(191, 23);
            this.iconAdd.TabIndex = 6;
            this.iconAdd.Text = "Add Icon";
            this.iconAdd.Click += new System.EventHandler(this.iconAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 496);
            this.Controls.Add(this.mainFLP);
            this.Name = "Form1";
            this.Text = "SimLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.mainFLP.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msm;
        private System.Windows.Forms.FlowLayoutPanel mainFLP;
        private System.Windows.Forms.FlowLayoutPanel controlPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox programNameTextBox;
        private MetroFramework.Controls.MetroButton programAdd;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroComboBox styleBox;
        private MetroFramework.Controls.MetroComboBox themeBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel prgmPanel;
        private MetroFramework.Controls.MetroButton addWebPage;
        private MetroFramework.Controls.MetroButton addDelay;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton createShortcut;
        private MetroFramework.Controls.MetroButton iconAdd;
    }
}


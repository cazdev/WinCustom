namespace WinCustom
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.topDrag = new System.Windows.Forms.Panel();
            this.topMinimise = new System.Windows.Forms.Button();
            this.topClose = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.mainNext = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.sideMenuList = new System.Windows.Forms.ListBox();
            this.mainLogo = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.mainSettings = new System.Windows.Forms.Button();
            this.sideButton = new System.Windows.Forms.Panel();
            this.mainSideButton = new System.Windows.Forms.Panel();
            this.topDrag.SuspendLayout();
            this.main.SuspendLayout();
            this.side.SuspendLayout();
            this.SuspendLayout();
            // 
            // topDrag
            // 
            this.topDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topDrag.Controls.Add(this.topMinimise);
            this.topDrag.Controls.Add(this.topClose);
            this.topDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDrag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topDrag.Location = new System.Drawing.Point(0, 0);
            this.topDrag.Name = "topDrag";
            this.topDrag.Size = new System.Drawing.Size(800, 30);
            this.topDrag.TabIndex = 0;
            this.topDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topDrag_MouseDown);
            // 
            // topMinimise
            // 
            this.topMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topMinimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topMinimise.FlatAppearance.BorderSize = 0;
            this.topMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topMinimise.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.topMinimise.ForeColor = System.Drawing.Color.White;
            this.topMinimise.Location = new System.Drawing.Point(710, -3);
            this.topMinimise.Name = "topMinimise";
            this.topMinimise.Size = new System.Drawing.Size(44, 30);
            this.topMinimise.TabIndex = 3;
            this.topMinimise.Text = "_";
            this.topMinimise.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.topMinimise.UseVisualStyleBackColor = false;
            this.topMinimise.Click += new System.EventHandler(this.topMinimise_Click);
            // 
            // topClose
            // 
            this.topClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topClose.FlatAppearance.BorderSize = 0;
            this.topClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.topClose.ForeColor = System.Drawing.Color.White;
            this.topClose.Location = new System.Drawing.Point(756, 0);
            this.topClose.Name = "topClose";
            this.topClose.Size = new System.Drawing.Size(44, 30);
            this.topClose.TabIndex = 2;
            this.topClose.Text = "x";
            this.topClose.UseVisualStyleBackColor = false;
            this.topClose.Click += new System.EventHandler(this.topClose_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.main.Controls.Add(this.mainSettings);
            this.main.Controls.Add(this.mainNext);
            this.main.Controls.Add(this.side);
            this.main.Controls.Add(this.mainLogo);
            this.main.Controls.Add(this.bottom);
            this.main.Controls.Add(this.mainSideButton);
            this.main.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main.Location = new System.Drawing.Point(0, 28);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(800, 422);
            this.main.TabIndex = 1;
            // 
            // mainNext
            // 
            this.mainNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(211)))));
            this.mainNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainNext.FlatAppearance.BorderSize = 0;
            this.mainNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(216)))));
            this.mainNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(138)))), ((int)(((byte)(216)))));
            this.mainNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainNext.ForeColor = System.Drawing.Color.White;
            this.mainNext.Location = new System.Drawing.Point(344, 249);
            this.mainNext.Name = "mainNext";
            this.mainNext.Size = new System.Drawing.Size(108, 33);
            this.mainNext.TabIndex = 4;
            this.mainNext.Text = "Continue";
            this.mainNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainNext.UseVisualStyleBackColor = false;
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side.Controls.Add(this.sideButton);
            this.side.Controls.Add(this.sideMenuList);
            this.side.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side.Location = new System.Drawing.Point(-135, 0);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(140, 417);
            this.side.TabIndex = 2;
            // 
            // sideMenuList
            // 
            this.sideMenuList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sideMenuList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sideMenuList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideMenuList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sideMenuList.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideMenuList.ForeColor = System.Drawing.Color.White;
            this.sideMenuList.FormattingEnabled = true;
            this.sideMenuList.ItemHeight = 22;
            this.sideMenuList.Items.AddRange(new object[] {
            "Context Menu",
            "Cortana",
            "Start Menu",
            "Taskbar"});
            this.sideMenuList.Location = new System.Drawing.Point(12, 103);
            this.sideMenuList.Name = "sideMenuList";
            this.sideMenuList.Size = new System.Drawing.Size(116, 88);
            this.sideMenuList.Sorted = true;
            this.sideMenuList.TabIndex = 6;
            this.sideMenuList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.sideMenuList_DrawItem);
            this.sideMenuList.SelectedIndexChanged += new System.EventHandler(this.sideMenuList_SelectedIndexChanged);
            // 
            // mainLogo
            // 
            this.mainLogo.AutoEllipsis = true;
            this.mainLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLogo.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLogo.ForeColor = System.Drawing.Color.White;
            this.mainLogo.Location = new System.Drawing.Point(259, 114);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(281, 70);
            this.mainLogo.TabIndex = 2;
            this.mainLogo.Text = "Win Custom";
            this.mainLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom.Location = new System.Drawing.Point(0, 417);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(800, 5);
            this.bottom.TabIndex = 0;
            // 
            // mainSettings
            // 
            this.mainSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainSettings.BackgroundImage")));
            this.mainSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSettings.FlatAppearance.BorderSize = 0;
            this.mainSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mainSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainSettings.ForeColor = System.Drawing.Color.White;
            this.mainSettings.Location = new System.Drawing.Point(738, 32);
            this.mainSettings.Name = "mainSettings";
            this.mainSettings.Size = new System.Drawing.Size(48, 48);
            this.mainSettings.TabIndex = 5;
            this.mainSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainSettings.UseVisualStyleBackColor = false;
            // 
            // sideButton
            // 
            this.sideButton.BackgroundImage = global::WinCustom.Properties.Resources.back;
            this.sideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideButton.Location = new System.Drawing.Point(12, 32);
            this.sideButton.Name = "sideButton";
            this.sideButton.Size = new System.Drawing.Size(48, 48);
            this.sideButton.TabIndex = 8;
            this.sideButton.Click += new System.EventHandler(this.sideButton_Click);
            // 
            // mainSideButton
            // 
            this.mainSideButton.BackgroundImage = global::WinCustom.Properties.Resources.menu;
            this.mainSideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainSideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSideButton.Location = new System.Drawing.Point(12, 32);
            this.mainSideButton.Name = "mainSideButton";
            this.mainSideButton.Size = new System.Drawing.Size(48, 48);
            this.mainSideButton.TabIndex = 9;
            this.mainSideButton.Click += new System.EventHandler(this.mainSideButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.topDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "WinCustom";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.topDrag.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topDrag;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label mainLogo;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.Button topClose;
        private System.Windows.Forms.Button topMinimise;
        private System.Windows.Forms.Button mainNext;
        private System.Windows.Forms.Button mainSettings;
        private System.Windows.Forms.ListBox sideMenuList;
        private System.Windows.Forms.Panel sideButton;
        private System.Windows.Forms.Panel mainSideButton;
    }
}


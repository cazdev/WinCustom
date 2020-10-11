using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.topDrag = new System.Windows.Forms.Panel();
            this.topMinimise = new System.Windows.Forms.Button();
            this.topClose = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.mainSubtitle = new System.Windows.Forms.Label();
            this.mainNext = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.sideHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainSettings = new System.Windows.Forms.Button();
            this.sideAbout = new System.Windows.Forms.Button();
            this.sideTaskbar = new System.Windows.Forms.Button();
            this.sideStartMenu = new System.Windows.Forms.Button();
            this.sideCortana = new System.Windows.Forms.Button();
            this.sideContextMenu = new System.Windows.Forms.Button();
            this.sideControlPanel = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.sideExpand = new System.Windows.Forms.Timer(this.components);
            this.sideCollapse = new System.Windows.Forms.Timer(this.components);
            this.hoverCollapse = new Transparent();
            this.hoverExpand = new Transparent();
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
            this.main.Controls.Add(this.hoverCollapse);
            this.main.Controls.Add(this.mainSubtitle);
            this.main.Controls.Add(this.mainNext);
            this.main.Controls.Add(this.side);
            this.main.Controls.Add(this.mainLogo);
            this.main.Controls.Add(this.bottom);
            this.main.Controls.Add(this.hoverExpand);
            this.main.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main.Location = new System.Drawing.Point(0, 28);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(800, 422);
            this.main.TabIndex = 1;
            // 
            // mainSubtitle
            // 
            this.mainSubtitle.AutoEllipsis = true;
            this.mainSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainSubtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSubtitle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.mainSubtitle.Location = new System.Drawing.Point(260, 188);
            this.mainSubtitle.Name = "mainSubtitle";
            this.mainSubtitle.Size = new System.Drawing.Size(281, 23);
            this.mainSubtitle.TabIndex = 10;
            this.mainSubtitle.Text = "github.com/cazdev/wincustom";
            this.mainSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainSubtitle.Click += new System.EventHandler(this.mainSubtitle_Click);
            // 
            // mainNext
            // 
            this.mainNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainNext.BackgroundImage")));
            this.mainNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainNext.FlatAppearance.BorderSize = 0;
            this.mainNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainNext.ForeColor = System.Drawing.Color.White;
            this.mainNext.Location = new System.Drawing.Point(375, 294);
            this.mainNext.Name = "mainNext";
            this.mainNext.Size = new System.Drawing.Size(48, 48);
            this.mainNext.TabIndex = 4;
            this.mainNext.UseVisualStyleBackColor = false;
            this.mainNext.Click += new System.EventHandler(this.mainNextContext_Click);
            this.mainNext.MouseEnter += new System.EventHandler(this.mainNext_MouseEnter);
            this.mainNext.MouseLeave += new System.EventHandler(this.mainNext_MouseLeave);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side.Controls.Add(this.sideHome);
            this.side.Controls.Add(this.label5);
            this.side.Controls.Add(this.label4);
            this.side.Controls.Add(this.label3);
            this.side.Controls.Add(this.label2);
            this.side.Controls.Add(this.label1);
            this.side.Controls.Add(this.mainSettings);
            this.side.Controls.Add(this.sideAbout);
            this.side.Controls.Add(this.sideTaskbar);
            this.side.Controls.Add(this.sideStartMenu);
            this.side.Controls.Add(this.sideCortana);
            this.side.Controls.Add(this.sideContextMenu);
            this.side.Controls.Add(this.sideControlPanel);
            this.side.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side.ForeColor = System.Drawing.Color.White;
            this.side.Location = new System.Drawing.Point(0, 0);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(163, 417);
            this.side.TabIndex = 2;
            // 
            // sideHome
            // 
            this.sideHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideHome.FlatAppearance.BorderSize = 0;
            this.sideHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideHome.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideHome.ForeColor = System.Drawing.Color.White;
            this.sideHome.Location = new System.Drawing.Point(0, 69);
            this.sideHome.Name = "sideHome";
            this.sideHome.Size = new System.Drawing.Size(163, 28);
            this.sideHome.TabIndex = 23;
            this.sideHome.Text = "Home";
            this.sideHome.UseVisualStyleBackColor = false;
            this.sideHome.Click += new System.EventHandler(this.sideHome_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainSettings
            // 
            this.mainSettings.BackgroundImage = global::WinCustom.Properties.Resources.settings;
            this.mainSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainSettings.FlatAppearance.BorderSize = 0;
            this.mainSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSettings.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mainSettings.ForeColor = System.Drawing.Color.White;
            this.mainSettings.Location = new System.Drawing.Point(65, 18);
            this.mainSettings.Name = "mainSettings";
            this.mainSettings.Size = new System.Drawing.Size(32, 32);
            this.mainSettings.TabIndex = 16;
            this.mainSettings.UseVisualStyleBackColor = false;
            // 
            // sideAbout
            // 
            this.sideAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideAbout.FlatAppearance.BorderSize = 0;
            this.sideAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideAbout.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideAbout.ForeColor = System.Drawing.Color.White;
            this.sideAbout.Location = new System.Drawing.Point(0, 339);
            this.sideAbout.Name = "sideAbout";
            this.sideAbout.Size = new System.Drawing.Size(163, 28);
            this.sideAbout.TabIndex = 15;
            this.sideAbout.Text = "About";
            this.sideAbout.UseVisualStyleBackColor = false;
            this.sideAbout.Click += new System.EventHandler(this.sideAbout_Click);
            // 
            // sideTaskbar
            // 
            this.sideTaskbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideTaskbar.FlatAppearance.BorderSize = 0;
            this.sideTaskbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideTaskbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideTaskbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideTaskbar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideTaskbar.ForeColor = System.Drawing.Color.White;
            this.sideTaskbar.Location = new System.Drawing.Point(0, 257);
            this.sideTaskbar.Name = "sideTaskbar";
            this.sideTaskbar.Size = new System.Drawing.Size(163, 28);
            this.sideTaskbar.TabIndex = 14;
            this.sideTaskbar.Text = "Taskbar";
            this.sideTaskbar.UseVisualStyleBackColor = false;
            this.sideTaskbar.Click += new System.EventHandler(this.sideTaskbar_Click);
            // 
            // sideStartMenu
            // 
            this.sideStartMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideStartMenu.FlatAppearance.BorderSize = 0;
            this.sideStartMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideStartMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideStartMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideStartMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideStartMenu.ForeColor = System.Drawing.Color.White;
            this.sideStartMenu.Location = new System.Drawing.Point(0, 229);
            this.sideStartMenu.Name = "sideStartMenu";
            this.sideStartMenu.Size = new System.Drawing.Size(163, 28);
            this.sideStartMenu.TabIndex = 13;
            this.sideStartMenu.Text = "Start Menu";
            this.sideStartMenu.UseVisualStyleBackColor = false;
            this.sideStartMenu.Click += new System.EventHandler(this.sideStartMenu_Click);
            // 
            // sideCortana
            // 
            this.sideCortana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideCortana.FlatAppearance.BorderSize = 0;
            this.sideCortana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideCortana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideCortana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideCortana.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideCortana.ForeColor = System.Drawing.Color.White;
            this.sideCortana.Location = new System.Drawing.Point(0, 172);
            this.sideCortana.Name = "sideCortana";
            this.sideCortana.Size = new System.Drawing.Size(163, 28);
            this.sideCortana.TabIndex = 12;
            this.sideCortana.Text = "Cortana";
            this.sideCortana.UseVisualStyleBackColor = false;
            this.sideCortana.Click += new System.EventHandler(this.sideCortana_Click);
            // 
            // sideContextMenu
            // 
            this.sideContextMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideContextMenu.FlatAppearance.BorderSize = 0;
            this.sideContextMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideContextMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideContextMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideContextMenu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideContextMenu.ForeColor = System.Drawing.Color.White;
            this.sideContextMenu.Location = new System.Drawing.Point(0, 144);
            this.sideContextMenu.Name = "sideContextMenu";
            this.sideContextMenu.Size = new System.Drawing.Size(163, 28);
            this.sideContextMenu.TabIndex = 11;
            this.sideContextMenu.Text = "Context Menu";
            this.sideContextMenu.UseVisualStyleBackColor = false;
            this.sideContextMenu.Click += new System.EventHandler(this.mainNextContext_Click);
            // 
            // sideControlPanel
            // 
            this.sideControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sideControlPanel.FlatAppearance.BorderSize = 0;
            this.sideControlPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideControlPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sideControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideControlPanel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sideControlPanel.ForeColor = System.Drawing.Color.White;
            this.sideControlPanel.Location = new System.Drawing.Point(3, 200);
            this.sideControlPanel.Name = "sideControlPanel";
            this.sideControlPanel.Size = new System.Drawing.Size(163, 28);
            this.sideControlPanel.TabIndex = 21;
            this.sideControlPanel.Text = "Control Panel";
            this.sideControlPanel.UseVisualStyleBackColor = false;
            this.sideControlPanel.Click += new System.EventHandler(this.sideControlPanel_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.AutoEllipsis = true;
            this.mainLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLogo.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLogo.ForeColor = System.Drawing.Color.White;
            this.mainLogo.Location = new System.Drawing.Point(259, 120);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(281, 70);
            this.mainLogo.TabIndex = 2;
            this.mainLogo.Text = "Win Custom";
            this.mainLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mainLogo.Click += new System.EventHandler(this.mainLogo_Click);
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom.Location = new System.Drawing.Point(0, 417);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(800, 5);
            this.bottom.TabIndex = 0;
            // 
            // sideExpand
            // 
            this.sideExpand.Interval = 1;
            this.sideExpand.Tick += new System.EventHandler(this.sideExpand_Tick);
            // 
            // sideCollapse
            // 
            this.sideCollapse.Interval = 1;
            this.sideCollapse.Tick += new System.EventHandler(this.sideCollapse_Tick);
            // 
            // hoverCollapse
            // 
            this.hoverCollapse.BackColor = System.Drawing.Color.Transparent;
            this.hoverCollapse.Location = new System.Drawing.Point(163, 0);
            this.hoverCollapse.Name = "hoverCollapse";
            this.hoverCollapse.Opacity = 100;
            this.hoverCollapse.Size = new System.Drawing.Size(52, 419);
            this.hoverCollapse.TabIndex = 12;
            this.hoverCollapse.MouseEnter += new System.EventHandler(this.hoverCollapse_MouseEnter);
            // 
            // hoverExpand
            // 
            this.hoverExpand.BackColor = System.Drawing.Color.Transparent;
            this.hoverExpand.Location = new System.Drawing.Point(0, 0);
            this.hoverExpand.Name = "hoverExpand";
            this.hoverExpand.Opacity = 100;
            this.hoverExpand.Size = new System.Drawing.Size(75, 417);
            this.hoverExpand.TabIndex = 11;
            this.hoverExpand.MouseEnter += new System.EventHandler(this.hoverExpand_MouseEnter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.topDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Button topClose;
        private System.Windows.Forms.Button topMinimise;
        public Panel side;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button mainSettings;
        public Button sideContextMenu;
        public Button sideCortana;
        public Panel main;
        public Button sideTaskbar;
        public Button sideStartMenu;
        public Button sideAbout;
        public Button sideControlPanel;
        public Button sideHome;
        public Label mainLogo;
        public Button mainNext;
        public Label mainSubtitle;
        public Transparent hoverExpand;
        public Transparent hoverCollapse;
        private Timer sideExpand;
        private Timer sideCollapse;
    }
}


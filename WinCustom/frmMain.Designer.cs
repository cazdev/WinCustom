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
            this.topDrag = new System.Windows.Forms.Panel();
            this.topMinimise = new System.Windows.Forms.Button();
            this.topClose = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.hoverCollapse = new Transparent();
            this.mainSubtitle = new System.Windows.Forms.Label();
            this.mainNext = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.mainSettings = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.hoverExpand = new Transparent();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // hoverCollapse
            // 
            this.hoverCollapse.BackColor = System.Drawing.Color.Transparent;
            this.hoverCollapse.Location = new System.Drawing.Point(160, 0);
            this.hoverCollapse.Name = "hoverCollapse";
            this.hoverCollapse.Opacity = 100;
            this.hoverCollapse.Size = new System.Drawing.Size(16, 419);
            this.hoverCollapse.TabIndex = 12;
            this.hoverCollapse.MouseEnter += new System.EventHandler(this.hoverCollapse_MouseEnter);
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
            this.mainNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mainNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainNext.FlatAppearance.BorderSize = 0;
            this.mainNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mainNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mainNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainNext.ForeColor = System.Drawing.Color.White;
            this.mainNext.Location = new System.Drawing.Point(344, 293);
            this.mainNext.Name = "mainNext";
            this.mainNext.Size = new System.Drawing.Size(108, 33);
            this.mainNext.TabIndex = 4;
            this.mainNext.Text = "Continue";
            this.mainNext.UseVisualStyleBackColor = false;
            this.mainNext.Click += new System.EventHandler(this.mainNext_Click);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.side.Controls.Add(this.label4);
            this.side.Controls.Add(this.label3);
            this.side.Controls.Add(this.label2);
            this.side.Controls.Add(this.label1);
            this.side.Controls.Add(this.mainSettings);
            this.side.Controls.Add(this.button5);
            this.side.Controls.Add(this.button4);
            this.side.Controls.Add(this.button3);
            this.side.Controls.Add(this.button2);
            this.side.Controls.Add(this.button1);
            this.side.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side.ForeColor = System.Drawing.Color.White;
            this.side.Location = new System.Drawing.Point(-133, 0);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(163, 417);
            this.side.TabIndex = 2;
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
            this.mainSettings.Location = new System.Drawing.Point(64, 48);
            this.mainSettings.Name = "mainSettings";
            this.mainSettings.Size = new System.Drawing.Size(32, 32);
            this.mainSettings.TabIndex = 16;
            this.mainSettings.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(26, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 28);
            this.button5.TabIndex = 15;
            this.button5.Text = "About";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(26, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "Taskbar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(26, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Start Menu";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(26, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cortana";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Context Menu";
            this.button1.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
        private System.Windows.Forms.Button topClose;
        private System.Windows.Forms.Button topMinimise;
        private System.Windows.Forms.Button mainNext;
        private System.Windows.Forms.Label mainSubtitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private Transparent hoverExpand;
        private System.Windows.Forms.Button button5;
        private Button mainSettings;
        public Panel side;
        private Transparent hoverCollapse;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}


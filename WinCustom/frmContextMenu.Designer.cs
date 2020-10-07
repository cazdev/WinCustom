namespace WinCustom
{
    partial class frmContextMenu
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
            this.mainNext = new System.Windows.Forms.Button();
            this.mainApply = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainRestore = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customCheckBox1 = new CustomCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainNext
            // 
            this.mainNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.mainNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainNext.FlatAppearance.BorderSize = 0;
            this.mainNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.mainNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.mainNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainNext.ForeColor = System.Drawing.Color.White;
            this.mainNext.Location = new System.Drawing.Point(461, 29);
            this.mainNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainNext.Name = "mainNext";
            this.mainNext.Size = new System.Drawing.Size(108, 33);
            this.mainNext.TabIndex = 5;
            this.mainNext.Text = "No thanks!";
            this.mainNext.UseVisualStyleBackColor = false;
            // 
            // mainApply
            // 
            this.mainApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.mainApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainApply.FlatAppearance.BorderSize = 0;
            this.mainApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.mainApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.mainApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainApply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainApply.ForeColor = System.Drawing.Color.White;
            this.mainApply.Location = new System.Drawing.Point(174, 29);
            this.mainApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainApply.Name = "mainApply";
            this.mainApply.Size = new System.Drawing.Size(108, 33);
            this.mainApply.TabIndex = 6;
            this.mainApply.Text = "I want this!";
            this.mainApply.UseVisualStyleBackColor = false;
            this.mainApply.Click += new System.EventHandler(this.mainApply_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinCustom.Properties.Resources.context;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 266);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainRestore
            // 
            this.mainRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.mainRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainRestore.FlatAppearance.BorderSize = 0;
            this.mainRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mainRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mainRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainRestore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainRestore.ForeColor = System.Drawing.Color.White;
            this.mainRestore.Location = new System.Drawing.Point(295, 29);
            this.mainRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRestore.Name = "mainRestore";
            this.mainRestore.Size = new System.Drawing.Size(108, 33);
            this.mainRestore.TabIndex = 8;
            this.mainRestore.Text = "Restore!";
            this.mainRestore.UseVisualStyleBackColor = false;
            this.mainRestore.Click += new System.EventHandler(this.mainRestore_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.AutoEllipsis = true;
            this.mainLogo.BackColor = System.Drawing.Color.Transparent;
            this.mainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLogo.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLogo.ForeColor = System.Drawing.Color.White;
            this.mainLogo.Location = new System.Drawing.Point(0, 0);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(800, 36);
            this.mainLogo.TabIndex = 9;
            this.mainLogo.Text = "Copy directory path";
            this.mainLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bottom.Controls.Add(this.customCheckBox1);
            this.bottom.Controls.Add(this.mainRestore);
            this.bottom.Controls.Add(this.mainNext);
            this.bottom.Controls.Add(this.mainApply);
            this.bottom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom.Location = new System.Drawing.Point(0, 330);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(800, 90);
            this.bottom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adds the option to copy directory path in file context menu\r\nDo you want this?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customCheckBox1
            // 
            this.customCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customCheckBox1.Location = new System.Drawing.Point(49, 28);
            this.customCheckBox1.Name = "customCheckBox1";
            this.customCheckBox1.Padding = new System.Windows.Forms.Padding(6);
            this.customCheckBox1.Size = new System.Drawing.Size(77, 38);
            this.customCheckBox1.TabIndex = 9;
            this.customCheckBox1.Text = "customCheckBox1";
            this.customCheckBox1.UseVisualStyleBackColor = true;
            // 
            // frmContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmContextMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainNext;
        private System.Windows.Forms.Button mainApply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainRestore;
        private System.Windows.Forms.Label mainLogo;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Label label1;
        private CustomCheckBox customCheckBox1;
    }
}
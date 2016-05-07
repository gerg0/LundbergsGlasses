namespace LunbergsGlasses
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bBox = new System.Windows.Forms.CheckBox();
            this.gBox = new System.Windows.Forms.CheckBox();
            this.rBox = new System.Windows.Forms.CheckBox();
            this.gScrollBar = new System.Windows.Forms.VScrollBar();
            this.bScrollBar = new System.Windows.Forms.VScrollBar();
            this.rScrollBar = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_label = new System.Windows.Forms.Label();
            this.g_label = new System.Windows.Forms.Label();
            this.r_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // bBox
            // 
            this.bBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bBox.AutoSize = true;
            this.bBox.Checked = true;
            this.bBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bBox.Enabled = false;
            this.bBox.Location = new System.Drawing.Point(123, 389);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(15, 14);
            this.bBox.TabIndex = 12;
            this.bBox.UseVisualStyleBackColor = true;
            this.bBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // gBox
            // 
            this.gBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBox.AutoSize = true;
            this.gBox.Checked = true;
            this.gBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gBox.Enabled = false;
            this.gBox.Location = new System.Drawing.Point(73, 389);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(15, 14);
            this.gBox.TabIndex = 11;
            this.gBox.UseVisualStyleBackColor = true;
            this.gBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // rBox
            // 
            this.rBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBox.AutoSize = true;
            this.rBox.Checked = true;
            this.rBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rBox.Enabled = false;
            this.rBox.Location = new System.Drawing.Point(23, 389);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(15, 14);
            this.rBox.TabIndex = 10;
            this.rBox.UseVisualStyleBackColor = true;
            this.rBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // gScrollBar
            // 
            this.gScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gScrollBar.Enabled = false;
            this.gScrollBar.Location = new System.Drawing.Point(68, 69);
            this.gScrollBar.Maximum = 109;
            this.gScrollBar.Name = "gScrollBar";
            this.gScrollBar.Size = new System.Drawing.Size(25, 300);
            this.gScrollBar.TabIndex = 9;
            this.gScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // bScrollBar
            // 
            this.bScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bScrollBar.Enabled = false;
            this.bScrollBar.Location = new System.Drawing.Point(118, 69);
            this.bScrollBar.Maximum = 109;
            this.bScrollBar.Name = "bScrollBar";
            this.bScrollBar.Size = new System.Drawing.Size(25, 300);
            this.bScrollBar.TabIndex = 8;
            this.bScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // rScrollBar
            // 
            this.rScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rScrollBar.Enabled = false;
            this.rScrollBar.Location = new System.Drawing.Point(18, 69);
            this.rScrollBar.Maximum = 109;
            this.rScrollBar.Name = "rScrollBar";
            this.rScrollBar.Size = new System.Drawing.Size(25, 300);
            this.rScrollBar.TabIndex = 7;
            this.rScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(73, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(123, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.b_label);
            this.groupBox1.Controls.Add(this.g_label);
            this.groupBox1.Controls.Add(this.r_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rScrollBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bScrollBar);
            this.groupBox1.Controls.Add(this.gScrollBar);
            this.groupBox1.Controls.Add(this.rBox);
            this.groupBox1.Controls.Add(this.bBox);
            this.groupBox1.Controls.Add(this.gBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(502, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 500);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // b_label
            // 
            this.b_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_label.AutoSize = true;
            this.b_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_label.Location = new System.Drawing.Point(118, 422);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(28, 15);
            this.b_label.TabIndex = 15;
            this.b_label.Text = "100";
            this.b_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g_label
            // 
            this.g_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.g_label.AutoSize = true;
            this.g_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.g_label.Location = new System.Drawing.Point(68, 422);
            this.g_label.Name = "g_label";
            this.g_label.Size = new System.Drawing.Size(28, 15);
            this.g_label.TabIndex = 15;
            this.g_label.Text = "100";
            this.g_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_label
            // 
            this.r_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.r_label.Location = new System.Drawing.Point(18, 422);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(28, 15);
            this.r_label.TabIndex = 15;
            this.r_label.Text = "100";
            this.r_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(16, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Import Print Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(681, 539);
            this.Name = "Form1";
            this.Text = "Lundberg\'s Glasses";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox bBox;
        private System.Windows.Forms.CheckBox gBox;
        private System.Windows.Forms.CheckBox rBox;
        private System.Windows.Forms.VScrollBar gScrollBar;
        private System.Windows.Forms.VScrollBar bScrollBar;
        private System.Windows.Forms.VScrollBar rScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Label g_label;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Button button1;

    }
}


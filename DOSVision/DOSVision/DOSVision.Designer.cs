
namespace DOSVision
{
    partial class DOSVision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOSVision));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEnable = new Guna.UI2.WinForms.Guna2Button();
            this.btnAntiDDOS = new Guna.UI2.WinForms.Guna2Button();
            this.cmbInterfaces = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOSVision.Properties.Resources.DOSVision;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(848, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listView1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Gray;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(871, 362);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEnable
            // 
            this.btnEnable.BorderColor = System.Drawing.Color.Gray;
            this.btnEnable.BorderRadius = 9;
            this.btnEnable.BorderThickness = 1;
            this.btnEnable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEnable.CheckedState.Parent = this.btnEnable;
            this.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnable.CustomImages.Parent = this.btnEnable;
            this.btnEnable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnable.DisabledState.Parent = this.btnEnable;
            this.btnEnable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEnable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.Gray;
            this.btnEnable.HoverState.Parent = this.btnEnable;
            this.btnEnable.Location = new System.Drawing.Point(701, 466);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.ShadowDecoration.Parent = this.btnEnable;
            this.btnEnable.Size = new System.Drawing.Size(180, 36);
            this.btnEnable.TabIndex = 5;
            this.btnEnable.Text = "Enable";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnAntiDDOS
            // 
            this.btnAntiDDOS.BorderColor = System.Drawing.Color.Gray;
            this.btnAntiDDOS.BorderRadius = 9;
            this.btnAntiDDOS.BorderThickness = 1;
            this.btnAntiDDOS.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAntiDDOS.CheckedState.Parent = this.btnAntiDDOS;
            this.btnAntiDDOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntiDDOS.CustomImages.Parent = this.btnAntiDDOS;
            this.btnAntiDDOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAntiDDOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAntiDDOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAntiDDOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAntiDDOS.DisabledState.Parent = this.btnAntiDDOS;
            this.btnAntiDDOS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAntiDDOS.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntiDDOS.ForeColor = System.Drawing.Color.Gray;
            this.btnAntiDDOS.HoverState.Parent = this.btnAntiDDOS;
            this.btnAntiDDOS.Location = new System.Drawing.Point(454, 466);
            this.btnAntiDDOS.Name = "btnAntiDDOS";
            this.btnAntiDDOS.ShadowDecoration.Parent = this.btnAntiDDOS;
            this.btnAntiDDOS.Size = new System.Drawing.Size(241, 36);
            this.btnAntiDDOS.TabIndex = 6;
            this.btnAntiDDOS.Text = "Enable Anti-DDOS";
            this.btnAntiDDOS.Click += new System.EventHandler(this.btnAntiDDOS_Click);
            // 
            // cmbInterfaces
            // 
            this.cmbInterfaces.BackColor = System.Drawing.Color.Transparent;
            this.cmbInterfaces.BorderColor = System.Drawing.Color.Gray;
            this.cmbInterfaces.BorderRadius = 9;
            this.cmbInterfaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInterfaces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterfaces.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmbInterfaces.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbInterfaces.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbInterfaces.FocusedState.Parent = this.cmbInterfaces;
            this.cmbInterfaces.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbInterfaces.ForeColor = System.Drawing.Color.Gray;
            this.cmbInterfaces.HoverState.Parent = this.cmbInterfaces;
            this.cmbInterfaces.ItemHeight = 30;
            this.cmbInterfaces.ItemsAppearance.Parent = this.cmbInterfaces;
            this.cmbInterfaces.Location = new System.Drawing.Point(12, 466);
            this.cmbInterfaces.Name = "cmbInterfaces";
            this.cmbInterfaces.ShadowDecoration.Parent = this.cmbInterfaces;
            this.cmbInterfaces.Size = new System.Drawing.Size(436, 36);
            this.cmbInterfaces.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "DOSVision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "DOSVision is a Distributed Denial of Service Detector, Blocker created for hosted" +
    " VPS Sites/Games/other.";
            // 
            // DOSVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(895, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInterfaces);
            this.Controls.Add(this.btnAntiDDOS);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DOSVision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOSVision by Pronner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DOSVision_FormClosing);
            this.Load += new System.EventHandler(this.DOSVision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button btnAntiDDOS;
        private Guna.UI2.WinForms.Guna2Button btnEnable;
        private Guna.UI2.WinForms.Guna2ComboBox cmbInterfaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


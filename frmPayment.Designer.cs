namespace Shoppa
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDeliveryFee = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheckout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbDeliveryFee = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 82);
            this.panel1.TabIndex = 0;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbProductName.Location = new System.Drawing.Point(12, 10);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(176, 25);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Địa chỉ nhận hàng:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(12, 42);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(360, 20);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Đặng Doãn Đạt (0345785426) - Địa chỉ - Tỉnh thành";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(946, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 39);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(525, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(669, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(818, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Thành tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDeliveryFee);
            this.panel3.Controls.Add(this.cboDeliveryFee);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 63);
            this.panel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phương thức vận chuyển:";
            // 
            // cboDeliveryFee
            // 
            this.cboDeliveryFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryFee.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliveryFee.FormattingEnabled = true;
            this.cboDeliveryFee.Location = new System.Drawing.Point(211, 19);
            this.cboDeliveryFee.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cboDeliveryFee.Name = "cboDeliveryFee";
            this.cboDeliveryFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboDeliveryFee.Size = new System.Drawing.Size(187, 25);
            this.cboDeliveryFee.TabIndex = 40;
            this.cboDeliveryFee.SelectedIndexChanged += new System.EventHandler(this.cboDeliveryFee_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(964, 486);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbCheckout);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnCheckout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(964, 56);
            this.panel4.TabIndex = 4;
            // 
            // btnCheckout
            // 
            this.btnCheckout.AllowAnimations = true;
            this.btnCheckout.AllowMouseEffects = true;
            this.btnCheckout.AllowToggling = false;
            this.btnCheckout.AnimationSpeed = 200;
            this.btnCheckout.AutoGenerateColors = false;
            this.btnCheckout.AutoRoundBorders = false;
            this.btnCheckout.AutoSizeLeftIcon = true;
            this.btnCheckout.AutoSizeRightIcon = true;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BackColor1 = System.Drawing.Color.BlueViolet;
            this.btnCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.BackgroundImage")));
            this.btnCheckout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckout.ButtonText = "Đặt hàng";
            this.btnCheckout.ButtonTextMarginLeft = 0;
            this.btnCheckout.ColorContrastOnClick = 45;
            this.btnCheckout.ColorContrastOnHover = 45;
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCheckout.CustomizableEdges = borderEdges2;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheckout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheckout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnCheckout.IconLeft")));
            this.btnCheckout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCheckout.IconMarginLeft = 11;
            this.btnCheckout.IconPadding = 10;
            this.btnCheckout.IconRight = null;
            this.btnCheckout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCheckout.IconSize = 25;
            this.btnCheckout.IdleBorderColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.IdleBorderRadius = 3;
            this.btnCheckout.IdleBorderThickness = 1;
            this.btnCheckout.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.IdleIconLeftImage")));
            this.btnCheckout.IdleIconRightImage = null;
            this.btnCheckout.IndicateFocus = false;
            this.btnCheckout.Location = new System.Drawing.Point(754, 8);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheckout.OnDisabledState.BorderRadius = 3;
            this.btnCheckout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckout.OnDisabledState.BorderThickness = 1;
            this.btnCheckout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheckout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheckout.OnDisabledState.IconLeftImage = null;
            this.btnCheckout.OnDisabledState.IconRightImage = null;
            this.btnCheckout.onHoverState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnCheckout.onHoverState.BorderRadius = 3;
            this.btnCheckout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckout.onHoverState.BorderThickness = 1;
            this.btnCheckout.onHoverState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnCheckout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.onHoverState.IconLeftImage = null;
            this.btnCheckout.onHoverState.IconRightImage = null;
            this.btnCheckout.OnIdleState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.OnIdleState.BorderRadius = 3;
            this.btnCheckout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckout.OnIdleState.BorderThickness = 1;
            this.btnCheckout.OnIdleState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCartView.OnIdleState.IconLeftImage")));
            this.btnCheckout.OnIdleState.IconRightImage = null;
            this.btnCheckout.OnPressedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.OnPressedState.BorderRadius = 3;
            this.btnCheckout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheckout.OnPressedState.BorderThickness = 1;
            this.btnCheckout.OnPressedState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCheckout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.OnPressedState.IconLeftImage = null;
            this.btnCheckout.OnPressedState.IconRightImage = null;
            this.btnCheckout.Size = new System.Drawing.Size(200, 40);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheckout.TextMarginLeft = 0;
            this.btnCheckout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCheckout.UseDefaultRadiusAndThickness = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkViolet;
            this.label7.Location = new System.Drawing.Point(391, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tổng thanh toán:";
            // 
            // lbCheckout
            // 
            this.lbCheckout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.ForeColor = System.Drawing.Color.Purple;
            this.lbCheckout.Location = new System.Drawing.Point(543, 10);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(193, 37);
            this.lbCheckout.TabIndex = 42;
            this.lbCheckout.Text = "999.999₫";
            this.lbCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDeliveryFee
            // 
            this.lbDeliveryFee.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbDeliveryFee.Location = new System.Drawing.Point(782, 13);
            this.lbDeliveryFee.Name = "lbDeliveryFee";
            this.lbDeliveryFee.Size = new System.Drawing.Size(120, 37);
            this.lbDeliveryFee.TabIndex = 41;
            this.lbDeliveryFee.Text = "50.000₫";
            this.lbDeliveryFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDeliveryFee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCheckout;
        private System.Windows.Forms.Label lbDeliveryFee;
        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
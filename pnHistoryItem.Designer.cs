namespace Shoppa
{
    partial class pnHistoryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnHistoryItem));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCoupon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCoupon);
            this.panel1.Controls.Add(this.lbTotalAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 46);
            this.panel1.TabIndex = 0;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(390, 13);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(110, 21);
            this.lbTotalAmount.TabIndex = 46;
            this.lbTotalAmount.Text = "999.999.999";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Thành tiền:";
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(111, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(173, 21);
            this.lbStatus.TabIndex = 44;
            this.lbStatus.Text = "Giao hàng thành công";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(17, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Trạng thái:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 234);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCoupon
            // 
            this.btnCoupon.AllowAnimations = true;
            this.btnCoupon.AllowMouseEffects = true;
            this.btnCoupon.AllowToggling = false;
            this.btnCoupon.AnimationSpeed = 200;
            this.btnCoupon.AutoGenerateColors = false;
            this.btnCoupon.AutoRoundBorders = false;
            this.btnCoupon.AutoSizeLeftIcon = true;
            this.btnCoupon.AutoSizeRightIcon = true;
            this.btnCoupon.BackColor = System.Drawing.Color.Transparent;
            this.btnCoupon.BackColor1 = System.Drawing.Color.BlueViolet;
            this.btnCoupon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoupon.BackgroundImage")));
            this.btnCoupon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCoupon.ButtonText = "Đánh giá";
            this.btnCoupon.ButtonTextMarginLeft = 0;
            this.btnCoupon.ColorContrastOnClick = 45;
            this.btnCoupon.ColorContrastOnHover = 45;
            this.btnCoupon.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCoupon.CustomizableEdges = borderEdges1;
            this.btnCoupon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCoupon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCoupon.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCoupon.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCoupon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCoupon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCoupon.ForeColor = System.Drawing.Color.White;
            this.btnCoupon.IconLeft = null;
            this.btnCoupon.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoupon.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoupon.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCoupon.IconMarginLeft = 11;
            this.btnCoupon.IconPadding = 10;
            this.btnCoupon.IconRight = null;
            this.btnCoupon.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCoupon.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoupon.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnCoupon.IconSize = 25;
            this.btnCoupon.IdleBorderColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.IdleBorderRadius = 3;
            this.btnCoupon.IdleBorderThickness = 1;
            this.btnCoupon.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.IdleIconLeftImage = null;
            this.btnCoupon.IdleIconRightImage = null;
            this.btnCoupon.IndicateFocus = false;
            this.btnCoupon.Location = new System.Drawing.Point(531, 9);
            this.btnCoupon.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCoupon.OnDisabledState.BorderRadius = 3;
            this.btnCoupon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCoupon.OnDisabledState.BorderThickness = 1;
            this.btnCoupon.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCoupon.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCoupon.OnDisabledState.IconLeftImage = null;
            this.btnCoupon.OnDisabledState.IconRightImage = null;
            this.btnCoupon.onHoverState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnCoupon.onHoverState.BorderRadius = 3;
            this.btnCoupon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCoupon.onHoverState.BorderThickness = 1;
            this.btnCoupon.onHoverState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnCoupon.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCoupon.onHoverState.IconLeftImage = null;
            this.btnCoupon.onHoverState.IconRightImage = null;
            this.btnCoupon.OnIdleState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.OnIdleState.BorderRadius = 3;
            this.btnCoupon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCoupon.OnIdleState.BorderThickness = 1;
            this.btnCoupon.OnIdleState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCoupon.OnIdleState.IconLeftImage = null;
            this.btnCoupon.OnIdleState.IconRightImage = null;
            this.btnCoupon.OnPressedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.OnPressedState.BorderRadius = 3;
            this.btnCoupon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCoupon.OnPressedState.BorderThickness = 1;
            this.btnCoupon.OnPressedState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCoupon.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCoupon.OnPressedState.IconLeftImage = null;
            this.btnCoupon.OnPressedState.IconRightImage = null;
            this.btnCoupon.Size = new System.Drawing.Size(107, 29);
            this.btnCoupon.TabIndex = 47;
            this.btnCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCoupon.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCoupon.TextMarginLeft = 0;
            this.btnCoupon.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCoupon.UseDefaultRadiusAndThickness = true;
            // 
            // pnHistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Name = "pnHistoryItem";
            this.Size = new System.Drawing.Size(652, 280);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCoupon;
    }
}

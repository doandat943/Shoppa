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
            this.btnRating = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRating);
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
            // btnRating
            // 
            this.btnRating.AllowAnimations = true;
            this.btnRating.AllowMouseEffects = true;
            this.btnRating.AllowToggling = false;
            this.btnRating.AnimationSpeed = 200;
            this.btnRating.AutoGenerateColors = false;
            this.btnRating.AutoRoundBorders = false;
            this.btnRating.AutoSizeLeftIcon = true;
            this.btnRating.AutoSizeRightIcon = true;
            this.btnRating.BackColor = System.Drawing.Color.Transparent;
            this.btnRating.BackColor1 = System.Drawing.Color.BlueViolet;
            this.btnRating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRating.BackgroundImage")));
            this.btnRating.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRating.ButtonText = "Đánh giá";
            this.btnRating.ButtonTextMarginLeft = 0;
            this.btnRating.ColorContrastOnClick = 45;
            this.btnRating.ColorContrastOnHover = 45;
            this.btnRating.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRating.CustomizableEdges = borderEdges1;
            this.btnRating.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRating.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRating.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRating.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRating.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.IconLeft = null;
            this.btnRating.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRating.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRating.IconMarginLeft = 11;
            this.btnRating.IconPadding = 10;
            this.btnRating.IconRight = null;
            this.btnRating.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRating.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnRating.IconSize = 25;
            this.btnRating.IdleBorderColor = System.Drawing.Color.BlueViolet;
            this.btnRating.IdleBorderRadius = 3;
            this.btnRating.IdleBorderThickness = 1;
            this.btnRating.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.btnRating.IdleIconLeftImage = null;
            this.btnRating.IdleIconRightImage = null;
            this.btnRating.IndicateFocus = false;
            this.btnRating.Location = new System.Drawing.Point(531, 9);
            this.btnRating.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.btnRating.Name = "btnRating";
            this.btnRating.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRating.OnDisabledState.BorderRadius = 3;
            this.btnRating.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRating.OnDisabledState.BorderThickness = 1;
            this.btnRating.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRating.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRating.OnDisabledState.IconLeftImage = null;
            this.btnRating.OnDisabledState.IconRightImage = null;
            this.btnRating.onHoverState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnRating.onHoverState.BorderRadius = 3;
            this.btnRating.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRating.onHoverState.BorderThickness = 1;
            this.btnRating.onHoverState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnRating.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRating.onHoverState.IconLeftImage = null;
            this.btnRating.onHoverState.IconRightImage = null;
            this.btnRating.OnIdleState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnRating.OnIdleState.BorderRadius = 3;
            this.btnRating.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRating.OnIdleState.BorderThickness = 1;
            this.btnRating.OnIdleState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnRating.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRating.OnIdleState.IconLeftImage = null;
            this.btnRating.OnIdleState.IconRightImage = null;
            this.btnRating.OnPressedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnRating.OnPressedState.BorderRadius = 3;
            this.btnRating.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRating.OnPressedState.BorderThickness = 1;
            this.btnRating.OnPressedState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnRating.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRating.OnPressedState.IconLeftImage = null;
            this.btnRating.OnPressedState.IconRightImage = null;
            this.btnRating.Size = new System.Drawing.Size(107, 29);
            this.btnRating.TabIndex = 47;
            this.btnRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRating.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRating.TextMarginLeft = 0;
            this.btnRating.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRating.UseDefaultRadiusAndThickness = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRating;
    }
}

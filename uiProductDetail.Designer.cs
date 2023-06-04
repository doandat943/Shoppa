namespace Shoppa
{
    partial class uiProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiProductDetail));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnSubtractQuantity = new System.Windows.Forms.Button();
            this.lbProductName = new System.Windows.Forms.Label();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbSold = new System.Windows.Forms.Label();
            this.txtProductInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Đánh giá";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 466);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 142);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mô tả sản phẩm";
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.MistyRose;
            this.pbProductImage.Image = ((System.Drawing.Image)(resources.GetObject("pbProductImage.Image")));
            this.pbProductImage.Location = new System.Drawing.Point(15, 15);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(200, 200);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 21;
            this.pbProductImage.TabStop = false;
            // 
            // btnSubtractQuantity
            // 
            this.btnSubtractQuantity.Location = new System.Drawing.Point(350, 232);
            this.btnSubtractQuantity.Name = "btnSubtractQuantity";
            this.btnSubtractQuantity.Size = new System.Drawing.Size(35, 35);
            this.btnSubtractQuantity.TabIndex = 30;
            this.btnSubtractQuantity.Text = "-";
            this.btnSubtractQuantity.UseVisualStyleBackColor = true;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(241, 15);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(148, 30);
            this.lbProductName.TabIndex = 22;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.Location = new System.Drawing.Point(441, 232);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(35, 35);
            this.btnAddQuantity.TabIndex = 29;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbPrice.Location = new System.Drawing.Point(239, 115);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(146, 40);
            this.lbPrice.TabIndex = 23;
            this.lbPrice.Text = "999.999₫";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(391, 233);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(44, 33);
            this.txtQuantity.TabIndex = 28;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AllowAnimations = true;
            this.btnAddToCart.AllowMouseEffects = true;
            this.btnAddToCart.AllowToggling = false;
            this.btnAddToCart.AnimationSpeed = 200;
            this.btnAddToCart.AutoGenerateColors = false;
            this.btnAddToCart.AutoRoundBorders = false;
            this.btnAddToCart.AutoSizeLeftIcon = true;
            this.btnAddToCart.AutoSizeRightIcon = true;
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BackColor1 = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddToCart.ButtonText = "Thêm vào giỏ hàng";
            this.btnAddToCart.ButtonTextMarginLeft = 0;
            this.btnAddToCart.ColorContrastOnClick = 45;
            this.btnAddToCart.ColorContrastOnHover = 45;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddToCart.CustomizableEdges = borderEdges1;
            this.btnAddToCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddToCart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddToCart.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddToCart.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddToCart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.IconLeft")));
            this.btnAddToCart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddToCart.IconMarginLeft = 11;
            this.btnAddToCart.IconPadding = 10;
            this.btnAddToCart.IconRight = null;
            this.btnAddToCart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddToCart.IconSize = 25;
            this.btnAddToCart.IdleBorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.IdleBorderRadius = 3;
            this.btnAddToCart.IdleBorderThickness = 1;
            this.btnAddToCart.IdleFillColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.IdleIconLeftImage")));
            this.btnAddToCart.IdleIconRightImage = null;
            this.btnAddToCart.IndicateFocus = false;
            this.btnAddToCart.Location = new System.Drawing.Point(15, 229);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddToCart.OnDisabledState.BorderRadius = 3;
            this.btnAddToCart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddToCart.OnDisabledState.BorderThickness = 1;
            this.btnAddToCart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddToCart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddToCart.OnDisabledState.IconLeftImage = null;
            this.btnAddToCart.OnDisabledState.IconRightImage = null;
            this.btnAddToCart.onHoverState.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnAddToCart.onHoverState.BorderRadius = 3;
            this.btnAddToCart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddToCart.onHoverState.BorderThickness = 1;
            this.btnAddToCart.onHoverState.FillColor = System.Drawing.Color.DarkOrchid;
            this.btnAddToCart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.onHoverState.IconLeftImage = null;
            this.btnAddToCart.onHoverState.IconRightImage = null;
            this.btnAddToCart.OnIdleState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.OnIdleState.BorderRadius = 3;
            this.btnAddToCart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddToCart.OnIdleState.BorderThickness = 1;
            this.btnAddToCart.OnIdleState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.OnIdleState.IconLeftImage")));
            this.btnAddToCart.OnIdleState.IconRightImage = null;
            this.btnAddToCart.OnPressedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.OnPressedState.BorderRadius = 3;
            this.btnAddToCart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddToCart.OnPressedState.BorderThickness = 1;
            this.btnAddToCart.OnPressedState.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddToCart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.OnPressedState.IconLeftImage = null;
            this.btnAddToCart.OnPressedState.IconRightImage = null;
            this.btnAddToCart.Size = new System.Drawing.Size(200, 40);
            this.btnAddToCart.TabIndex = 24;
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToCart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddToCart.TextMarginLeft = 0;
            this.btnAddToCart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddToCart.UseDefaultRadiusAndThickness = true;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(509, 234);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(115, 30);
            this.lbUnit.TabIndex = 27;
            this.lbUnit.Text = "Đơn vị: Cái";
            // 
            // lbSold
            // 
            this.lbSold.AutoSize = true;
            this.lbSold.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSold.Location = new System.Drawing.Point(241, 60);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(130, 30);
            this.lbSold.TabIndex = 25;
            this.lbSold.Text = "Đã bán: 999";
            // 
            // txtProductInfo
            // 
            this.txtProductInfo.Location = new System.Drawing.Point(15, 304);
            this.txtProductInfo.Multiline = true;
            this.txtProductInfo.Name = "txtProductInfo";
            this.txtProductInfo.Size = new System.Drawing.Size(627, 126);
            this.txtProductInfo.TabIndex = 26;
            this.txtProductInfo.Text = "- ABC\r\n- Sản phẩm này bla, bla\r\n";
            // 
            // uiProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.btnSubtractQuantity);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbSold);
            this.Controls.Add(this.txtProductInfo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uiProductDetail";
            this.Size = new System.Drawing.Size(670, 622);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Button btnSubtractQuantity;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Button btnAddQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddToCart;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label lbSold;
        private System.Windows.Forms.TextBox txtProductInfo;
    }
}

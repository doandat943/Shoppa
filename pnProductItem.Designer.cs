namespace Shoppa
{
    partial class pnProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnProductItem));
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.PictureBox();
            this.lbSold = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProductImage.Location = new System.Drawing.Point(0, 0);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(155, 148);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(8, 157);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(77, 13);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Tên Mặt Hàng";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.Location = new System.Drawing.Point(127, 206);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(25, 25);
            this.btnAddToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.TabStop = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbSold
            // 
            this.lbSold.AutoSize = true;
            this.lbSold.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSold.Location = new System.Drawing.Point(8, 209);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(72, 15);
            this.lbSold.TabIndex = 4;
            this.lbSold.Text = "Đã bán: 999";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(6, 177);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(95, 25);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "999.999₫";
            // 
            // pnProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbSold);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.pbProductImage);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "pnProductItem";
            this.Size = new System.Drawing.Size(155, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox btnAddToCart;
        private System.Windows.Forms.Label lbSold;
        private System.Windows.Forms.Label lbPrice;
    }
}

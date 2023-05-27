namespace Shoppa
{
    partial class pnCartItem
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
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.btnSubtractQuantity = new System.Windows.Forms.Button();
            this.btnAddQuantity = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Location = new System.Drawing.Point(19, 19);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(150, 150);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 1;
            this.pbProductImage.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(191, 74);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(137, 37);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "999.999₫";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(194, 29);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(130, 24);
            this.lbProductName.TabIndex = 6;
            this.lbProductName.Text = "Tên Mặt Hàng";
            // 
            // btnSubtractQuantity
            // 
            this.btnSubtractQuantity.Location = new System.Drawing.Point(198, 134);
            this.btnSubtractQuantity.Name = "btnSubtractQuantity";
            this.btnSubtractQuantity.Size = new System.Drawing.Size(35, 35);
            this.btnSubtractQuantity.TabIndex = 19;
            this.btnSubtractQuantity.Text = "-";
            this.btnSubtractQuantity.UseVisualStyleBackColor = true;
            this.btnSubtractQuantity.Click += new System.EventHandler(this.btnSubtractQuantity_Click);
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.Location = new System.Drawing.Point(289, 134);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(35, 35);
            this.btnAddQuantity.TabIndex = 18;
            this.btnAddQuantity.Text = "+";
            this.btnAddQuantity.UseVisualStyleBackColor = true;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(239, 135);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(44, 33);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.Text = "10";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(584, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 55);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubtractQuantity);
            this.Controls.Add(this.btnAddQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.pbProductImage);
            this.Name = "pnCartItem";
            this.Size = new System.Drawing.Size(664, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Button btnSubtractQuantity;
        private System.Windows.Forms.Button btnAddQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnDelete;
    }
}

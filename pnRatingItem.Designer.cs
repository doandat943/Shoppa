namespace Shoppa
{
    partial class pnRatingItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnRatingItem));
            this.lbAccountName = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.pnRatingStar = new Shoppa.pnRatingStar();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.Location = new System.Drawing.Point(84, 16);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(56, 21);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "Admin";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.DarkMagenta;
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(19, 16);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(52, 50);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComment.Location = new System.Drawing.Point(84, 42);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(206, 21);
            this.lbComment.TabIndex = 2;
            this.lbComment.Text = "Sản phẩm trên cả tuyệt vời!!";
            // 
            // pnRatingStar
            // 
            this.pnRatingStar.Location = new System.Drawing.Point(457, 26);
            this.pnRatingStar.Name = "pnRatingStar";
            this.pnRatingStar.Size = new System.Drawing.Size(155, 31);
            this.pnRatingStar.TabIndex = 3;
            // 
            // pnRatingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnRatingStar);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lbAccountName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "pnRatingItem";
            this.Size = new System.Drawing.Size(627, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lbComment;
        private pnRatingStar pnRatingStar;
    }
}

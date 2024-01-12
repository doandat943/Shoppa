namespace Shoppa
{
    partial class frmTemp
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
            this.uiStatistic1 = new Shoppa.uiStatistic();
            this.SuspendLayout();
            // 
            // uiStatistic1
            // 
            this.uiStatistic1.Location = new System.Drawing.Point(42, 12);
            this.uiStatistic1.Name = "uiStatistic1";
            this.uiStatistic1.Size = new System.Drawing.Size(670, 450);
            this.uiStatistic1.TabIndex = 0;
            // 
            // frmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiStatistic1);
            this.Name = "frmTemp";
            this.Text = "frmTemp";
            this.ResumeLayout(false);

        }

        #endregion

        private uiStatistic uiStatistic1;
    }
}
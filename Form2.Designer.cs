namespace WindowsFormsApp2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblMomo = new System.Windows.Forms.Label();
            this.lblTcb = new System.Windows.Forms.Label();
            this.pictureBoxMomo = new System.Windows.Forms.PictureBox();
            this.pictureBoxTcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMomo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTcb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMomo
            // 
            this.lblMomo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMomo.Location = new System.Drawing.Point(15, 6);
            this.lblMomo.Name = "lblMomo";
            this.lblMomo.Size = new System.Drawing.Size(225, 20);
            this.lblMomo.TabIndex = 0;
            this.lblMomo.Text = "MoMo";
            this.lblMomo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTcb
            // 
            this.lblTcb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTcb.Location = new System.Drawing.Point(270, 6);
            this.lblTcb.Name = "lblTcb";
            this.lblTcb.Size = new System.Drawing.Size(225, 20);
            this.lblTcb.TabIndex = 1;
            this.lblTcb.Text = "Techcombank";
            this.lblTcb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMomo
            // 
            this.pictureBoxMomo.Image = global::WindowsFormsApp2.Properties.Resources.momo;
            this.pictureBoxMomo.Location = new System.Drawing.Point(15, 29);
            this.pictureBoxMomo.Name = "pictureBoxMomo";
            this.pictureBoxMomo.Size = new System.Drawing.Size(225, 318);
            this.pictureBoxMomo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMomo.TabIndex = 2;
            this.pictureBoxMomo.TabStop = false;
            // 
            // pictureBoxTcb
            // 
            this.pictureBoxTcb.Image = global::WindowsFormsApp2.Properties.Resources.tcb;
            this.pictureBoxTcb.Location = new System.Drawing.Point(270, 29);
            this.pictureBoxTcb.Name = "pictureBoxTcb";
            this.pictureBoxTcb.Size = new System.Drawing.Size(225, 318);
            this.pictureBoxTcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTcb.TabIndex = 3;
            this.pictureBoxTcb.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 358);
            this.Controls.Add(this.pictureBoxTcb);
            this.Controls.Add(this.pictureBoxMomo);
            this.Controls.Add(this.lblTcb);
            this.Controls.Add(this.lblMomo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 397);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 397);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMomo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMomo;
        private System.Windows.Forms.Label lblTcb;
        private System.Windows.Forms.PictureBox pictureBoxMomo;
        private System.Windows.Forms.PictureBox pictureBoxTcb;
    }
}

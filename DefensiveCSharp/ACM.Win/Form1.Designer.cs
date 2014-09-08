namespace ACM.Win
{
    partial class Form1
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
            this.lblPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.Location = new System.Drawing.Point(289, 12);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(75, 49);
            this.lblPlaceOrder.TabIndex = 0;
            this.lblPlaceOrder.Text = "Place Order";
            this.lblPlaceOrder.UseVisualStyleBackColor = true;
            this.lblPlaceOrder.Click += new System.EventHandler(this.lblPlaceOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.lblPlaceOrder);
            this.Name = "Form1";
            this.Text = "ACM Inc.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblPlaceOrder;
    }
}


namespace ACM.Win
{
    partial class PedometerWin
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
            this.lblStepsGoal = new System.Windows.Forms.Label();
            this.lblStepsToday = new System.Windows.Forms.Label();
            this.txtTowardsGoal = new System.Windows.Forms.TextBox();
            this.txtStepsToday = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStepsGoal
            // 
            this.lblStepsGoal.AutoSize = true;
            this.lblStepsGoal.Location = new System.Drawing.Point(32, 9);
            this.lblStepsGoal.Name = "lblStepsGoal";
            this.lblStepsGoal.Size = new System.Drawing.Size(102, 13);
            this.lblStepsGoal.TabIndex = 0;
            this.lblStepsGoal.Text = "Steps towards Goal:";
            // 
            // lblStepsToday
            // 
            this.lblStepsToday.AutoSize = true;
            this.lblStepsToday.Location = new System.Drawing.Point(12, 45);
            this.lblStepsToday.Name = "lblStepsToday";
            this.lblStepsToday.Size = new System.Drawing.Size(122, 13);
            this.lblStepsToday.TabIndex = 1;
            this.lblStepsToday.Text = "Number of Steps Today:";
            // 
            // txtTowardsGoal
            // 
            this.txtTowardsGoal.Location = new System.Drawing.Point(140, 6);
            this.txtTowardsGoal.Name = "txtTowardsGoal";
            this.txtTowardsGoal.Size = new System.Drawing.Size(138, 20);
            this.txtTowardsGoal.TabIndex = 2;
            // 
            // txtStepsToday
            // 
            this.txtStepsToday.Location = new System.Drawing.Point(140, 42);
            this.txtStepsToday.Name = "txtStepsToday";
            this.txtStepsToday.Size = new System.Drawing.Size(138, 20);
            this.txtStepsToday.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(284, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 52);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate!!!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(137, 82);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 119);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStepsToday);
            this.Controls.Add(this.txtTowardsGoal);
            this.Controls.Add(this.lblStepsToday);
            this.Controls.Add(this.lblStepsGoal);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStepsGoal;
        private System.Windows.Forms.Label lblStepsToday;
        private System.Windows.Forms.TextBox txtTowardsGoal;
        private System.Windows.Forms.TextBox txtStepsToday;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
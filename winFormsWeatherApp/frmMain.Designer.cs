namespace winFormsWeatherApp
{
    partial class frmMain
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
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblRealFeelDegrees = new System.Windows.Forms.Label();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.Location = new System.Drawing.Point(73, 39);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(61, 13);
            this.lblFeelsLike.TabIndex = 0;
            this.lblFeelsLike.Text = "Feels Like: ";
            // 
            // lblRealFeelDegrees
            // 
            this.lblRealFeelDegrees.AutoSize = true;
            this.lblRealFeelDegrees.Location = new System.Drawing.Point(135, 39);
            this.lblRealFeelDegrees.Name = "lblRealFeelDegrees";
            this.lblRealFeelDegrees.Size = new System.Drawing.Size(45, 13);
            this.lblRealFeelDegrees.TabIndex = 2;
            this.lblRealFeelDegrees.Text = "degrees";
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(6, 184);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(250, 20);
            this.txtApiUrl.TabIndex = 4;
            this.txtApiUrl.Text = "http://api.wunderground.com/api/ae9db64f41585f03/hourly/q/OH/Columbus.json";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set URL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.lblRealFeelDegrees);
            this.Controls.Add(this.lblFeelsLike);
            this.Name = "frmMain";
            this.Text = "My Weather App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Label lblRealFeelDegrees;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Button button1;
    }
}


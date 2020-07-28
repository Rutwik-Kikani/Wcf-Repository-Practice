namespace WCFInstancingDemoWinClient
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
            this.btnInvokeService = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInvokeService
            // 
            this.btnInvokeService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvokeService.Location = new System.Drawing.Point(0, 0);
            this.btnInvokeService.Name = "btnInvokeService";
            this.btnInvokeService.Size = new System.Drawing.Size(569, 77);
            this.btnInvokeService.TabIndex = 0;
            this.btnInvokeService.Text = "Invoke Service";
            this.btnInvokeService.UseVisualStyleBackColor = true;
            this.btnInvokeService.Click += new System.EventHandler(this.btnInvokeService_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Green;
            this.lblCounter.Location = new System.Drawing.Point(0, 77);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(569, 373);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "lable1";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnInvokeService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvokeService;
        private System.Windows.Forms.Label lblCounter;
    }
}


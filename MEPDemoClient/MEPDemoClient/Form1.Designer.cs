namespace MEPDemoClient
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRequestReplyOperation = new System.Windows.Forms.Button();
            this.btnRequestReplyOperationThrowsException = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnOneWayOperation = new System.Windows.Forms.Button();
            this.btnOneWayOperationThrowsException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 244);
            this.listBox1.TabIndex = 0;
            // 
            // btnRequestReplyOperation
            // 
            this.btnRequestReplyOperation.Location = new System.Drawing.Point(12, 287);
            this.btnRequestReplyOperation.Name = "btnRequestReplyOperation";
            this.btnRequestReplyOperation.Size = new System.Drawing.Size(776, 34);
            this.btnRequestReplyOperation.TabIndex = 1;
            this.btnRequestReplyOperation.Text = "Request Reply Operation";
            this.btnRequestReplyOperation.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperation.Click += new System.EventHandler(this.btnRequestReplyOperation_Click);
            // 
            // btnRequestReplyOperationThrowsException
            // 
            this.btnRequestReplyOperationThrowsException.Location = new System.Drawing.Point(12, 327);
            this.btnRequestReplyOperationThrowsException.Name = "btnRequestReplyOperationThrowsException";
            this.btnRequestReplyOperationThrowsException.Size = new System.Drawing.Size(776, 36);
            this.btnRequestReplyOperationThrowsException.TabIndex = 2;
            this.btnRequestReplyOperationThrowsException.Text = "Request Reply Operation Throws Exception";
            this.btnRequestReplyOperationThrowsException.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperationThrowsException.Click += new System.EventHandler(this.btnRequestReplyOperationThrowsException_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(12, 463);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(776, 34);
            this.btnClearData.TabIndex = 3;
            this.btnClearData.Text = "ClearData";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnOneWayOperation
            // 
            this.btnOneWayOperation.Location = new System.Drawing.Point(12, 369);
            this.btnOneWayOperation.Name = "btnOneWayOperation";
            this.btnOneWayOperation.Size = new System.Drawing.Size(776, 41);
            this.btnOneWayOperation.TabIndex = 4;
            this.btnOneWayOperation.Text = "One Way Operation";
            this.btnOneWayOperation.UseVisualStyleBackColor = true;
            this.btnOneWayOperation.Click += new System.EventHandler(this.btnOneWayOperation_Click);
            // 
            // btnOneWayOperationThrowsException
            // 
            this.btnOneWayOperationThrowsException.Location = new System.Drawing.Point(12, 416);
            this.btnOneWayOperationThrowsException.Name = "btnOneWayOperationThrowsException";
            this.btnOneWayOperationThrowsException.Size = new System.Drawing.Size(776, 41);
            this.btnOneWayOperationThrowsException.TabIndex = 5;
            this.btnOneWayOperationThrowsException.Text = "One Way Operation Throws Exception";
            this.btnOneWayOperationThrowsException.UseVisualStyleBackColor = true;
            this.btnOneWayOperationThrowsException.Click += new System.EventHandler(this.btnOneWayOperationThrowsException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btnOneWayOperationThrowsException);
            this.Controls.Add(this.btnOneWayOperation);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnRequestReplyOperationThrowsException);
            this.Controls.Add(this.btnRequestReplyOperation);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRequestReplyOperation;
        private System.Windows.Forms.Button btnRequestReplyOperationThrowsException;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnOneWayOperation;
        private System.Windows.Forms.Button btnOneWayOperationThrowsException;
    }
}


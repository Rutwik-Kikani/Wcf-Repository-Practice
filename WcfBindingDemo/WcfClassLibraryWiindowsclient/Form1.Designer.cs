namespace WcfClassLibraryWiindowsclient
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
            this.btnGetText = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnMulInterger = new System.Windows.Forms.Button();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnGetText
            // 
            this.btnGetText.AutoSize = true;
            this.btnGetText.Location = new System.Drawing.Point(242, 106);
            this.btnGetText.Name = "btnGetText";
            this.btnGetText.Size = new System.Drawing.Size(75, 27);
            this.btnGetText.TabIndex = 0;
            this.btnGetText.Text = "GetText";
            this.btnGetText.UseVisualStyleBackColor = true;
            this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(351, 106);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(64, 25);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // btnMulInterger
            // 
            this.btnMulInterger.AutoSize = true;
            this.btnMulInterger.Location = new System.Drawing.Point(242, 159);
            this.btnMulInterger.Name = "btnMulInterger";
            this.btnMulInterger.Size = new System.Drawing.Size(135, 27);
            this.btnMulInterger.TabIndex = 2;
            this.btnMulInterger.Text = "MultiplyTwoInteger";
            this.btnMulInterger.UseVisualStyleBackColor = true;
            this.btnMulInterger.Click += new System.EventHandler(this.btnMulInterger_Click);
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplication.Location = new System.Drawing.Point(416, 159);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(64, 25);
            this.lblMultiplication.TabIndex = 4;
            this.lblMultiplication.Text = "label2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tcp";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(43, 159);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pipe";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(43, 202);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Http";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.btnMulInterger);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnGetText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnMulInterger;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}


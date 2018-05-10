namespace UCLN
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
            this.rtbNum1 = new System.Windows.Forms.RichTextBox();
            this.rtbNum2 = new System.Windows.Forms.RichTextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbNum1
            // 
            this.rtbNum1.Location = new System.Drawing.Point(12, 88);
            this.rtbNum1.Name = "rtbNum1";
            this.rtbNum1.Size = new System.Drawing.Size(312, 68);
            this.rtbNum1.TabIndex = 0;
            this.rtbNum1.Text = "";
            // 
            // rtbNum2
            // 
            this.rtbNum2.Location = new System.Drawing.Point(389, 88);
            this.rtbNum2.Name = "rtbNum2";
            this.rtbNum2.Size = new System.Drawing.Size(312, 68);
            this.rtbNum2.TabIndex = 0;
            this.rtbNum2.Text = "";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(330, 180);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(203, 226);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(312, 96);
            this.rtbResult.TabIndex = 0;
            this.rtbResult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many bits you want?";
            // 
            // tbBits
            // 
            this.tbBits.Location = new System.Drawing.Point(291, 40);
            this.tbBits.Name = "tbBits";
            this.tbBits.Size = new System.Drawing.Size(100, 20);
            this.tbBits.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBits);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbNum2);
            this.Controls.Add(this.rtbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNum1;
        private System.Windows.Forms.RichTextBox rtbNum2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBits;
    }
}


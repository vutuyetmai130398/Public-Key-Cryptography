namespace LiThuyetSo
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tbBits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberTest = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbResultPrimes = new System.Windows.Forms.RichTextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMersenne = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(904, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(15, 20);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(855, 96);
            this.rtbResult.TabIndex = 1;
            this.rtbResult.Text = "";
            // 
            // tbBits
            // 
            this.tbBits.Location = new System.Drawing.Point(890, 51);
            this.tbBits.Name = "tbBits";
            this.tbBits.Size = new System.Drawing.Size(100, 20);
            this.tbBits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(872, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many bits you want? \r\n8 bits, 32 bits, 64 bits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBits);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbResult);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate the prime number";
            // 
            // txtNumberTest
            // 
            this.txtNumberTest.Location = new System.Drawing.Point(9, 43);
            this.txtNumberTest.Name = "txtNumberTest";
            this.txtNumberTest.Size = new System.Drawing.Size(671, 96);
            this.txtNumberTest.TabIndex = 6;
            this.txtNumberTest.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(700, 94);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(313, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGen);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.txtNumberTest);
            this.groupBox2.Location = new System.Drawing.Point(15, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 156);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Prime Number";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(700, 43);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(313, 23);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "Generate the number which less than 2^89 -1";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbResultPrimes);
            this.groupBox3.Controls.Add(this.btnCal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rtbMersenne);
            this.groupBox3.Location = new System.Drawing.Point(18, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1016, 154);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mersenne Prime";
            // 
            // rtbResultPrimes
            // 
            this.rtbResultPrimes.Location = new System.Drawing.Point(543, 52);
            this.rtbResultPrimes.Name = "rtbResultPrimes";
            this.rtbResultPrimes.Size = new System.Drawing.Size(341, 90);
            this.rtbResultPrimes.TabIndex = 17;
            this.rtbResultPrimes.Text = "";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(410, 79);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 16;
            this.btnCal.Text = "Result";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prime numbers which less than 10th first Mersenne Prime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "10th first Mersenne Prime";
            // 
            // rtbMersenne
            // 
            this.rtbMersenne.Location = new System.Drawing.Point(7, 52);
            this.rtbMersenne.Name = "rtbMersenne";
            this.rtbMersenne.Size = new System.Drawing.Size(365, 84);
            this.rtbMersenne.TabIndex = 13;
            this.rtbMersenne.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.TextBox tbBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtNumberTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbResultPrimes;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbMersenne;
    }
}


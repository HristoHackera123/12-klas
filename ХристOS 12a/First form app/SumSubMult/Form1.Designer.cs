namespace SumSubMult
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSum = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnSum
            // 
            btnSum.Location = new Point(187, 263);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(75, 23);
            btnSum.TabIndex = 0;
            btnSum.Text = "Sum";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btn_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(278, 264);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(122, 22);
            btnSubtract.TabIndex = 1;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btn_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(438, 255);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(104, 32);
            btnMultiply.TabIndex = 2;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(82, 86);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(555, 86);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(95, 23);
            txtNum2.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(320, 182);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(107, 23);
            txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnSum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSum;
        private Button btnSubtract;
        private Button btnMultiply;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
    }
}

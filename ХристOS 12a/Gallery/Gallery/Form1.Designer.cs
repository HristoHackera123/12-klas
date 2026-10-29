namespace Gallery
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
            btnLeft = new Button();
            btnRight = new Button();
            pictureBox = new PictureBox();
            btnAdd = new Button();
            addFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Segoe UI", 18F);
            btnLeft.Location = new Point(68, 341);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(165, 65);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "Prev.";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btn_Click;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Segoe UI", 18F);
            btnRight.Location = new Point(410, 341);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(165, 65);
            btnRight.TabIndex = 1;
            btnRight.Text = "Next";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.son_meme_resize;
            pictureBox.Location = new Point(68, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(507, 295);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(270, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 67);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // addFileDialog
            // 
            addFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 447);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeft;
        private Button btnRight;
        private PictureBox pictureBox;
        private Button btnAdd;
        private OpenFileDialog addFileDialog;
    }
}

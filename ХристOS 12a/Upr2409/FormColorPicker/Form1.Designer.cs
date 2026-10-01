namespace FormColorPicker
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
            lsbColors = new ListBox();
            btnAdd = new Button();
            btnSelect = new Button();
            colorDialog = new ColorDialog();
            txtAdd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lsbColors
            // 
            lsbColors.FormattingEnabled = true;
            lsbColors.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow", "Black", "White" });
            lsbColors.Location = new Point(489, -2);
            lsbColors.Name = "lsbColors";
            lsbColors.Size = new Size(314, 454);
            lsbColors.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 83);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add color";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(302, 344);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(165, 48);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select color";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(29, 68);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(201, 33);
            txtAdd.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 4;
            label1.Text = "Make a new color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(302, 302);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 5;
            label2.Text = "Choose an existing one:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(237, 244);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 6;
            label3.Text = "OR";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdd);
            Controls.Add(btnSelect);
            Controls.Add(btnAdd);
            Controls.Add(lsbColors);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbColors;
        private Button btnAdd;
        private Button btnSelect;
        private ColorDialog colorDialog;
        private TextBox txtAdd;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

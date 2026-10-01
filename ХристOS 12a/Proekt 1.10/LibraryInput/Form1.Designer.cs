namespace LibraryInput
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
            lblAuthor = new Label();
            lblTitle = new Label();
            lblIzdatelstvo = new Label();
            lblGenre = new Label();
            lblCover = new Label();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            cmbIzdatelstvo = new ComboBox();
            cmbGenre = new ComboBox();
            cmbCover = new ComboBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F);
            lblAuthor.Location = new Point(92, 49);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(56, 21);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Автор:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(557, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Заглавие:";
            // 
            // lblIzdatelstvo
            // 
            lblIzdatelstvo.AutoSize = true;
            lblIzdatelstvo.Font = new Font("Segoe UI", 12F);
            lblIzdatelstvo.Location = new Point(74, 199);
            lblIzdatelstvo.Name = "lblIzdatelstvo";
            lblIzdatelstvo.Size = new Size(100, 21);
            lblIzdatelstvo.TabIndex = 2;
            lblIzdatelstvo.Text = "Издателство";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F);
            lblGenre.Location = new Point(332, 199);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(50, 21);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Жанр";
            // 
            // lblCover
            // 
            lblCover.AutoSize = true;
            lblCover.Font = new Font("Segoe UI", 12F);
            lblCover.Location = new Point(539, 199);
            lblCover.Name = "lblCover";
            lblCover.Size = new Size(119, 21);
            lblCover.TabIndex = 4;
            lblCover.Text = "Вид на Корица:";
            // 
            // txtAuthor
            // 
            txtAuthor.AccessibleName = "Автор";
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(64, 92);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 29);
            txtAuthor.TabIndex = 5;
            txtAuthor.TextChanged += ControlHasText;
            // 
            // txtTitle
            // 
            txtTitle.AccessibleName = "Заглавие";
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(537, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(117, 29);
            txtTitle.TabIndex = 6;
            txtTitle.TextChanged += ControlHasText;
            // 
            // cmbIzdatelstvo
            // 
            cmbIzdatelstvo.AccessibleName = "издателство";
            cmbIzdatelstvo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzdatelstvo.Font = new Font("Segoe UI", 12F);
            cmbIzdatelstvo.FormattingEnabled = true;
            cmbIzdatelstvo.Items.AddRange(new object[] { "Просвета", "Архимед", "Някой друг", "Зорница", "Аз карам опел" });
            cmbIzdatelstvo.Location = new Point(64, 244);
            cmbIzdatelstvo.Name = "cmbIzdatelstvo";
            cmbIzdatelstvo.Size = new Size(121, 29);
            cmbIzdatelstvo.TabIndex = 7;
            cmbIzdatelstvo.TextChanged += ControlHasText;
            // 
            // cmbGenre
            // 
            cmbGenre.AccessibleName = "жанр";
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.Font = new Font("Segoe UI", 12F);
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "художествен", "научно-популярен", "спражочен" });
            cmbGenre.Location = new Point(296, 244);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(121, 29);
            cmbGenre.TabIndex = 8;
            cmbGenre.TextChanged += ControlHasText;
            // 
            // cmbCover
            // 
            cmbCover.AccessibleName = "вид на корица";
            cmbCover.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCover.Font = new Font("Segoe UI", 12F);
            cmbCover.FormattingEnabled = true;
            cmbCover.Items.AddRange(new object[] { "Мека", "Твърда" });
            cmbCover.Location = new Point(539, 244);
            cmbCover.Name = "cmbCover";
            cmbCover.Size = new Size(128, 29);
            cmbCover.TabIndex = 9;
            cmbCover.TextChanged += ControlHasText;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSubmit.Location = new Point(266, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(234, 70);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Въведете книга";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(cmbCover);
            Controls.Add(cmbGenre);
            Controls.Add(cmbIzdatelstvo);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(lblCover);
            Controls.Add(lblGenre);
            Controls.Add(lblIzdatelstvo);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Въвеждане на книга";
            TextChanged += ControlHasText;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthor;
        private Label lblTitle;
        private Label lblIzdatelstvo;
        private Label lblGenre;
        private Label lblCover;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private ComboBox cmbIzdatelstvo;
        private ComboBox cmbGenre;
        private ComboBox cmbCover;
        private Button btnSubmit;
    }
}

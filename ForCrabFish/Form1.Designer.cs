namespace ForCrabFish
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
            WelcomeBox = new TextBox();
            MenuComboBox = new ComboBox();
            SuspendLayout();
            // 
            // WelcomeBox
            // 
            WelcomeBox.Anchor = AnchorStyles.None;
            WelcomeBox.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline);
            WelcomeBox.Location = new Point(145, 0);
            WelcomeBox.Name = "WelcomeBox";
            WelcomeBox.Size = new Size(556, 52);
            WelcomeBox.TabIndex = 0;
            WelcomeBox.Text = "Приложение для изучения C#";
            WelcomeBox.TextAlign = HorizontalAlignment.Center;
            WelcomeBox.TextChanged += textBox1_TextChanged;
            // 
            // MenuComboBox
            // 
            MenuComboBox.AccessibleRole = AccessibleRole.MenuBar;
            MenuComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuComboBox.FormattingEnabled = true;
            MenuComboBox.Items.AddRange(new object[] { "Теория", "Практика" });
            MenuComboBox.Location = new Point(3, 87);
            MenuComboBox.Name = "MenuComboBox";
            MenuComboBox.Size = new Size(121, 29);
            MenuComboBox.TabIndex = 1;
            MenuComboBox.Text = "Меню";
            MenuComboBox.SelectedIndexChanged += MenuComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuComboBox);
            Controls.Add(WelcomeBox);
            ForeColor = Color.Coral;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WelcomeBox;
        private ComboBox MenuComboBox;
    }
}

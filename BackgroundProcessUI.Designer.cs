namespace POC_BackgroungProcessUI
{
    partial class BackgroundProcessUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundProcessUI));
            StartProcess = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            Url = new TextBox();
            Browsers = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StartProcess
            // 
            StartProcess.BackColor = Color.Transparent;
            StartProcess.BackgroundImageLayout = ImageLayout.None;
            StartProcess.Location = new Point(376, 251);
            StartProcess.Name = "StartProcess";
            StartProcess.Size = new Size(206, 29);
            StartProcess.TabIndex = 0;
            StartProcess.Text = "Start Process";
            StartProcess.UseVisualStyleBackColor = false;
            StartProcess.Click += StartProcess_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Url);
            panel1.Controls.Add(Browsers);
            panel1.Controls.Add(StartProcess);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 452);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("HoloLens MDL2 Assets", 16.2F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(200, 186);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 5;
            label2.Text = "Insert URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("HoloLens MDL2 Assets", 16.2F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(200, 129);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 4;
            label1.Text = "Select Browser";
            // 
            // Url
            // 
            Url.Location = new Point(375, 194);
            Url.Name = "Url";
            Url.Size = new Size(207, 27);
            Url.TabIndex = 3;
            Url.TextChanged += Url_TextChanged;
            // 
            // Browsers
            // 
            Browsers.FormattingEnabled = true;
            Browsers.Location = new Point(376, 137);
            Browsers.Name = "Browsers";
            Browsers.Size = new Size(206, 28);
            Browsers.TabIndex = 2;
            Browsers.SelectedIndexChanged += Browsers_SelectedIndexChanged;
            // 
            // BackgroundProcessUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BackgroundProcessUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartProcess;
        private Panel panel1;
        private Label label1;
        private TextBox Url;
        private ComboBox Browsers;
        private Label label2;
    }
}

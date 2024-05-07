namespace Project_TSP_21621541
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(92, 312);
            button1.Name = "button1";
            button1.Size = new Size(141, 87);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 12);
            button2.Name = "button2";
            button2.Size = new Size(141, 87);
            button2.TabIndex = 1;
            button2.Text = "Log-in";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(334, 411);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "SignInForm";
            Text = "Sign-in";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
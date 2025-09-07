namespace KBO.Test.UI
{
    partial class frmTest
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
            lblGreeting = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Bold | FontStyle.Underline);
            lblGreeting.Location = new Point(140, 163);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(129, 19);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hello World!";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(159, 185);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Goodbye!";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 377);
            Controls.Add(btnExit);
            Controls.Add(lblGreeting);
            Name = "frmTest";
            Text = "TESTING TESTING";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreeting;
        private Button btnExit;
    }
}

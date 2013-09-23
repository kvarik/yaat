namespace Simple_Application {
    partial class formMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(12, 76);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(260, 105);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Just a Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnButton);
            this.Name = "formMain";
            this.Text = "Simple Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
    }
}


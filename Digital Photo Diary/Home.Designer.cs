
namespace Digital_Photo_Diary
{
    partial class Home
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
            this.createButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.lastLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(124, 114);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(153, 57);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Event";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(124, 198);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(153, 52);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View Saved Events";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLabel.Location = new System.Drawing.Point(64, 60);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(116, 19);
            this.lastLabel.TabIndex = 2;
            this.lastLabel.Text = "Last Modified";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 336);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.createButton);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
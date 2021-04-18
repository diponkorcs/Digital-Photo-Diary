
namespace Digital_Photo_Diary
{
    partial class CreateEvent
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.eventnameTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.createPictureBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.importanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(34, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Event Name";
            // 
            // eventnameTextBox
            // 
            this.eventnameTextBox.Location = new System.Drawing.Point(126, 18);
            this.eventnameTextBox.Name = "eventnameTextBox";
            this.eventnameTextBox.Size = new System.Drawing.Size(141, 20);
            this.eventnameTextBox.TabIndex = 1;
            this.eventnameTextBox.TextChanged += new System.EventHandler(this.eventnameTextBox_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(279, 19);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 16);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Event Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 17);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 155);
            this.textBox2.TabIndex = 5;
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.Location = new System.Drawing.Point(77, 56);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(43, 16);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = "Story";
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Location = new System.Drawing.Point(34, 236);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(86, 16);
            this.pictureLabel.TabIndex = 6;
            this.pictureLabel.Text = "Add Picture";
            // 
            // createPictureBox
            // 
            this.createPictureBox.Location = new System.Drawing.Point(126, 236);
            this.createPictureBox.Name = "createPictureBox";
            this.createPictureBox.Size = new System.Drawing.Size(192, 202);
            this.createPictureBox.TabIndex = 7;
            this.createPictureBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(126, 446);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(99, 27);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(579, 434);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 39);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Event";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // discardButton
            // 
            this.discardButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.Location = new System.Drawing.Point(460, 434);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(113, 39);
            this.discardButton.TabIndex = 10;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less Importance"});
            this.comboBox1.Location = new System.Drawing.Point(461, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoSize = true;
            this.importanceLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceLabel.Location = new System.Drawing.Point(372, 236);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(83, 16);
            this.importanceLabel.TabIndex = 13;
            this.importanceLabel.Text = "Importance";
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 485);
            this.Controls.Add(this.importanceLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.createPictureBox);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.eventnameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "CreateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.createEvent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox eventnameTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.PictureBox createPictureBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label importanceLabel;
    }
}

namespace Digital_Photo_Diary.Windows_Forms
{
    partial class SavedEvents
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
            this.importanceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.storyGroupBox = new System.Windows.Forms.GroupBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.iLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.storyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoSize = true;
            this.importanceLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceLabel.Location = new System.Drawing.Point(535, 52);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(83, 16);
            this.importanceLabel.TabIndex = 27;
            this.importanceLabel.Text = "Importance";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(333, 431);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 39);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete Event";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(571, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 39);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save Event";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.Location = new System.Drawing.Point(54, 233);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(58, 16);
            this.pictureLabel.TabIndex = 20;
            this.pictureLabel.Text = "Pictures";
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(184, 22);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(86, 16);
            this.selectLabel.TabIndex = 28;
            this.selectLabel.Text = "Select Event";
            this.selectLabel.Click += new System.EventHandler(this.selectLabel_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(276, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(452, 431);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 39);
            this.editButton.TabIndex = 30;
            this.editButton.Text = "Edit Event";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(540, 21);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(78, 16);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Event Date";
            // 
            // storyGroupBox
            // 
            this.storyGroupBox.Controls.Add(this.storyLabel);
            this.storyGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyGroupBox.Location = new System.Drawing.Point(57, 72);
            this.storyGroupBox.Name = "storyGroupBox";
            this.storyGroupBox.Size = new System.Drawing.Size(517, 144);
            this.storyGroupBox.TabIndex = 32;
            this.storyGroupBox.TabStop = false;
            this.storyGroupBox.Text = "Story";
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Location = new System.Drawing.Point(29, 22);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(43, 16);
            this.storyLabel.TabIndex = 0;
            this.storyLabel.Text = "Story";
            this.storyLabel.Visible = false;
            // 
            // iLabel
            // 
            this.iLabel.AutoSize = true;
            this.iLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLabel.Location = new System.Drawing.Point(624, 52);
            this.iLabel.Name = "iLabel";
            this.iLabel.Size = new System.Drawing.Size(83, 16);
            this.iLabel.TabIndex = 33;
            this.iLabel.Text = "Importance";
            this.iLabel.Visible = false;
            this.iLabel.Click += new System.EventHandler(this.iLabel_Click);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(624, 21);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(37, 16);
            this.dLabel.TabIndex = 34;
            this.dLabel.Text = "Date";
            this.dLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 446);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 24);
            this.backButton.TabIndex = 35;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 192);
            this.panel1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 24);
            this.button1.TabIndex = 37;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(57, 19);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(111, 24);
            this.showButton.TabIndex = 38;
            this.showButton.Text = "Show Events";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // SavedEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 485);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.iLabel);
            this.Controls.Add(this.storyGroupBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.importanceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureLabel);
            this.Name = "SavedEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saved Events";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SavedEvents_FormClosing);
            this.Load += new System.EventHandler(this.SavedEvents_Load);
            this.storyGroupBox.ResumeLayout(false);
            this.storyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label importanceLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox storyGroupBox;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label iLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showButton;
    }
}
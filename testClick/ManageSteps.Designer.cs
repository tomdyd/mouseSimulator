namespace testClick
{
    partial class ManageSteps
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
            stepsList = new ListBox();
            Delete_btn = new Button();
            Edit_btn = new Button();
            SuspendLayout();
            // 
            // stepsList
            // 
            stepsList.FormattingEnabled = true;
            stepsList.ItemHeight = 15;
            stepsList.Location = new Point(12, 12);
            stepsList.Name = "stepsList";
            stepsList.Size = new Size(255, 229);
            stepsList.TabIndex = 0;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(147, 258);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(120, 29);
            Delete_btn.TabIndex = 1;
            Delete_btn.Text = "Usuń";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.Location = new Point(12, 258);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(120, 29);
            Edit_btn.TabIndex = 2;
            Edit_btn.Text = "Edytuj";
            Edit_btn.UseVisualStyleBackColor = true;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // ManageSteps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 309);
            Controls.Add(Edit_btn);
            Controls.Add(Delete_btn);
            Controls.Add(stepsList);
            Name = "ManageSteps";
            Text = "ManageSteps";
            FormClosing += ManageSteps_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox stepsList;
        private Button Delete_btn;
        private Button Edit_btn;
    }
}
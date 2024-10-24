namespace testClick
{
    partial class EditPoint
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
            xPos = new TextBox();
            yPos = new TextBox();
            Ok_btn = new Button();
            Cancel_btn = new Button();
            xPosLabel = new Label();
            yPosLabel = new Label();
            SuspendLayout();
            // 
            // xPos
            // 
            xPos.Location = new Point(23, 40);
            xPos.Name = "xPos";
            xPos.Size = new Size(137, 23);
            xPos.TabIndex = 0;
            xPos.Enabled = false;
            // 
            // yPos
            // 
            yPos.Location = new Point(178, 40);
            yPos.Name = "yPos";
            yPos.Size = new Size(137, 23);
            yPos.TabIndex = 1;
            yPos.Enabled = false;
            // 
            // Ok_btn
            // 
            Ok_btn.Location = new Point(60, 90);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(100, 29);
            Ok_btn.TabIndex = 2;
            Ok_btn.Text = "Ok";
            Ok_btn.UseVisualStyleBackColor = true;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(178, 90);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(100, 29);
            Cancel_btn.TabIndex = 3;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // xPosLabel
            // 
            xPosLabel.AutoSize = true;
            xPosLabel.Location = new Point(23, 22);
            xPosLabel.Name = "xPosLabel";
            xPosLabel.Size = new Size(88, 15);
            xPosLabel.TabIndex = 4;
            xPosLabel.Text = "Współrzędne X:";
            // 
            // yPosLabel
            // 
            yPosLabel.AutoSize = true;
            yPosLabel.Location = new Point(178, 22);
            yPosLabel.Name = "yPosLabel";
            yPosLabel.Size = new Size(88, 15);
            yPosLabel.TabIndex = 5;
            yPosLabel.Text = "Współrzędne Y:";
            // 
            // EditPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 125);
            Controls.Add(yPosLabel);
            Controls.Add(xPosLabel);
            Controls.Add(Cancel_btn);
            Controls.Add(Ok_btn);
            Controls.Add(yPos);
            Controls.Add(xPos);
            Name = "EditPoint";
            Text = "EditPoint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox xPos;
        private TextBox yPos;
        private Button Ok_btn;
        private Button Cancel_btn;
        private Label xPosLabel;
        private Label yPosLabel;
    }
}
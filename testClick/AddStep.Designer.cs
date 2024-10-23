namespace testClick
{
    partial class AddStep
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
            components = new System.ComponentModel.Container();
            currentY = new Label();
            currentX = new Label();
            yPos = new TextBox();
            xPos = new TextBox();
            yPosLabel = new Label();
            xPosLabel = new Label();
            AddBtn = new Button();
            timerCursor = new System.Windows.Forms.Timer(components);
            Ok_btn = new Button();
            SuspendLayout();
            // 
            // currentY
            // 
            currentY.AutoSize = true;
            currentY.Location = new Point(163, 225);
            currentY.Name = "currentY";
            currentY.Size = new Size(20, 15);
            currentY.TabIndex = 17;
            currentY.Text = "Y: ";
            // 
            // currentX
            // 
            currentX.AutoSize = true;
            currentX.Location = new Point(102, 225);
            currentX.Name = "currentX";
            currentX.Size = new Size(20, 15);
            currentX.TabIndex = 16;
            currentX.Text = "X: ";
            // 
            // yPos
            // 
            yPos.Location = new Point(83, 111);
            yPos.Name = "yPos";
            yPos.Size = new Size(122, 23);
            yPos.TabIndex = 13;
            // 
            // xPos
            // 
            xPos.Location = new Point(83, 52);
            xPos.Name = "xPos";
            xPos.Size = new Size(122, 23);
            xPos.TabIndex = 12;
            // 
            // yPosLabel
            // 
            yPosLabel.AutoSize = true;
            yPosLabel.Location = new Point(83, 92);
            yPosLabel.Name = "yPosLabel";
            yPosLabel.Size = new Size(122, 15);
            yPosLabel.TabIndex = 11;
            yPosLabel.Text = "Pozycja kursora (oś Y)";
            // 
            // xPosLabel
            // 
            xPosLabel.AutoSize = true;
            xPosLabel.Location = new Point(83, 34);
            xPosLabel.Name = "xPosLabel";
            xPosLabel.Size = new Size(122, 15);
            xPosLabel.TabIndex = 10;
            xPosLabel.Text = "Pozycja kursora (oś X)";
            // 
            // AddBtn
            // 
            AddBtn.AccessibleName = "";
            AddBtn.Location = new Point(83, 159);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(122, 29);
            AddBtn.TabIndex = 9;
            AddBtn.Text = "Dodaj krok";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // Ok_btn
            // 
            Ok_btn.Location = new Point(83, 259);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(122, 29);
            Ok_btn.TabIndex = 18;
            Ok_btn.Text = "Ok";
            Ok_btn.UseVisualStyleBackColor = true;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // AddStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 316);
            Controls.Add(Ok_btn);
            Controls.Add(currentY);
            Controls.Add(currentX);
            Controls.Add(yPos);
            Controls.Add(xPos);
            Controls.Add(yPosLabel);
            Controls.Add(xPosLabel);
            Controls.Add(AddBtn);
            Name = "AddStep";
            Text = "AddStep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentY;
        private Label currentX;
        private TextBox yPos;
        private TextBox xPos;
        private Label yPosLabel;
        private Label xPosLabel;
        private Button AddBtn;
        private System.Windows.Forms.Timer timerCursor;
        private Button Ok_btn;
    }
}
namespace testClick
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            StartSimulationButton = new Button();
            xPosLabel = new Label();
            yPosLabel = new Label();
            xPos = new TextBox();
            yPos = new TextBox();
            sleepTimeLabel = new Label();
            sleepTime = new TextBox();
            currentX = new Label();
            currentY = new Label();
            timerCursor = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // StartSimulationButton
            // 
            StartSimulationButton.AccessibleName = "";
            StartSimulationButton.Location = new Point(65, 204);
            StartSimulationButton.Name = "StartSimulationButton";
            StartSimulationButton.Size = new Size(122, 29);
            StartSimulationButton.TabIndex = 0;
            StartSimulationButton.Text = "Start";
            StartSimulationButton.UseVisualStyleBackColor = true;
            StartSimulationButton.Click += StartSimulationButton_Click;
            // 
            // xPosLabel
            // 
            xPosLabel.AutoSize = true;
            xPosLabel.Location = new Point(65, 32);
            xPosLabel.Name = "xPosLabel";
            xPosLabel.Size = new Size(122, 15);
            xPosLabel.TabIndex = 1;
            xPosLabel.Text = "Pozycja kursora (oś X)";
            // 
            // yPosLabel
            // 
            yPosLabel.AutoSize = true;
            yPosLabel.Location = new Point(65, 90);
            yPosLabel.Name = "yPosLabel";
            yPosLabel.Size = new Size(122, 15);
            yPosLabel.TabIndex = 2;
            yPosLabel.Text = "Pozycja kursora (oś Y)";
            // 
            // xPos
            // 
            xPos.Location = new Point(65, 50);
            xPos.Name = "xPos";
            xPos.Size = new Size(122, 23);
            xPos.TabIndex = 3;
            // 
            // yPos
            // 
            yPos.Location = new Point(65, 109);
            yPos.Name = "yPos";
            yPos.Size = new Size(122, 23);
            yPos.TabIndex = 4;
            // 
            // sleepTimeLabel
            // 
            sleepTimeLabel.AutoSize = true;
            sleepTimeLabel.Location = new Point(65, 147);
            sleepTimeLabel.Name = "sleepTimeLabel";
            sleepTimeLabel.Size = new Size(119, 15);
            sleepTimeLabel.TabIndex = 5;
            sleepTimeLabel.Text = "Opóźnienie kliknięcia";
            // 
            // sleepTime
            // 
            sleepTime.Location = new Point(65, 165);
            sleepTime.Name = "sleepTime";
            sleepTime.Size = new Size(122, 23);
            sleepTime.TabIndex = 6;
            // 
            // currentX
            // 
            currentX.AutoSize = true;
            currentX.Location = new Point(84, 270);
            currentX.Name = "currentX";
            currentX.Size = new Size(20, 15);
            currentX.TabIndex = 7;
            currentX.Text = "X: ";
            // 
            // currentY
            // 
            currentY.AutoSize = true;
            currentY.Location = new Point(145, 270);
            currentY.Name = "currentY";
            currentY.Size = new Size(20, 15);
            currentY.TabIndex = 8;
            currentY.Text = "Y: ";
            // 
            // timerCursor
            // 
            timerCursor.Tick += TimerCursor_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 317);
            Controls.Add(currentY);
            Controls.Add(currentX);
            Controls.Add(sleepTime);
            Controls.Add(sleepTimeLabel);
            Controls.Add(yPos);
            Controls.Add(xPos);
            Controls.Add(yPosLabel);
            Controls.Add(xPosLabel);
            Controls.Add(StartSimulationButton);
            Name = "Form1";
            Text = "Mouse Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartSimulationButton;
        private Label xPosLabel;
        private Label yPosLabel;
        private TextBox xPos;
        private TextBox yPos;
        private Label sleepTimeLabel;
        private TextBox sleepTime;
        private Label currentX;
        private Label currentY;
        private System.Windows.Forms.Timer timerCursor;
    }
}

namespace testClick
{
    partial class HomeForm
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
            StartSimulationButton = new Button();
            AddStepBtn = new Button();
            sleepTime = new TextBox();
            sleepTimeLabel = new Label();
            ManageSteps = new Button();
            SuspendLayout();
            // 
            // StartSimulationButton
            // 
            StartSimulationButton.AccessibleName = "";
            StartSimulationButton.Location = new Point(69, 199);
            StartSimulationButton.Name = "StartSimulationButton";
            StartSimulationButton.Size = new Size(122, 29);
            StartSimulationButton.TabIndex = 0;
            StartSimulationButton.Text = "Start";
            StartSimulationButton.UseVisualStyleBackColor = true;
            StartSimulationButton.Click += StartSimulationButton_Click;
            // 
            // AddStepBtn
            // 
            AddStepBtn.AccessibleName = "";
            AddStepBtn.Location = new Point(69, 25);
            AddStepBtn.Name = "AddStepBtn";
            AddStepBtn.Size = new Size(122, 31);
            AddStepBtn.TabIndex = 1;
            AddStepBtn.Text = "Dodaj krok";
            AddStepBtn.UseVisualStyleBackColor = true;
            AddStepBtn.Click += AddStepBtn_Click;
            // 
            // sleepTime
            // 
            sleepTime.Location = new Point(69, 133);
            sleepTime.Name = "sleepTime";
            sleepTime.Size = new Size(122, 23);
            sleepTime.TabIndex = 17;
            // 
            // sleepTimeLabel
            // 
            sleepTimeLabel.AutoSize = true;
            sleepTimeLabel.Location = new Point(69, 115);
            sleepTimeLabel.Name = "sleepTimeLabel";
            sleepTimeLabel.Size = new Size(119, 15);
            sleepTimeLabel.TabIndex = 16;
            sleepTimeLabel.Text = "Opóźnienie kliknięcia";
            // 
            // ManageSteps
            // 
            ManageSteps.AccessibleName = "";
            ManageSteps.Location = new Point(69, 70);
            ManageSteps.Name = "ManageSteps";
            ManageSteps.Size = new Size(122, 29);
            ManageSteps.TabIndex = 18;
            ManageSteps.Text = "Zarządzaj krokami";
            ManageSteps.UseVisualStyleBackColor = true;
            ManageSteps.Click += ManageSteps_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(259, 262);
            Controls.Add(ManageSteps);
            Controls.Add(sleepTime);
            Controls.Add(sleepTimeLabel);
            Controls.Add(AddStepBtn);
            Controls.Add(StartSimulationButton);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mouse Simulator";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartSimulationButton;
        private Button AddStepBtn;
        private TextBox sleepTime;
        private Label sleepTimeLabel;
        private Button ManageSteps;
    }
}

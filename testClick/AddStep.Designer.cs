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
            timerCursor = new System.Windows.Forms.Timer(components);
            ControlTab = new TabControl();
            ClickTab = new TabPage();
            xPos = new TextBox();
            Ok_btn = new Button();
            currentY = new Label();
            currentX = new Label();
            yPos = new TextBox();
            yPosLabel = new Label();
            xPosLabel = new Label();
            AddBtn = new Button();
            scrollTab = new TabPage();
            ScrollOk_btn = new Button();
            AddScroll_btn = new Button();
            scrollValue = new TextBox();
            label1 = new Label();
            ControlTab.SuspendLayout();
            ClickTab.SuspendLayout();
            scrollTab.SuspendLayout();
            SuspendLayout();
            // 
            // ControlTab
            // 
            ControlTab.Controls.Add(ClickTab);
            ControlTab.Controls.Add(scrollTab);
            ControlTab.Location = new Point(1, 1);
            ControlTab.Name = "ControlTab";
            ControlTab.SelectedIndex = 0;
            ControlTab.Size = new Size(294, 313);
            ControlTab.TabIndex = 0;
            // 
            // ClickTab
            // 
            ClickTab.Controls.Add(xPos);
            ClickTab.Controls.Add(Ok_btn);
            ClickTab.Controls.Add(currentY);
            ClickTab.Controls.Add(currentX);
            ClickTab.Controls.Add(yPos);
            ClickTab.Controls.Add(yPosLabel);
            ClickTab.Controls.Add(xPosLabel);
            ClickTab.Controls.Add(AddBtn);
            ClickTab.Location = new Point(4, 24);
            ClickTab.Name = "ClickTab";
            ClickTab.Padding = new Padding(3);
            ClickTab.Size = new Size(286, 285);
            ClickTab.TabIndex = 0;
            ClickTab.Text = "Click";
            ClickTab.UseVisualStyleBackColor = true;
            // 
            // xPos
            // 
            xPos.Location = new Point(82, 33);
            xPos.Name = "xPos";
            xPos.Size = new Size(122, 23);
            xPos.TabIndex = 43;
            // 
            // Ok_btn
            // 
            Ok_btn.Location = new Point(82, 240);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(122, 29);
            Ok_btn.TabIndex = 42;
            Ok_btn.Text = "Ok";
            Ok_btn.UseVisualStyleBackColor = true;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // currentY
            // 
            currentY.AutoSize = true;
            currentY.Location = new Point(162, 206);
            currentY.Name = "currentY";
            currentY.Size = new Size(20, 15);
            currentY.TabIndex = 41;
            currentY.Text = "Y: ";
            // 
            // currentX
            // 
            currentX.AutoSize = true;
            currentX.Location = new Point(101, 206);
            currentX.Name = "currentX";
            currentX.Size = new Size(20, 15);
            currentX.TabIndex = 40;
            currentX.Text = "X: ";
            // 
            // yPos
            // 
            yPos.Location = new Point(82, 92);
            yPos.Name = "yPos";
            yPos.Size = new Size(122, 23);
            yPos.TabIndex = 39;
            // 
            // yPosLabel
            // 
            yPosLabel.AutoSize = true;
            yPosLabel.Location = new Point(82, 73);
            yPosLabel.Name = "yPosLabel";
            yPosLabel.Size = new Size(122, 15);
            yPosLabel.TabIndex = 37;
            yPosLabel.Text = "Pozycja kursora (oś Y)";
            // 
            // xPosLabel
            // 
            xPosLabel.AutoSize = true;
            xPosLabel.Location = new Point(82, 15);
            xPosLabel.Name = "xPosLabel";
            xPosLabel.Size = new Size(122, 15);
            xPosLabel.TabIndex = 36;
            xPosLabel.Text = "Pozycja kursora (oś X)";
            // 
            // AddBtn
            // 
            AddBtn.AccessibleName = "";
            AddBtn.Location = new Point(82, 140);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(122, 29);
            AddBtn.TabIndex = 35;
            AddBtn.Text = "Dodaj krok";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // scrollTab
            // 
            scrollTab.Controls.Add(ScrollOk_btn);
            scrollTab.Controls.Add(AddScroll_btn);
            scrollTab.Controls.Add(scrollValue);
            scrollTab.Controls.Add(label1);
            scrollTab.Location = new Point(4, 24);
            scrollTab.Name = "scrollTab";
            scrollTab.Padding = new Padding(3);
            scrollTab.Size = new Size(286, 285);
            scrollTab.TabIndex = 1;
            scrollTab.Text = "Scroll";
            scrollTab.UseVisualStyleBackColor = true;
            // 
            // ScrollOk_btn
            // 
            ScrollOk_btn.Location = new Point(66, 244);
            ScrollOk_btn.Name = "ScrollOk_btn";
            ScrollOk_btn.Size = new Size(149, 29);
            ScrollOk_btn.TabIndex = 47;
            ScrollOk_btn.Text = "Ok";
            ScrollOk_btn.UseVisualStyleBackColor = true;
            ScrollOk_btn.Click += ScrollOk_btn_Click;
            // 
            // AddScroll_btn
            // 
            AddScroll_btn.Location = new Point(66, 115);
            AddScroll_btn.Name = "AddScroll_btn";
            AddScroll_btn.Size = new Size(149, 29);
            AddScroll_btn.TabIndex = 46;
            AddScroll_btn.Text = "Dodaj scroll";
            AddScroll_btn.UseVisualStyleBackColor = true;
            AddScroll_btn.Click += AddScroll_btn_Click;
            // 
            // scrollValue
            // 
            scrollValue.Location = new Point(66, 86);
            scrollValue.Name = "scrollValue";
            scrollValue.Size = new Size(149, 23);
            scrollValue.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 68);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 44;
            label1.Text = "Podaj wartość przesunięcia";
            // 
            // AddStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 310);
            Controls.Add(ControlTab);
            Name = "AddStep";
            Text = "AddStep";
            ControlTab.ResumeLayout(false);
            ClickTab.ResumeLayout(false);
            ClickTab.PerformLayout();
            scrollTab.ResumeLayout(false);
            scrollTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerCursor;
        private TabControl ControlTab;
        private TabPage ClickTab;
        private TabPage scrollTab;
        private Button Ok_btn;
        private Label currentY;
        private Label currentX;
        private TextBox yPos;
        private Label yPosLabel;
        private Label xPosLabel;
        private Button AddBtn;
        private TextBox xPos;
        private Button AddScroll_btn;
        private TextBox scrollValue;
        private Label label1;
        private Button ScrollOk_btn;
    }
}
namespace testClick
{
    partial class EditScroll
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
            scrollValue = new TextBox();
            valueLabel = new Label();
            Ok_btn = new Button();
            Cancel_btn = new Button();
            SuspendLayout();
            // 
            // scrollValue
            // 
            scrollValue.Location = new Point(165, 35);
            scrollValue.Name = "scrollValue";
            scrollValue.Size = new Size(112, 23);
            scrollValue.TabIndex = 0;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(165, 17);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(112, 15);
            valueLabel.TabIndex = 1;
            valueLabel.Text = "Nowa watość scroll:";
            // 
            // Ok_btn
            // 
            Ok_btn.Location = new Point(123, 70);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(93, 29);
            Ok_btn.TabIndex = 2;
            Ok_btn.Text = "Ok";
            Ok_btn.UseVisualStyleBackColor = true;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.Location = new Point(222, 70);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(93, 29);
            Cancel_btn.TabIndex = 3;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = true;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // EditScroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 105);
            Controls.Add(Cancel_btn);
            Controls.Add(Ok_btn);
            Controls.Add(valueLabel);
            Controls.Add(scrollValue);
            Name = "EditScroll";
            Text = "EditScroll";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox scrollValue;
        private Label valueLabel;
        private Button Ok_btn;
        private Button Cancel_btn;
    }
}
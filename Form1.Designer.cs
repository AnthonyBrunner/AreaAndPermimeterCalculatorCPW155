namespace AreaAndPermimeterCalculator
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
            calculateButton = new Button();
            lengthText = new TextBox();
            widthText = new TextBox();
            areaText = new TextBox();
            lengthLabel = new Label();
            widthLabel = new Label();
            areaLabel = new Label();
            perimeterText = new TextBox();
            perimeterLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(46, 195);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(118, 59);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate Area and Perimeter";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // lengthText
            // 
            lengthText.Location = new Point(95, 33);
            lengthText.Name = "lengthText";
            lengthText.Size = new Size(100, 23);
            lengthText.TabIndex = 1;
            // 
            // widthText
            // 
            widthText.Location = new Point(95, 70);
            widthText.Name = "widthText";
            widthText.Size = new Size(100, 23);
            widthText.TabIndex = 2;
            // 
            // areaText
            // 
            areaText.Location = new Point(95, 109);
            areaText.Name = "areaText";
            areaText.Size = new Size(100, 23);
            areaText.TabIndex = 3;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(31, 41);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(44, 15);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(36, 78);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(39, 15);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Width";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new Point(39, 117);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(31, 15);
            areaLabel.TabIndex = 6;
            areaLabel.Text = "Area";
            // 
            // perimeterText
            // 
            perimeterText.Location = new Point(95, 150);
            perimeterText.Name = "perimeterText";
            perimeterText.Size = new Size(100, 23);
            perimeterText.TabIndex = 7;
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Location = new Point(12, 158);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(58, 15);
            perimeterLabel.TabIndex = 8;
            perimeterLabel.Text = "Perimeter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 292);
            Controls.Add(perimeterLabel);
            Controls.Add(perimeterText);
            Controls.Add(areaLabel);
            Controls.Add(widthLabel);
            Controls.Add(lengthLabel);
            Controls.Add(areaText);
            Controls.Add(widthText);
            Controls.Add(lengthText);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Area and Perimeter Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox lengthText;
        private TextBox widthText;
        private TextBox areaText;
        private Label lengthLabel;
        private Label widthLabel;
        private Label areaLabel;
        private TextBox perimeterText;
        private Label perimeterLabel;
    }
}

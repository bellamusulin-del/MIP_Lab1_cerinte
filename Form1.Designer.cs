namespace MIPLAB1
{
    partial class Form1
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
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(336, 112);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "button1";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(12, 212);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "button2";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(690, 212);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "button3";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(336, 395);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "button4";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(405, 235);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 22);
            this.resultTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(353, 241);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 16);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(242, 234);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(242, 203);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(438, 203);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 22);
            this.intervalTextBox.TabIndex = 8;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(353, 203);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(79, 16);
            this.intervalLabel.TabIndex = 9;
            this.intervalLabel.Text = "Interval (ms)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label intervalLabel;
    }
}


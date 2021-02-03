namespace TriviaQuiz
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
            this.Question1Answers = new System.Windows.Forms.ComboBox();
            this.Question1Label = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AnswerOuput = new System.Windows.Forms.TextBox();
            this.Question5Label = new System.Windows.Forms.Label();
            this.Question5Answers = new System.Windows.Forms.ComboBox();
            this.Question4Label = new System.Windows.Forms.Label();
            this.Question4Answers = new System.Windows.Forms.ComboBox();
            this.Question3Label = new System.Windows.Forms.Label();
            this.Question3Answers = new System.Windows.Forms.ComboBox();
            this.Question2Label = new System.Windows.Forms.Label();
            this.Question2Answers = new System.Windows.Forms.ComboBox();
            this.btnNewQs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question1Answers
            // 
            this.Question1Answers.FormattingEnabled = true;
            this.Question1Answers.Location = new System.Drawing.Point(42, 52);
            this.Question1Answers.Name = "Question1Answers";
            this.Question1Answers.Size = new System.Drawing.Size(656, 21);
            this.Question1Answers.TabIndex = 0;
            this.Question1Answers.Text = "-Select an answer-";
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Location = new System.Drawing.Point(45, 32);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(61, 13);
            this.Question1Label.TabIndex = 1;
            this.Question1Label.Text = "Question 1:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(42, 537);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(175, 32);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AnswerOuput
            // 
            this.AnswerOuput.Location = new System.Drawing.Point(827, 32);
            this.AnswerOuput.Multiline = true;
            this.AnswerOuput.Name = "AnswerOuput";
            this.AnswerOuput.ReadOnly = true;
            this.AnswerOuput.Size = new System.Drawing.Size(291, 537);
            this.AnswerOuput.TabIndex = 3;
            // 
            // Question5Label
            // 
            this.Question5Label.AutoSize = true;
            this.Question5Label.Location = new System.Drawing.Point(45, 279);
            this.Question5Label.Name = "Question5Label";
            this.Question5Label.Size = new System.Drawing.Size(61, 13);
            this.Question5Label.TabIndex = 5;
            this.Question5Label.Text = "Question 5:";
            // 
            // Question5Answers
            // 
            this.Question5Answers.FormattingEnabled = true;
            this.Question5Answers.Location = new System.Drawing.Point(42, 304);
            this.Question5Answers.Name = "Question5Answers";
            this.Question5Answers.Size = new System.Drawing.Size(656, 21);
            this.Question5Answers.TabIndex = 4;
            this.Question5Answers.Text = "-Select an answer-";
            // 
            // Question4Label
            // 
            this.Question4Label.AutoSize = true;
            this.Question4Label.Location = new System.Drawing.Point(45, 213);
            this.Question4Label.Name = "Question4Label";
            this.Question4Label.Size = new System.Drawing.Size(61, 13);
            this.Question4Label.TabIndex = 7;
            this.Question4Label.Text = "Question 4:";
            // 
            // Question4Answers
            // 
            this.Question4Answers.FormattingEnabled = true;
            this.Question4Answers.Location = new System.Drawing.Point(42, 233);
            this.Question4Answers.Name = "Question4Answers";
            this.Question4Answers.Size = new System.Drawing.Size(656, 21);
            this.Question4Answers.TabIndex = 6;
            this.Question4Answers.Text = "-Select an answer-";
            // 
            // Question3Label
            // 
            this.Question3Label.AutoSize = true;
            this.Question3Label.Location = new System.Drawing.Point(45, 152);
            this.Question3Label.Name = "Question3Label";
            this.Question3Label.Size = new System.Drawing.Size(61, 13);
            this.Question3Label.TabIndex = 9;
            this.Question3Label.Text = "Question 3:";
            // 
            // Question3Answers
            // 
            this.Question3Answers.FormattingEnabled = true;
            this.Question3Answers.Location = new System.Drawing.Point(42, 172);
            this.Question3Answers.Name = "Question3Answers";
            this.Question3Answers.Size = new System.Drawing.Size(656, 21);
            this.Question3Answers.TabIndex = 8;
            this.Question3Answers.Text = "-Select an answer-";
            // 
            // Question2Label
            // 
            this.Question2Label.AutoSize = true;
            this.Question2Label.Location = new System.Drawing.Point(45, 92);
            this.Question2Label.Name = "Question2Label";
            this.Question2Label.Size = new System.Drawing.Size(61, 13);
            this.Question2Label.TabIndex = 11;
            this.Question2Label.Text = "Question 2:";
            // 
            // Question2Answers
            // 
            this.Question2Answers.FormattingEnabled = true;
            this.Question2Answers.Location = new System.Drawing.Point(42, 112);
            this.Question2Answers.Name = "Question2Answers";
            this.Question2Answers.Size = new System.Drawing.Size(656, 21);
            this.Question2Answers.TabIndex = 10;
            this.Question2Answers.Text = "-Select an answer-";
            // 
            // btnNewQs
            // 
            this.btnNewQs.Location = new System.Drawing.Point(304, 538);
            this.btnNewQs.Name = "btnNewQs";
            this.btnNewQs.Size = new System.Drawing.Size(187, 32);
            this.btnNewQs.TabIndex = 12;
            this.btnNewQs.Text = "New Questions";
            this.btnNewQs.UseVisualStyleBackColor = true;
            this.btnNewQs.Click += new System.EventHandler(this.btnNewQs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 625);
            this.Controls.Add(this.btnNewQs);
            this.Controls.Add(this.Question2Label);
            this.Controls.Add(this.Question2Answers);
            this.Controls.Add(this.Question3Label);
            this.Controls.Add(this.Question3Answers);
            this.Controls.Add(this.Question4Label);
            this.Controls.Add(this.Question4Answers);
            this.Controls.Add(this.Question5Label);
            this.Controls.Add(this.Question5Answers);
            this.Controls.Add(this.AnswerOuput);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Question1Label);
            this.Controls.Add(this.Question1Answers);
            this.Name = "Form1";
            this.Text = "Trivia Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Question1Answers;
        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox AnswerOuput;
        private System.Windows.Forms.Label Question5Label;
        private System.Windows.Forms.ComboBox Question5Answers;
        private System.Windows.Forms.Label Question4Label;
        private System.Windows.Forms.ComboBox Question4Answers;
        private System.Windows.Forms.Label Question3Label;
        private System.Windows.Forms.ComboBox Question3Answers;
        private System.Windows.Forms.Label Question2Label;
        private System.Windows.Forms.ComboBox Question2Answers;
        private System.Windows.Forms.Button btnNewQs;
    }
}


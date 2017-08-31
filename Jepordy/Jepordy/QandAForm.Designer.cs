namespace Jepordy
{
    partial class QandAForm
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
            this.components = new System.ComponentModel.Container();
            this.txtQuestionDisplay = new System.Windows.Forms.TextBox();
            this.btnAnswerP1 = new System.Windows.Forms.Button();
            this.btnAnswerP2 = new System.Windows.Forms.Button();
            this.btnAnswerP3 = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblGuessingPlayer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuestionDisplay
            // 
            this.txtQuestionDisplay.BackColor = System.Drawing.Color.Blue;
            this.txtQuestionDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtQuestionDisplay.Multiline = true;
            this.txtQuestionDisplay.Name = "txtQuestionDisplay";
            this.txtQuestionDisplay.ReadOnly = true;
            this.txtQuestionDisplay.Size = new System.Drawing.Size(424, 283);
            this.txtQuestionDisplay.TabIndex = 0;
            this.txtQuestionDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuestionDisplay.WordWrap = false;
            // 
            // btnAnswerP1
            // 
            this.btnAnswerP1.Location = new System.Drawing.Point(32, 501);
            this.btnAnswerP1.Name = "btnAnswerP1";
            this.btnAnswerP1.Size = new System.Drawing.Size(89, 84);
            this.btnAnswerP1.TabIndex = 1;
            this.btnAnswerP1.Text = "button1";
            this.btnAnswerP1.UseVisualStyleBackColor = true;
            this.btnAnswerP1.Click += new System.EventHandler(this.AttemptGuess);
            // 
            // btnAnswerP2
            // 
            this.btnAnswerP2.Location = new System.Drawing.Point(173, 501);
            this.btnAnswerP2.Name = "btnAnswerP2";
            this.btnAnswerP2.Size = new System.Drawing.Size(89, 84);
            this.btnAnswerP2.TabIndex = 2;
            this.btnAnswerP2.Text = "button2";
            this.btnAnswerP2.UseVisualStyleBackColor = true;
            this.btnAnswerP2.Click += new System.EventHandler(this.AttemptGuess);
            // 
            // btnAnswerP3
            // 
            this.btnAnswerP3.Location = new System.Drawing.Point(313, 501);
            this.btnAnswerP3.Name = "btnAnswerP3";
            this.btnAnswerP3.Size = new System.Drawing.Size(89, 84);
            this.btnAnswerP3.TabIndex = 3;
            this.btnAnswerP3.Text = "button3";
            this.btnAnswerP3.UseVisualStyleBackColor = true;
            this.btnAnswerP3.Click += new System.EventHandler(this.AttemptGuess);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtAnswer.Location = new System.Drawing.Point(32, 402);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(334, 57);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "Type your answer here.";
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuessingPlayer
            // 
            this.lblGuessingPlayer.AutoSize = true;
            this.lblGuessingPlayer.Location = new System.Drawing.Point(203, 308);
            this.lblGuessingPlayer.Name = "lblGuessingPlayer";
            this.lblGuessingPlayer.Size = new System.Drawing.Size(18, 18);
            this.lblGuessingPlayer.TabIndex = 5;
            this.lblGuessingPlayer.Text = "+";
            this.lblGuessingPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(372, 402);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(64, 57);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(202, 357);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(25, 24);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "+";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QandAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Jepordy.Properties.Resources.Jepbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 604);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblGuessingPlayer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnAnswerP3);
            this.Controls.Add(this.btnAnswerP2);
            this.Controls.Add(this.btnAnswerP1);
            this.Controls.Add(this.txtQuestionDisplay);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "QandAForm";
            this.Text = "QandAForm";
            this.Load += new System.EventHandler(this.QandAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestionDisplay;
        private System.Windows.Forms.Button btnAnswerP1;
        private System.Windows.Forms.Button btnAnswerP2;
        private System.Windows.Forms.Button btnAnswerP3;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblGuessingPlayer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
    }
}
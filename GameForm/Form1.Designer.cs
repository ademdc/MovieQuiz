namespace GameForm
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1Text = new System.Windows.Forms.TextBox();
            this.player2Text = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.player2CountLabel = new System.Windows.Forms.Label();
            this.player1CountLabel = new System.Windows.Forms.Label();
            this.newQuestionBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(222, 437);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(112, 35);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Text = "Submit";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(18, 49);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(57, 20);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1";
            // 
            // player1Text
            // 
            this.player1Text.Location = new System.Drawing.Point(18, 212);
            this.player1Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player1Text.Name = "player1Text";
            this.player1Text.Size = new System.Drawing.Size(235, 26);
            this.player1Text.TabIndex = 5;
            // 
            // player2Text
            // 
            this.player2Text.Location = new System.Drawing.Point(312, 212);
            this.player2Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player2Text.Name = "player2Text";
            this.player2Text.Size = new System.Drawing.Size(235, 26);
            this.player2Text.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(18, 491);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 20);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result";
            // 
            // player2CountLabel
            // 
            this.player2CountLabel.AutoSize = true;
            this.player2CountLabel.Location = new System.Drawing.Point(530, 437);
            this.player2CountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2CountLabel.Name = "player2CountLabel";
            this.player2CountLabel.Size = new System.Drawing.Size(18, 20);
            this.player2CountLabel.TabIndex = 8;
            this.player2CountLabel.Text = "0";
            // 
            // player1CountLabel
            // 
            this.player1CountLabel.AutoSize = true;
            this.player1CountLabel.Location = new System.Drawing.Point(14, 366);
            this.player1CountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1CountLabel.Name = "player1CountLabel";
            this.player1CountLabel.Size = new System.Drawing.Size(18, 20);
            this.player1CountLabel.TabIndex = 9;
            this.player1CountLabel.Text = "0";
            // 
            // newQuestionBtn
            // 
            this.newQuestionBtn.Location = new System.Drawing.Point(18, 74);
            this.newQuestionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newQuestionBtn.Name = "newQuestionBtn";
            this.newQuestionBtn.Size = new System.Drawing.Size(130, 34);
            this.newQuestionBtn.TabIndex = 10;
            this.newQuestionBtn.Text = "New Question";
            this.newQuestionBtn.UseVisualStyleBackColor = true;
            this.newQuestionBtn.Click += new System.EventHandler(this.newQuestionBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(312, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 533);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newQuestionBtn);
            this.Controls.Add(this.player1CountLabel);
            this.Controls.Add(this.player2CountLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.player2Text);
            this.Controls.Add(this.player1Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox player1Text;
        private System.Windows.Forms.TextBox player2Text;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label player2CountLabel;
        private System.Windows.Forms.Label player1CountLabel;
        private System.Windows.Forms.Button newQuestionBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


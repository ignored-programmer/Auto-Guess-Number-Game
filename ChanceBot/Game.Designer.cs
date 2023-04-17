namespace ChanceBot
{
    partial class Game
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
            lblCounter = new Label();
            lblRandom = new Label();
            inputUser = new TextBox();
            submit = new Button();
            btnBot = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(32, 28);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(50, 20);
            lblCounter.TabIndex = 0;
            lblCounter.Text = "label1";
            // 
            // lblRandom
            // 
            lblRandom.AutoSize = true;
            lblRandom.Location = new Point(32, 60);
            lblRandom.Name = "lblRandom";
            lblRandom.Size = new Size(50, 20);
            lblRandom.TabIndex = 1;
            lblRandom.Text = "label1";
            // 
            // inputUser
            // 
            inputUser.Location = new Point(312, 247);
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(125, 27);
            inputUser.TabIndex = 2;
            // 
            // submit
            // 
            submit.Location = new Point(328, 280);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 3;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // btnBot
            // 
            btnBot.Location = new Point(633, 381);
            btnBot.Name = "btnBot";
            btnBot.Size = new Size(117, 57);
            btnBot.TabIndex = 4;
            btnBot.Text = "Bot";
            btnBot.UseVisualStyleBackColor = true;
            btnBot.Click += btnBot_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(588, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 324);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 6;
            label1.Text = "Your previous guesses";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnBot);
            Controls.Add(submit);
            Controls.Add(inputUser);
            Controls.Add(lblRandom);
            Controls.Add(lblCounter);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chance Bot";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCounter;
        private Label lblRandom;
        private TextBox inputUser;
        private Button submit;
        private Button btnBot;
        private ListBox listBox1;
        private Label label1;
    }
}
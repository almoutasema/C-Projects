
namespace WinFormsApp1
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
            Button = new Button();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PersonalNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ResultTextBox = new TextBox();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(1047, 638);
            Button.Margin = new Padding(5);
            Button.Name = "Button";
            Button.Size = new Size(265, 72);
            Button.TabIndex = 0;
            Button.Text = "Ok";
            Button.UseVisualStyleBackColor = true;
            Button.Click += button1_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(561, 461);
            FirstNameTextBox.Margin = new Padding(5);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.PlaceholderText = "First Name";
            FirstNameTextBox.Size = new Size(351, 39);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(561, 552);
            LastNameTextBox.Margin = new Padding(5);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.PlaceholderText = "Last Name";
            LastNameTextBox.Size = new Size(351, 39);
            LastNameTextBox.TabIndex = 2;
            // 
            // PersonalNumberTextBox
            // 
            PersonalNumberTextBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PersonalNumberTextBox.Location = new Point(561, 638);
            PersonalNumberTextBox.Margin = new Padding(5);
            PersonalNumberTextBox.Name = "PersonalNumberTextBox";
            PersonalNumberTextBox.PlaceholderText = "Personal Number";
            PersonalNumberTextBox.Size = new Size(351, 39);
            PersonalNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(421, 461);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 4;
            label1.Text = "Förnamn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(421, 555);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 5;
            label2.Text = "Efternamn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(421, 653);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 6;
            label3.Text = "Personnr:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(421, 279);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(512, 40);
            label4.TabIndex = 7;
            label4.Text = "Ange  namn  och  personnummer:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(542, 187);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 54);
            label5.TabIndex = 8;
            label5.Text = "VÄLKOMMEN!";
            // 
            // button2
            // 
            button2.Location = new Point(1047, 754);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(265, 72);
            button2.TabIndex = 9;
            button2.Text = "Avsluta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = SystemColors.ScrollBar;
            ResultTextBox.BorderStyle = BorderStyle.FixedSingle;
            ResultTextBox.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ResultTextBox.Location = new Point(432, 883);
            ResultTextBox.Margin = new Padding(5);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.PlaceholderText = "RESULTAT:";
            ResultTextBox.Size = new Size(880, 647);
            ResultTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(2771, 1584);
            Controls.Add(ResultTextBox);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PersonalNumberTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(Button);
            Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button Button;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox PersonalNumberTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox ResultTextBox;
    }
}

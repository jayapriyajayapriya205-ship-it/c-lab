using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormDemo
{
    public class Form1 : Form
    {
        Label title, nameLabel, ageLabel, genderLabel, courseLabel;
        TextBox nameBox, ageBox;
        RadioButton male, female;
        ComboBox courseBox;
        Button registerButton, clearButton;

        public Form1()
        {
            Text = "Student Registration Form";
            Width = 500;
            Height = 450;

            title = new Label();
            title.Text = "STUDENT REGISTRATION";
            title.Font = new Font("Arial", 16);
            title.Location = new Point(130, 30);
            title.AutoSize = true;

            nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(60, 90);

            nameBox = new TextBox();
            nameBox.Location = new Point(180, 90);
            nameBox.Width = 220;

            ageLabel = new Label();
            ageLabel.Text = "Age:";
            ageLabel.Location = new Point(60, 140);

            ageBox = new TextBox();
            ageBox.Location = new Point(180, 140);
            ageBox.Width = 220;

            genderLabel = new Label();
            genderLabel.Text = "Gender:";
            genderLabel.Location = new Point(60, 190);

            male = new RadioButton();
            male.Text = "Male";
            male.Location = new Point(180, 190);

            female = new RadioButton();
            female.Text = "Female";
            female.Location = new Point(260, 190);

            courseLabel = new Label();
            courseLabel.Text = "Course:";
            courseLabel.Location = new Point(60, 240);

            courseBox = new ComboBox();
            courseBox.Location = new Point(180, 240);
            courseBox.Width = 220;
            courseBox.Items.Add("Information Technology");
            courseBox.Items.Add("Computer Science");
            courseBox.Items.Add("Electronics");
            courseBox.Items.Add("Mechanical");

            registerButton = new Button();
            registerButton.Text = "Register";
            registerButton.Location = new Point(150, 300);
            registerButton.Click += RegisterButton_Click;

            clearButton = new Button();
            clearButton.Text = "Clear";
            clearButton.Location = new Point(250, 300);
            clearButton.Click += ClearButton_Click;

            Controls.Add(title);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(ageLabel);
            Controls.Add(ageBox);
            Controls.Add(genderLabel);
            Controls.Add(male);
            Controls.Add(female);
            Controls.Add(courseLabel);
            Controls.Add(courseBox);
            Controls.Add(registerButton);
            Controls.Add(clearButton);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string gender = male.Checked ? "Male" : "Female";

            MessageBox.Show(
                "Registration Successful!\n\n" +
                "Name: " + nameBox.Text + "\n" +
                "Age: " + ageBox.Text + "\n" +
                "Gender: " + gender + "\n" +
                "Course: " + courseBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            ageBox.Clear();
            male.Checked = false;
            female.Checked = false;
            courseBox.SelectedIndex = -1;
        }
    }
}
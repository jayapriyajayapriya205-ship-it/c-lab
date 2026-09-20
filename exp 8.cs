using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormDemo
{
    public class Form1 : Form
    {
        Label title, nameLabel, ageLabel, genderLabel, courseLabel;
        Label hobbyLabel, colorLabel;

        TextBox nameBox, ageBox;

        RadioButton male, female;

        ComboBox courseBox;

        CheckBox programming, drawing, sports;

        Button submitButton, clearButton, colorButton;

        public Form1()
        {
            Text = "Student Registration Form";
            Width = 550;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            title = new Label();
            title.Text = "STUDENT REGISTRATION FORM";
            title.Font = new Font("Arial", 18, FontStyle.Bold);
            title.Location = new Point(120, 30);
            title.AutoSize = true;

            nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(60, 90);
            nameLabel.AutoSize = true;

            nameBox = new TextBox();
            nameBox.Location = new Point(200, 90);
            nameBox.Width = 230;

            ageLabel = new Label();
            ageLabel.Text = "Age:";
            ageLabel.Location = new Point(60, 135);
            ageLabel.AutoSize = true;

            ageBox = new TextBox();
            ageBox.Location = new Point(200, 135);
            ageBox.Width = 230;

            genderLabel = new Label();
            genderLabel.Text = "Gender:";
            genderLabel.Location = new Point(60, 180);
            genderLabel.AutoSize = true;

            male = new RadioButton();
            male.Text = "Male";
            male.Location = new Point(200, 180);

            female = new RadioButton();
            female.Text = "Female";
            female.Location = new Point(280, 180);

            courseLabel = new Label();
            courseLabel.Text = "Course:";
            courseLabel.Location = new Point(60, 225);
            courseLabel.AutoSize = true;

            courseBox = new ComboBox();
            courseBox.Location = new Point(200, 225);
            courseBox.Width = 230;

            courseBox.Items.Add("Information Technology");
            courseBox.Items.Add("Computer Science");
            courseBox.Items.Add("Electronics");
            courseBox.Items.Add("Mechanical");

            hobbyLabel = new Label();
            hobbyLabel.Text = "Hobbies:";
            hobbyLabel.Location = new Point(60, 270);
            hobbyLabel.AutoSize = true;

            programming = new CheckBox();
            programming.Text = "Programming";
            programming.Location = new Point(200, 270);

            drawing = new CheckBox();
            drawing.Text = "Drawing";
            drawing.Location = new Point(320, 270);

            sports = new CheckBox();
            sports.Text = "Sports";
            sports.Location = new Point(200, 305);

            colorLabel = new Label();
            colorLabel.Text = "Background:";
            colorLabel.Location = new Point(60, 350);
            colorLabel.AutoSize = true;

            colorButton = new Button();
            colorButton.Text = "Change Color";
            colorButton.Location = new Point(200, 345);
            colorButton.Click += ColorButton_Click;

            submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Width = 100;
            submitButton.Location = new Point(150, 410);
            submitButton.Click += SubmitButton_Click;

            clearButton = new Button();
            clearButton.Text = "Clear";
            clearButton.Width = 100;
            clearButton.Location = new Point(280, 410);
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
            Controls.Add(hobbyLabel);
            Controls.Add(programming);
            Controls.Add(drawing);
            Controls.Add(sports);
            Controls.Add(colorLabel);
            Controls.Add(colorButton);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            string gender = "";

            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";

            string hobbies = "";

            if (programming.Checked)
                hobbies += "Programming ";

            if (drawing.Checked)
                hobbies += "Drawing ";

            if (sports.Checked)
                hobbies += "Sports";

            MessageBox.Show(
                "Registration Successful!\n\n" +
                "Name: " + nameBox.Text + "\n" +
                "Age: " + ageBox.Text + "\n" +
                "Gender: " + gender + "\n" +
                "Course: " + courseBox.Text + "\n" +
                "Hobbies: " + hobbies);
        }

        private void ClearButton_Click(object? sender, EventArgs e)
        {
            nameBox.Clear();
            ageBox.Clear();

            male.Checked = false;
            female.Checked = false;

            programming.Checked = false;
            drawing.Checked = false;
            sports.Checked = false;

            courseBox.SelectedIndex = -1;
        }

        private void ColorButton_Click(object? sender, EventArgs e)
        {
            if (BackColor == SystemColors.Control)
                BackColor = Color.LightBlue;
            else
                BackColor = SystemColors.Control;
        }
    }
}
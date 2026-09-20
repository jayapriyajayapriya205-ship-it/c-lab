using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDIWithDialog
{
    public class MainForm : Form
    {
        MenuStrip menu;
        ToolStripMenuItem fileMenu;
        ToolStripMenuItem newMenu;
        ToolStripMenuItem dialogMenu;
        ToolStripMenuItem exitMenu;
        ToolStripMenuItem windowMenu;
        ToolStripMenuItem cascadeMenu;
        ToolStripMenuItem tileMenu;

        public MainForm()
        {
            Text = "MDI Application";
            Width = 800;
            Height = 500;
            IsMdiContainer = true;
            menu = new MenuStrip();
            fileMenu = new ToolStripMenuItem("File");
            newMenu = new ToolStripMenuItem("New");
            dialogMenu = new ToolStripMenuItem("Custom Dialog");
            exitMenu = new ToolStripMenuItem("Exit");
            fileMenu.DropDownItems.Add(newMenu);
            fileMenu.DropDownItems.Add(dialogMenu);
            fileMenu.DropDownItems.Add(exitMenu);
            windowMenu = new ToolStripMenuItem("Window");
            cascadeMenu = new ToolStripMenuItem("Cascade");
            tileMenu = new ToolStripMenuItem("Tile");
            windowMenu.DropDownItems.Add(cascadeMenu);
            windowMenu.DropDownItems.Add(tileMenu);
            menu.Items.Add(fileMenu);
            menu.Items.Add(windowMenu);
            Controls.Add(menu);
            MainMenuStrip = menu;
            newMenu.Click += NewMenu_Click;
            dialogMenu.Click += DialogMenu_Click;
            exitMenu.Click += ExitMenu_Click;
            cascadeMenu.Click += CascadeMenu_Click;
            tileMenu.Click += TileMenu_Click;
        }

        // Create MDI Child
        private void NewMenu_Click(object sender, EventArgs e)
        {
            Form child = new Form();

            child.Text = "MDI Child";
            child.Width = 300;
            child.Height = 200;
            child.MdiParent = this;

            Label label = new Label();
            label.Text = "This is an MDI Child Window";
            label.AutoSize = true;
            label.Left = 70;
            label.Top = 70;

            child.Controls.Add(label);
            child.Show();
        }

        // Open Custom Dialog
        private void DialogMenu_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();

            dialog.Text = "Custom Dialog Box";
            dialog.Width = 350;
            dialog.Height = 200;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;

            Label nameLabel = new Label();
            nameLabel.Text = "Enter Name:";
            nameLabel.Left = 30;
            nameLabel.Top = 35;

            TextBox nameTextBox = new TextBox();
            nameTextBox.Left = 120;
            nameTextBox.Top = 30;
            nameTextBox.Width = 150;

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Left = 80;
            okButton.Top = 90;

            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Left = 180;
            cancelButton.Top = 90;

            okButton.Click += (s, ev) =>
            {
                MessageBox.Show(
                    "Name: " + nameTextBox.Text,
                    "Details"
                );
                dialog.Close();
            };

            cancelButton.Click += (s, ev) =>
            {
                dialog.Close();
            };

            dialog.Controls.Add(nameLabel);
            dialog.Controls.Add(nameTextBox);
            dialog.Controls.Add(okButton);
            dialog.Controls.Add(cancelButton);

            dialog.ShowDialog();
        }

        // Exit
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Arrange child windows
        private void CascadeMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}

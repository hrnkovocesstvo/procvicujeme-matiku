using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace procvicujeme_matiku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Example data: label names
            string[] questions = { "Name:", "Age:", "Email:", "Phone:" };

            int startXLabel = 20;  // X position for labels
            int startXTextbox = 120; // X position for textboxes
            int startY = 20;       // starting Y position
            int spacingY = 30;     // vertical space between rows

            for (int i = 0; i < questions.Length; i++)
            {
                // Create Label
                Label priklad = new Label();
                priklad.Text = questions[i];
                priklad.Location = new System.Drawing.Point(startXLabel, startY + i * spacingY);
                priklad.AutoSize = true;
                this.Controls.Add(priklad);

                // Create TextBox
                TextBox odpoved = new TextBox();
                odpoved.Location = new System.Drawing.Point(startXTextbox, startY + i * spacingY);
                odpoved.Width = 200;
                this.Controls.Add(odpoved);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

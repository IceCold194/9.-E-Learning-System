using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.E_Learning_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            Course myCourse = new OnlineCourse(textBoxTitle.Text, textBoxDuration.Text, textBoxPlatform.Text);

            MessageBox.Show(myCourse.DisplayDetails(), "Course Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

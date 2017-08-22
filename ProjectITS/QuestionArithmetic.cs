using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectITS
{
    public partial class QuestionArithmetic : Form
    {
        public static int scoreArithmetic = 0;
        public QuestionArithmetic()
        {
            InitializeComponent();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            if (rdbtn12.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn24.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn34.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn42.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn63.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn72.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn81.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn92.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn103.Checked)
            {
                scoreArithmetic += 1;
            }
            if (rdbtn51.Checked)
            {
                scoreArithmetic += 1;
            }

            QuestionGeometry QG = new QuestionGeometry();
            QG.Show();
            this.Hide();
        }
    }
}

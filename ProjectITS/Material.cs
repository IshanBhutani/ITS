using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ProjectITS
{
    public partial class Material : Form
    {
        SpeechSynthesizer ss;

        string tutorSpeak;
        public Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            //ss.Rate = -2;
            ss.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            ss.SpeakAsync("Hi! '"+Home.userName+ "' My name is .I am your personal tutor who is cool and awesome. I am not boring unlike your teachers in school.Please press the \"Start Tutorial\" button to get you started with the magicaal experience.");  
        }

        private void btnStartMaterial_Click(object sender, EventArgs e)
        {
            if (QuestionGeometry.s == "Poor")
            {
                tutorSpeak = "Hi!'" + Home.userName + "' Since Your performance wasn't up to the mark I am recommending you some learning material to help you clear math concepts and practice some questions. Please click on of the displayed topic to start the lesson.";
                ss.SpeakAsync(tutorSpeak);
            }
            if (QuestionGeometry.s == "Moderate")
            {
                tutorSpeak = "Hi! '" + Home.userName + "'.Since your performance wasn't up to the mark ,I am recommending you some learning material here are some of the material for you to help you clear your general math concepts and practice some questions and help you get better at it .Please click on one of the displayed topic to start the lesson.";
                ss.SpeakAsync(tutorSpeak);
            }
            if (QuestionGeometry.s == "Good")
            {
                tutorSpeak = "Hi! '" + Home.userName + "' Your performance was good but I know you can do better. So to help you get better here are some good study material. Please click on one of the displayed topic to start the lesson.";
                ss.SpeakAsync(tutorSpeak);
            }
            if (QuestionGeometry.s == "Excellent")
            {
                tutorSpeak = "Hi! '" + Home.userName + "' Since You performed really well more than I expected but then as we know learning is a never ending process to make you best of the best I am providing some material for you to gain more in depth knowledge about algebra, arithmetic and geometry. Please click on onen of the displayed topic to start the lesson.";
                ss.Speak(tutorSpeak);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestionGeometry.s=="Poor" || QuestionGeometry.s == "Moderate")
            {
                axAcroPDF1.LoadFile("AlgebraMat.pdf");
            }
            else
            {
                axAcroPDF1.LoadFile("AlgebraGood.pdf");
            }
        }

        private void btnArithmeticMat_Click(object sender, EventArgs e)
        {
                axAcroPDF1.LoadFile("ArithmeticMat.pdf");
        }

        private void btnGeoMat_Click(object sender, EventArgs e)
        {
            if (QuestionGeometry.s == "poor" || QuestionGeometry.s == "Moderate")
            {
                axAcroPDF1.LoadFile("GeoMat.pdf");
            }
            else
            {
                axAcroPDF1.LoadFile("GeoGood.pdf");
            }
        }
    }
}

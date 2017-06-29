using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATT_Rewritten
{
    public partial class BATT : Form
    {
        public BATT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string Translate(char c)
        {
            string output;
            switch (c)
            {
                case 'a':
                    output = ":regional_indicator_a:";
                    break;
                case 'b':
                    output = ":regional_indicator_b:";
                    break;
                case 'c':
                    output = ":regional_indicator_c:";
                    break;
                case 'd':
                    output = ":regional_indicator_d:";
                    break;
                case 'e':
                    output = ":regional_indicator_e:";
                    break;
                case 'f':
                    output = ":regional_indicator_f:";
                    break;
                case 'g':
                    output = ":regional_indicator_g:";
                    break;
                case 'h':
                    output = ":regional_indicator_h:";
                    break;
                case 'i':
                    output = ":regional_indicator_i:";
                    break;
                case 'j':
                    output = ":regional_indicator_j:";
                    break;
                case 'k':
                    output = ":regional_indicator_k:";
                    break;
                case 'l':
                    output = ":regional_indicator_l:";
                    break;
                case 'm':
                    output = ":regional_indicator_m:";
                    break;
                case 'n':
                    output = ":regional_indicator_n:";
                    break;
                case 'o':
                    output = ":regional_indicator_o:";
                    break;
                case 'p':
                    output = ":regional_indicator_p:";
                    break;
                case 'q':
                    output = ":regional_indicator_q:";
                    break;
                case 'r':
                    output = ":regional_indicator_r:";
                    break;
                case 's':
                    output = ":regional_indicator_s:";
                    break;
                case 't':
                    output = ":regional_indicator_t:";
                    break;
                case 'u':
                    output = ":regional_indicator_u:";
                    break;
                case 'v':
                    output = ":regional_indicator_v:";
                    break;
                case 'w':
                    output = ":regional_indicator_w:";
                    break;
                case 'x':
                    output = ":regional_indicator_x:";
                    break;
                case 'y':
                    output = ":regional_indicator_y:";
                    break;
                case 'z':
                    output = ":regional_indicator_z:";
                    break;
                case '!':
                    output = ":exclamation:";
                    break;
                case '?':
                    output = ":question:";
                    break;
                case '0':
                    output = ":zero:";
                    break;
                case '1':
                    output = ":one:";
                    break;
                case '2':
                    output = ":two:";
                    break;
                case '3':
                    output = ":three:";
                    break;
                case '4':
                    output = ":four:";
                    break;
                case '5':
                    output = ":five:";
                    break;
                case '6':
                    output = ":six:";
                    break;
                case '7':
                    output = ":seven";
                    break;
                case '8':
                    output = ":eight:";
                    break;
                case '9':
                    output = ":nine";
                    break;
                default:
                    output = " ";
                    break;
            }
            return output;
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.ToLower();
            string output = "";
            BATT t = new BATT();
            foreach (char c in input)
            {
                string nextEmoji = t.Translate(c);
                output = output + " " + nextEmoji;
            }
            outputBox.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
    }
}

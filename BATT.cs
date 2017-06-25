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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string Translate(char c)
        {
            string output = "nope";
            switch (c)
            {
                case 'A':
                case 'a':
                    output = ":regional_indicator_a:";
                    break;
                case 'B':
                case 'b':
                    output = ":regional_indicator_b:";
                    break;
                case 'C':
                case 'c':
                    output = ":regional_indicator_c:";
                    break;
                case 'D':
                case 'd':
                    output = ":regional_indicator_d:";
                    break;
                case 'E':
                case 'e':
                    output = ":regional_indicator_e:";
                    break;
                case 'F':
                case 'f':
                    output = ":regional_indicator_f:";
                    break;
                case 'G':
                case 'g':
                    output = ":regional_indicator_g:";
                    break;
                case 'H':
                case 'h':
                    output = ":regional_indicator_h:";
                    break;
                case 'I':
                case 'i':
                    output = ":regional_indicator_i:";
                    break;
                case 'J':
                case 'j':
                    output = ":regional_indicator_j:";
                    break;
                case 'K':
                case 'k':
                    output = ":regional_indicator_k:";
                    break;
                case 'L':
                case 'l':
                    output = ":regional_indicator_l:";
                    break;
                case 'M':
                case 'm':
                    output = ":regional_indicator_m:";
                    break;
                case 'N':
                case 'n':
                    output = ":regional_indicator_n:";
                    break;
                case 'O':
                case 'o':
                    output = ":regional_indicator_o:";
                    break;
                case 'P':
                case 'p':
                    output = ":regional_indicator_p:";
                    break;
                case 'Q':
                case 'q':
                    output = ":regional_indicator_q:";
                    break;
                case 'R':
                case 'r':
                    output = ":regional_indicator_r:";
                    break;
                case 'S':
                case 's':
                    output = ":regional_indicator_s:";
                    break;
                case 'T':
                case 't':
                    output = ":regional_indicator_t:";
                    break;
                case 'U':
                case 'u':
                    output = ":regional_indicator_u:";
                    break;
                case 'V':
                case 'v':
                    output = ":regional_indicator_v:";
                    break;
                case 'W':
                case 'w':
                    output = ":regional_indicator_w:";
                    break;
                case 'X':
                case 'x':
                    output = ":regional_indicator_x:";
                    break;
                case 'Y':
                case 'y':
                    output = ":regional_indicator_y:";
                    break;
                case 'Z':
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
            string input = inputBox.Text;
            string output = "";
            Form1 t = new BATT_Rewritten.Form1();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BATT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            translationBox.Text = "";
            errorMessage.Hide();

            string input = inputBox.Text;

            #region Defining and Assigning Variables 
            char letter1 = 'n';
            char letter2 = 'n';
            char letter3 = 'n';
            char letter4 = 'n';
            char letter5 = 'n';
            char letter6 = 'n';
            char letter7 = 'n';
            char letter8 = 'n';
            char letter9 = 'n';
            char letter10 = 'n';
            char letter11 = 'n';
            char letter12 = 'n';
            char letter13 = 'n';
            char letter14 = 'n';
            char letter15 = 'n';
            char letter16 = 'n';
            char letter17 = 'n';
            char letter18 = 'n';
            char letter19 = 'n';
            char letter20 = 'n';

            switch(input.Length)
            {
                case 1:
                    letter1 = input[0];
                    break;
                case 2:
                    letter1 = input[0];
                    letter2 = input[1];
                    break;
                case 3:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    break;
                case 4:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    break;
                case 5:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    break;
                case 6:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    break;
                case 7:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    break;
                case 8:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    break;
                case 9:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    break;
                case 10:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    break;
                case 11:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    break;
                case 12:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    break;
                case 13:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    break;
                case 14:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    break;
                case 15:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    break;
                case 16:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    letter16 = input[15];
                    break;
                case 17:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    letter16 = input[15];
                    letter17 = input[16];
                    break;
                case 18:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    letter16 = input[15];
                    letter17 = input[16];
                    letter18 = input[17];
                    break;
                case 19:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    letter16 = input[15];
                    letter17 = input[16];
                    letter18 = input[17];
                    letter19 = input[18];
                    break;
                case 20:
                    letter1 = input[0];
                    letter2 = input[1];
                    letter3 = input[2];
                    letter4 = input[3];
                    letter5 = input[4];
                    letter6 = input[5];
                    letter7 = input[6];
                    letter8 = input[7];
                    letter9 = input[8];
                    letter10 = input[9];
                    letter11 = input[10];
                    letter12 = input[11];
                    letter13 = input[12];
                    letter14 = input[13];
                    letter15 = input[14];
                    letter16 = input[15];
                    letter17 = input[16];
                    letter18 = input[17];
                    letter19 = input[18];
                    letter20 = input[19];
                    break;


            }

            string output1 = "";  
            string output2 = "";
            string output3 = "";
            string output4 = "";
            string output5 = "";    //Defining each output variable and assigning them to "" - C# doesn't like if it's not assigned from the start.
            string output6 = "";
            string output7 = "";
            string output8 = "";
            string output9 = "";
            string output10 = "";
            string output11 = "";
            string output12 = "";
            string output13 = "";
            string output14 = "";
            string output15 = "";
            #endregion

            //The Translation Block - Here's where the translation from character to emoji happens. It's rather huge. (Imagine this block x90. That's the end goal)
            switch (letter1)
            {
                case 'a':
                case 'A':
                    output1 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output1 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output1 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output1 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output1 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output1 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output1 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output1 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output1 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output1 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output1 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output1 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output1 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output1 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output1 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output1 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output1 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output1 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output1 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output1 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output1 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output1 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output1 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output1 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output1 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output1 = ":regional_indicator_z:";
                    break;
                case '!':
                    output1 = ":exclamation:";
                    break;
                case '?':
                    output1 = ":question:";
                    break;
                case '0':
                    output1 = ":zero:";
                    break;
                case '1':
                    output1 = ":one:";
                    break;
                case '2':
                    output1 = ":two:";
                    break;
                case '3':
                    output1 = ":three:";
                    break;
                case '4':
                    output1 = ":four:";
                    break;
                case '5':
                    output1 = ":five:";
                    break;
                case '6':
                    output1 = ":six:";
                    break;
                case '7':
                    output1 = ":seven";
                    break;
                case '8':
                    output1 = ":eight:";
                    break;
                case '9':
                    output1 = ":nine";
                    break;
                default:
                    break;

            }

            switch (letter2)
            {
                case 'a':
                case 'A':
                    output2 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output2 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output2 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output2 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output2 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output2 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output2 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output2 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output2 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output2 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output2 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output2 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output2 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output2 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output2 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output2 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output2 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output2 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output2 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output2 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output2 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output2 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output2 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output2 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output2 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output2 = ":regional_indicator_z:";
                    break;
                case '!':
                    output2 = ":exclamation:";
                     break;
                case '?':
                    output2 = ":question:";
                    break;
                case '0':
                    output2 = ":zero:";
                    break;
                case '1':
                    output2 = ":one:";
                    break;
                case '2':
                    output2 = ":two:";
                    break;
                case '3':
                    output2 = ":three:";
                    break;
                case '4':
                    output2 = ":four:";
                    break;
                case '5':
                    output2 = ":five:";
                    break;
                case '6':
                    output2 = ":six:";
                    break;
                case '7':
                    output2 = ":seven";
                    break;
                case '8':
                    output2 = ":eight:";
                    break;
                case '9':
                    output2 = ":nine";
                    break;
                default:
                    break;

            }

            switch (letter3)
            {
                case 'a':
                case 'A':
                    output3 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output3 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output3 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output3 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output3 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output3 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output3 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output3 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output3 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output3 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output3 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output3 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output3 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output3 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output3 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output3 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output3 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output3 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output3 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output3 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output3 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output3 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output3 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output3 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output3 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output3 = ":regional_indicator_z:";
                    break;
                case '!':
                    output3 = ":exclamation:";
                    break;
                case '?':
                    output3 = ":question:";
                    break;
                case '0':
                    output3 = ":zero:";
                    break;
                case '1':
                    output3 = ":one:";
                    break;
                case '2':
                    output3 = ":two:";
                    break;
                case '3':
                    output3 = ":three:";
                    break;
                case '4':
                    output3 = ":four:";
                    break;
                case '5':
                    output3 = ":five:";
                    break;
                case '6':
                    output3 = ":six:";
                    break;
                case '7':
                    output3 = ":seven";
                    break;
                case '8':
                    output3 = ":eight:";
                    break;
                case '9':
                    output3 = ":nine";
                    break;
                default:
                    break;

            }

            switch (letter4)
            {
                case 'a':
                case 'A':
                    output4 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output4 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output4 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output4 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output4 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output4 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output4 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output4 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output4 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output4 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output4 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output4 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output4 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output4 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output4 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output4 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output4 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output4 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output4 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output4 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output4 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output4 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output4 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output4 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output4 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output4 = ":regional_indicator_z:";
                    break;
                case '!':
                    output4 = ":exclamation:";
                    break;
                case '?':
                    output4 = ":question:";
                    break;
                case '0':
                    output4 = ":zero:";
                    break;
                case '1':
                    output4 = ":one:";
                    break;
                case '2':
                    output4 = ":two:";
                    break;
                case '3':
                    output4 = ":three:";
                    break;
                case '4':
                    output4 = ":four:";
                    break;
                case '5':
                    output4 = ":five:";
                    break;
                case '6':
                    output4 = ":six:";
                    break;
                case '7':
                    output4 = ":seven";
                    break;
                case '8':
                    output4 = ":eight:";
                    break;
                case '9':
                    output4 = ":nine";
                    break;
                default:
                    break;

            }

            switch (letter5)
            {
                case 'a':
                case 'A':
                    output5 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output5 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output5 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output5 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output5 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output5 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output5 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output5 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output5 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output5 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output5 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output5 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output5 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output5 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output5 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output5 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output5 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output5 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output5 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output5 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output5 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output5 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output5 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output5 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output5 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output5 = ":regional_indicator_z:";
                    break;
                case '!':
                    output5 = ":exclamation:";
                    break;
                case '?':
                    output5 = ":question:";
                    break;
                case '0':
                    output2 = ":zero:";
                    break;
                case '1':
                    output5 = ":one:";
                    break;
                case '2':
                    output5 = ":two:";
                    break;
                case '3':
                    output5 = ":three:";
                    break;
                case '4':
                    output5 = ":four:";
                    break;
                case '5':
                    output5 = ":five:";
                    break;
                case '6':
                    output5 = ":six:";
                    break;
                case '7':
                    output5 = ":seven";
                    break;
                case '8':
                    output5 = ":eight:";
                    break;
                case '9':
                    output5 = ":nine";
                    break;
                default:
                    break;

            }

            switch (letter6)
            {
                case 'a':
                case 'A':
                    output6 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output6 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output6 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output6 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output6 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output6 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output6 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output6 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output6 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output6 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output6 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output6 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output6 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output6 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output6 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output6 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output6 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output6 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output6 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output6 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output6 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output6 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output6 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output6 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output6 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output6 = ":regional_indicator_z:";
                    break;
                case '!':
                    output6 = ":exclamation:";
                    break;
                case '?':
                    output6 = ":question:";
                    break;
                case '0':
                    output6 = ":zero:";
                    break;
                case '1':
                    output6 = ":one:";
                    break;
                case '2':
                    output6 = ":two:";
                    break;
                case '3':
                    output6 = ":three:";
                    break;
                case '4':
                    output6 = ":four:";
                    break;
                case '5':
                    output6 = ":five:";
                    break;
                case '6':
                    output6 = ":six:";
                    break;
                case '7':
                    output6 = ":seven";
                    break;
                case '8':
                    output6 = ":eight:";
                    break;
                case '9':
                    output6 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter7)
            {
                case 'a':
                case 'A':
                    output7 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output7 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output7 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output7 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output7 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output7 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output7 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output7 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output7 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output7 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output7 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output7 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output7 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output7 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output7 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output7 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output7 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output7 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output7 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output7 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output7 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output7 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output7 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output7 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output7 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output7 = ":regional_indicator_z:";
                    break;
                case '!':
                    output7 = ":exclamation:";
                    break;
                case '?':
                    output7 = ":question:";
                    break;
                case '0':
                    output7 = ":zero:";
                    break;
                case '1':
                    output7 = ":one:";
                    break;
                case '2':
                    output7 = ":two:";
                    break;
                case '3':
                    output7 = ":three:";
                    break;
                case '4':
                    output7 = ":four:";
                    break;
                case '5':
                    output7 = ":five:";
                    break;
                case '6':
                    output7 = ":six:";
                    break;
                case '7':
                    output7 = ":seven";
                    break;
                case '8':
                    output7 = ":eight:";
                    break;
                case '9':
                    output7 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter8)
            {
                case 'a':
                case 'A':
                    output8 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output8 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output8 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output8 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output8 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output8 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output8 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output8 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output8 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output8 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output8 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output8 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output8 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output8 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output8 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output8 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output8 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output8 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output8 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output8 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output8 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output8 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output8 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output8 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':                   
                    output8 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output8 = ":regional_indicator_z:";
                    break;
                case '!':
                    output8 = ":exclamation:";
                    break;
                case '?':
                    output8 = ":question:";
                    break;
                case '0':
                    output8 = ":zero:";
                    break;
                case '1':
                    output8 = ":one:";
                    break;
                case '2':
                    output8 = ":two:";
                    break;
                case '3':
                    output8 = ":three:";
                    break;
                case '4':
                    output8 = ":four:";
                    break;
                case '5':
                    output8 = ":five:";
                    break;
                case '6':
                    output8 = ":six:";
                    break;
                case '7':
                    output8 = ":seven";
                    break;
                case '8':
                    output8 = ":eight:";
                    break;
                case '9':
                    output8 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter9)
            {
                case 'a':
                case 'A':
                    output9 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output9 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output9 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output9 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output9 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output9 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output9 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output9 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output9 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output9 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output9 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output9 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output9 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output9 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output9 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output9 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output9 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output9 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output9 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output9 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output9 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output9 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output9 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output9 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output9 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output9 = ":regional_indicator_z:";
                    break;
                case '!':
                    output9 = ":exclamation:";
                    break;
                case '?':
                    output9 = ":question:";
                    break;
                case '0':
                    output9 = ":zero:";
                    break;
                case '1':
                    output9 = ":one:";
                    break;
                case '2':
                    output9 = ":two:";
                    break;
                case '3':
                    output9 = ":three:";
                    break;
                case '4':
                    output9 = ":four:";
                    break;
                case '5':
                    output9 = ":five:";
                    break;
                case '6':
                    output9 = ":six:";
                    break;
                case '7':
                    output9 = ":seven";
                    break;
                case '8':
                    output9 = ":eight:";
                    break;
                case '9':
                    output9 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter10)
            {
                case 'a':
                case 'A':
                    output10 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output10 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output10 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output10 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output10 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output10 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output10 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output10 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output10 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output10 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output10 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output10 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output10 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output10 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output10 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output10 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output10 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output10 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output10 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output10 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output10 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output10 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output10 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output10 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output10 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output10 = ":regional_indicator_z:";
                    break;
                case '!':
                    output10 = ":exclamation:";
                    break;
                case '?':
                    output10 = ":question:";
                    break;
                case '0':
                    output10 = ":zero:";
                    break;
                case '1':
                    output10 = ":one:";
                    break;
                case '2':
                    output10 = ":two:";
                    break;
                case '3':
                    output10 = ":three:";
                    break;
                case '4':
                    output10 = ":four:";
                    break;
                case '5':
                    output10 = ":five:";
                    break;
                case '6':
                    output10 = ":six:";
                    break;
                case '7':
                    output10 = ":seven";
                    break;
                case '8':
                    output10 = ":eight:";
                    break;
                case '9':
                    output10 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter11)
            {
                case 'a':
                case 'A':
                    output11 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output11 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output11 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output11 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output11 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output11 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output11 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output11 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output11 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output11 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output11 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output11 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output11 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output11 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output11 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output11 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output11 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output11 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output11 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output11 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output11 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output11 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output11 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output11 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output11 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output11 = ":regional_indicator_z:";
                    break;
                case '!':
                    output11 = ":exclamation:";
                    break;
                case '?':
                    output11 = ":question:";
                    break;
                case '0':
                    output10 = ":zero:";
                    break;
                case '1':
                    output10 = ":one:";
                    break;
                case '2':
                    output10 = ":two:";
                    break;
                case '3':
                    output10 = ":three:";
                    break;
                case '4':
                    output10 = ":four:";
                    break;
                case '5':
                    output10 = ":five:";
                    break;
                case '6':
                    output10 = ":six:";
                    break;
                case '7':
                    output10 = ":seven";
                    break;
                case '8':
                    output10 = ":eight:";
                    break;
                case '9':
                    output10 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter12)
            {
                case 'a':
                case 'A':
                    output12 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output12 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output12 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output12 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output12 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output12 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output12 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output12 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output12 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output12 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output12 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output12 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output12 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output12 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output12 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output12 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output12 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output12 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output12 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output12 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output12 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output12 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output12 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output12 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output12 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output12 = ":regional_indicator_z:";
                    break;
                case '!':
                    output12 = ":exclamation:";
                    break;
                case '?':
                    output12 = ":question:";
                    break;
                case '0':
                    output12 = ":zero:";
                    break;
                case '1':
                    output12 = ":one:";
                    break;
                case '2':
                    output12 = ":two:";
                    break;
                case '3':
                    output12 = ":three:";
                    break;
                case '4':
                    output12 = ":four:";
                    break;
                case '5':
                    output12 = ":five:";
                    break;
                case '6':
                    output12 = ":six:";
                    break;
                case '7':
                    output12 = ":seven";
                    break;
                case '8':
                    output12 = ":eight:";
                    break;
                case '9':
                    output12 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter13)
            {
                case 'a':
                case 'A':
                    output13 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output13 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output13 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output13 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output13 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output13 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output13 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output13 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output13 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output13 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output13 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output13 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output13 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output13 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output13 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output13 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output13 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output13 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output13 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output13 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output13 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output13 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output13 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output13 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output13 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output13 = ":regional_indicator_z:";
                    break;
                case '!':
                    output13 = ":exclamation:";
                    break;
                case '?':
                    output13 = ":question:";
                    break;
                case '0':
                    output13 = ":zero:";
                    break;
                case '1':
                    output13 = ":one:";
                    break;
                case '2':
                    output13 = ":two:";
                    break;
                case '3':
                    output13 = ":three:";
                    break;
                case '4':
                    output13 = ":four:";
                    break;
                case '5':
                    output13 = ":five:";
                    break;
                case '6':
                    output13 = ":six:";
                    break;
                case '7':
                    output13 = ":seven";
                    break;
                case '8':
                    output13 = ":eight:";
                    break;
                case '9':
                    output13 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter14)
            {
                case 'a':
                case 'A':
                    output14 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output14 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output14 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output14 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output14 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output14 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output14 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output14 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output14 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output14 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output14 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output14 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output14 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output14 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output14 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output14 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output14 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output14 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output14 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output14 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output14 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output14 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output14 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output14 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output14 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output14 = ":regional_indicator_z:";
                    break;
                case '!':
                    output14 = ":exclamation:";
                    break;
                case '?':
                    output14 = ":question:";
                    break;
                case '0':
                    output14 = ":zero:";
                    break;
                case '1':
                    output14 = ":one:";
                    break;
                case '2':
                    output14 = ":two:";
                    break;
                case '3':
                    output14 = ":three:";
                    break;
                case '4':
                    output14 = ":four:";
                    break;
                case '5':
                    output14 = ":five:";
                    break;
                case '6':
                    output14 = ":six:";
                    break;
                case '7':
                    output14 = ":seven";
                    break;
                case '8':
                    output14 = ":eight:";
                    break;
                case '9':
                    output14 = ":nine";
                    break;
                default:
                    break;
            }

            switch (letter15)
            {
                case 'a':
                case 'A':
                    output15 = ":regional_indicator_a:";
                    break;
                case 'b':
                case 'B':
                    output15 = ":regional_indicator_b:";
                    break;
                case 'c':
                case 'C':
                    output15 = ":regional_indicator_c:";
                    break;
                case 'd':
                case 'D':
                    output15 = ":regional_indicator_d:";
                    break;
                case 'e':
                case 'E':
                    output15 = ":regional_indicator_e:";
                    break;
                case 'f':
                case 'F':
                    output15 = ":regional_indicator_f:";
                    break;
                case 'g':
                case 'G':
                    output15 = ":regional_indicator_g:";
                    break;
                case 'h':
                case 'H':
                    output15 = ":regional_indicator_h:";
                    break;
                case 'i':
                case 'I':
                    output15 = ":regional_indicator_i:";
                    break;
                case 'j':
                case 'J':
                    output15 = ":regional_indicator_j:";
                    break;
                case 'k':
                case 'K':
                    output15 = ":regional_indicator_k:";
                    break;
                case 'l':
                case 'L':
                    output15 = ":regional_indicator_l:";
                    break;
                case 'm':
                case 'M':
                    output15 = ":regional_indicator_m:";
                    break;
                case 'n':
                case 'N':
                    output15 = ":regional_indicator_n:";
                    break;
                case 'o':
                case 'O':
                    output15 = ":regional_indicator_o:";
                    break;
                case 'p':
                case 'P':
                    output15 = ":regional_indicator_p:";
                    break;
                case 'q':
                case 'Q':
                    output15 = ":regional_indicator_q:";
                    break;
                case 'r':
                case 'R':
                    output15 = ":regional_indicator_r:";
                    break;
                case 's':
                case 'S':
                    output15 = ":regional_indicator_s:";
                    break;
                case 't':
                case 'T':
                    output15 = ":regional_indicator_t:";
                    break;
                case 'u':
                case 'U':
                    output15 = ":regional_indicator_u:";
                    break;
                case 'v':
                case 'V':
                    output15 = ":regional_indicator_v:";
                    break;
                case 'w':
                case 'W':
                    output15 = ":regional_indicator_w:";
                    break;
                case 'x':
                case 'X':
                    output15 = ":regional_indicator_x:";
                    break;
                case 'y':
                case 'Y':
                    output15 = ":regional_indicator_y:";
                    break;
                case 'z':
                case 'Z':
                    output15 = ":regional_indicator_z:";
                    break;
                case '!':
                    output15 = ":exclamation:";
                    break;
                case '?':
                    output15 = ":question:";
                    break;
                case '0':
                    output15 = ":zero:";
                    break;
                case '1':
                    output15 = ":one:";
                    break;
                case '2':
                    output15 = ":two:";
                    break;
                case '3':
                    output15 = ":three:";
                    break;
                case '4':
                    output15 = ":four:";
                    break;
                case '5':
                    output15 = ":five:";
                    break;
                case '6':
                    output15 = ":six:";
                    break;
                case '7':
                    output15 = ":seven";
                    break;
                case '8':
                    output15 = ":eight:";
                    break;
                case '9':
                    output15 = ":nine";
                    break;
                default:
                    break;
            }

            //Combining the outputs
            switch (input.Length)
            {
                case 1:
                    translationBox.Text = (output1);
                    break;
                case 2:
                    translationBox.Text = (output1 + " " + output2);
                    break;
                case 3:
                    translationBox.Text = (output1 + " " + output2 + " " + output3);
                    break;
                case 4:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4);
                    break;
                case 5:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5);
                    break;
                case 6:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6);
                    break;
                case 7:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7);
                    break;
                case 8:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8);
                    break;
                case 9:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9);
                    break;
                case 10:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10);
                    break;
                case 11:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10 + " " + output11);
                    break;
                case 12:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10 + " " + output11 + " " + output12);
                    break;
                case 13:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10 + " " + output11 + " " + output12 + " " + output13);
                    break;
                case 14:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10 + " " + output11 + " " + output12 + " " + output13 + " " + output14);
                    break;
                case 15:
                    translationBox.Text = (output1 + " " + output2 + " " + output3 + " " + output4 + " " + output5 + " " + output6 + " " + output7 + " " + output8 + " " + output9 + " " + output10 + " " + output11 + " " + output12 + " " + output13 + " " + output14 + " " + output15);
                    break;

            }

            if(string.IsNullOrWhiteSpace(translationBox.Text))
            {
                errorMessage.Show();
            }
                
            

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void translationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(translationBox.Text);
        }
    }
}
using System;
using System.Threading;
using System.Windows.Forms;

namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string morse = textBox1.Text;

            for (int i = 0; i < morse.Length; i++)
            {
                PlaySound(morse[i].ToString());
                Wait();
            }
        }

        int shortt = 150;
        int longg = 400;

        private void PlaySound(string c)
        {
            c=c.ToLower();
            switch (c)
            {
                case " ":
                    Thread.Sleep(400);
                    break;
            
                case "a":
                    Beep(shortt); Beep(longg);
                    break;
            
                case "b":
                    Beep(longg); Beep(shortt); Beep(shortt); Beep(shortt);
                    break;
            
                case "c":
                    Beep(longg); Beep(shortt); Beep(longg); Beep(shortt);
                    break;
            
                case "d":
                    Beep(longg); Beep(shortt); Beep(shortt);
                    break;
            
                case "e":
                    Beep(shortt);
                    break;
            
                case "f":
                    Beep(shortt); Beep(shortt); Beep(longg); Beep(shortt);
                    break;
            
                case "g":
                    Beep(longg); Beep(longg); Beep(shortt);
                    break;
            
                case "h":
                    Beep(shortt); Beep(shortt); Beep(shortt); Beep(shortt);
                    break;
            
                case "i":
                case "ı":
                    Beep(shortt); Beep(shortt);
                    break;
            
                case "j":
                    Beep(shortt); Beep(longg); Beep(longg); Beep(longg);
                    break;
            
                case "k":
                    Beep(longg); Beep(shortt); Beep(longg);
                    break;
            
                case "l":
                    Beep(shortt); Beep(longg); Beep(shortt); Beep(shortt);
                    break;
            
                case "m":
                    Beep(longg); Beep(longg);
                    break;
            
                case "n":
                    Beep(longg); Beep(shortt);
                    break;
            
                case "o":
                    Beep(longg); Beep(longg); Beep(longg);
                    break;
            
                case "p":
                    Beep(shortt); Beep(longg); Beep(longg); Beep(shortt);
                    break;
            
                case "q":
                    Beep(longg); Beep(longg); Beep(shortt); Beep(longg);
                    break;
            
                case "r":
                    Beep(shortt); Beep(longg); Beep(shortt);
                    break;
            
                case "s":
                    Beep(shortt); Beep(shortt); Beep(shortt);
                    break;
            
                case "t":
                    Beep(longg);
                    break;
            
                case "u":
                    Beep(shortt); Beep(shortt); Beep(longg);
                    break;
            
                case "v":
                    Beep(shortt); Beep(shortt); Beep(shortt); Beep(longg);
                    break;
            
                case "w":
                    Beep(shortt); Beep(longg); Beep(longg);
                    break;
            
                case "x":
                    Beep(longg); Beep(shortt); Beep(shortt); Beep(longg);
                    break;
            
                case "y":
                    Beep(longg); Beep(shortt); Beep(longg); Beep(longg);
                    break;
            
                case "z":
                    Beep(longg); Beep(longg); Beep(shortt); Beep(shortt);
                    break;
            
                default:
                    // Handle unrecognized characters if needed
                    break;
            }

        }

        private void Wait() => Thread.Sleep(300);

        private void Beep(int len) => Console.Beep(757, len);
    }
}

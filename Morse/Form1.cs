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
            if (c == " ")
            {
                Thread.Sleep(400);
                return;
            }
            if (c == "a")
            {
                Beep(shortt); Beep(longg);
                return;
            }
            if (c == "b")
            {
                Beep(longg); Beep(shortt); Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "c")
            {
                Beep(longg); Beep(shortt); Beep(longg); Beep(shortt);
                return;
            }
            if (c == "d")
            {
                Beep(longg); Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "e")
            {
                Beep(shortt);
                return;
            }
            if (c == "f")
            {
                Beep(shortt); Beep(shortt); Beep(longg); Beep(shortt);
                return;
            }
            if (c == "g")
            {
                Beep(longg); Beep(longg); Beep(shortt);
                return;
            }
            if (c == "h")
            {
                Beep(shortt); Beep(shortt); Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "i" || c == "ı")
            {
                Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "j")
            {
                Beep(shortt); Beep(longg); Beep(longg); Beep(longg);
                return;
            }
            if (c == "k")
            {
                Beep(longg); Beep(shortt); Beep(longg);
                return;
            }
            if (c == "l")
            {
                Beep(shortt); Beep(longg); Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "m")
            {
                Beep(longg); Beep(longg);
                return;
            }
            if (c == "n")
            {
                Beep(longg); Beep(shortt);
                return;
            }
            if (c == "o")
            {
                Beep(longg); Beep(longg); Beep(longg);
                return;
            }
            if (c == "p")
            {
                Beep(shortt); Beep(longg); Beep(longg); Beep(shortt);
                return;
            }
            if (c == "q")
            {
                Beep(longg); Beep(longg); Beep(shortt); Beep(longg);
                return;
            }
            if (c == "r")
            {
                Beep(shortt); Beep(longg); Beep(shortt);
                return;
            }
            if (c == "s")
            {
                Beep(shortt); Beep(shortt); Beep(shortt);
                return;
            }
            if (c == "t")
            {
                Beep(longg);
                return;
            }
            if (c == "u")
            {
                Beep(shortt); Beep(shortt); Beep(longg);
                return;
            }
            if (c == "v")
            {
                Beep(shortt); Beep(shortt); Beep(shortt); Beep(longg);
                return;
            }
            if (c == "w")
            {
                Beep(shortt); Beep(longg); Beep(longg);
                return;
            }
            if (c == "x")
            {
                Beep(longg); Beep(shortt); Beep(shortt); Beep(longg);
                return;
            }
            if (c == "y")
            {
                Beep(longg); Beep(shortt); Beep(longg); Beep(longg);
                return;
            }
            if (c == "z")
            {
                Beep(longg); Beep(longg); Beep(shortt); Beep(shortt);
                return;
            }
        }

        private void Wait() => Thread.Sleep(300);

        private void Beep(int len) => Console.Beep(757, len);
    }
}

using System;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
namespace _0101
{
    public partial class Form1 : Form
    {
        bool flag = true;
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr FindWindow(string lpClassname, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr SetWindowText(IntPtr hWnd, string lpString);
        static void UpdateNotepadWindowTitle(string newTitle)
        {
            IntPtr notepadWindow = FindWindow("Notepad", null);
            SetWindowText(notepadWindow, newTitle);
        }


        async Task start_or_stop()
        {
            DateTime startTime = DateTime.Now;


            while (true)
            {
                TimeSpan timeElapsed = DateTime.Now - startTime;
                string timeString = timeElapsed.ToString(@"hh\:mm\:ss");
                if (flag)
                {
                    UpdateNotepadWindowTitle("Час роботи програми: " + timeString);
                }
                await Task.Delay(1000);
            }
        }



        public Form1()
        {
            InitializeComponent();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            flag = true;

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await start_or_stop();
        }
    }
}
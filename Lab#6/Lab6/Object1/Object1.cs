using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object1
{
    public partial class Object1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)] public string lpData;
        }

        public Process process1;
        public Process process2;

        public Object1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            int min = (int)numericUpDown2.Value;
            int max = (int)numericUpDown3.Value;

            if (n == 0 || min == 0 || max == 0)
            {
                label4.Text = "must be: values > 0";
                return;
            }
            else if (min > max)
            {
                label4.Text = "must be: min < max";
                return;
            }

            IntPtr Object2Window = FindWindow(null, "Object2");
            IntPtr Object3Window = FindWindow(null, "Object3");

            if (Object2Window == IntPtr.Zero) 
            {
                process1 = new Process();
                process1.StartInfo.FileName = @"C:\yaroslavels\projects\oop_labs\Lab#6\Lab6\Object2\bin\Debug\netcoreapp3.1\Object2.exe";
                process1.Start();
                Task.Delay(500).Wait();
                Object2Window = FindWindow(null, "Object2");
            }

            string values = $"{n} {min} {max}";

            int WM_COPYDATA = 0x004A;

            COPYDATASTRUCT cds = new COPYDATASTRUCT
            {
                dwData = new IntPtr(1),
                cbData = values.Length + 1,
                lpData = values
            };

            SendMessage(Object2Window, WM_COPYDATA, IntPtr.Zero, ref cds);

            if (Object3Window == IntPtr.Zero)
            {
                process2 = new Process();
                process2.StartInfo.FileName = @"C:\yaroslavels\projects\oop_labs\Lab#6\Lab6\Object3\bin\Debug\netcoreapp3.1\Object3.exe";
                process2.Start();
                Task.Delay(500).Wait();
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (process1 != null)
            {
                process1.Kill();
            }

            if (process2 != null)
            {
                process2.Kill();
            }
        }
    }
}

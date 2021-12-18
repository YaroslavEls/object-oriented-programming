using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Object1
{
    public partial class Form1 : Form
    {
        private Process proc;
        private string ClassName;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;    // Any value the sender chooses.  Perhaps its main window handle?
            public int cbData;       // The count of bytes in the message.
            [MarshalAs(UnmanagedType.LPStr)] public string lpData;    // The address of the message.
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = new Process();
            proc.StartInfo.FileName = @"C:\yaroslavels\projects\oop_labs\Lab#6\Lab6\Object3\bin\Debug\netcoreapp3.1\Object3.exe";
            proc.Start();
            Debug.WriteLine(proc.ProcessName);
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // proc.Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
/*            StringBuilder className = new StringBuilder(256);
            int nRet = GetClassName(Handle, className, className.Capacity);
            Debug.WriteLine(nRet);
            ClassName = nRet != 0 ? className.ToString() : null;

            Debug.WriteLine(ClassName);*/

            IntPtr toplevelWindow = FindWindow(null, "Form2");
            Debug.WriteLine(toplevelWindow);

            int WM_COPYDATA = 0x004A;

            string s = "Text-test";
            int copylen = s.Length;

            IntPtr sptr = Marshal.StringToHGlobalAnsi(s);
            IntPtr dptr = Marshal.AllocHGlobal(copylen + 1);

            Encoding u8 = Encoding.UTF8;

            /*COPYDATASTRUCT cds = new COPYDATASTRUCT();

            cds.dwData = 1;
            cds.cbData = sptr;
            cds.lpData = dptr;

            SendMessage(toplevelWindow, WM_COPYDATA, 0, cds);*/

            string str = "aueweyfiuewiufaewtiyfgwfafygafwwaut";

            var cds = new COPYDATASTRUCT
            {
                dwData = new IntPtr(3),
                cbData = str.Length + 1,
                lpData = str
            };

            SendMessage(toplevelWindow, WM_COPYDATA, IntPtr.Zero, ref cds);

        }
    }
}

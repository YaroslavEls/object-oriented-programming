using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Object3
{
    public partial class Form2 : Form
    {
        private string ClassName;

        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;    // Any value the sender chooses.  Perhaps its main window handle?
            public int cbData;       // The count of bytes in the message.
            [MarshalAs(UnmanagedType.LPStr)] public string lpData;    // The address of the message.
        }

        public Form2()
        {
            InitializeComponent();

            StringBuilder className = new StringBuilder(256);
            int nRet = GetClassName(Handle, className, className.Capacity);
            Debug.WriteLine(nRet);
            ClassName = nRet != 0 ? className.ToString() : null;

            Debug.WriteLine(ClassName);
        }


        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            // Listen for operating system messages.
            switch (m.Msg)
            {
                // The WM_ACTIVATEAPP message occurs when the application
                // becomes the active application or becomes inactive.
                case 0x004A:

                    COPYDATASTRUCT st = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
                    label1.Text = st.dwData.ToString() + " -> " + st.cbData.ToString() + " -> " + st.lpData.ToString();

                    //CANMessage MsgIn = new CANMessage(8);
                    //MsgIn = (CANMessage)Marshal.PtrToStructure(st.lpData, typeof(CANMessage));

                    //label1.Text = "zxc";
                    //label1.Text = m.LParam.GetType().ToString();
                    Debug.WriteLine("qwe");

                    // The WParam value identifies what is occurring.
                    bool appActive = (((int)m.WParam != 0));

                    // Invalidate to get new text painted.
                    this.Invalidate();

                    break;
            }
            base.WndProc(ref m);
        }

    }
}

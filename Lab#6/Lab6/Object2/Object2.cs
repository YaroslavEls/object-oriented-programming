using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Object2
{
    public partial class Object2 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)] public string lpData;
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x004A:

                    COPYDATASTRUCT st = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));

                    string[] nums = st.lpData.Split(" ");

                    int n = Int32.Parse(nums[0]);
                    int min = Int32.Parse(nums[1]);
                    int max = Int32.Parse(nums[2]);

                    var rand = new Random();

                    double[] result = new double[n];

                    string data = "";

                    for (int i = 0; i < n; i++)
                    {
                        result[i] = rand.NextDouble() * (max - min) + min;
                        Sort(result, i);
                    }

                    foreach (double num in result)
                    {
                        dataGridView1.Rows.Add(Array.IndexOf(result, num), num);
                        data += num.ToString() + " ";
                    }

                    Clipboard.SetText(data);

                    break;
            }
            base.WndProc(ref m);
        }

        public Object2()
        {
            InitializeComponent();
        }

        private double[] Sort(double[] arr, int i)
        {
            if (i != 0 && arr[i] < arr[i - 1])
            {
                double tmp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = tmp;
                Sort(arr, i - 1);
            }
            return arr;
        }
    }
}

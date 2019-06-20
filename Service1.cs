using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace WinPService
{
    public partial class Service1 : ServiceBase
    {
        [DllImport("AutostartDLL.dll", EntryPoint = "fnAutostart")]
        public static extern int fnAutostart(string exePath);// 应该是exePath
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
             //File.AppendAllText("C:\\WinPService\\WinPService\\bin\\x64\\Release\\log.txt", "启动时间为：" + DateTime.Now);
            //fnAutostart("C:\\Users\\tabjin\\Desktop\\WindowsFormsApplication1.exe");
            //Interop.CreateProcess("cmd.exe", @"C:\Windows\System32\");
            Interop.CreateProcess("winlog.exe", @"C:\Windows\System32\");
        }

        protected override void OnStop()
        {
        }
    }
}

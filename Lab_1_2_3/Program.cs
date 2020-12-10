using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2_3
{
    static class Program
    {
        [STAThread]
        static async Task  Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //await Task.Run(() => Application.Run(new Lab_1()));
            //await Task.Run(() => Application.Run(new Lab_2()));
            //await Task.Run(() => Application.Run(new Lab_3()));
            Task t1 = Task.Run(() => Application.Run(new Lab_1()));
            Task t2 = Task.Run(() => Application.Run(new Lab_2()));
            Task t3 = Task.Run(() => Application.Run(new Lab_3()));
            await Task.WhenAll(new[] { t1, t2, t3 });
        }
    }
}

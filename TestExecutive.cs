using ABT.Test.Exec.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ABT.Test.Exec {
    public class TestExecutive {
        [STAThread]
        static void Main() {
            TestExec.MutexTestPlan = new Mutex(true, TestExec.MutexTestPlanName, out Boolean onlyInstance);
            if (!onlyInstance) {
                _ = MessageBox.Show($"Already have one executing instance of a TestPlan.{Environment.NewLine}{Environment.NewLine}" +
                    $"Cannot have two, as both would control system instruments simultaneously.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GC.KeepAlive(TestExec.MutexTestPlan);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Application.Run(new TestExec(Resources.Amphenol)); }
            catch (Exception e) {
                TestExec.ErrorMessage(e.ToString());
                TestExec.ErrorMessage(e);
            }
        }
    }
}

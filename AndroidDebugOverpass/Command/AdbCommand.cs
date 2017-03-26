using AndroidDebugOverpass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidDebugOverpass.Command
{
    abstract class AdbCommand<T>
    {
        private const string ADB_FILE_NANE = "adb.exe";
        private Action<T> mOnSuccess;
        private Action<Exception> mOnError;
        protected Device mTargetDevice;

        protected abstract string BuildParameter();
        protected abstract T ParseOutput(string output);

        public void Execute(Action<T> onSuccess, Action<Exception> onError)
        {
            mOnSuccess = onSuccess;
            mOnError = onError;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(RunCommand);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CommandCompleted);
            worker.RunWorkerAsync(BuildParameter());
        }

        public AdbCommand<T> ForDevice(Device device)
        {
            mTargetDevice = device;
            return this;
        }

        private void RunCommand(object sender, DoWorkEventArgs e)
        {
            string arg = e.Argument as string;

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = ADB_FILE_NANE;
            p.StartInfo.Arguments = arg;
            p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(65001);
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            e.Result = output;
        }

        private void CommandCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            String text = e.Result as string;
            try
            {
                T result = ParseOutput(text);
                mOnSuccess(result);
            }
            catch (Exception ex)
            {
                mOnError(ex);
            }
        }

    }
}

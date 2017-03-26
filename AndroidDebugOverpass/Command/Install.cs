using AndroidDebugOverpass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidDebugOverpass.Command
{
    class Install : AdbCommand<bool>
    {

        private string mApk;

        public Install ForApk(string apk)
        {
            mApk = apk;
            return this;
        }

        protected override string BuildParameter()
        {
            string command = (mTargetDevice == null ? "" : "-s " + mTargetDevice.SerialId) + " install " + mApk;
            return command;
        }

        protected override bool ParseOutput(string output)
        {
            string[] lines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            if (lines != null && lines[lines.Length - 2].StartsWith("Success"))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

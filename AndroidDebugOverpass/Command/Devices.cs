using AndroidDebugOverpass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidDebugOverpass.Command
{
    class Devices : AdbCommand<List<Device>>
    {
        protected override string BuildParameter()
        {
            return "devices";
        }

        protected override List<Device> ParseOutput(string output)
        {
            List<Device> devices = new List<Device>();
            string[] lines = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 1; i < lines.Length; i++)
            {
                if (!String.IsNullOrEmpty(lines[i]))
                {
                    string[] tokens = lines[i].Split('\t');
                    if (tokens.Length >= 2)
                    {
                        Device device = new Device(tokens[0], tokens[1]);
                        devices.Add(device);
                    }
                }
            }
            return devices;
        }
    }
}

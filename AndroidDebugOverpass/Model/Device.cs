using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidDebugOverpass.Model
{
    class Device
    {
        private string mSerialId;
        private string mState;

        public string SerialId { get { return mSerialId; } }
        public string State { get { return mState; } }

        public Device(string serialId, string state)
        {
            mSerialId = serialId;
            mState = state;
        }

        public override string ToString()
        {
            return mSerialId + ": " + mState;
        }
    }
}

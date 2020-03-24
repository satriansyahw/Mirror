using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class StartupSetting
    {
        public readonly int FormOptionValueLength = 1000000;
        public readonly int FormOptionsBodyLength = 1000000;
        public readonly int FormOptionsHeaderLength = 1000000;

        public StartupSetting()
        {

        }
        private static StartupSetting instance;
        public static StartupSetting GetInstance
        {
            get
            {
                if (instance == null) instance = new StartupSetting();
                return instance;
            }
        }

    }
}

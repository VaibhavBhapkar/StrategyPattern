using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class KEYPAIRConfigurationReader : IConfiguartionReader
    {
        public string GetValue()
        {
            return "KEYPAIR";
        }
    }
}

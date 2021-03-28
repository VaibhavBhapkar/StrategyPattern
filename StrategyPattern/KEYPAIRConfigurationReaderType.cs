using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class KEYPAIRConfigurationReaderType : IConfiguartionReader
    {
        public string GetValue()
        {
            return "KEYPAIR";
        }
    }
}

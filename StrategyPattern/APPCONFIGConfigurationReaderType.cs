using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class APPCONFIGConfigurationReaderType : IConfiguartionReader
    {
        public string GetValue()
        {
            return "APPCONFIG"; 
        }
    }
}

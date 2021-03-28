using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class XMLConfigurationReaderType : IConfiguartionReader
    {
        public string GetValue()
        {
            return "XML";
        }
    }
}

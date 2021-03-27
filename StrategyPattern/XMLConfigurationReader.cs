using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class XMLConfigurationReader : IConfiguartionReader
    {
        public string GetValue()
        {
            return "XML";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class JSONConfigurationReaderType : IConfiguartionReader
    {
        public string GetValue()
        {
            return "JSON";
        }
    }
}

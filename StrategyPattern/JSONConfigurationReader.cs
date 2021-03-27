using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class JSONConfigurationReader : IConfiguartionReader
    {
        public string GetValue()
        {
            return "JSON";
        }
    }
}

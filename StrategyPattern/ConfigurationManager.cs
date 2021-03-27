using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConfigurationManager
    {
        IConfiguartionReader _reader;
        public IConfiguartionReader ConfigurationReader
        {
            get { return this._reader; }
            set { this._reader = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConfigSource
    {
        public enum ConfigurationSource
        {
            APPCONFIG,
            XML,
            JSON,
            KEYPAIR
        }

    }
}

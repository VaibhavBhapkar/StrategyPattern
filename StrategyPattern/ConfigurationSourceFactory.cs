using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace StrategyPattern
{
    public class ConfigurationSourceFactory
    {
        public IConfiguartionReader GetInstanceOfConfigurationReader(string source)
        {
            Type typeAssembly = FindTypeInAssembly.FindInstanceOfAssembly(source,typeof(IConfiguartionReader).ToString());
            if (typeAssembly == null) throw new Exception("Bad Type");
            else return Activator.CreateInstance(typeAssembly) as IConfiguartionReader;
        }       
    }
}

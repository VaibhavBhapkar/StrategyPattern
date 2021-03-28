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
        private Type GetTypeToCreate(string sourceName)
        {
            foreach (var source in configSource)
            {
                Console.WriteLine(source.Key);
                if (source.Key.Contains(sourceName))
                {
                    return configSource[source.Key];
                }
            }
            return null;
        }
        private void LoadTypesAssemblyCanReturn()
        {
            configSource = new Dictionary<string, Type>();
            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typeInThisAssembly)
            {
                if (type.GetInterface(typeof(IConfiguartionReader).ToString()) != null)
                {
                    configSource.Add(type.Name.ToUpper(), type);
                }
            }
        }
    }
}

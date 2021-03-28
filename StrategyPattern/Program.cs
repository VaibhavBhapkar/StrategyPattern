using System;
using System.Reflection;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager _manager = new ConfigurationManager();
            string configSourceType = Console.ReadLine();
            configSourceType = configSourceType.ToUpper() + "CONFIGURATIONREADERTYPE";
            ConfigurationSourceFactory factory = new ConfigurationSourceFactory();
            IConfiguartionReader configReader = factory.GetInstanceOfConfigurationReader(configSourceType);
            Console.WriteLine(configReader.GetValue());
        }
           
    }

}

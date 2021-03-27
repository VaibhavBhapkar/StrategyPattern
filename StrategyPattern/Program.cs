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
            configSourceType = configSourceType.ToUpper() + "CONFIGURATIONREADER";
            ConfigurationSourceFactory factory = new ConfigurationSourceFactory();
            IConfiguartionReader configReader = factory.CreateInstance(configSourceType);
            Console.WriteLine(configReader.GetValue());
        }
           
    }

}

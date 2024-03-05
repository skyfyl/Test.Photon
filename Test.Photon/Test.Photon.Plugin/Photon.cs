using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Photon.Plugin
{
    public class Photon
    {
        public static void Run()
        {
            var type = typeof(Photon);
            var assembly = type.Assembly;
            var name = assembly.GetName().Name;
            string path = string.Format("{0}.config", typeof(Photon).Assembly.Location);

            var fileMap = new ConfigurationFileMap(path);
            var configuration = ConfigurationManager.OpenMappedMachineConfiguration(fileMap);
            // var configuration = ConfigurationManager.OpenMappedMachineConfiguration(ConfigurationUserLevel.None);
            // var sectionGroup = configuration.GetSectionGroup("applicationSettings"); // This is the section group name, change to your needs
            // var se = configuration.AppSettings.Settings;
            var sectionGroup = configuration.GetSectionGroup("applicationSettings");
            var section = (ClientSettingsSection)sectionGroup.Sections.Get($"{name}.Properties.Settings"); // This is the section name, change to your needs
            var setting = section.Settings.Get("Value1"); // This is the setting name, change to your needs
            Console.WriteLine($"value1: {section.Settings.Get("Value1").Value.ValueXml.InnerText}");
            Console.WriteLine($"value2: {section.Settings.Get("Value2").Value.ValueXml.InnerText}");
        }
    }
}

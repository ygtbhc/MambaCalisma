using System.Collections.Generic;
using System.Xml;

namespace MessageHelperLibrary
{
    public static class XmlMessageBase
    {
        public static Dictionary<string, string> GetValue(string fileName, string xpath)
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();

            XmlDocument xml = new XmlDocument();
            xml.Load(fileName);

            var element = xml.SelectNodes(xpath);
            foreach (XmlElement n in element)
            {
                if (n is XmlElement)
                    keyValues.Add(n.GetAttribute("name"), n.InnerText);
            }

            return keyValues;
        }
    }
}

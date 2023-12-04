using Newtonsoft.Json;
using System.Xml;

class Program
{
    static void Main()
    {
        // Sample JSON data
        string jsonData = "{ \"name\": \"Катя\", \"age\": 13, \"city\": \"Москва\" }";

        // Using Newtonsoft.Json to deserialize JSON
        dynamic jsonObject = JsonConvert.DeserializeObject(jsonData);

        // Creating an XmlDocument and adding root element
        XmlDocument xmlDocument = new XmlDocument();
        XmlNode rootNode = xmlDocument.CreateElement("Root");
        xmlDocument.AppendChild(rootNode);

        // Adding elements and attributes from JSON data
        foreach (var property in jsonObject)
        {
            XmlNode node = xmlDocument.CreateElement(property.Name);
            node.InnerText = property.Value.ToString();
            rootNode.AppendChild(node);
        }

        // Output the XML
        string xmlOutput = xmlDocument.OuterXml;
        Console.WriteLine(xmlOutput);
    }
}
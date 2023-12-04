using System;
using System.Text.Json;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Sample JSON data
        string jsonData = "{ \"name\": \"Катя\", \"age\": 13, \"city\": \"Москва\" }";

        // Using System.Text.Json to parse JSON
        JsonDocument jsonDocument = JsonDocument.Parse(jsonData);

        // Creating XDocument and adding elements and attributes
        XDocument xDocument = new XDocument(
            new XElement("Root",
                jsonDocument.RootElement.EnumerateObject()
                    .Select(prop => new XElement(prop.Name, prop.Value.ToString()))
            )
        );

        // Output the XML
        string xmlOutput = xDocument.ToString();
        Console.WriteLine(xmlOutput);
        
    }
}

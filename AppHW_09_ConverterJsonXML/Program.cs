using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Sample JSON data
        string jsonData = "{ \"name\": \"Катя\", \"age\": 13, \"city\": \"Москва\" }";

        // Using DataContractJsonSerializer to deserialize JSON
        using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData)))
        {
            var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, object>));
            var jsonObject = (Dictionary<string, object>)serializer.ReadObject(stream);

            // Creating XElement and adding elements and attributes
            XElement xmlElement = new XElement("Root",jsonObject.Select(kv => new XElement(kv.Key, kv.Value)));

            // Output the XML
            string xmlOutput = xmlElement.ToString();
            Console.WriteLine(xmlOutput);
        }
    }
}
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CatFactory
{
    public class Serializer : ISerializer
    {
        public string Serialize<T>(T obj)
        {
            var serializer = new XmlSerializer(obj.GetType());

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }

        public T Deserialze<T>(string source)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stream = new FileStream(source, FileMode.Open))
            {
                using (var reader = XmlReader.Create(stream))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
        }
    }
}

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CatFactory.Tests.Helpers
{
    public static class XmlSerializerHelper
    {
        public static string Serialize<T>(T obj)
        {
            var serializer = new XmlSerializer(obj.GetType());

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }

        public static T DeserializeFrom<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stream = new FileStream(path, FileMode.Open))
            {
                using (var reader = XmlReader.Create(stream))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
        }
    }
}

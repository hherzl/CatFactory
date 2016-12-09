using System;
using System.IO;
using System.Xml.Serialization;

namespace CatFactory
{
    public class Serializer : ISerializer
    {
        public String Serialize<T>(T obj)
        {
            var serializer = new XmlSerializer(obj.GetType());

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }

        public T Deserialze<T>(String source)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (StringReader reader = new StringReader(source))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}

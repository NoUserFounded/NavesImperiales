using System;
using System.IO;
using System.Xml.Serialization;

namespace NavesImperialesModels
{
    public class XmlManager<T> where T : class
    {
        public static T Load(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(reader) as T;
            }
        }

        public static void Save(string path, T data)
        {
            using (var writer = new StreamWriter(path))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, data);
            }
        }
    }
}

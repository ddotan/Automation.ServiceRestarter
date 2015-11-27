using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automation.Restarter.Agent.Utilities
{
    public class XMLUtils
    {
        public static T DeSerilize<T>(string i_FilePath)
        {
            T loadedThis;
            try
            {
                using (FileStream stream = new FileStream(i_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    loadedThis = (T)serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return loadedThis;
        }
        public static void Serlize<T>(string i_FilePath, T i_Obj)
        {
            using (FileStream stream = new FileStream(i_FilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, i_Obj);
                stream.Flush();
            }
        }

        public static void DictionarySerlize(string i_FilePath, Dictionary<string, string> i_Obj)
        {
            using (FileStream stream = new FileStream(i_FilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(item[]),
                                  new XmlRootAttribute() { ElementName = "Services" });
                serializer.Serialize(stream,
                    i_Obj.Select(kv => new item() { id = kv.Key, value = kv.Value }).ToArray());
            }
        }
        public static Dictionary<string, string> DictionaryDeSerlize(string i_FilePath)
        {
            Dictionary<string, string> item = null;
            using (FileStream stream = new FileStream(i_FilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(item[]),
                                  new XmlRootAttribute() { ElementName = "Services" });
                item = ((item[])serializer.Deserialize(stream))
                .ToDictionary(i => i.id, i => i.value);
            }
            return item;
        }
    }
}


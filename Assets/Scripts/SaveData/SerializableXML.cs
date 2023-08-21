using System;
using System.Xml.Serialization;
using System.IO;


public class SerializableXML<T> : IData<T>
    {
    private static XmlSerializer _serializer;

    public SerializableXML()
    {
        _serializer = new XmlSerializer(typeof(T));
    }

    public void Save(T data, string path = null)
    {
        if (data == null && !String.IsNullOrEmpty(path)) return;

        using (var fs = new FileStream(path, FileMode.Create))
        {
            _serializer.Serialize(fs, data);
        }
    }

    public T Load(string path)
    {
        T result;
        if (!File.Exists(path)) return default;
        using (var fs = new FileStream(path, FileMode.Open))
        {
            result = (T)_serializer.Deserialize(fs);
        }

        return result;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UnityEngine;


public class Save
{
    private SerializableXML<SavedData> _serializibleXMLData = new SerializableXML<SavedData>();
   // private SavedData _savedData = new SavedData() { Name = "", Position = .transform.position };

    public void Start()
    {
        var path = Path.Combine(Application.streamingAssetsPath, "SerializableXlmSave.xlm");
        var save = _serializibleXMLData.Load(path);
        Debug.Log(save);
    }
}

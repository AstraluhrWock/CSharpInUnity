using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UnityEngine;


public class Save : MonoBehaviour
{
    private SerializableXML<SavedData> _serializibleXMLData = new SerializableXML<SavedData>();
    private SavedData _savedData;

    public void Start()
    {
        var bonus = GameObject.FindGameObjectWithTag("Player");
        _savedData = new SavedData() { Name = bonus.name, Position = bonus.transform.position };
        var path = Path.Combine(Application.streamingAssetsPath, "SerializableXmlSave.xml");
        _serializibleXMLData.Save(_savedData,path);
       
    }
}
 
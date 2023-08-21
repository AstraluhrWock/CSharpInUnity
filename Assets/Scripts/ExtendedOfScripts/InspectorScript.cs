using UnityEngine;

public sealed class InspectorScript : MonoBehaviour
{
    private Transform _root;

    public int count = 10;
    public int offset = 1;
    public GameObject obj;
    public float test;

    private void Start()
    {
        CreateGameObject();
    }

    public void CreateGameObject()
    {
        _root = new GameObject("Root").transform;
        for (var i = 1; i <= count; i++)
        {
            Instantiate(obj, new Vector3(0, offset * i, 0), Quaternion.identity, _root);
        }
    }

    public void AddComponent()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<MeshRenderer>();
        gameObject.AddComponent<BoxCollider>();
    }

    public void RemoveComponent()
    {
        DestroyImmediate(GetComponent<Rigidbody>());
        DestroyImmediate(GetComponent<MeshRenderer>());
        DestroyImmediate(GetComponent<BoxCollider>());
    }

}

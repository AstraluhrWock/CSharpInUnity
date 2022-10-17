using UnityEditor;
using UnityEngine;

public class NewWindow : EditorWindow
{
    public static GameObject ObjectInstantiane;
    public string objectName = "Untitled";
    public bool groupEnable = false;
    public bool randomColor = true;
    public int countOfObject = 1;
    public float radius = 10;
    public Color colorField = Color.red;

    private void OnGUI()
    {
        GUILayout.Label("������� ���������", EditorStyles.boldLabel);
        ObjectInstantiane = EditorGUILayout.ObjectField("������ ��� �������", ObjectInstantiane, typeof(GameObject), true) as GameObject;
        objectName = EditorGUILayout.TextField("��� �������", objectName);
        groupEnable = EditorGUILayout.BeginToggleGroup("�������������� ���������", groupEnable);
        randomColor = EditorGUILayout.Toggle("��������� ����", randomColor);
        countOfObject = EditorGUILayout.IntSlider("���������� ��������", countOfObject, 1, 100);
        radius = EditorGUILayout.Slider("������ ����������", radius, 10, 50);
        colorField = EditorGUILayout.ColorField("�������� ����", colorField);
        EditorGUILayout.EndToggleGroup();
        var button = GUILayout.Button("������� �������");
        if (button)
        {
            if (ObjectInstantiane)
            {
                GameObject root = new GameObject("Root");
                for (int i = 0; i < countOfObject; i++)
                {
                    float angle = i * Mathf.PI * 2 / countOfObject;
                    Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
                    GameObject temp = Instantiate(ObjectInstantiane, pos, Quaternion.identity);
                    temp.name = objectName + "(" + i + ")";
                    temp.transform.parent = root.transform;
                    var tempRender = temp.GetComponent<Renderer>();
                    if (tempRender && randomColor)
                    {
                        tempRender.material.color = Random.ColorHSV();
                    }
                }
            }
        }
    }
}

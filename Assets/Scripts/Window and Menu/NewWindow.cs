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
        GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
        ObjectInstantiane = EditorGUILayout.ObjectField("Объект для вставки", ObjectInstantiane, typeof(GameObject), true) as GameObject;
        objectName = EditorGUILayout.TextField("Имя объекта", objectName);
        groupEnable = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", groupEnable);
        randomColor = EditorGUILayout.Toggle("Случайный цвет", randomColor);
        countOfObject = EditorGUILayout.IntSlider("Количество объектов", countOfObject, 1, 100);
        radius = EditorGUILayout.Slider("Радиус окружности", radius, 10, 50);
        colorField = EditorGUILayout.ColorField("Выберите цвет", colorField);
        EditorGUILayout.EndToggleGroup();
        var button = GUILayout.Button("Создать объекты");
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

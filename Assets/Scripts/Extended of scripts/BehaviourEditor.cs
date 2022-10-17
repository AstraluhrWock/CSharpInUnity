using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InspectorScript))]
public class BehaviourEditor : UnityEditor.Editor
{
    private bool _isPressButtonOk;

    public override void OnInspectorGUI()
    {
        InspectorScript testTarget = (InspectorScript)target;

        testTarget.count = EditorGUILayout.IntSlider(testTarget.count, 10, 50);
        testTarget.offset = EditorGUILayout.IntSlider(testTarget.offset, 1, 5);
        testTarget.obj = EditorGUILayout.ObjectField("Объект для вставки", testTarget.obj, typeof(GameObject), false) as GameObject;
        var isPressButton = GUILayout.Button("Создать объект по нажатию кнопки", EditorStyles.miniButtonLeft);
        _isPressButtonOk = GUILayout.Toggle(_isPressButtonOk, "OK");

        if (isPressButton)
        {
            testTarget.CreateGameObject();
            _isPressButtonOk = true;
        }

        if (_isPressButtonOk)
        {
            testTarget.test = EditorGUILayout.Slider(testTarget.test, 10, 50);
            EditorGUILayout.HelpBox("Вы нажали на кнопку", MessageType.Warning);
            var isPressAddButton = GUILayout.Button("Add Component", EditorStyles.miniButtonLeft);
            var isPressRemoveButton = GUILayout.Button("Remove Component", EditorStyles.miniButtonLeft);

            if (isPressAddButton)
            {
                testTarget.AddComponent();
            }

            if (isPressRemoveButton)
            {
                testTarget.RemoveComponent();
            }
        }
    }
}

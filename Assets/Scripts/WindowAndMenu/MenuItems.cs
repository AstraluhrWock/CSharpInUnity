using UnityEditor;


public class MenuItems
{
    [MenuItem("Lesson 7/Пункт меню №1")]
    private static void MenuOption()
    {
        EditorWindow.GetWindow(typeof(NewWindow), false, "Lesson 7");
    }
}


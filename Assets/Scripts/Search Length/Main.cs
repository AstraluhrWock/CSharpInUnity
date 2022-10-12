using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethod;
using System.Linq;

//4 b. * ���������� ��������� � OrderBy � �������������� �������� 
/*public delegate void Request(Dictionary<string, int> delegateDict);

public static void OrderByRequest(KeyValuePair<string, int> dict);
{ 
    var d = dict.OrderBy(pair => pair.Value);
}*/

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string s = "Hello world";
        int count = s.SearchOfLength();
        Debug.Log(count);
        CountOfEntrance();
        OrderByFunction();
    }


    // 3. ���� ��������� List<T>. ��������� ����������, ������� ��� ������ ������� ����������� � ������ ���������: 
    // �. ��� ����� �����;
    public void CountOfEntrance()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(1);
        numbers.Add(0);
        numbers.Add(1);
        // b. *��� ���������� ���������;

        // �. ** ��������� Linq.
        var count = numbers.GroupBy(x => x).Select(x => new { Value = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).First();
        Debug.Log($"{count.Value} count of: {count.Count}");
    }

    // 4. * � ��������� ��� �������� ���������, ����������:
    public void OrderByFunction()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>()
            {
            {"four",4 },
            {"two",2 },
            { "one",1 },
            {"three",3 },
            };

        var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair)
        {
            return pair.Value;
        });

        foreach (var pair in d)
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }

        // �.�������� ��������� � OrderBy � �������������� ������ - ��������� =>.
        var dir = dict.OrderBy(pair => pair.Value);

        foreach (var pair in dir)
        {
            Debug.Log($"my order: {pair.Key} - {pair.Value}");
        }

        

    }
}

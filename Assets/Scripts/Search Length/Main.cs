using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethod;
using System.Linq;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string s = "Hello world";
        int count = s.SearchOfLength();
        Debug.Log(count);
        CountOfEntrance();
    }


    // 3. Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции: 
    // а. для целых чисел;

    public void CountOfEntrance()
    {
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(1);
        numbers.Add(0);
        numbers.Add(1);
        var count = numbers.GroupBy(x => x).Select(x => new { Value = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).First();
        Debug.Log($"{count.Value} count of: {count.Count}");
    }


  /*  public void OrderByFunction() 
    {
       Dictionary<string, int> dict = new Dictionary<string, int>()
            {
            {"four",4 },
            {"two",2 },
            { "one",1 },
            {"three",3 },
            };

        var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) {
            return pair.Value;
        });



        var sort = (dict) =>
            {
                dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; };
            };

        delegate void sort(dict);


        foreach (var pair in d)
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }     

    }*/
}

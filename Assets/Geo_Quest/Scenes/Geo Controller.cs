using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    private int varOne = 1;
    int var3= 3;
    private string bacon = "salami";
    private int v;

    // Start is called before the first frame update
    void Start()
    {
        int var2 = 2;
        Debug.Log("Hello World");
        string milk = "what?";
        Debug.Log(bacon+milk);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var3++);
        var3++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        //print("Howdy!");
    }

    // Update is called once per frame
    void Update()
    {
        n = n + 1;
        print(n);
    }
}

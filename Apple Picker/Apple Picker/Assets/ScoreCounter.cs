using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI; // this line enables use of uGUI classes like text

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;

    private Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0"); // this 0 is a zero??

    }
}

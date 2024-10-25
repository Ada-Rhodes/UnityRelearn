using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    //Speed at which the AppleTree moves
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that AppleTree will change direction 
    public float changeDirectionChance = 0.1f;

    // Seconds between Apple instantiations 
    public float appleDropDelay = 1f;

    void Start()
    {
        //Start dropping apples 
        
    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing direction 
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // move right 
        } else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // move left
        } 
    }

    // Called every 50 ms 
    private void FixedUpdate()
    {
        if (Random.value < changeDirectionChance) {
            speed *= -1;

        }
    }
}

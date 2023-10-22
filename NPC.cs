using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int health = 5;
    int level = 1;
    float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.z += speed * Time.deltaTime;
        transform.position = newPos;
    }
}

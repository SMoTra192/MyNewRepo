using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrain : MonoBehaviour
{
    int count;
    int step = 100;
    bool False;
    bool True = True;
    float _speed = Vector3
    float PosY = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       print(count);
        print(step);

        print(False);
        print(True);
        var pose = transform.position;
        pose.x = positionX;
        transform.position = pose; 
    }

    // Update is called once per frame
    void Update()
    {
       var speed : Vector3.zero;
       speed.x = Input.GetAxis("Horizontal");
       speed.y = Input.GetAxis("Vertical");

         

   }
}

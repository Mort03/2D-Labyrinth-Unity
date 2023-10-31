using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    

    float newPositionX;
    float newPositionY;

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    GameObject teleporter;
    int teleporting = 0;
    public Move player;
    
    public void ifInteractedWith()
    {
        teleporting++;
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        if (teleporting == 1)
        {
            player.transform.position = new Vector2(-8.88f, 14.87f);
            teleporting = 0;
        }


    }
}

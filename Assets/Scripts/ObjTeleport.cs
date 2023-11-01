using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjTeleport : MonoBehaviour
{
    public Teleportation teleport;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        teleport.ifInteractedWith();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

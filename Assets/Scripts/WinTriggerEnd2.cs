using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger2 : MonoBehaviour
{
    public WinTextEnd2 winEnd2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winEnd2.Goal2();
        Destroy(gameObject);
    }
}

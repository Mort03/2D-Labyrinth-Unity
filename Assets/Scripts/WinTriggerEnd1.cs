using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerEnd1 : MonoBehaviour
{
    public WinTextEnd1 winEnd1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winEnd1.Goal1();
        Destroy(gameObject);
    }

}

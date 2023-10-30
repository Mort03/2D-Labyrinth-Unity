using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = coins.ToString();
    }

    public void AddCoins()
    {
        coins++;
    }
}

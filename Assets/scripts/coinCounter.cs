using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coinCounter : MonoBehaviour
{
    public static coinCounter instance;
    public TMP_Text coinText;
    public int currentCoins = 0;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinText.text = "Coins: " +currentCoins.ToString();
    }
    public void increaseCoins(int v)
    {
        currentCoins += v;
        coinText.text ="Coins: " + currentCoins.ToString();
    }
}

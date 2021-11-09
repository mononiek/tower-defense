using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 3;

    public Text moneyText;
    public Text livesText;



    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }

    void Update()
    {
        moneyText.text = "$" + Money;
        livesText.text = "Lives: " + Lives;
    }
}

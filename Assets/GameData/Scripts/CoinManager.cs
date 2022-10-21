using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public ulong TotalCoins = 0;
    public ulong PerSecond = 1;
    public ulong ClickCoin = 1;
    public TMP_Text TotalCoinsText;
    public TMP_Text PerSecondText;

    public Text DistanceText;

    protected ulong Timer;

    float temp;

    void Awake()
    {
        instance = this;
        TotalCoins = ulong.Parse(PlayerPrefs.GetString("Coins","0"),0);
        PerSecond = ulong.Parse(PlayerPrefs.GetString("PerSecond","0"));
        ClickCoin = ulong.Parse(PlayerPrefs.GetString("ClickCoin","0"));


        InvokeRepeating("SaveGame", 5f, 60f);
        temp = TotalCoins;
    }

    void Update()
    {

        temp += PerSecond *Time.deltaTime;

        TotalCoins = (ulong)temp;

        PerSecondText.text = "PerSecond: " + Display(PerSecond);

        TotalCoinsText.text = Display(TotalCoins) + "\nCoins";

    }
    public string Display(ulong valueToConvert)
    {
        string converted;

        if (valueToConvert >= 1000000000000000000)
        {
            converted = (valueToConvert / 1000000000000000000f).ToString("f3") + " QUI";
        }
        else if (valueToConvert >= 1000000000000000)
        {
            converted = (valueToConvert / 1000000000000000f).ToString("f3") + " QUA";
        }
        else if (valueToConvert >= 1000000000000)
        {
            converted = (valueToConvert / 1000000000000f).ToString("f3") + "T";
        }
        else if (valueToConvert >= 1000000000)
        {
            converted = (valueToConvert / 1000000000f).ToString("f3") + "B";
        }
        else if (valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("f3") + "M";
        }
        else if (valueToConvert >= 999)
        {
            converted = (valueToConvert / 999f).ToString("f3") + "K";
        }
        else
        {
            converted = Mathf.Round(valueToConvert).ToString();
        }
        return converted;
    }
    void SaveGame()
    {
        PlayerPrefs.SetString("Coins", TotalCoins.ToString());
        PlayerPrefs.SetString("PerSecond", PerSecond.ToString());
        PlayerPrefs.SetString("ClickCoin", ClickCoin.ToString());
        print("Game Saved !");
    }

    void ResetClick()
    {
        this.transform.GetChild(1).gameObject.SetActive(false);
    }

    public void OnClick()
    {

        Text tempTextBox = Instantiate(DistanceText, transform) as Text;
        tempTextBox.text = "+ " + ClickCoin;
        //tempTextBox.transform.SetParent(this.transform, false);

        TotalCoins += ClickCoin;
        TotalCoinsText.text = TotalCoins + "\nCoins";
        this.transform.GetChild(1).gameObject.GetComponent<Animator>().enabled = true;
        Invoke("ResetClick", 1.2f);
    }
}
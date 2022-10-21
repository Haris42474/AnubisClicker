using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public float TotalCoins = 0;
    public float PerSecond = 1;
    public float ClickCoin = 1;
    public TMP_Text TotalCoinsText;
    public TMP_Text PerSecondText;

    public Text DistanceText;

    protected float Timer;

    void Awake()
    {
        instance = this;
        TotalCoins = PlayerPrefs.GetFloat("Coins", 1);
        PerSecond = PlayerPrefs.GetFloat("PerSecond", 1);
        ClickCoin = PlayerPrefs.GetFloat("ClickCoin", 1);

        InvokeRepeating("SaveGame", 5f, 60f);

    }

    void Update()
    {
        Timer += Time.deltaTime;

        TotalCoins += PerSecond * Time.deltaTime;

        PerSecondText.text = "PerSecond: " + Display(PerSecond);

        TotalCoinsText.text = Display(TotalCoins) + "\nCoins";

    }
    public string Display(float valueToConvert)
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
        PlayerPrefs.SetFloat("Coins", TotalCoins);
        PlayerPrefs.SetFloat("PerSecond", PerSecond);
        PlayerPrefs.SetFloat("ClickCoin", ClickCoin);
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
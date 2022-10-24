using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Store : MonoBehaviour
{
    public static Store instance;

    public List<string> EmployeeType;

    public List<int> EmployeeCount;

    public List<ulong> EmployeePrice;

    public List<ulong> DefaultPrice;

    public List<ulong> addPerSec;

    public List<TextMeshProUGUI> Description;

    const float mainDigit = 1.15f;

    private void Awake()
    {
        instance = this;
        saveData();
    }

    void load()
    {
        for(int i=0;i<10;i++)
        {
            EmployeeCount[i] = PlayerPrefs.GetInt("EmployeeCount" + (i + 1), 0);
            EmployeePrice[i] = ulong.Parse(PlayerPrefs.GetString("EmployeePrice" + (i + 1), "0"));
            addPerSec[i] = ulong.Parse(PlayerPrefs.GetString("AddPerSec" + (i + 1), "0"));
        }
    }
    void Start()
    {
        for(int i=0;i<10;i++)
        {
            Description[i].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[i]) + " c\nBuy " + EmployeeType[i] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[i]);
        }
        load();
    }
    public void AddEmployee1()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[0])
        {
            CoinManager.instance.temp -= EmployeePrice[0];
            CoinManager.instance.PerSecond += addPerSec[0];
            EmployeeCount[0]++;
            EmployeePrice[0] = (ulong)Mathf.CeilToInt(DefaultPrice[0] * (Mathf.Pow(mainDigit, EmployeeCount[0])));
            Description[0].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[0]) + " c\nBuy " + EmployeeType[0] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[0]);
        }

    }
    public void AddEmployee2()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[1])
        {
            CoinManager.instance.temp -= EmployeePrice[1];
            CoinManager.instance.PerSecond += addPerSec[1];
            EmployeeCount[1]++;
            EmployeePrice[1] = (ulong)Mathf.CeilToInt(DefaultPrice[1] * (Mathf.Pow(mainDigit, EmployeeCount[1])));
            Description[1].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[1]) + " c\nBuy " + EmployeeType[1] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[1]);
        }

    }
    public void AddEmployee3()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[2])
        {
            CoinManager.instance.temp -= EmployeePrice[2];
            CoinManager.instance.PerSecond += addPerSec[2];
            EmployeeCount[2]++;
            EmployeePrice[2] = (ulong)Mathf.CeilToInt(DefaultPrice[2] * (Mathf.Pow(mainDigit, EmployeeCount[2])));
            Description[2].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[2]) + " c\nBuy " + EmployeeType[2] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[2]);
        }

    }
    public void AddEmployee4()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[3])
        {
            CoinManager.instance.temp -= EmployeePrice[3];
            CoinManager.instance.PerSecond += addPerSec[3];
            EmployeeCount[3]++;
            EmployeePrice[3] = (ulong)Mathf.CeilToInt(DefaultPrice[3] * (Mathf.Pow(mainDigit, EmployeeCount[3])));
            Description[3].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[3]) + " c\nBuy " + EmployeeType[3] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[3]);
        }

    }
    public void AddEmployee5()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[4])
        {
            CoinManager.instance.temp -= EmployeePrice[4];
            CoinManager.instance.PerSecond += addPerSec[4];
            EmployeeCount[4]++;
            EmployeePrice[4] = (ulong)Mathf.CeilToInt(DefaultPrice[4] * (Mathf.Pow(mainDigit, EmployeeCount[4])));
            Description[4].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[4]) + " c\nBuy " + EmployeeType[4] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[4]);
        }

    }
    public void AddEmployee6()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[5])
        {
            CoinManager.instance.temp -= EmployeePrice[5];
            CoinManager.instance.PerSecond += addPerSec[5];
            EmployeeCount[5]++;
            EmployeePrice[5] = (ulong)Mathf.CeilToInt(DefaultPrice[5] * (Mathf.Pow(mainDigit, EmployeeCount[5])));
            Description[5].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[5]) + " c\nBuy " + EmployeeType[5] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[5]);
        }

    }
    public void AddEmployee7()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[6])
        {
            CoinManager.instance.temp -= EmployeePrice[6];
            CoinManager.instance.PerSecond += addPerSec[6];
            EmployeeCount[6]++;
            EmployeePrice[6] = (ulong)Mathf.CeilToInt(DefaultPrice[6] * (Mathf.Pow(mainDigit, EmployeeCount[6])));
            Description[6].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[6]) + " c\nBuy " + EmployeeType[6] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[6]);
        }

    }
    public void AddEmployee8()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[0])
        {
            CoinManager.instance.temp -= EmployeePrice[0];
            CoinManager.instance.PerSecond += addPerSec[7];
            EmployeeCount[7]++;
            EmployeePrice[7] = (ulong)Mathf.CeilToInt(DefaultPrice[7] * (Mathf.Pow(mainDigit, EmployeeCount[0])));
            Description[7].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[7]) + " c\nBuy " + EmployeeType[7] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[7]);
        }

    }
    public void AddEmployee9()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[8])
        {
            CoinManager.instance.temp -= EmployeePrice[8];
            CoinManager.instance.PerSecond += addPerSec[8];
            EmployeeCount[8]++;
            EmployeePrice[8] = (ulong)Mathf.CeilToInt(DefaultPrice[8] * (Mathf.Pow(mainDigit, EmployeeCount[8])));
            Description[8].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[8]) + " c\nBuy " + EmployeeType[8] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[8]);
        }

    }
    public void AddEmployee10()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[9])
        {
            CoinManager.instance.temp -= EmployeePrice[9];
            CoinManager.instance.PerSecond += addPerSec[9];
            EmployeeCount[9]++;
            EmployeePrice[9] = (ulong)Mathf.CeilToInt(DefaultPrice[9] * (Mathf.Pow(mainDigit, EmployeeCount[9])));
            Description[9].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[9]) + " c\nBuy " + EmployeeType[9] + " to add per second count: +" + CoinManager.instance.Display(addPerSec[9]);
        }

    }
    public void saveData()
    {
        for(int i=0;i<10;i++)
        {
            PlayerPrefs.SetInt("EmployeeCount" + (i + 1), EmployeeCount[i]);
            PlayerPrefs.SetString("EmployeePrice" + (i + 1), EmployeePrice[i].ToString());
            PlayerPrefs.SetString("AddPerSec" + (i + 1), addPerSec[i].ToString());
        }
    }
}

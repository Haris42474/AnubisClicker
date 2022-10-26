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

    public List<TextMeshProUGUI> ECount;

    const float mainDigit = 1.15f;

    [SerializeField] AudioSource audio;

    public List<AudioClip> Sounds;

    public GameObject Statues;

    int count = 0;

    int countSize = 10;

    private void Awake()
    {
        instance = this;
        if(PlayerPrefs.GetInt("check", 0)==0)
        {
            saveData();
            PlayerPrefs.SetInt("check", 1);
        }
        
    }

    void load()
    {
        for(int i=0;i<10;i++)
        {
            EmployeeCount[i] = PlayerPrefs.GetInt("EmployeeCount" + (i + 1), 0);
            EmployeePrice[i] = ulong.Parse(PlayerPrefs.GetString("EmployeePrice" + (i + 1), "0"));
            addPerSec[i] = ulong.Parse(PlayerPrefs.GetString("AddPerSec" + (i + 1), "0"));
        }
        count=PlayerPrefs.GetInt("Count", 0);
    }
    void Start()
    {
        load();
        for(int i=0;i<10;i++)
        {
            Description[i].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[i]) + " c\nBuy " + EmployeeType[i] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[i]);
            ECount[i].text = EmployeeCount[i] + "";
            if (EmployeeCount[i] > 0 && count == 0)
            {
                count += EmployeeCount[i];
            }
        }
        
        for(int i=0;i<count;i++)
        {
            Statues.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
    public void AddEmployee1()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[0])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[0];
            CoinManager.instance.PerSecond += addPerSec[0];
            EmployeeCount[0]++;
            EmployeePrice[0] = (ulong)Mathf.CeilToInt(DefaultPrice[0] * (Mathf.Pow(mainDigit, EmployeeCount[0])));
            Description[0].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[0]) + " c\nBuy " + EmployeeType[0] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[0]);
            ECount[0].text = EmployeeCount[0] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }

    }
    public void AddEmployee2()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[1])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[1];
            CoinManager.instance.PerSecond += addPerSec[1];
            EmployeeCount[1]++;
            EmployeePrice[1] = (ulong)Mathf.CeilToInt(DefaultPrice[1] * (Mathf.Pow(mainDigit, EmployeeCount[1])));
            Description[1].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[1]) + " c\nBuy " + EmployeeType[1] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[1]);
            ECount[1].text = EmployeeCount[1] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee3()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[2])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[2];
            CoinManager.instance.PerSecond += addPerSec[2];
            EmployeeCount[2]++;
            EmployeePrice[2] = (ulong)Mathf.CeilToInt(DefaultPrice[2] * (Mathf.Pow(mainDigit, EmployeeCount[2])));
            Description[2].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[2]) + " c\nBuy " + EmployeeType[2] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[2]);
            ECount[2].text = EmployeeCount[2] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee4()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[3])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[3];
            CoinManager.instance.PerSecond += addPerSec[3];
            EmployeeCount[3]++;
            EmployeePrice[3] = (ulong)Mathf.CeilToInt(DefaultPrice[3] * (Mathf.Pow(mainDigit, EmployeeCount[3])));
            Description[3].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[3]) + " c\nBuy " + EmployeeType[3] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[3]);
            ECount[3].text = EmployeeCount[3] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee5()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[4])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[4];
            CoinManager.instance.PerSecond += addPerSec[4];
            EmployeeCount[4]++;
            EmployeePrice[4] = (ulong)Mathf.CeilToInt(DefaultPrice[4] * (Mathf.Pow(mainDigit, EmployeeCount[4])));
            Description[4].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[4]) + " c\nBuy " + EmployeeType[4] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[4]);
            ECount[4].text = EmployeeCount[4] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee6()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[5])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[5];
            CoinManager.instance.PerSecond += addPerSec[5];
            EmployeeCount[5]++;
            EmployeePrice[5] = (ulong)Mathf.CeilToInt(DefaultPrice[5] * (Mathf.Pow(mainDigit, EmployeeCount[5])));
            Description[5].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[5]) + " c\nBuy " + EmployeeType[5] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[5]);
            ECount[5].text = EmployeeCount[5] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee7()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[6])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[6];
            CoinManager.instance.PerSecond += addPerSec[6];
            EmployeeCount[6]++;
            EmployeePrice[6] = (ulong)Mathf.CeilToInt(DefaultPrice[6] * (Mathf.Pow(mainDigit, EmployeeCount[6])));
            Description[6].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[6]) + " c\nBuy " + EmployeeType[6] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[6]);
            ECount[6].text = EmployeeCount[6] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee8()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[7])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[7];
            CoinManager.instance.PerSecond += addPerSec[7];
            EmployeeCount[7]++;
            EmployeePrice[7] = (ulong)Mathf.CeilToInt(DefaultPrice[7] * (Mathf.Pow(mainDigit, EmployeeCount[0])));
            Description[7].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[7]) + " c\nBuy " + EmployeeType[7] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[7]);
            ECount[7].text = EmployeeCount[7] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee9()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[8])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[8];
            CoinManager.instance.PerSecond += addPerSec[8];
            EmployeeCount[8]++;
            EmployeePrice[8] = (ulong)Mathf.CeilToInt(DefaultPrice[8] * (Mathf.Pow(mainDigit, EmployeeCount[8])));
            Description[8].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[8]) + " c\nBuy " + EmployeeType[8] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[8]);
            ECount[8].text = EmployeeCount[8] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
        }
    }
    public void AddEmployee10()
    {
        if (CoinManager.instance.TotalCoins >= EmployeePrice[9])
        {
            audio.PlayOneShot(Sounds[0]);
            CoinManager.instance.temp -= EmployeePrice[9];
            CoinManager.instance.PerSecond += addPerSec[9];
            EmployeeCount[9]++;
            EmployeePrice[9] = (ulong)Mathf.CeilToInt(DefaultPrice[9] * (Mathf.Pow(mainDigit, EmployeeCount[9])));
            Description[9].text = "Cost : " + CoinManager.instance.Display(EmployeePrice[9]) + " c\nBuy " + EmployeeType[9] + " to increase CPS: +" + CoinManager.instance.Display(addPerSec[9]);
            ECount[9].text = EmployeeCount[9] + "";
            if (count < countSize)
            {
                Statues.transform.GetChild(count).gameObject.SetActive(true);
                count++;
            }
        }
        else
        {
            audio.PlayOneShot(Sounds[1]);
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
        PlayerPrefs.SetInt("Count", count);
    }
}

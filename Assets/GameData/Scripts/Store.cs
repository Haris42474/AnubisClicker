using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Store : MonoBehaviour
{
    [SerializeField] ulong EmployeeCount = 0;

    [SerializeField] ulong EmployeePrice = 100;

    [SerializeField] ulong CursorCount = 0;

    [SerializeField] ulong CursorPrice = 500;

    public ulong addPerSec = 1;
    public ulong addClickCoin = 3;

    public TMP_Text EmployeeCountText;

    public void AddEmployee()
    {
        if(CoinManager.instance.TotalCoins>=EmployeePrice)
        {
            CoinManager.instance.TotalCoins -= EmployeePrice;
            CoinManager.instance.PerSecond += addPerSec;
            EmployeeCount++;
            EmployeeCountText.text = "Employees = " + EmployeeCount;
        }
        
    }
    public void AddCursor()
    {
        if (CoinManager.instance.TotalCoins >= CursorPrice)
        {
            CoinManager.instance.TotalCoins -= CursorPrice;
            CoinManager.instance.ClickCoin += addClickCoin;
        }

    }

}

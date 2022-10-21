using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Store : MonoBehaviour
{
    [SerializeField] float EmployeeCount = 0;

    [SerializeField] float EmployeePrice = 100;

    [SerializeField] float CursorCount = 0;

    [SerializeField] float CursorPrice = 500;

    public int addPerSec = 1;
    public int addClickCoin = 3;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyManager : MonoBehaviour
{
	public int money;
	public Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
    }

    // Update is called once per frame
    void Update()
    {
    	money = PlayerPrefs.GetInt("money");
    	moneyText.text = money.ToString();   
    }
}

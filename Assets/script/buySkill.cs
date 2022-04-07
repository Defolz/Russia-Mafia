using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buySkill : MonoBehaviour
{
	public int Pistol;
    public int Heal;
    public int Grenade;
	public int money;
	public Button butBuyPistol;
    public Button butBuyHeal;
    public Button butBuyGrenade;
    // Start is called before the first frame update
    void Start()
    {
    	Pistol = PlayerPrefs.GetInt("Pistol");
        Heal  = PlayerPrefs.GetInt("Heal");
        Grenade  = PlayerPrefs.GetInt("Grenade");
    	money = PlayerPrefs.GetInt("money");

    	if(Pistol !=0)
    	{
    		Pistol = 1;
    		butBuyPistol.interactable = false;
    	}

        if(Heal !=0)
        {
            Heal = 1;
            butBuyHeal.interactable = false;
        }

        if(Grenade !=0)
        {
            Grenade = 1;
            butBuyGrenade.interactable = false;
        }     
    }

    public void buyPistol()
    {
    	if(Pistol !=0)
    	{
    		Pistol = 1;
    		PlayerPrefs.SetInt("Pistol", 1);
    		butBuyPistol.interactable = false;
    	}
    	else if(Pistol == 0)
    	{
    		Pistol = 1;
    		money-=500;
    		PlayerPrefs.SetInt("Pistol", Pistol);
    		PlayerPrefs.SetInt("money", money);
    		butBuyPistol.interactable = false;
    	}
    }

    public void buyHeal()
    {
        if(Heal !=0)
        {
            Heal = 1;
            PlayerPrefs.SetInt("Heal", 1);
            butBuyHeal.interactable = false;
        }
        else if(Heal == 0)
        {
            Heal = 1;
            money-=1000;
            PlayerPrefs.SetInt("Heal", Heal);
            PlayerPrefs.SetInt("money", money);
            butBuyHeal.interactable = false;
        }
    }

    public void buyGrenade()
    {
        if(Grenade !=0)
        {
            Grenade = 1;
            PlayerPrefs.SetInt("Grenade", 1);
            butBuyGrenade.interactable = false;
        }
        else if(Grenade == 0)
        {
            Grenade = 1;
            money-=2000;
            PlayerPrefs.SetInt("Grenade", Grenade);
            PlayerPrefs.SetInt("money", money);
            butBuyGrenade.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

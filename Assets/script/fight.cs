

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fight : MonoBehaviour
{
	public float health;
	public float healthEnemy;
	public int Damage = 1;
	public int Pistol;
	public int Heal;
	public int Grenade;
	public Text HealtText;
	public Text EnemyText;
	public Button butPistol;
	public Button butHeal;
	public Button butGrenade;
	public GameObject enemyButton;
	public int money;
	public AudioSource audioSource;
	public AudioSource ogh;
	public Image healthEnemyBar;
	public int healthEnemyBarStart;
	public Image healthBarMe;
    void Start()
    {
    	health = PlayerPrefs.GetInt("health");
    	healthEnemyBarStart = PlayerPrefs.GetInt("healthEnemy");
    	healthEnemy = PlayerPrefs.GetInt("healthEnemy");
    	Pistol = PlayerPrefs.GetInt("Pistol");
    	Heal = PlayerPrefs.GetInt("Heal");
    	Grenade = PlayerPrefs.GetInt("Grenade");
    	money = PlayerPrefs.GetInt("money");
    	StartCoroutine(HealtLoss());
    	//StartCoroutine(HealtLossFire());
    	StartCoroutine(MagicSpawn());
    	if(Pistol !=1)
    	{
    		butPistol.interactable = false;
    	}
    	if(Heal!=1)
    	{
    		butHeal.interactable = false;
    	}
    	if(Grenade !=1)
    	{
    		butGrenade.interactable = false;
    	}
    	audioSource = GetComponent<AudioSource>();
    	 
    }

    public void Hit()
    {
    	healthEnemy -= Damage;
    	healthEnemyBar.fillAmount = healthEnemy/healthEnemyBarStart;
    	if (healthEnemy <= 0)
    	{
    		money+=500;
    		PlayerPrefs.SetInt("money", money);

    	}
    }

    public void SkillPistol()
    {
    	
    	if (Pistol == 1)
    	{
    		healthEnemy-=50;
    		butPistol.interactable = false;
    		healthEnemyBar.fillAmount = healthEnemy/healthEnemyBarStart;
    		audioSource.Play();
    	}
    	else if(Pistol !=1)
    	{
    		butPistol.interactable = false;
    	}
    	if (healthEnemy <= 0)
    	{
    		money+=500;
    		PlayerPrefs.SetInt("money", money);
    	}
    }

    public void SkillHeal()
    {
    	if (Heal == 1)
    	{
    		health+=20;
    		butHeal.interactable = false;
    	}
    	else if(Heal !=1)
    	{
    		butHeal.interactable = false;
    	}	
    }

    public void SkillGrenade()
    {
    	
    	if (Grenade == 1)
    	{
    		healthEnemy-=100;
    		butGrenade.interactable = false;
    		healthEnemyBar.fillAmount = healthEnemy/healthEnemyBarStart;
    		//audioSource.Play();
    	}
    	else if(Grenade !=1)
    	{
    		butGrenade.interactable = false;
    	}
    	if (healthEnemy <= 0)
    	{
    		money+=500;
    		PlayerPrefs.SetInt("money", money);
    	}
    }

    public void MagicFire()
    {
    	health-=50;
  		healthBarMe.fillAmount = health/100;
  		audioSource.Play();
    }

    IEnumerator HealtLoss()
    {
        yield return new WaitForSeconds(1);
        health--;
        healthBarMe.fillAmount = health/100;
        StartCoroutine(HealtLoss());
    }

    /*IEnumerator HealtLossFire()
    {
    	yield return new WaitForSeconds(15);
    	if (enemyButton.SetActive = true)
    	{
  			float chance = Random.Range(0f,1f);
  			if (chance >= 0.5f)
  			{
  				MagicFire();
  				ogh.Play();
  			}
  		}
  		StartCoroutine(HealtLossFire());
    }*/

    

    IEnumerator MagicSpawn()
    {
    	yield return new WaitForSeconds(Random.Range(10,20));
    	enemyButton.SetActive(false);
    	yield return new WaitForSeconds(Random.Range(5,10));
    	enemyButton.SetActive(true);
    	float chance = Random.Range(0f,1f);
  		if (chance >= 0.5f)
  		{
  			MagicFire();
  		}
    	StartCoroutine(MagicSpawn());
    }

    // Update is called once per frame
    void Update()
    {
    	HealtText.text = health.ToString();
   		EnemyText.text = healthEnemy.ToString();
   		if (health <= 0)
        {
            Camera.main.GetComponent<UIManager>().Lose();
            
        }
        else if (healthEnemy <= 0)
        {
            Camera.main.GetComponent<UIManager>().Win();
            PlayerPrefs.SetInt("money", money);

        } 
    }   
}
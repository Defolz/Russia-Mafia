using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthAll : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public int gusstationhealth = 200;
    public int zavodHealth = 400;
    void Start()
    {
    	PlayerPrefs.SetInt("health", health);

    	if (SceneManager.GetActiveScene().name == "gusstation")
    	{
    		PlayerPrefs.SetInt("healthEnemy", gusstationhealth);
    	}
    	else if(SceneManager.GetActiveScene().name == "Zavod")
    	{
    		PlayerPrefs.SetInt("healthEnemy", zavodHealth);	
    	}
    	
    }

}

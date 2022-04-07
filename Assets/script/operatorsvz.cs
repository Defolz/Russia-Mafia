using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operatorsvz : MonoBehaviour
{
	public int Pistol;
    // Start is called before the first frame update
    void Start()
    {
    	    
    }

    // Update is called once per frame
    void Update()
    {
    	Pistol = PlayerPrefs.GetInt("Pistol");	  
    }
}

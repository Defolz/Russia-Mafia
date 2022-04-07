using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifdeath : MonoBehaviour
{
	public int HPBoss;
	public int HP;
    // Start is called before the first frame update
    void Start()
    {
    	HPBoss = PlayerPrefs.GetInt("HPBoss");
    	HP = PlayerPrefs.GetInt("HP");    
    }

    // Update is called once per frame
    void Update()
    {
    	
        if (HP <= 0)
        {
            Camera.main.GetComponent<UIManager>().Lose();
        }
        if (HPBoss <= 0)
        {
            Camera.main.GetComponent<UIManager>().Win();
        } 
    }
}

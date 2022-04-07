using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hit : MonoBehaviour
{
	public int HPBoss = 100;
	public int Damage = 1;
    public int HP = 100;
	public Text HPBossText;
	public Text HPText;
    // Start is called before the first frame update
    void Start()
    {
        HPBoss = 100;
        HP = 100;
        StartCoroutine(HealtLoss());
    }


    public void Hit()
    {
    	HPBoss -= Damage;
    	PlayerPrefs.SetInt("HPBoss", HPBoss);
    }

    IEnumerator HealtLoss()
    {
        yield return new WaitForSeconds(1);
        HP--;
        PlayerPrefs.SetInt("HP", HP);
        StartCoroutine(HealtLoss());
    }

    // Update is called once per frame
    void Update()
    {
        HP = PlayerPrefs.GetInt("HP");
        HPBoss = PlayerPrefs.GetInt("HPBoss");
    	HPBossText.text = HPBoss.ToString();
    	HPText.text = HP.ToString();    
    }
}

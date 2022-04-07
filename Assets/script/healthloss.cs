using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthloss : MonoBehaviour
{
    // Start is called before the first frame update
    public int HP;
    void Start()
    {
    	HP = PlayerPrefs.GetInt("HP");
    	StartCoroutine(HealtLoss());      
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
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastreset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
    	PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

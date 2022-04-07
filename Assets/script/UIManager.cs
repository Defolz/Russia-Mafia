using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	[SerializeField] private GameObject panelWin;
	[SerializeField] private GameObject panelLose;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Win(){
    	panelWin.SetActive(true);
    }

    public void Lose(){
    	panelLose.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

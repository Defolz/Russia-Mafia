using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    	Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
    public void ToGlobalMap()
    {
    	SceneManager.LoadScene(0);	
    }

    public void ToMap()
    {
    	SceneManager.LoadScene(1);
    }

    public void ToGusstation()
    {
        SceneManager.LoadScene(2);
    }

    public void ToShop()
    {
    	SceneManager.LoadScene(3);
    }

    public void ToZavod()
    {
    	SceneManager.LoadScene(4);
    }

    public void ToSpalny()
    {
    	SceneManager.LoadScene(5);
    }

    public void ToPadik()
   	{
   		SceneManager.LoadScene(6);
   	}

   	public void ToSad()
   	{
   		SceneManager.LoadScene(7);
   	}


}

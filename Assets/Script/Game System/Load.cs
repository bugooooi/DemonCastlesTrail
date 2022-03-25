using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    private int sceneToContinue;

    public void ContinueGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("4Travel");

        if(sceneToContinue != 0)
            SceneManager.LoadScene(sceneToContinue);
        else
            return;
 
    }
}

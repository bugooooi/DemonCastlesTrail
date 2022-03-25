using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public Text Annouce;
    private void Update(){
        Annouce.text="You arrived at "+TravelStat.LandmarkNow;
    }

    public void LevelUpProgress(){
        SceneManager.LoadScene("5Landmark");
    }
}

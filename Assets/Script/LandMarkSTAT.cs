using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LandMarkSTAT : MonoBehaviour
{
    public Text LMName;

    private void Update(){
        UpdateLandMark();
    }
    
    private void UpdateLandMark(){
        LMName.text=TravelStat.LandmarkNow;
    }

}

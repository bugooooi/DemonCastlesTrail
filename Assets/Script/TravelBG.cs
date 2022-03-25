using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TravelBG : MonoBehaviour
{
    [SerializeField] private bool unlockedTBG;
    public Image unlockTBG;
    public string TBGName;
    private static string TNow;


    void Start(){

    }

    private void Update(){
        TNow=TravelStat.LandmarkNow;
        UpdateTBG();
    }

    private void UpdateTBG(){
        if(TBGName==TNow){
            unlockTBG.gameObject.SetActive(true);
        }else{
            unlockTBG.gameObject.SetActive(false);
        }
    }
}

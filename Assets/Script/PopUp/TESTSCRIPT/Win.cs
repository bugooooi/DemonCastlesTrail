using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject SHopUp;
    public void WinProgress(){
        if(TravelStat.currentSupply<TravelStat.MaxSupply){
            TravelStat.currentSupply+=15;
            TravelStat.Gold+=5;
            if(TravelStat.currentHp>0){
                TravelStat.currentHp-=5;
            }else{
                SceneManager.LoadScene("1Menu");
            }
        }else{
            TravelStat.currentSupply=TravelStat.MaxSupply;
            TravelStat.Gold+=5;
            if(TravelStat.currentHp>0){
                TravelStat.currentHp-=5;
            }else{
                SceneManager.LoadScene("1Menu");
            }
        }
        SHopUp.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject SHopUp;
    public void LoseProgress(){
        if(TravelStat.currentSupply<TravelStat.MaxSupply){
            TravelStat.currentSupply+=5;
            if(TravelStat.currentHp>0){
                TravelStat.currentHp-=20;
            }else{
                SceneManager.LoadScene("8Death");
            }
        }else{
            TravelStat.currentSupply=TravelStat.MaxSupply;
            if(TravelStat.currentHp>0){
                TravelStat.currentHp-=20;
            }else{
                SceneManager.LoadScene("8Death");
            }
        }
        SHopUp.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestCampButton : MonoBehaviour
{
    public Text SupplyText;
    public void RestTime(){
        //Item Supply Health
        if(TravelStat.currentSupply<=TravelStat.MaxSupply&&TravelStat.currentSupply>=10&&TravelStat.currentStamina<TravelStat.maxStamina){
            TravelStat.currentSupply-=(10-ItemStat.SaveSupply);
            TravelStat.currentStamina+=5;
            TravelStat.currentHp+=ItemStat.SupplyHealth;
            if(TravelStat.currentStamina>=TravelStat.maxStamina){
                TravelStat.currentStamina=TravelStat.maxStamina;
            }
        }
        else{
            SupplyText.text = "Supplies : Not Enough";
        }
    }
}

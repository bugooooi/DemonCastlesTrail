using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestStat : MonoBehaviour
{
    public Text SupplyText,GPText,HPText,StaminaText,PCLv;

    private void Update(){
        UpdateStat();
    }
    //displayText.text = (fillPercentage * 100).ToString("0.00") + "%";
    private void UpdateStat(){
        SupplyText.text = "Supplies : "+TravelStat.currentSupply+" / "+TravelStat.MaxSupply;
        GPText.text = "Gold : "+TravelStat.Gold;
        HPText.text = "Health Point : "+TravelStat.currentHp+" / "+TravelStat.maxHp;
        StaminaText.text = "STAMINA : "+TravelStat.currentStamina;
    }
}

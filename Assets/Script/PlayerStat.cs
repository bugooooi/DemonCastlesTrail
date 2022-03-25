using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStat : MonoBehaviour
{
    public Text SupplyText,DisText,GPText,HPText,StaminaText,PCLv;
    public GameObject POPLV,CampB,BagB,HPC,BPC;

    void Start(){
        InvokeRepeating("TravelPower", 1f, 1f);
    }

    private void Update(){
        Death();
        UpdateStat();
        if(TravelStat.LandmarkNow=="Crabonest"){
            CampB.SetActive(false);
            BPC.SetActive(true);
            HPC.SetActive(false);
        }else if(TravelStat.LandmarkNow=="Colossus"){
            CampB.SetActive(false);
            BPC.SetActive(true);
            HPC.SetActive(false);
        }else{
            CampB.SetActive(true);
            BPC.SetActive(false);
            HPC.SetActive(true);
        }
    }
    //displayText.text = (fillPercentage * 100).ToString("0.00") + "%";
    private void UpdateStat(){
        SupplyText.text = "Supplies : "+TravelStat.currentSupply+" / "+TravelStat.MaxSupply;
        DisText.text = "Distance to "+TravelStat.LandmarkNow+" : "+TravelStat.Distance;
        GPText.text = "Gold : "+TravelStat.Gold;
        HPText.text = "Health Point : "+TravelStat.currentHp+" / "+TravelStat.maxHp;
        StaminaText.text = "STAMINA : "+TravelStat.currentStamina;
    }
    private void TravelPower(){
        if(TravelStat.currentStamina > 0&&TravelStat.Distance>0){
            TravelStat.currentStamina -= 2;
            TravelStat.Distance-=(10 + ItemStat.HorseRun); //-10
        }else if(TravelStat.currentStamina <= 0&&TravelStat.Distance>0){
            if(TravelStat.currentHp>0){
                TravelStat.currentHp -= (5 - ItemStat.Starve);
                TravelStat.Distance-=(10 + ItemStat.HorseRun); //-10
            }else if(TravelStat.currentHp<=0){
                SceneManager.LoadScene("8Death");
            }
        }else{
            if(TravelStat.Distance<0){
                TravelStat.Distance=0;
            }
            POPLV.SetActive(true);
            CampB.SetActive(false);
            BagB.SetActive(false);
            /*
            TravelStat.levelnow+=1;
            TravelStat.maxHp+=5;
            TravelStat.maxStamina+=5;
            SceneManager.LoadScene("5Landmark");*/
        }
        
    }
    public void Death()
    {
        if (TravelStat.currentHp == 0)
        {
            Destroy(gameObject);
        }
    }
}

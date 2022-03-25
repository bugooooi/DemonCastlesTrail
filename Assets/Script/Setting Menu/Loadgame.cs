using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loadgame : MonoBehaviour
{
    public void loadplayer()
    {
        
        PlayerData data = SaveSystem.LoadPlayer();

        TravelStat.LandmarkNow = data.LN;
        TravelStat.LandmarkPre = data.LP;

        TravelStat.maxStamina = data.MS;
        TravelStat.currentStamina = data.CS;
        
        TravelStat.maxHp = data.MH;
        TravelStat.currentHp = data.CH;

        TravelStat.MaxSupply = data.MSu;
        TravelStat.currentSupply = data.CSu;

        TravelStat.Gold = data.GD;

        TravelStat.QuestPass = data.QP;
        TravelStat.QuestUnlock = data.QU;
        
        ItemStat.Item = data.IT;

        SceneManager.LoadScene("5Landmark");
    }

    public void NewGame()
    {

        TravelStat.LandmarkNow = "Merinia";
        TravelStat.LandmarkPre = new List<string>(); 

        TravelStat.maxStamina = 100;
        TravelStat.currentStamina = 100;
        
        TravelStat.maxHp = 100 + ItemStat.SeaArmor + ItemStat.ArmorFire+ItemStat.IronArmor;
        TravelStat.currentHp =100;

        TravelStat.MaxSupply = 100;
        TravelStat.currentSupply = 100;

        TravelStat.Gold =100;///100

        TravelStat.QuestPass = new List<string>();
        TravelStat.QuestUnlock = new List<string>(); 
        
        ItemStat.Item = new List<string>();

        SceneManager.LoadScene("2Intro");
    }

}

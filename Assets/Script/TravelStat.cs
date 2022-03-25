using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelStat : MonoBehaviour
{
    public static string LandmarkNow = "Merinia";
    public static List<string> LandmarkPre = new List<string>(); 
 

    public static string BagBack = "4Travel";
    public static string BackFromAttack = "5Landmark";
    
    public static int maxStamina = 100;
    public static int currentStamina = 100;

    public static int maxHp=100 + ItemStat.SeaArmor + ItemStat.ArmorFire+ItemStat.IronArmor;
    public static int currentHp=100;

    public static int MaxSupply=100;
    public static int currentSupply=100;

    public static int Distance=0;

    public static int Gold=100;///100
    public static int PriceInn=20;
    public static int PriceSupply=25;

    public static int levelnow=1;

    public static List<string> QuestPass = new List<string>(); 
    public static List<string> QuestUnlock = new List<string>(); 

    public static string QAName="0";

    public static string Item_Name = "1Sword";

    void Update(){
        SaveSystem.SavePlayer(this);
    }

}

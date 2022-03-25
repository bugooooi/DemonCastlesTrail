using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealShop : MonoBehaviour
{
    public void HealShProgress(){
        if(TravelStat.currentSupply<TravelStat.MaxSupply&&TravelStat.Gold>=100){
            TravelStat.Gold-=100;
            TravelStat.currentHp=TravelStat.currentHp+10 + ItemStat.BloodBag;
        }
    }

}

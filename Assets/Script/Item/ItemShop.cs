using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemShop : MonoBehaviour
{
    public string ItemName;
    public string ItemMap;
    public GameObject ItemUP;

    private void Update(){
        if(TravelStat.LandmarkNow==ItemMap&&!ItemStat.Item.Contains(ItemName)){
            ItemUP.SetActive(true);
        }else{
            ItemUP.SetActive(false);
        }
    }


    public void ItemBuy(){
        if(TravelStat.Gold>=250){
            TravelStat.Gold-=250;
            ItemStat.Item.Add(ItemName);
            ItemUP.SetActive(false);
        }
    }
}

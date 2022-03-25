using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeathBTN : MonoBehaviour
{
    public Text TextBTN;

    private void Update(){
        if(ItemStat.Item.Contains("3Revival")){
            TextBTN.text="Revive at "+TravelStat.LandmarkNow;
        }else{
            TextBTN.text="Back To Menu";
        }
    }

    public void ProgressDeath(){
        if(ItemStat.Item.Contains("3Revival")){
            ItemStat.Item.Remove("3Revival");
            if(TravelStat.LandmarkNow=="DemonCastle"){
                SceneManager.LoadScene("turnbase");
            }else{
                SceneManager.LoadScene("5Landmark");
            }
        }else{SceneManager.LoadScene("1Menu");}
    }
}

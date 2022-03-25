using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestInn : MonoBehaviour
{
    public Text TextRestInn;
    private void Update(){
        UpdateStat();
    }
    //displayText.text = (fillPercentage * 100).ToString("0.00") + "%";
    private void UpdateStat(){
        if(TravelStat.LandmarkNow=="Elywynn"){
            TravelStat.PriceInn=50;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="DragonVillage"){
            TravelStat.PriceInn=20;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="StormFront"){
            TravelStat.PriceInn=45;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="SandLand"){
            TravelStat.PriceInn=80;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="Crabonest"){
            TravelStat.PriceInn=30;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="DrownPort"){
            TravelStat.PriceInn=30;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else if(TravelStat.LandmarkNow=="Colossus"){
            TravelStat.PriceInn=45;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }else{
            TravelStat.PriceInn=20;
            TextRestInn.text="Rest at Inn ("+TravelStat.PriceInn+" Gold)";
        }
    }
    public void RestInnTime(){
        if(TravelStat.currentStamina<TravelStat.maxStamina&&TravelStat.Gold>=TravelStat.PriceInn){
            TravelStat.Gold-=TravelStat.PriceInn;
            TravelStat.currentStamina=TravelStat.maxStamina;
        }
    }
}

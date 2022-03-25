using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FullFillSupply : MonoBehaviour
{
    public Text TextFillPrice;
    private void Update(){
        UpdateStat();
    }
    //displayText.text = (fillPercentage * 100).ToString("0.00") + "%";
    private void UpdateStat(){
        if(TravelStat.LandmarkNow=="Elywynn"){
            TravelStat.PriceSupply=25;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="DragonVillage"){
            TravelStat.PriceSupply=30;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="StormFront"){
            TravelStat.PriceSupply=45;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="SandLand"){
            TravelStat.PriceSupply=100;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="Crabonest"){
            TravelStat.PriceSupply=25;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="DrownPort"){
            TravelStat.PriceSupply=35;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else if(TravelStat.LandmarkNow=="Colossus"){
            TravelStat.PriceSupply=40;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";
        }else{
            TravelStat.PriceSupply=20;
            TextFillPrice.text="Fill Supply ("+TravelStat.PriceSupply+" Gold)";;
        }
    }
    public void FullFillProgress(){
        if(TravelStat.currentSupply<TravelStat.MaxSupply&&TravelStat.Gold>=TravelStat.PriceSupply){
            TravelStat.Gold-=TravelStat.PriceSupply;
            TravelStat.currentSupply=TravelStat.MaxSupply;
        }
    }
}

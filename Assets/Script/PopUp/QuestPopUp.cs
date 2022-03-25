using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestPopUp : MonoBehaviour
{
    public GameObject ElyQ,DVQ,SFQ,SLQ,CNQ,DPQ,CollQ;
    public void QuestProgress(){
        if(TravelStat.LandmarkNow=="Elywynn"){
            ElyQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="DragonVillage"){
            DVQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="StormFront"){
            SFQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="SandLand"){
            SLQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="Crabonest"){
            CNQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="Downport"){
            DPQ.SetActive(true);
        }else if(TravelStat.LandmarkNow=="Colossus"){
            CollQ.SetActive(true);
        }
    }
}

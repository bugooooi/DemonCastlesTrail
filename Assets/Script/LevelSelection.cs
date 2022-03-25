using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private bool unlockedMap;
    [SerializeField] private bool unlockedLocaton;
    public Image unlockImageMap;
    public Image unlockImagePC;
    public string MapName;
    //private TravelStat TStat;
    private static string LandNow;
    public int DT;

    private void Update(){
        LandNow=TravelStat.LandmarkNow;
        UpdateMapImage();
        UpdatePCImage();
       
    }

    private void UpdateMapImage(){
        if(!TravelStat.LandmarkPre.Contains(MapName)){
            unlockImageMap.gameObject.SetActive(false);
        }else{
            unlockImageMap.gameObject.SetActive(true);
        }
    }

    private void UpdatePCImage(){
        if(MapName==LandNow){
            unlockImagePC.gameObject.SetActive(true);
        }else{
            unlockImagePC.gameObject.SetActive(false);
        }
    }


    public void PressSelection(string Landmark)
    {
        if(LandNow!=MapName&&TravelStat.LandmarkPre.Contains(MapName)==false)
        {
            if(LandNow=="Merinia"){
                if(MapName=="Elywynn"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="DragonVillage"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="Elywynn"){
                if(MapName=="DragonVillage"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="SandLand"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="DragonVillage"){
                if(MapName=="Elywynn"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="StormFront"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="SandLand"){
                if(MapName=="DragonVillage"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="StormFront"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="Crabonest"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="StormFront"){
                if(MapName=="SandLand"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }else if(MapName=="Crabonest"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="Crabonest"){
                if(MapName=="DrownPort"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="DrownPort"){
                if(MapName=="Colossus"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="Colossus"){
                if(MapName=="HellHound"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }else if(LandNow=="HellHound"){
                if(MapName=="DemonCastle"){
                    TravelStat.LandmarkPre.Add(LandNow);
                    TravelStat.LandmarkNow=MapName;
                    TravelStat.Distance=DT;
                    SceneManager.LoadScene(Landmark);
                }
            }
        }
    }

    
}

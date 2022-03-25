using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Monster_Explore : MonoBehaviour
{
    public string NowPage;
    /*public static List<string> DVEx = new List<string>();
    public static List<string> ELEx = new List<string>(); 
    public static List<string> SFEx = new List<string>(); 
    public static List<string> SLEx = new List<string>(); 
    public static List<string> CNEx = new List<string>(); */
    //public static List<string> DPEx = new List<string>("Rogue","Vampire Spawn","Vampire","Devil Army"); 
    //public static List<string> CollEx = new List<string>("Rogue","Devil Army"); 
    //public static List<string> HHEx = new List<string>("Rogue","Decil Army"); 
    /*void Start(){
        //DVEx
        TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");
        TravelStat.DVEx.Add("Rogue");TravelStat.DVEx.Add("Rogue");
        TravelStat.DVEx.Add("GDragon");TravelStat.DVEx.Add("BDragon");
        //ELEx
        TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");TravelStat.ELEx.Add("Rogue");
        TravelStat.ELEx.Add("Ork");TravelStat.ELEx.Add("Ork");
        TravelStat.ELEx.Add("Ork");TravelStat.ELEx.Add("Ork Boss");
        //SFEx
        TravelStat.SFEx.Add("Rogue");TravelStat.SFEx.Add("Rogue");TravelStat.SFEx.Add("Rogue");TravelStat.SFEx.Add("Rogue");TravelStat.SFEx.Add("Rogue");TravelStat.SFEx.Add("Devil Army");TravelStat.SFEx.Add("Devil Army");
        TravelStat.SFEx.Add("Devil Army");TravelStat.SFEx.Add("Devil Army");TravelStat.SFEx.Add("Ork");TravelStat.SFEx.Add("Ork");TravelStat.SFEx.Add("Ork");TravelStat.SFEx.Add("Rock King");
        //SLEx
        TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");TravelStat.SLEx.Add("Rogue");
        TravelStat.SLEx.Add("Sand Rogue");TravelStat.SLEx.Add("Sand Rogue");TravelStat.SLEx.Add("Sand Rogue");TravelStat.SLEx.Add("Sand Rogue");TravelStat.SLEx.Add("Worm");
        //CNEx
        TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");TravelStat.CNEx.Add("Rogue");
        TravelStat.CNEx.Add("Red");TravelStat.CNEx.Add("Red");TravelStat.CNEx.Add("Red");TravelStat.CNEx.Add("Blue");TravelStat.CNEx.Add("Blue");TravelStat.CNEx.Add("Blue");TravelStat.CNEx.Add("Devil Army");TravelStat.CNEx.Add("Devil Army");TravelStat.CNEx.Add("Devil Army");

    }  */

    string[] DVEx = new string[] {"Rogue","Rogue","Rogue","Rogue","Rogue","Rogue",
    "Rogue","Rogue","Rogue","Rogue","Rogue","Rogue","Rogue","Black Dragon","Green Dragon"};
    string[] ELEx = new string[] {"Rogue","Rogue","Rogue","Rogue","Rogue","Rogue",
    "Rogue","Rogue","Ork Boss","Ork","Ork","Ork","Ork","Ork","Ork","Ork","Ork","Ork"};
    string[] SFEx = new string[] {"Rogue","Rogue","Rogue","Rogue","Rogue","Rogue",
    "Rogue","Rogue","Devil Army","Devil Army","Devil Army","Devil Army","Devil Army"
    ,"Devil Army","Devil Army","Devil Army","Devil Army","Rock King"};
    string[] SLEx = new string[] {"Rogue","Rogue","Rogue","Rogue","Rogue","Rogue",
    "Rogue","Rogue","Sand Rogue","Sand Rogue","Sand Rogue","Sand Rogue","Sand Rogue","Sand Rogue",
    "Sand Rogue","Sand Rogue","Sand Rogue","Worm"};
    string[] DPEx = new string[] {"Rogue","Rogue","Rogue","Rogue","Rogue","Rogue",
    "Rogue","Rogue","Vampire Spawn","Vampire Spawn","Vampire Spawn","Vampire Spawn","Vampire Spawn","Vampire Spawn",
    "Vampire Spawn","Vampire Spawn","Vampire Spawn","Vampire Spawn","Vampire"};
    string[] HHEx = new string[] {"Devil Army"};
    System.Random random = new System.Random();
 
    public void Explore_btn(){
        //DV
        if(TravelStat.LandmarkNow=="DragonVillage"){
            if(!ItemStat.Item.Contains("2Fire")&&!ItemStat.Item.Contains("2Special")){
            int useDVEx = random.Next(DVEx.Length);
            string pickDVEx = DVEx[useDVEx];
            print(pickDVEx);
            if(pickDVEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Black Dragon"){
                Monster_System.Mon_Name="Black Dragon";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Green Dragon"){
                Monster_System.Mon_Name="Green Dragon";
                SceneManager.LoadScene("turnbase");
            }}
            if(!ItemStat.Item.Contains("2Fire")&&ItemStat.Item.Contains("2Special")){
            int useDVEx = random.Next(DVEx.Length);
            string pickDVEx = DVEx[useDVEx];
            print(pickDVEx);
            if(pickDVEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Black Dragon"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Green Dragon"){
                Monster_System.Mon_Name="Green Dragon";
                SceneManager.LoadScene("turnbase");
            }}
            if(!ItemStat.Item.Contains("2Special")&&ItemStat.Item.Contains("2Fire")){
            int useDVEx = random.Next(DVEx.Length);
            string pickDVEx = DVEx[useDVEx];
            print(pickDVEx);
            if(pickDVEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Black Dragon"){
                Monster_System.Mon_Name="Black Dragon";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Green Dragon"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            }if(ItemStat.Item.Contains("2Special")&&ItemStat.Item.Contains("2Fire")){
            int useDVEx = random.Next(DVEx.Length);
            string pickDVEx = DVEx[useDVEx];
            print(pickDVEx);
            if(pickDVEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Black Dragon"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDVEx=="Green Dragon"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }}
        }
        //EX
        if(TravelStat.LandmarkNow=="Elywynn"){
            if(!ItemStat.Item.Contains("3Revival")){
            int useELEx = random.Next(ELEx.Length);
            string pickELEx = ELEx[useELEx];
            print(pickELEx);
            if(pickELEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickELEx=="Ork"){
                Monster_System.Mon_Name="Ork";
                SceneManager.LoadScene("turnbase");
            }
            if(pickELEx=="Ork Boss"){
                Monster_System.Mon_Name="Ork Boss";
                SceneManager.LoadScene("turnbase");
            }
            }if(ItemStat.Item.Contains("3Revival")){
            int useELEx = random.Next(ELEx.Length);
            string pickELEx = ELEx[useELEx];
            print(pickELEx);
            if(pickELEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickELEx=="Ork"){
                Monster_System.Mon_Name="Ork";
                SceneManager.LoadScene("turnbase");
            }
            if(pickELEx=="Ork Boss"){
                Monster_System.Mon_Name="Ork Boss";
                SceneManager.LoadScene("turnbase");
            }
        }}


        //SF
        if(TravelStat.LandmarkNow=="StormFront"){
            if(!ItemStat.Item.Contains("4Sword")){
            int useSFEx = random.Next(SFEx.Length);
            string pickSFEx = SFEx[useSFEx];
            print(pickSFEx);
            if(pickSFEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEx=="Devil Army"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEx=="Rock King"){
                Monster_System.Mon_Name="Rock King";
                SceneManager.LoadScene("turnbase");
            }}if(ItemStat.Item.Contains("4Sword")){
            int useSFEx = random.Next(SFEx.Length);
            string pickSFEx = SFEx[useSFEx];
            print(pickSFEx);
            if(pickSFEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEx=="Devil Army"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEx=="Rock King"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }}

        }
        //SL
        if(TravelStat.LandmarkNow=="SandLand"){
            int useSLEx = random.Next(SLEx.Length);
            string pickSLEx = SLEx[useSLEx];
            print(pickSLEx);
            if(pickSLEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSLEx=="Sand Rogue"){
                Monster_System.Mon_Name="Sand Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSLEx=="Worm"){
                Monster_System.Mon_Name="Worm";
                SceneManager.LoadScene("turnbase");
            }
        }
        //DP
        if(TravelStat.LandmarkNow=="DrownPort"){
            
            int useDPEx = random.Next(DPEx.Length);
            string pickDPEx = SLEx[useDPEx];
            print(pickDPEx);
            if(!ItemStat.Item.Contains("6BloodDrink")&&!ItemStat.Item.Contains("6Sword")){
            if(pickDPEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire Spawn"){
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire"){
                Monster_System.Mon_Name="Vampire";
                SceneManager.LoadScene("turnbase");
            }}
            if(!ItemStat.Item.Contains("6BloodDrink")&&ItemStat.Item.Contains("6Sword")){
            if(pickDPEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire Spawn"){
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }}
            if(ItemStat.Item.Contains("6BloodDrink")&&ItemStat.Item.Contains("6Sword")){
            if(pickDPEx=="Rogue"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire Spawn"){
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEx=="Vampire"){
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }}

        }
        //HH
        if(TravelStat.LandmarkNow=="HellHound"){
            int useHHEx = random.Next(HHEx.Length);
            string pickHHEx = HHEx[useHHEx]; 
            print(pickHHEx);
            if(pickHHEx=="Devil Army"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
        }

        if(TravelStat.LandmarkNow=="Crabonest"){
            int useHHEx = random.Next(HHEx.Length);
            string pickHHEx = HHEx[useHHEx]; 
            print(pickHHEx);
            if(pickHHEx=="Devil Army"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
        }
        if(TravelStat.LandmarkNow=="Colossus"){
            int useHHEx = random.Next(HHEx.Length);
            string pickHHEx = HHEx[useHHEx]; 
            print(pickHHEx);
            if(pickHHEx=="Devil Army"){
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
        }

        if(TravelStat.currentSupply<TravelStat.MaxSupply){
            TravelStat.currentSupply+=10*ItemStat.DragonEx;
            if(TravelStat.currentSupply>TravelStat.MaxSupply){
                TravelStat.currentSupply=TravelStat.MaxSupply;
            }
        }
        TravelStat.BackFromAttack=NowPage;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemStat : MonoBehaviour
{
    //Item ถ้าชื่อไอเทมอยู่ในลิสต์ไอเทมจะขึ้นในหน้า Iventory
    public static List<string> Item = new List<string>(); 

    //Item พื้นฐาน**********************************************************

    public static int BasicDM=5;

    public static int SwordFire = 0;
    public static int ArmorFire = 0;
    public static int DragonEx = 1;

    public static int TwinSword = 0;
    public static int SupplyHealth = 0;//3
    public static int revive=0;
    public static int DevilSword = 0;

    public static int StoneArmor = 0;
    public static int StoneSword = 0;
    public static int IronArmor = 0;

    public static int HorseRun = 0;//10
    public static int BigSword = 0;
    public static int SeaArmor = 0;

    public static int Cross = 1;
    public static int BloodBag = 0;
    public static int BloodSword = 0;

    public static int Starve=0;//4

    public static int SaveSupply = 0; //เขียนแล้วบางอัน

    void Update(){
        Item_Func();
        
    }

    public void Item_Func(){
        //SwordFire
        if(Item.Contains("2Sword")==true){
            SwordFire=2;
        }
        //FireSkill
        if(Item.Contains("2Fire")==true){
            //ทำการเซ็ตในหน้า TurnBase
        }
        //Explore
        if(Item.Contains("2Explore")==true){
            DragonEx = 2;
        }
        //FireArmor
        if(Item.Contains("2Armor")==true){
            ArmorFire=10;
        }
        //Special
        if(Item.Contains("2Special")==true){
            //เสร็จแล้วแค่เอาเข้า Contains
        }
        //Twin
        if(Item.Contains("3Twin")==true){
            TwinSword=5;
        }
        //HealtRun
        if(Item.Contains("3HealtRun")==true){
            //เสร็จแล้วแค่เอาเข้า Contains
            //รอพี่ตูน
        }
        //HealtSup
        if(Item.Contains("3HealtSup")==true){
            SupplyHealth=3;
        }
        //Revial
        if(Item.Contains("3Revival")==true){
            //เสร็จแล้วแค่เอาเข้า Contains
        }
        //DevilSword
        if(Item.Contains("3DevilSword")==true){
            DevilSword=10;
        }
        //StoneArmor
        if(Item.Contains("4Armor")==true){
            StoneArmor=1;
        }
        //Protection
        if(Item.Contains("4Protect")==true){
            //เสร็จแล้วแค่เอาเข้า Contains
            //รอพี่ตูน
        }
        //IronArmor
        if(Item.Contains("4IronArmor")==true){
            IronArmor=10;
        }
        //StoneSword
        if(Item.Contains("4Sword")==true){
            StoneSword=2;
        }
        //StoneSword
        if(Item.Contains("4Sword")==true){
            StoneSword=2;
        }
        //Finished
        if(Item.Contains("4Finished")==true){
            //ทำการเซ็ตในหน้า TurnBase
        }
        //SaveSup
        if(Item.Contains("5ReduceSup")==true){
            SaveSupply=5;
        }
        //ReduceSta
        if(Item.Contains("5ReduceSta")==true){
            Starve=4;
        }
        //HorseRun
        if(Item.Contains("5HorseRun")==true){
            HorseRun=10;
        }
        //SeaArmor
        if(Item.Contains("5Armor")==true){
            SeaArmor=5;
        }
        //SeaSword
        if(Item.Contains("5Sword")==true){
            BigSword=2;
        }
        //Cross
        if(Item.Contains("6Cross")==true){
            Cross=1;
        }
        //BloodRitual
        if(Item.Contains("6BloodRitual")==true){
            //ทำการเซ็ตในหน้า TurnBase
        }
        //RedHorse
        if(Item.Contains("6RedHorse")==true){
            //รอพี่ตูน
        }
        //BloodSword
        if(Item.Contains("6Sword")==true){
            BloodSword=1;
        }
        //BloodDrink
        if(Item.Contains("6BloodDrink")==true){
            BloodBag=10;
        }
        
    }

  
}

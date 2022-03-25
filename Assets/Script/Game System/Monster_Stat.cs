using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Monster_Stat : MonoBehaviour
{
    public Text Mon_Title,Mon_HP,Mon_CarrHP,Player_HP,Player_STA;
    private void Start(){
        Mons_Stat();
    }
    private void Update(){
        Player_HP.text = "Health Point : "+TravelStat.currentHp+" / "+TravelStat.maxHp;
        Player_STA.text = "STAMINA : "+TravelStat.currentStamina;
        Mon_CarrHP.text = Monster_System.Mon_Healt.ToString();
    }

    private void Mons_Stat(){
        if(Monster_System.Mon_Name=="Black Dragon"){
            Mon_Title.text="มังกรดำ";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,20)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 25";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=50;
        }else if(Monster_System.Mon_Name=="Blue"){
            Mon_Title.text="ทหารฝ่ายฟ้า";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,30);
        }else if(Monster_System.Mon_Name=="Blue Boss"){
            Mon_Title.text="หัวหน้าฝ่ายฟ้า";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,30);
        }else if(Monster_System.Mon_Name=="Red Boss"){
            Mon_Title.text="หัวหน้าฝ่ายแดง";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,30);
        }else if(Monster_System.Mon_Name=="Champ1"){
            Mon_Title.text="ผู้ท้าชิงคนที่1";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=10;
        }else if(Monster_System.Mon_Name=="Champ2"){
            Mon_Title.text="ผู้ท้าชิงคนที่2";
            Monster_System.Mon_Healt=20;
            Monster_System.Mon_Damage=Random.Range(8,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 20";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=20;
        }else if(Monster_System.Mon_Name=="Champ3"){
            Mon_Title.text="ผู้ท้าชิงคนที่3";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(8,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 25";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=30;
        }else if(Monster_System.Mon_Name=="Champ4"){
            Mon_Title.text="ผู้ท้าชิงคนที่4";
            Monster_System.Mon_Healt=30;
            Monster_System.Mon_Damage=Random.Range(8,20)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 30";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=50;
        }else if(Monster_System.Mon_Name=="Devil Army"){
            Mon_Title.text="ทหารจอมมาร";
            Monster_System.Mon_Healt=20;
            Monster_System.Mon_Damage=Random.Range(5,13)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 20";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(20,50);
        }else if(Monster_System.Mon_Name=="Ork King"){
            Mon_Title.text="ราชาออร์ค";
            Monster_System.Mon_Healt=20;
            Monster_System.Mon_Damage=Random.Range(5,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 20";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(20,50);
        }else if(Monster_System.Mon_Name=="Ork"){
            Mon_Title.text="ออร์ค";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(5,12)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,30);
        }else if(Monster_System.Mon_Name=="Red Dragon"){
            Mon_Title.text="มังกรแดง";
            Monster_System.Mon_Healt=20;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 20";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(20,50);
        }else if(Monster_System.Mon_Name=="Green Dragon"){
            Mon_Title.text="มังกรเขียว";
            Monster_System.Mon_Healt=20;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 20";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(20,50);
        }else if(Monster_System.Mon_Name=="Red"){
            Mon_Title.text="ทหารฝ่ายแดง";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,30);
        }else if(Monster_System.Mon_Name=="Rock King"){
            Mon_Title.text="นายพลหินผา";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 25";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=50;
        }else if(Monster_System.Mon_Name=="Rogue"){
            Mon_Title.text="โจร";
            Monster_System.Mon_Healt=10;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 10";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(10,15);
        }else if(Monster_System.Mon_Name=="Sand Rogue"){
            Mon_Title.text="โจรทะเลทราย";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(2,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,20);
        }else if(Monster_System.Mon_Name=="Vampire"){
            Mon_Title.text="แวมไพร์";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,20)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 25";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=50;
        }else if(Monster_System.Mon_Name=="Vampire Spawn"){
            Mon_Title.text="สมุนแวมไพร์";
            Monster_System.Mon_Healt=15;
            Monster_System.Mon_Damage=Random.Range(5,10)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 15";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=Random.Range(15,20);
        }else if(Monster_System.Mon_Name=="Worm"){
            Mon_Title.text="หนอนยักษ์";
            Monster_System.Mon_Healt=25;
            Monster_System.Mon_Damage=Random.Range(5,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 25";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=50;
        }else if(Monster_System.Mon_Name=="Boss1"){
            Mon_Title.text="ราชาปีศาจ";
            Monster_System.Mon_Healt=100;
            Monster_System.Mon_Damage=Random.Range(10,15)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 100";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=0;
        }else if(Monster_System.Mon_Name=="Boss2"){
            Mon_Title.text="ราชาปีศาจเอาจริง";
            Monster_System.Mon_Healt=150;
            Monster_System.Mon_Damage=Random.Range(15,20)-ItemStat.StoneArmor-ItemStat.Cross;
            Mon_HP.text="Maximum Health Point : 150";
            //Mon_CarrHP.text=Monster_System.Mon_Healt.ToString();
            Monster_System.Mon_Gold=0;
        }


    }
    
}

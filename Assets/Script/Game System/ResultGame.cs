using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultGame : MonoBehaviour
{
    string[] Fifty = new string[] {"0","1"};
    System.Random random = new System.Random();

    private void Update(){
        Result();
    }
    private void Result(){
        int useFifty = random.Next(Fifty.Length);
        string pickFifty = Fifty[useFifty];

        if(TravelStat.currentHp<=0){
            SceneManager.LoadScene("8Death");
        }else if(Monster_System.Mon_Healt<=0){
            TravelStat.Gold+=Monster_System.Mon_Gold;

            if(TravelStat.QAName=="4Ely"){
                ItemStat.Item.Add("3HealtRun");
            }
            if(TravelStat.QAName=="4DV"){
                ItemStat.Item.Add("2Sword");
            }
            if(TravelStat.QAName=="3SL"){
                ItemStat.Item.Add("5ReduceSup");
            }
            if(TravelStat.QAName=="3CN"){
                ItemStat.Item.Add("5Sword");
            }
            if(TravelStat.QAName=="4CN"){
                ItemStat.Item.Add("5Armor");
            }
            if(TravelStat.QAName=="2DP"){
                ItemStat.Item.Add("6Cross");
            }
            if(TravelStat.QAName=="3Coll"){
                ItemStat.Item.Add("4IronArmor");
            }
            if(TravelStat.QAName=="4Coll"){
                ItemStat.Item.Add("4Finished");
            }
            if(Monster_System.Mon_Name=="Black Dragon"){
                ItemStat.Item.Add("2Special");
            }
            if(Monster_System.Mon_Name=="Green Dragon"){
                if(pickFifty=="1"){
                    if(!ItemStat.Item.Contains("2Fire")){
                        ItemStat.Item.Add("2Fire");
                    }
                }
            }
            if(Monster_System.Mon_Name=="Ork Boss"){
                ItemStat.Item.Add("3Revival");
            }
            if(Monster_System.Mon_Name=="Rock King"){
                ItemStat.Item.Add("4Sword");
            }
            if(Monster_System.Mon_Name=="Vampire Spawn"){
                if(pickFifty=="1"){
                    if(!ItemStat.Item.Contains("6BloodDrink")){
                        ItemStat.Item.Add("6BloodDrink");
                    }
                }
            }
            if(Monster_System.Mon_Name=="Vampire"){
                ItemStat.Item.Add("6Sword");
            }

            if(Monster_System.Mon_Name=="Boss1"){
                Demon_Dialogue.Demon_d=9;
                SceneManager.LoadScene("IntroBoss");
            }
            if(Monster_System.Mon_Name=="Boss1"){
                Demon_Dialogue.Demon_d=11;
                SceneManager.LoadScene("IntroBoss");
            }

            TravelStat.QAName="0";
            SceneManager.LoadScene(TravelStat.BackFromAttack);
        }
    }
}

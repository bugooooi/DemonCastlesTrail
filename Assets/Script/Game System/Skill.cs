using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skill : MonoBehaviour
{
    public Image Fire_Skill;
    public Image Blood_Skill;
    public Image Finished_Skill;
    //public string Skill_Name;

    private void Update(){
        UpdateSkill();
    }

    private void UpdateSkill(){
        if(!ItemStat.Item.Contains("2Fire")){
            Fire_Skill.gameObject.SetActive(false);
        }else{
            Fire_Skill.gameObject.SetActive(true);
        }
        if(!ItemStat.Item.Contains("6BloodDrink")){
            Blood_Skill.gameObject.SetActive(false);
        }else{
            Blood_Skill.gameObject.SetActive(true);
        }
        if(!ItemStat.Item.Contains("4Finished")){
            Finished_Skill.gameObject.SetActive(false);
        }else{
            Finished_Skill.gameObject.SetActive(true);
        }
    }

    /*public void ClickForSkill(){

        if(Skill_Name=="Fire"&&TravelStat.currentStamina>=10){

        }

    }*/
}

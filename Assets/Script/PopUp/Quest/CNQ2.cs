using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CNQ2 : MonoBehaviour
{
    public string QName;
    public GameObject Choosen;

    public void PassQuestProgress(){
        if(QName=="RED"){
            TravelStat.QuestUnlock.Add("3CN");
            Choosen.SetActive(false);
        }else if(QName=="BLUE"){
            TravelStat.QuestUnlock.Add("4CN");
            Choosen.SetActive(false);
        }
    }
}

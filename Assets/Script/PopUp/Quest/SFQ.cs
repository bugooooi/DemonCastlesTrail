using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SFQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1SF");
        PassImage();
        UnlockImage();
    }

    private void PassImage(){
        if(TravelStat.QuestPass.Contains(QName)==true){
            IPass.gameObject.SetActive(true);
        }else{
            IPass.gameObject.SetActive(false);
        }
    }

    private void UnlockImage(){
        if(TravelStat.QuestUnlock.Contains(QName)==false){
            ILock.gameObject.SetActive(true);
        }else{
            ILock.gameObject.SetActive(false);
        }
    }

    public void PassQuestProgress(){
        if(TravelStat.QuestPass.Contains(QName)==false&&TravelStat.QuestUnlock.Contains(QName)==true){
            if(QName=="1SF"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1SF";
                QTitle.text="Raid Of The Stone";
                QStory.text="คุณอยู่ในเมือง Stormfront ในขณะที่ถูกบุกโดยทหารของจามมาร";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2SF");
            }else if(QName=="2SF"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2SF";
                QTitle.text="Quest From The Stone";
                QStory.text="คุณได้รับหน้าที่ในการปกป้องเมืองนี้จากศัตรูที่เข้ามาอย่างไม่หยุดยั้ง";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("3SF");
            }else if(QName=="3SF"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3SF";
                QTitle.text="The Stone Wall";
                QStory.text="คุณต้องปกป้อง Stormfront จากศัตรู";
                //TravelStat.QuestPass.Add(QName);
            }
        }
    }

    public void LevelUpProgress(){
        TravelStat.levelnow+=1;
        TravelStat.maxHp+=5;
        TravelStat.maxStamina+=5;
        TravelStat.currentHp=TravelStat.maxHp;
    }
}

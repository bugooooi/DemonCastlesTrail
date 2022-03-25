using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SLQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1SL");
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
            if(QName=="1SL"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1SL";
                QTitle.text="The Death City";
                QStory.text="คุณถูกโจมตีอย่างไม่ทันตั้งตัวโดยโจรทะเลทราย";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2SL");
            }else if(QName=="2SL"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2SL";
                QTitle.text="The Death Water";
                QStory.text="พวกโจรทะเลทรายขโมยอาหารของคุณ คุณจึงทำการต่อสู้เพื่อนำอาหารที่ถูกขโมยไปกลับมา";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("3SL");
            }else if(QName=="3SL"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3SL";
                QTitle.text="The Death Worm";
                QStory.text="คุณถูกไล่ตามโดยหนอนทะเลทรายยักษ์ ทางหนีของคุณถูกขวางโดยโจรทะเลทราย";
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

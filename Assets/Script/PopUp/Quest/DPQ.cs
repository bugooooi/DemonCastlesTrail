using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DPQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1DL");
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
            if(QName=="1DP"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1DP";
                QTitle.text="Blood Eater";
                QStory.text="คุณเผชิญหน้ากับปีศาจในเมืองแห่งนี้สมุนแวมไพร์";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2DL");
            }else if(QName=="2DP"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2DP";
                QTitle.text="Blood Slayer";
                QStory.text="หลังจากคุณจัดการสมุนแวมไพร์จนถึงปราสาทแห่งหนึ่ง และได้เผชิญหน้ากับหัวหน้าของพวกมันน";
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

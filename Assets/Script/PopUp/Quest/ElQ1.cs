using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ElQ1 : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1Ely");
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
            if(QName=="1Ely"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1Ely";
                QTitle.text="Welcome To The Forest";
                QStory.text="คุณเดินทางมาถึงเมือง Elywynn เมืองโบราณในป่าลึกของเหล่าเอลฟ์ เมืองที่สงบสุขแต่ไม่ได้สงบอย่างที่คิด Elywynn พบเจอกับปัญหาออร์คก่อกวน ตอนนี้คุณพบออร์คตัวหนึ่งกำลังทำร้ายชาวเมือง Elywynn ";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2Ely");
            }else if(QName=="2Ely"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2Ely";
                QTitle.text="Protect The Forest";
                QStory.text="กองทัพออร์คบุกเมือง Elywynn คุณต้องปกป้องเมืองนี้ไว้ให้ได้";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("3Ely");
            }else if(QName=="3Ely"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3Ely";
                QTitle.text="The Changeling In The Forest";
                QStory.text="ชาวบ้านในเมือง Elywynn ขอให้คุณออกตามหาภูติในตำนานเพื่อช่วยพวกเขา แต่คุณเจอเข้ากับออร์คในป่า";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("4Ely");
            }else if(QName=="4Ely"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="4Ely";
                QTitle.text="Thank You From The Forest";
                QStory.text="คุณจัดการกับออร์คที่อยู่รอบๆเมือง Elywynn";
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

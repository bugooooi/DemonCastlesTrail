using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1Coll");
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
            if(QName=="1Coll"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1Coll";
                QTitle.text="The First Champion";
                QStory.text="ผู้เข้าท้าชิงคนแรก คืออดีตโจรผู้ชำนาญการ";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2Ely");
            }else if(QName=="2Coll"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2Coll";
                QTitle.text="The Second Champion";
                QStory.text="ผู้เข้าท้าชิงคนที่สอง คืออดีตโจรอีกคนที่ชำนาญการหมือนคนแรกแต่เก่งกว่า";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("3Ely");
            }else if(QName=="3Coll"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3Coll";
                QTitle.text="The Third Champion";
                QStory.text="ผู้ท้าชิงคนที่สาม นักรบผู้เก่งกาจที่มาพร้อมกับดาบคู่ของเขา";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("4Ely");
            }else if(QName=="4Coll"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="4Coll";
                QTitle.text="The Fourth Champion";
                QStory.text="ผู้ท้าชิงคนสุดท้ายสุดยอดผู้ยอดเยี่ยมที่สุดในสนามประลองนี้";
                //TravelStat.QuestPass.Add(QName);
            }
        }
    }
}

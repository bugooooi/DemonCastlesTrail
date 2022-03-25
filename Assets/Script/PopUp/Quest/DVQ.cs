using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DVQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1DV");
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
        //Qpass   1DV
        //QUnlock 1DV
        if(TravelStat.QuestPass.Contains(QName)==false&&TravelStat.QuestUnlock.Contains(QName)==true){
            if(QName=="1DV"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1DV";
                QTitle.text="The Fire Village";
                QStory.text="คุณถูกไล่ตามโดยมังกรยักษ์ที่กำลังบินอยู่เหนือหัวคุณ คุณจึงต้องเผชิญหน้ากับมัน";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2DV");
            }else if(QName=="2DV"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2DV";
                QTitle.text="The Fire Story";
                QStory.text="ปกป้องหมู่บ้านจากโจรป่าที่บุกเข้ามา";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("3DV");
            }else if(QName=="3DV"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3DV";
                QTitle.text="The Fire Cave";
                QStory.text="จัดการกลุ่มโจรที่อยู่ในป่าเพื่อขับไล่ให้มันไปไกลๆจากหมู่บ้าน";
               // TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("4DV");
            }else if(QName=="4DV"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="4DV";
                QTitle.text="The Fire Slayer";
                QStory.text="สังหารมังกรแดงที่รุกรานหมู่บ้านตลอดหลายร้อยปี";
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

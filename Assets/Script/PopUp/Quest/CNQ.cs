using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CNQ : MonoBehaviour
{
    [SerializeField] private bool unlockQ;
    [SerializeField] private bool unlockPass;
    public Image IPass,ILock;
    public string QName;
    public GameObject Choosen;
    public GameObject Q_Pop;
    public Text QTitle;
    public Text QStory;

    private void Update(){
        TravelStat.QuestUnlock.Add("1CN");
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
            if(QName=="1CN"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="1CN";
                QTitle.text="The Fish Ocean";
                QStory.text="คุณมาถึงเมืองประมง Crabonest และได้พบการต้อนรับแบบคาดไม่ถึงโดยชาวเมืองที่ใส่เสื้อสีฟ้า บอกว่าคุณเป็นพวกสีแดง";
                //TravelStat.QuestPass.Add(QName);
                //TravelStat.QuestUnlock.Add("2CN");
            }else if(QName=="2CN"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="2CN";
                QTitle.text="The Ocean War";
                QStory.text="คุณเข้าร่วมสงครามกลางเมืองแบบไม่ทันตั้งตัว และได้ค้นพบว่าไม่มีฝ่ายไหนที่ดีเลย คุณจึงจะทำการกำจัดหัวหน้าทั้งสองฝ่าย";
                //TravelStat.QuestPass.Add(QName);
                Choosen.SetActive(true);
            }else if(QName=="3CN"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="3CN";
                QTitle.text="The Red Sea";
                QStory.text="คุณเผชิญหน้ากับหัวหน้าฝ่ายแดง";
                //TravelStat.QuestPass.Add(QName);
            }else if(QName=="4CN"){
                Q_Pop.SetActive(true);
                TravelStat.QAName="4CN";
                QTitle.text="The Blue Sea";
                QStory.text="คุณเผชิญหน้ากับหัวหน้าฝ่ายสีฟ้า";
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

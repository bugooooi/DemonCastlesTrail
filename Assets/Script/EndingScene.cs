using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public static int End_d=1;
    public Text E_text;
    public Text B_text;

    public void NextDialogue(){
        End_d+=1;
        if (End_d==1){
            E_text.text="มีตำนานเล่าขานถึงผู้กล้า ผู้ที่เดินทางไปในเส้นทางอันยากลำบาก";    
        }else if(End_d==2){
            E_text.text="โดยมีเป้าหมายเพื่อปกป้องโลกใบนี้จากจอมมารปีศาจ";
        }else if(End_d==3){
            E_text.text="แต่เขาไม่ได้เพียงแต่ปราบจอมมารแต่ยังสร้างผลกระทบต่อหมู่บ้านมากมายที่เขาผ่านทางไป";
        }else if(End_d==4){
            if(TravelStat.QuestPass.Contains("4Ely")){
                E_text.text="เขาได้ช่วยหมู่บ้านของเอลฟ์ในป่าจากการรุกรานของออร์คผู้ชั่วช้า";
            }else{E_text.text="เขาเมินเฉยต่อการรุกรานของออร์คที่ชั่วช้าทำให้หมูบ้านเอลฟ์ในป่าเหลือแต่เพียงตำนาน";}
        }else if(End_d==5){
            if(TravelStat.QuestPass.Contains("4DV")){
                E_text.text="เขาได้ปราบมังกรไฟเพื่อช่วยเหลือผู้คนในเมือง";
            }else{E_text.text="เมืองที่ครั้งหนึ่งเคยรุ่งเรืองตอนนี้เหลือเพียงแต่ขี้เถ้าจากมังกรไฟ";}
        }else if(End_d==6){
            if(TravelStat.QuestPass.Contains("3SF")){
                E_text.text="เขาเป็นป้อมปราการเพื่อปกป้องเมือง StormFront จากกองทัพของจอมมารและช่วยเหลือทหารจำนวนมาก";
            }else{E_text.text="เขาสามารถปราบจอมมารได้แต่เมือง StormFront ถูกตีแตกและเสียทหารไปเป็นจำนวนมากจากสงคราม";}
        }else if(End_d==7){
            E_text.text="เขาเอาชีวิตรอดผ่านทะเลทรายอันโหดร้าย";
        }else if(End_d==8){
            if(TravelStat.QuestPass.Contains("4CN")){
                E_text.text="เขาเข้าไปมีส่วนร่วมในสงครามกลางเมืองทำให้เมือง Crabonest ได้รับความสงบกลับคืนมา";
            }else{E_text.text="เขาเมินเฉยต่อสงครามที่เกิดขึ้นในเมือง Crabonest สงครามในเมืองนั้นยืดยาวมาจนถึงทุกวันนี้";}
        }else if(End_d==9){
            if(TravelStat.QuestPass.Contains("2DP")){
                E_text.text="เขาปราบแวมไพร์ที่ปกครองคนในเมือง DrownPort";
            }else{E_text.text="เมือง DrownPort กลายเป็นที่อยู่อาศัยของเหล่าผีดูดเลือดที่ไม่มีใครกล้าเข้าไป";}
        }
        else if(End_d==10){
            if(TravelStat.QuestPass.Contains("4Coll")){
                E_text.text="เขาเป็นแชมป์เปียนผู้ยิ่งใหญ่แห่ง The Colossus";
            }else{E_text.text="ความเก่งของเขาถูกดูถูกโดยผู้คนใน The Colossus เนื่องจากเขาไม่สามารถเอาชนะสุดยอมแชมป์เปียนได้";}
        }else if(End_d==11){
            E_text.text="และแน่นอนเขาสามารถเอาชนะจอมมารได้";
            B_text.text="The End";
        }else if(End_d==12){
            SceneManager.LoadScene("1Menu");
        }


    }
}

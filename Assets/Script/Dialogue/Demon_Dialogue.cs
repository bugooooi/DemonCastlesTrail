using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Demon_Dialogue : MonoBehaviour
{
    [SerializeField] private AudioSource click;
    public static int Demon_d=1;
    public Text D_text;

    public void NextDialogue(){
        Demon_d+=1;
        click.Play();
        if (Demon_d==1){
            D_text.text="ในที่สุดท่านก็มาถึงท่านผู้กล้า เป็นเกียรติอย่างยิ่งที่ในที่สุดก็ได้พบกับท่าน ตัวจริงเสียงจริง";    
        }else if(Demon_d==2){
            D_text.text="ข้าต้องยอมรับข้าไม่คาดคิดว่าท่านจะมาถึงที่นี่ได้ การเดินทางของท่านคงเหนื่อยมากแต่เดี๋ยวท่านก็ได้พักผ่อนยาวๆแล้ว";
        }else if(Demon_d==3){
            D_text.text="ใช้เวลาไม่นานท่านก็คงจะทำให้ทุกคนทั้งอาณาจักรได้ 'ผิดหวัง'";
        }else if(Demon_d==4){
            if(!TravelStat.LandmarkPre.Contains("2Special")){
                Monster_System.Mon_Name="Boss1";
                SceneManager.LoadScene("turnbase");
            }else{
                D_text.text="ไม่จริงน่า นี่แก แกมีมันได้ยังไง แกเอามันมาได้ยังไง";
            }
        }else if(Demon_d==5){
            D_text.text="หัวใจของมังกรดำ ข้าคงประมาทแกไม่ได้แล้วสินะ เพราะงั้นจัดเต็มเลยแล้วกัน";
        }else if(Demon_d==6){
            D_text.text="[ราชาปีศาจแปลงกลายเป็นอสูรกายขนาดยักษ์]";
        }else if(Demon_d==7){
            D_text.text="[ผู้กล้ารู้สึกร้อนที่อกจากนั้นเขาก็กลายร่างเป็นมังกรดำ]";
        }else if(Demon_d==8){
            Monster_System.Mon_Name="Boss2";
            SceneManager.LoadScene("turnbase");
        }
        else if(Demon_d==9){
            D_text.text="เจ้าทำได้ดีกว่าที่ข้าคิดไว้มากเจ้าผู้กล้า";
        }else if(Demon_d==10){
            D_text.text="มาเอาจริงกันเลยดีกว่า";
        }else if(Demon_d==10){
            Monster_System.Mon_Name="Boss2";
            SceneManager.LoadScene("turnbase");
        }
        else if(Demon_d==11){
            D_text.text="[ผู้กล้าใช้ดาบแทงไปที่หัวใจของจอมมารร่างของจอมมารสลายไป]";
        }else if(Demon_d==12){
            D_text.text="[ผู้กล้าใช้ดาบแทงไปที่หัวใจของจอมมารร่างของเขาสลายไป]";
        }else if(Demon_d==13){
            SceneManager.LoadScene("9Ending");
        }


    }
}

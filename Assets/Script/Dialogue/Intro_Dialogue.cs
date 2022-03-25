using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro_Dialogue : MonoBehaviour
{
    [SerializeField] private AudioSource click;
    public int King_d=1;
    public Text D_text;

    public void NextDialogue(){
        King_d+=1;
        click.Play();
        if(King_d==1){
            D_text.text="ท่านคือผู้ถูกเลือก อนาคตของอาณาจักรขึ้นอยู่กับท่าน ท่านต้องเดินทางไปที่ปราสาทจอมมารและกำจัดจอมมาร เพื่อช่วยโลกใบนี้ไว้";    
        }else if(King_d==2){
            D_text.text="ก่อนออกเดินทางข้ามีคำแนะนำจะมอบให้แก่ท่าน การเดินทางของท่านจะไม่ง่าย ท่านจะเจออุปสรรคมากมายระหว่างเดินทาง";
        }else if(King_d==3){
            D_text.text="การเดินทางไปปราสาทจอมมารท่านจะผ่านเมืองมากมาย แต่ก่อนที่จะถึงเมืองท่านจำเป็นต้องใช้พลังงาน (Stamina) เป็นอย่างมาก";
        }else if(King_d==4){
            D_text.text="หากท่านใช้ Stamina จนหมดจะทำให้ท่านเสียพลังชีวิต (Health Point:HP) ถ้าหาก HP ของท่านหมดท่านจะตาย";
        }else if(King_d==5){
            D_text.text="ท่านสามารถตั้ง Camp ระหว่างเดินทางเพื่อเพิ่ม Stamina ได้ โดยท่านจะต้องใช้ทรัพยากร (Supply)ในการฟื้นฟู Stamina";
        }else if(King_d==6){
            D_text.text="ท่านสามารถทำการสำรวจ (Explore) เพื่อเพิ่ม Supply ระหว่างเดินทางได้ เพราะถ้า Stamina และ Supply ของท่านหมดนั้นคงแย่มาก เมื่อท่านถึงเมืองท่านสามารถใช้เงินเพื่อพักผ่อนแบบไม่ใช้ Supply ในโรงเตี้ยม (Inn) ได้";
        }else if(King_d==7){
            D_text.text="และร้านค้า (Shop) ท่านสามารถเติมSupply หรือ HP หรือแม้แต่ซื้อ Item ใน Shop ได้ บางทีท่านอาจจะไม่อยากพลาดมัน";
        }else if(King_d==8){
            D_text.text="Item คือสิ่งที่จะมาทำให้การเดินทางของท่านสะดวกขึ้น บางชิ้นเพิ่มพลังของท่าน บางชิ้นทำให้การเดินทางของท่านเร็วขึ้น";
        }else if(King_d==9){
            D_text.text="และภารกิจ (Quest) ในแต่ละเมืองจะมีเรื่องราวให้ท่านเผชิญท่านอาจได้สิ่งตอบแทนแบบคาดไม่ถึง เพราะงั้นการช่วยชาวบ้านก็คงเป็นหน้าที่ของผู้ถูกเลือกเช่นท่าน";
        }else if(King_d==10){
            D_text.text="นั่นเป็นทั้งหมดที่ข้าจะแนะนำท่านได้ ขอให้ท่านโชตดีท่านผู้กล้า";
        }else if(King_d==11){
            SceneManager.LoadScene("3Map");
        }
    }

}

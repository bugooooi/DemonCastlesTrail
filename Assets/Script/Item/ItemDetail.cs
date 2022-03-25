using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemDetail : MonoBehaviour
{
    public string ItemName;
    public Text Item_Title;
    public Text Item_info;
    public Image UnlockItem;

    private void Start(){
        UpdateItem();
    }

    private void UpdateItem(){
        if(!ItemStat.Item.Contains(ItemName)){
            UnlockItem.gameObject.SetActive(false);
        }else{
            UnlockItem.gameObject.SetActive(true);
        }
    }

    public void Selectitem(){
        TravelStat.Item_Name=ItemName;
        

        if(TravelStat.Item_Name=="1Armor"){
            Item_Title.text="เกราะผู้กล้า";
            Item_info.text="มีพลังชีวิต 100 หน่วย";
        }else if(TravelStat.Item_Name=="1Sword"){
            Item_Title.text="ดาบผู้กล้า";
            Item_info.text="สร้างความเสียหายให้ศัตรู 5-15 หน่วย";
        }else if(TravelStat.Item_Name=="1Map"){
            Item_Title.text="แผนที่เดินทาง";
            Item_info.text="เส้นทางสู้ปราสาทจอมมาร";
        }else if(TravelStat.Item_Name=="1Bag"){
            Item_Title.text="กระเป๋าผู้กล้า";
            Item_info.text="เก็บไอเทมระหว่างเดินทาง";
        }else if(TravelStat.Item_Name=="1Horse"){
            Item_Title.text="ม้าผู้กล้า";
            Item_info.text="ใช้ในการเดินทางไปปราสาทจอมมาร";
        }else if(TravelStat.Item_Name=="2Sword"){
            Item_Title.text="ดาบเพลิง";
            Item_info.text="สร้างความเสียหายให้ศัตรูเพิ่ม +2 หน่วย";
        }else if(TravelStat.Item_Name=="2Fire"){
            Item_Title.text="ไฟมังกร";
            Item_info.text="สกิลสร้างความเสียหาย 10 หน่วย ใช้ 10 Stamina";
        }else if(TravelStat.Item_Name=="2Explore"){
            Item_Title.text="ดวงตามังกร";
            Item_info.text="ได้รับ Supply เพิ่มขึ้นสองเท่า";
        }else if(TravelStat.Item_Name=="2Armor"){
            Item_Title.text="เกราะเกล็ดมังกร";
            Item_info.text="เพิ่มพลังชีวิตสูงสุด 10 หน่วย";
        }else if(TravelStat.Item_Name=="2Special"){
            Item_Title.text="หัวใจมังกร";
            Item_info.text="ความลับ";
        }else if(TravelStat.Item_Name=="3Twin"){
            Item_Title.text="ดาบแฝด";
            Item_info.text="โจมตีสองครั้งโดยครั้งที่สองสร้างความเสียหายน้อยกว่าครั้งแรกครึ่งหนึ่ง";
        }else if(TravelStat.Item_Name=="3HealtRun"){
            Item_Title.text="ไอเทมฟื้นฟู";
            Item_info.text="มีเหตุการณ์พิเศษที่เพิ่มพลังชีวิตระหว่างการเดินทาง";
        }else if(TravelStat.Item_Name=="3HealtSup"){
            Item_Title.text="อาหารฟื้นฟูพลัง";
            Item_info.text="ทุกครั้งที่ใช้ Supply เพิ่มพลังชีวิต 3 หน่วย";
        }else if(TravelStat.Item_Name=="3Revival"){
            Item_Title.text="ฟื้นคืนชีพ";
            Item_info.text="สามารถเกิดใหม่ได้ 1 ครั้ง พร้อมพลังชีวิต 25 หน่วย";
        }else if(TravelStat.Item_Name=="3DevilSword"){
            Item_Title.text="ดาบปีศาจ";
            Item_info.text="สร้างความเสียหายให้ศัตรูเพิ่ม +10 หน่วย";
        }
        else if(TravelStat.Item_Name=="4Armor"){
            Item_Title.text="เกราะหิน";
            Item_info.text="ป้องกันความเสียหายที่ได้จากศัตรู -1 หน่วย";
        }else if(TravelStat.Item_Name=="4Protect"){
            Item_Title.text="โล่ป้องกัน";
            Item_info.text="ไม่มีโอกาสจะเจอกับโจรปล้นสะดมในระหว่างการเดินทาง";
        }else if(TravelStat.Item_Name=="4IronArmor"){
            Item_Title.text="เกราะแชมเปียน";
            Item_info.text="เพิ่มพลังชีวิตสูงสุด 10 หน่วย";
        }else if(TravelStat.Item_Name=="4Sword"){
            Item_Title.text="ดาบหิน";
            Item_info.text="สร้างความเสียหายให้ศัตรูเพิ่ม +2 หน่วย";
        }else if(TravelStat.Item_Name=="4Finished"){
            Item_Title.text="ท่าไม้ตาย";
            Item_info.text="สร้างความเสียหายให้ศัตรู 100 หน่วยใช้ 80 Stamina";
        }
        else if(TravelStat.Item_Name=="5ReduceSup"){
            Item_Title.text="กินประหยัด";
            Item_info.text="ใช้ Supply น้อยลง -5 หน่วย";
        }else if(TravelStat.Item_Name=="5ReduceSta"){
            Item_Title.text="อดอยาก";
            Item_info.text="เสียพลังชีวิต -1 ต่อวินาทีเมื่อ Stamina หมด";
        }else if(TravelStat.Item_Name=="5HorseRun"){
            Item_Title.text="เกือกม้า";
            Item_info.text="เดินทางเร็วขึ้น";
        }else if(TravelStat.Item_Name=="5Armor"){
            Item_Title.text="เกราะมหาสมุทร";
            Item_info.text="เพิ่มพลังชีวิตสูงสุด 5 หน่วย";
        }else if(TravelStat.Item_Name=="5Sword"){
            Item_Title.text="ดาบยักษ์";
            Item_info.text="สร้างความเสียหายให้ศัตรูเพิ่ม +2 หน่วย";
        }
        else if(TravelStat.Item_Name=="6Cross"){
            Item_Title.text="กางเกงขาว";
            Item_info.text="ลดความเสียหายที่ได้รับจากศัตรูลง -1 หน่วย";
        }else if(TravelStat.Item_Name=="6BloodRitual"){
            Item_Title.text="พิธีกรรมเลือด";
            Item_info.text="ลดเลือด -5 หน่วย สร้างความเสียหาย 20 หน่วย";
        }else if(TravelStat.Item_Name=="6RedHorse"){
            Item_Title.text="เกราะม้า";
            Item_info.text="ลดความเสียหายที่ได้รับจากการวิ่งหนีลง -5 หน่วย";
        }else if(TravelStat.Item_Name=="6Sword"){
            Item_Title.text="ดาบโลหิต";
            Item_info.text="เมื่อทำความเสียหายให้ศัตรู เพิ่มพลังชีวิต +1 หน่วย";
        }else if(TravelStat.Item_Name=="6BloodDrink"){
            Item_Title.text="ถุงเลือด";
            Item_info.text="การเพิ่มพลังชีวิตจากร้านค้ามากขึ้น";
        }


    }
}

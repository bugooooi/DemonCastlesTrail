using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Event_Rand : MonoBehaviour
{


    public Text Event_Update;
    public string NowPage;
    [SerializeField] private AudioSource hardroad; //เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina
    [SerializeField] private AudioSource fairy; //คุณได้รับดาบวิเศษจากเหล่าภูติ
    [SerializeField] private AudioSource rogue; //โจรปล้นสะดม//
    [SerializeField] private AudioSource rotfood;// อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป //
    [SerializeField] private AudioSource flower; //คุณได้รับการรักษาจากเหล่าภูติ
    [SerializeField] private AudioSource ork; //คุณถูกจู่โจมโดยออร์ค


    System.Random random = new System.Random();

    string[] ElyEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","Fairy","Ork","Flower"};
    string[] DVEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","RD","RR","Flower"};
    string[] SFEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","DA","RA","Flower"};
    string[] SLEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","SR","EW","Flower"};
    string[] DPEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","VS","VV","Flower"};
    string[] HHEvent = new string[] {"Rot Food","Rot Food","Rogue",
    "Hard Road","Hard Road","DA","DA","DA","DA","DA","DA","DA","VV","Flower"};
    

    IEnumerator Start()
    {
        while (true)
        {
            if (TravelStat.LandmarkNow == "Elywynn")
            {
                yield return new WaitForSeconds(6f);
                Ely_Func();
            }
            if (TravelStat.LandmarkNow == "DragonVillage")
            {
                yield return new WaitForSeconds(6f);
                DV_Func();
            }
            if (TravelStat.LandmarkNow == "StormFront")
            {
                yield return new WaitForSeconds(6f);
                SF_Func();
            }
            if (TravelStat.LandmarkNow == "SandLand")
            {
                yield return new WaitForSeconds(6f);
                SL_Func();
            }
            if (TravelStat.LandmarkNow == "DrownPort")
            {
                yield return new WaitForSeconds(6f);
                DP_Func();
            }
            if (TravelStat.LandmarkNow == "HellHound")
            {
                yield return new WaitForSeconds(6f);
                HH_Func();
            }
            if (TravelStat.LandmarkNow == "Crabonest")
            {
                yield return new WaitForSeconds(6f);
                CD_Func();
            }
            if (TravelStat.LandmarkNow == "Colossus")
            {
                yield return new WaitForSeconds(6f);
                CD_Func();
            }

        }
    }



    public void Ely_Func(){
        if(!ItemStat.Item.Contains("3Twin")){
            int useElyEvent = random.Next(ElyEvent.Length);
            string pickElyEvent = ElyEvent[useElyEvent];
            if(pickElyEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickElyEvent=="Rogue"){
                rogue.Play();
                if (!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickElyEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickElyEvent=="Fairy"){
                fairy.Play();
                Event_Update.text="คุณได้รับดาบวิเศษจากเหล่าภูติ";
                ItemStat.Item.Add("3Twin");
            }
            if(pickElyEvent=="Ork"){
                ork.Play();
                Event_Update.text="คุณถูกจู่โจมโดยออร์ค";
                TravelStat.currentHp-=5;
            }
            if(pickElyEvent=="Flower"){
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }else{//////////////////////////////////////////////////////////
            int useElyEvent = random.Next(ElyEvent.Length);
            string pickElyEvent = ElyEvent[useElyEvent];
            if(pickElyEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickElyEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickElyEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if (pickElyEvent == "Fairy")
            {
                fairy.Play();
                Event_Update.text = "คุณได้รับดาบวิเศษจากเหล่าภูติ";
                ItemStat.Item.Add("3Twin");
            }
            if (pickElyEvent=="Ork"){
                ork.Play();
                Event_Update.text="คุณถูกจู่โจมโดยออร์ค";
                TravelStat.currentHp-=5;
            }
            if(pickElyEvent=="Flower"){
                    if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }
    }

    public void CD_Func(){
            int useSLEvent = random.Next(SLEvent.Length);
            string pickSLEvent = SLEvent[useSLEvent];
            if(pickSLEvent=="Rot Food"){
            rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickSLEvent=="Rogue"){
            rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickSLEvent=="Hard Road"){
            hardroad.Play();
                Event_Update.text="ทะเลแปรปวนทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSLEvent=="SR"){
            
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
            if(pickSLEvent=="EW"){
            hardroad.Play();
                Event_Update.text="ทะเลแปรปวนทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSLEvent=="Flower"){
            
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }   
    }

    public void DV_Func(){
        if(!ItemStat.Item.Contains("2Armor")){
            int useDVEvent = random.Next(DVEvent.Length);
            string pickDVEvent = DVEvent[useDVEvent];
            if(pickDVEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickDVEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text="โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickDVEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickDVEvent=="RD"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยมังกรแดง แต่เหมือนมันทำบางอย่างหล่นไว้";
                TravelStat.currentHp-=10;
                ItemStat.Item.Add("2Armor");
            }
            if(pickDVEvent=="RR"){
                ork.Play();
                Event_Update.text="ถนนเต็มไปด้วยเปลวไฟจากมังกร";
                TravelStat.currentHp-=5;
            }
            if(pickDVEvent=="Flower"){
                
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }else{
            int useDVEvent = random.Next(DVEvent.Length);
            string pickDVEvent = DVEvent[useDVEvent];
            if(pickDVEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickDVEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickDVEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickDVEvent=="RD"){
                rogue.Play();
                Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                if(TravelStat.Gold>0){
                    TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
            }
            if(pickDVEvent=="RR"){
                ork.Play();
                Event_Update.text="ถนนเต็มไปด้วยเปลวไฟจากมังกร";
                TravelStat.currentHp-=5;
            }
            if(pickDVEvent=="Flower"){
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }
    }

    public void SF_Func(){
        if(!ItemStat.Item.Contains("4Armor")){
            int useSFEvent = random.Next(SFEvent.Length);
            string pickSFEvent = SFEvent[useSFEvent];
            if(pickSFEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickSFEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickSFEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSFEvent=="DA"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยทหารจอมมาร";
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEvent=="RA"){
                fairy.Play();
                Event_Update.text="คุณพบเกราะที่ดูคล้ายหิน";
                ItemStat.Item.Add("4Armor");
            }
            if(pickSFEvent=="Flower"){
               
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }else{
            int useSFEvent = random.Next(SFEvent.Length);
            string pickSFEvent = SFEvent[useSFEvent];
            if(pickSFEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickSFEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickSFEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSFEvent=="DA"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยทหารจอมมาร";
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEvent=="RA"){
                Monster_System.Mon_Name="Rogue";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSFEvent=="Flower"){
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }
    }

    public void SL_Func(){
            int useSLEvent = random.Next(SLEvent.Length);
            string pickSLEvent = SLEvent[useSLEvent];
            if(pickSLEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickSLEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickSLEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSLEvent=="SR"){
                rogue.Play();
                Event_Update.text="โจรทะเลทรายปล้นสะดม";
                Monster_System.Mon_Name="Sand Land";
                SceneManager.LoadScene("turnbase");
            }
            if(pickSLEvent=="EW"){
                hardroad.Play();
                Event_Update.text="น้ำในขวดของคุณแห้งเหือดทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickSLEvent=="Flower"){
            
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }   
    }
    
    public void DP_Func(){
        if(!ItemStat.Item.Contains("6RedHorse")){
            int useDPEvent = random.Next(DPEvent.Length);
            string pickDPEvent = DPEvent[useDPEvent];
            if(pickDPEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickDPEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickDPEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickDPEvent=="VS"){
                ork.Play();
                Event_Update.text="ถูกโจมตีโดยสมุนแวมไพร์";
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEvent=="VV"){
                fairy.Play();
                Event_Update.text="คุณพบกับเกราะสวมม้าของคุณ";
                ItemStat.Item.Add("6RedHorse");
            }
            if(pickDPEvent=="Flower"){
                
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                        rogue.Play();
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }else{
            int useDPEvent = random.Next(DPEvent.Length);
            string pickDPEvent = DPEvent[useDPEvent];
            if(pickDPEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickDPEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickDPEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickDPEvent=="VS"){
                ork.Play();
                Event_Update.text="ถูกโจมตีโดยสมุนแวมไพร์";
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEvent=="VV"){
                ork.Play();
                Event_Update.text="ถูกโจมตีโดยสมุนแวมไพร์";
                Monster_System.Mon_Name="Vampire Spawn";
                SceneManager.LoadScene("turnbase");
            }
            if(pickDPEvent=="Flower"){
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }
    }

    public void HH_Func(){
        if(!ItemStat.Item.Contains("3DevilSword")){
            int useHHEvent = random.Next(HHEvent.Length);
            string pickHHEvent = HHEvent[useHHEvent];
            if(pickHHEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickHHEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickHHEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickHHEvent=="DA"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยทหารจอมมาร";
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickHHEvent=="VV"){
                fairy.Play();
                Event_Update.text="คุณพบกับเกราะสวมม้าของคุณ";
                ItemStat.Item.Add("3DevilSword");
            }
            if(pickHHEvent=="Flower"){
                
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text= "โจรปล้นสะดม คุณเสีย 10 Gold";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }else{
            int useHHEvent = random.Next(HHEvent.Length);
            string pickHHEvent = HHEvent[useHHEvent];
            if(pickHHEvent=="Rot Food"){
                rotfood.Play();
                Event_Update.text="อาหารเน่าเสีย ทำให้ Supply ของคุณหายไป";
                TravelStat.currentSupply=TravelStat.currentSupply/2;
            }
            if(pickHHEvent=="Rogue"){
                rogue.Play();
                if(!ItemStat.Item.Contains("4Protect")){
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
            }
            if(pickHHEvent=="Hard Road"){
                hardroad.Play();
                Event_Update.text="เส้นทางถนนอันยากลำบากทำให้คุณเสีย Stamina";
                if(TravelStat.currentStamina>0){
                    TravelStat.currentStamina-=5;
                }else{
                    TravelStat.currentHp-=5;
                }
            }
            if(pickHHEvent=="DA"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยทหารจอมมาร";
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickHHEvent=="VV"){
                ork.Play();
                Event_Update.text="คุณถูกโจมตีโดยทหารจอมมาร";
                Monster_System.Mon_Name="Devil Army";
                SceneManager.LoadScene("turnbase");
            }
            if(pickHHEvent=="Flower"){
                if(ItemStat.Item.Contains("3Healtrun")){
                    flower.Play();
                    Event_Update.text="คุณได้รับการรักษาจากเหล่าภูติ";
                    if(TravelStat.currentHp<TravelStat.maxHp-5){
                        TravelStat.currentHp+=5;
                    }else{TravelStat.currentHp=TravelStat.maxHp;}
                }else{
                    if(!ItemStat.Item.Contains("4Protect")){
                    rogue.Play();
                    Event_Update.text="โจรปล้นสะดม";
                    if(TravelStat.Gold>0){
                        TravelStat.Gold-=10;
                }else{TravelStat.Gold=0;}
                }else{
                    Event_Update.text="การเดินทางของคุณราบรื่น";
                }
                }
            }
        }
    }




















}

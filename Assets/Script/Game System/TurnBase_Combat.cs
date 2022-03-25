using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnBase_Combat : MonoBehaviour
{
    public Text Battle_Update;
    [SerializeField] private AudioSource atk;
    [SerializeField] private AudioSource hurt;
    void Update()
    {
        
    }
    public void Attack_Buttom(){
        atk.Play();
        StartCoroutine(Attack_Func());
    }
    public void Fire_Buttom(){
        if(TravelStat.currentStamina>=10){
            StartCoroutine(Fire_Func());
        }
    }
    public void Blood_Buttom(){
        if(TravelStat.currentHp>=5){
            StartCoroutine(Blood_Func());
        }
    }
    public void Finish_Buttom(){
        if(TravelStat.currentStamina>=80){
            StartCoroutine(Finish_Func());
        }
    }
    IEnumerator Attack_Func(){
        Battle_Update.text="คุณโจมตีศัตรู";
        Monster_System.Mon_Healt-=PCStat.PCDM;
        if(TravelStat.currentHp<TravelStat.maxHp){
            TravelStat.currentHp+=ItemStat.BloodSword;
        }
        yield return new WaitForSeconds(1f);
        hurt.Play();
        Battle_Update.text="ศัตรูโจมตีคุณ";
        TravelStat.currentHp-=Monster_System.Mon_Damage;
        yield return new WaitForSeconds(1f);
        Battle_Update.text="ตาคุณโจมตี";
    }

    IEnumerator Fire_Func(){
        Battle_Update.text="คุณพ่นไฟใส่ศัตรู";
        Monster_System.Mon_Healt-=20;
        TravelStat.currentStamina-=10;
        yield return new WaitForSeconds(1f);
        hurt.Play();
        Battle_Update.text="ศัตรูโจมตีคุณ";
        TravelStat.currentHp-=Monster_System.Mon_Damage;
        yield return new WaitForSeconds(1f);
        Battle_Update.text="ตาคุณโจมตี";
    }
    IEnumerator Blood_Func(){
        Battle_Update.text="คุณใช้พิธีกรรมเลือด";
        Monster_System.Mon_Healt-=20;
        TravelStat.currentHp-=ItemStat.BloodSword;
        yield return new WaitForSeconds(1f);
        hurt.Play();
        Battle_Update.text="ศัตรูโจมตีคุณ";
        TravelStat.currentHp-=Monster_System.Mon_Damage;
        yield return new WaitForSeconds(1f);
        Battle_Update.text="ตาคุณโจมตี";
    }
    IEnumerator Finish_Func(){
        Battle_Update.text="คุณใช้ท่าไม้ตาย";
        Monster_System.Mon_Healt-=100;
        TravelStat.currentStamina-=800;
        yield return new WaitForSeconds(1f);
        hurt.Play();
        Battle_Update.text="ศัตรูโจมตีคุณ";
        TravelStat.currentHp-=Monster_System.Mon_Damage;
        yield return new WaitForSeconds(1f);
        Battle_Update.text="ตาคุณโจมตี";
    }
}

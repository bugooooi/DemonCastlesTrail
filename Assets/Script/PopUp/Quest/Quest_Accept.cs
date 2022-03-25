using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quest_Accept : MonoBehaviour
{
    public void Accept_Quest(){
        //Ely
        if(TravelStat.QAName=="1Ely"){
            Monster_System.Mon_Name="Ork";
            TravelStat.QuestPass.Add("1Ely");
            TravelStat.QuestUnlock.Add("2Ely");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2Ely"){
            Monster_System.Mon_Name="Ork";
            TravelStat.QuestPass.Add("2Ely");
            TravelStat.QuestUnlock.Add("3Ely");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3Ely"){
            Monster_System.Mon_Name="Ork";
            TravelStat.QuestPass.Add("3Ely");
            TravelStat.QuestUnlock.Add("4Ely");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="4Ely"){
            Monster_System.Mon_Name="Ork";
            TravelStat.QuestPass.Add("4Ely");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //DV
        if(TravelStat.QAName=="1DV"){
            Monster_System.Mon_Name="Red Dragon";
            TravelStat.QuestPass.Add("1DV");
            TravelStat.QuestUnlock.Add("2DV");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2DV"){
            Monster_System.Mon_Name="Rogue";
            TravelStat.QuestPass.Add("2DV");
            TravelStat.QuestUnlock.Add("3DV");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3DV"){
            Monster_System.Mon_Name="Rogue";
            TravelStat.QuestPass.Add("3DV");
            TravelStat.QuestUnlock.Add("4DV");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="4DV"){
            Monster_System.Mon_Name="Red Dragon";
            TravelStat.QuestPass.Add("4DV");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //SF
        if(TravelStat.QAName=="1SF"){
            Monster_System.Mon_Name="Devil Army";
            TravelStat.QuestPass.Add("1SF");
            TravelStat.QuestUnlock.Add("2SF");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2SF"){
            Monster_System.Mon_Name="Devil Army";
            TravelStat.QuestPass.Add("2SF");
            TravelStat.QuestUnlock.Add("3SF");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3SF"){
            Monster_System.Mon_Name="Devil Army";
            TravelStat.QuestPass.Add("3SF");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //SL
        if(TravelStat.QAName=="1SL"){
            Monster_System.Mon_Name="Sand Rogue";
            TravelStat.QuestPass.Add("1SL");
            TravelStat.QuestUnlock.Add("2SL");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2SL"){
            Monster_System.Mon_Name="Sand Rogue";
            TravelStat.QuestPass.Add("2SL");
            TravelStat.QuestUnlock.Add("3SL");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3SL"){
            Monster_System.Mon_Name="Sand Rogue";
            TravelStat.QuestPass.Add("3SL");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //CN
        if(TravelStat.QAName=="1CN"){
            Monster_System.Mon_Name="Blue";
            TravelStat.QuestPass.Add("1CN");
            TravelStat.QuestUnlock.Add("2CN");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2CN"){
            Monster_System.Mon_Name="Red";
            TravelStat.QuestPass.Add("2CN");
            TravelStat.QuestUnlock.Add("3CN");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3CN"){
            Monster_System.Mon_Name="Red";
            TravelStat.QuestPass.Add("3CN");
            TravelStat.QuestUnlock.Add("4CN");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="4CN"){
            Monster_System.Mon_Name="Blue";
            TravelStat.QuestPass.Add("4CN");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //DL
        if(TravelStat.QAName=="1DP"){
            Monster_System.Mon_Name="Vampire Spawn";
            TravelStat.QuestPass.Add("1DP");
            TravelStat.QuestUnlock.Add("2DP");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2DP"){
            Monster_System.Mon_Name="Vampire";
            TravelStat.QuestPass.Add("2DP");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }
        //Coll
        if(TravelStat.QAName=="1Coll"){
            Monster_System.Mon_Name="Champ1";
            TravelStat.QuestPass.Add("1Coll");
            TravelStat.QuestUnlock.Add("2Coll");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="2Coll"){
            Monster_System.Mon_Name="Champ2";
            TravelStat.QuestPass.Add("2Coll");
            TravelStat.QuestUnlock.Add("3Coll");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="3Coll"){
            Monster_System.Mon_Name="Champ3";
            TravelStat.QuestPass.Add("3Coll");
            TravelStat.QuestUnlock.Add("4Coll");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }else if(TravelStat.QAName=="4Coll"){
            Monster_System.Mon_Name="Champ4";
            TravelStat.QuestPass.Add("4Coll");
            TravelStat.BackFromAttack="5Landmark";
            SceneManager.LoadScene("turnbase");
        }

    }
}

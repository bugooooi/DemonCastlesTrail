using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Monster_Spite : MonoBehaviour
{
    public Image Mon_Pics;
    public string MonPic_Name;

    private void Update(){
        if(MonPic_Name==Monster_System.Mon_Name){
            Mon_Pics.gameObject.SetActive(true);
        }else{
            Mon_Pics.gameObject.SetActive(false);
        }
    }
}

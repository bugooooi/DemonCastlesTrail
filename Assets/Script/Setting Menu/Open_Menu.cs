using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Open_Menu : MonoBehaviour
{
    public Image OMenu;
    public string Command;
    public void ClickOpen(){
        if(Command=="Close"){
            OMenu.gameObject.SetActive(true);
            Command="Open";
        }else{
            OMenu.gameObject.SetActive(false);
            Command="Close";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BagBTN : MonoBehaviour
{
    public string NowPage;

    private void Update(){
        TravelStat.BagBack=NowPage;
    }
    public void PressSelection(){
        SceneManager.LoadScene("7Inventory");
    }
}

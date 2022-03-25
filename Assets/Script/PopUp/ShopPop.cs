using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopPop : MonoBehaviour
{
    public GameObject SHopUp;
    public void ShopPopProgress(){
        SHopUp.SetActive(true);
    }
}

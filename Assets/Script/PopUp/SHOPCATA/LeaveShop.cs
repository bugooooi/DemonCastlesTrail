using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaveShop : MonoBehaviour
{
    public GameObject SHopUp;
    public GameObject QUp;
    public void LeaveShProgress(){
        SHopUp.SetActive(false);
        QUp.SetActive(false);
    }
}

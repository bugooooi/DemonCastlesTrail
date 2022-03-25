using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_Game : MonoBehaviour
{
    [SerializeField] private AudioSource click;

    public void NewScene()
    {
        click.Play();
        SceneManager.LoadScene("2Intro");
       
    }
}

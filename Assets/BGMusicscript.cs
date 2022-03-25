using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicscript : MonoBehaviour
{
    public static BGMusicscript BgInstanace;

    private void Awake()
    {
        if(BgInstanace != null && BgInstanace != this)
        {
            Destroy(this.gameObject);
            return;
        }
        BgInstanace = this;
        DontDestroyOnLoad(this);
    }
}

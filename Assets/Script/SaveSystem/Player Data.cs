using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string LN;
    public List<string> LP;

    public int MS;
    public int CS;
    
    public int MH;
    public int CH;

    public int MSu;
    public int CSu;

    public int GD=100;

    public List<string> QP;
    public List<string> QU;

    public List<string> IT;


    public PlayerData(TravelStat player)
    {
        LN = TravelStat.LandmarkNow;
        LP = TravelStat.LandmarkPre;

        MS = TravelStat.maxStamina;
        CS = TravelStat.currentStamina;
        
        MH = TravelStat.maxHp;
        CH = TravelStat.currentHp;

        MSu = TravelStat.MaxSupply;
        CSu = TravelStat.currentSupply;

        GD = TravelStat.Gold;

        QP = TravelStat.QuestPass;
        QU = TravelStat.QuestUnlock;

        IT = ItemStat.Item;

    }
}


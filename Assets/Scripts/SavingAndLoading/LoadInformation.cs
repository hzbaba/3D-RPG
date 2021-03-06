﻿using UnityEngine;
using System.Collections;

public class LoadInformation {

    public static void LoadAllInformation()
    {

        //TODO: STILL NEED TO SAVE THE PLAYER CLASS

        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.Charm = PlayerPrefs.GetInt("CHARM");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELLECT");
        GameInformation.Evasion = PlayerPrefs.GetInt("EVASION");
        GameInformation.Spirit = PlayerPrefs.GetInt("SPIRIT");
        GameInformation.Luck = PlayerPrefs.GetInt("LUCK");
        GameInformation.Speed = PlayerPrefs.GetInt("SPEED");
        GameInformation.Hp = PlayerPrefs.GetInt("HP");
        GameInformation.Mp = PlayerPrefs.GetInt("MP");
        GameInformation.gold = PlayerPrefs.GetInt("GOLD");

        if (PlayerPrefs.GetString("ARMORPIECEHEAD") != null)
        {
            GameInformation.ArmorPieceHead = (BaseArmor)PPSerialization.Load("ARMORPIECEHEAD");
        }

        //Debug
        Debug.Log("DEBUG:   LOADED PLAYER INFORMATION");
    }


}

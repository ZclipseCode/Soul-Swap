using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FactionDeterminer : MonoBehaviour
{
    Faction[] factions = new Faction[2];

    private void Start()
    {
        DetermineFactions();
    }

    void DetermineFactions()
    {
        for (int i = 0; i < factions.Length; i++)
        {
            factions[i] = (Faction)Enum.ToObject(typeof(Faction), UnityEngine.Random.Range(0, Enum.GetValues(typeof(Faction)).Length));
        }

        while (factions[0] == factions[1])
        {
            factions[1] = (Faction)Enum.ToObject(typeof(Faction), UnityEngine.Random.Range(0, Enum.GetValues(typeof(Faction)).Length));
        }
    }

    public Faction GetFaction(int value)
    {
        if (value < 0 || value > 1)
        {
            Debug.Log("Faction value out of range!");

            return factions[0];
        }

        return factions[value];
    }
}

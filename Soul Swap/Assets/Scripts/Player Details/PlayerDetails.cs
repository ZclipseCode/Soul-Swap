using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerDetails", menuName = "PlayerDetails")]
public class PlayerDetails : ScriptableObject
{
    public string playerName;
    public Faction faction;
    public Class playerClass;
    public float initialHealth = 1;
    public float initialAttack = 1;
    public float initialSpeed = 1;
    // primary attack
    // alternative ability
    // passive ability
}

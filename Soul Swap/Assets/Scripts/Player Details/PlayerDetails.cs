using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerDetails", menuName = "PlayerDetails")]
public class PlayerDetails : ScriptableObject
{
    [SerializeField] string playerName;
    [SerializeField] Faction faction;
    [SerializeField] Class playerClass;
    [SerializeField] float health = 1;
    [SerializeField] float attack = 1;
    [SerializeField] float speed = 1;
    // primary attack
    // alternative ability
    // passive ability

    public void HealthIncrease(int value)
    {
        health += value;
    }

    public void AttackIncrease(int value)
    {
        attack += value;
    }

    public void SpeedIncrease(int value)
    {
        speed += value;
    }
}

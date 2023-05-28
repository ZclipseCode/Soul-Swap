using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTestPlayer : MonoBehaviour
{
    [SerializeField] Faction faction;
    [SerializeField] Class playerClass;
    SkillPoints skillPoints;

    [SerializeField] PlayerDetails details;
    [SerializeField] float health;
    [SerializeField] float attack;
    [SerializeField] float speed;

    void Start()
    {
        skillPoints = GetComponent<SkillPoints>();

        faction = details.faction;
        playerClass = details.playerClass;
        health = details.initialHealth;
        attack = details.initialAttack;
        speed = details.initialSpeed;
    }

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

    public Faction GetFaction()
    {
        return faction;
    }

    public Class GetClass()
    {
        return playerClass;
    }
}

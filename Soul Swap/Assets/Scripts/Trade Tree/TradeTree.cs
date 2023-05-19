using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeTree : MonoBehaviour
{
    [SerializeField] int minStatIncrease = 1;
    [SerializeField] int maxStatIncrease = 3;
    [SerializeField] int upgradeCost = 1;

    GameObject playerGO;
    Stats stats;
    SkillPoints skillPoints;

    FactionDeterminer factionDeterminer;
    Faction[] factions;

    Branch[] branches = new Branch[2];

    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
        stats = playerGO.GetComponent<Stats>();
        skillPoints = playerGO.GetComponent<SkillPoints>();

        factionDeterminer = GameObject.FindGameObjectWithTag("GameController").GetComponent<FactionDeterminer>(); // change tag?
        factions = factionDeterminer.GetFactions();

        //GenerateChoices();
    }

    // testing
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateChoices();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (skillPoints.GetSkillPoints() >= upgradeCost)
            {
                IncreaseStat(branches[0]);
                skillPoints.LoseSkillPoints(upgradeCost);
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (skillPoints.GetSkillPoints() >= upgradeCost)
            {
                IncreaseStat(branches[1]);
                skillPoints.LoseSkillPoints(upgradeCost);
            }
        }
    }

    public void GenerateChoices()
    {
        for (int i = 0; i < branches.Length; i++)
        {
            branches[i] =
                new Branch(factions[i],
                (Class)Enum.ToObject(typeof(Class), UnityEngine.Random.Range(0, Enum.GetValues(typeof(Class)).Length)),
                (Stat)Enum.ToObject(typeof(Stat), UnityEngine.Random.Range(0, Enum.GetValues(typeof(Stat)).Length)),
                UnityEngine.Random.Range(minStatIncrease, maxStatIncrease + 1));
        }

        Debug.Log($"{branches[0]}\n{branches[1]}");
    }

    public void IncreaseStat(Branch branch)
    {
        if (branch.Stat == Stat.Health)
        {
            stats.HealthIncrease(branch.StatIncrease);
        }
        else if (branch.Stat == Stat.Attack)
        {
            stats.AttackIncrease(branch.StatIncrease);
        }
        else if (branch.Stat == Stat.Speed)
        {
            stats.SpeedIncrease(branch.StatIncrease);
        }
        else
        {
            Debug.Log("Unrecognized stat!");
        }
    }
}

public class Branch
{
    Faction faction;
    Class playerClass;
    Stat stat;
    int statIncrease;

    public Branch(Faction faction, Class playerClass, Stat stat, int statIncrease)
    {
        Faction = faction;
        PlayerClass = playerClass;
        Stat = stat;
        StatIncrease = statIncrease;
    }

    public override string ToString()
    {
        return $"{Faction} {PlayerClass} {Stat} +{StatIncrease}";
    }

    public Faction Faction
    {
        get;
    }

    public Class PlayerClass
    {
        get;
    }

    public Stat Stat
    {
        get;
    }

    public int StatIncrease
    {
        get;
    }
}
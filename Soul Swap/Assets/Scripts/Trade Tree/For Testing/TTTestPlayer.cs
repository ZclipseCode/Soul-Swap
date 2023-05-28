using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTestPlayer : MonoBehaviour
{
    [SerializeField] Faction faction;
    [SerializeField] Class playerClass;
    PlayerDetails stats;
    SkillPoints skillPoints;

    void Start()
    {
        stats = GetComponent<PlayerDetails>();
        skillPoints = GetComponent<SkillPoints>();
    }
}

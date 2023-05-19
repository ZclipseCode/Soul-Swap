using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTestPlayer : MonoBehaviour
{
    [SerializeField] Faction faction;
    [SerializeField] Class playerClass;
    Stats stats;
    SkillPoints skillPoints;

    void Start()
    {
        stats = GetComponent<Stats>();
        skillPoints = GetComponent<SkillPoints>();
    }
}

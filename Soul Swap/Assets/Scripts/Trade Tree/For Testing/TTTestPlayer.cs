using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTestPlayer : MonoBehaviour
{
    [SerializeField] Faction faction;
    [SerializeField] Class playerClass;
    Stats stats;
    SkillPoints skillPoints;

    [SerializeField] PlayerDetails details;

    void Start()
    {
        stats = GetComponent<Stats>();
        skillPoints = GetComponent<SkillPoints>();
    }
}

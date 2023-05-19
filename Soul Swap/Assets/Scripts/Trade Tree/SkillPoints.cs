using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPoints : MonoBehaviour
{
    [SerializeField] int skillPoints;

    public void GainSkillPoints(int value)
    {
        skillPoints += value;
    }

    public void LoseSkillPoints(int value)
    {
        skillPoints -= value;
    }

    public int GetSkillPoints() => skillPoints;
}

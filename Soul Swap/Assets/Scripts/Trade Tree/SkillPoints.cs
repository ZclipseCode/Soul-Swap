using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPoints : MonoBehaviour
{
    [SerializeField] float skillPoints;

    public void ChangeSkillPoints(int value)
    {
        skillPoints += value;
    }
}

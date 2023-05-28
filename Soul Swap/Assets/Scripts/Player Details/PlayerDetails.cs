using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetails : MonoBehaviour
{
    [SerializeField] float health = 1;
    [SerializeField] float attack = 1;
    [SerializeField] float speed = 1;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    [SerializeField] private int healthPoints = 3;
    [SerializeField] private int collectibles = 0;

    public void damagePlayer(int amount)
    {
        healthPoints -= amount;
    }

    public void healPlayer(int amount)
    {
        healthPoints += amount;
    }

    public void addCollectible(int amount)
    {
        collectibles += amount;
    }

}

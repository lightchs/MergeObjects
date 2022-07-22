using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchEntity : MonoBehaviour
{
    [SerializeField] private EntityType entityType;

    public EntityType EntityType => entityType;
    public EntityType Upgrade()
    {
        switch (EntityType)
        {
            case EntityType.BabyСorn: return EntityType.Corn;
            case EntityType.ВadDoghouse: return EntityType.Doghouse;
            case EntityType.Doghouse: return EntityType.Coin;
            case EntityType.Corn: return EntityType.Coin;
            default: return EntityType.Coin;
        }
    }
}

public enum EntityType
{
    none,
    BabyСorn,
    Corn,
    ВadDoghouse,
    Doghouse,
    Coin,
}


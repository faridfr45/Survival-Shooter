using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] enemyPrefab;

    public GameObject FactoryMethod(int tag)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag]);
        return enemy;
    }
}

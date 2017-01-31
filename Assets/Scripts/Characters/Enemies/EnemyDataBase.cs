using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemyDataBase : MonoBehaviour {

    public List<Enemy> enemyTypes = new List<Enemy>();

    void Awake()
    {
        AddEnemies();
    }

    void AddEnemies()
    {
        if (PlayerInformation.Stage <= 5)
        {
            enemyTypes.Add(new Rat());
            enemyTypes.Add(new Knight());
        }
    }
}

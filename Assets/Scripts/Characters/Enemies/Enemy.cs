using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : Character {
    private EnemySpawner _enemySpawner;

    public int goldWorth;
    public string enemySpriteFileName;

    void Awake()
    {
        //Gets the EnemySpawner script in the parent to access the list of active enemies
        _enemySpawner = GetComponentInParent<EnemySpawner>();
    }

    void Update()
    {
        Death();
    }

    void Death()
    {
        //If enemy is at or below 0 health
        if (health <= 0)
        {
            PlayerInformation.Gold += goldWorth;                    //Gives the player gold
            _enemySpawner.ActiveEnemies.Remove(this.gameObject);    //Removes this object from the active enemies list
            Destroy(this.gameObject);                               //Destroys this object
        }
    }
}

using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemySpawner : EnemyDataBase {

    [SerializeField]private List<Transform> _spawnPositions = new List<Transform>();
    private EnemyFactory    _enemyFactory = new EnemyFactory();
    private Transform       _enemyContainer;
    private int             _randomEnemy;

    private List<GameObject> _activeEnemies = new List<GameObject>();
    //Getter and setter for the Active Enemies list
    public List<GameObject> ActiveEnemies
    {
        get { return _activeEnemies; }
        set { _activeEnemies = value; }
    }

	void Start () 
    {
        _enemyContainer = this.transform;
	}
	
	void Update () 
    {
        if (_activeEnemies.Count == 0)
        {
            SpawnEnemyWave();
        }
	}

    // randomEnemyAmount returns a random value between 1 and 6 this value represents the amount of enemies to spawn
    // enemies then get spawned and placed into the activeEnemies list
    void SpawnEnemyWave()
    {
        int randomEnemyAmount = Random.Range(1, 6);
        for (int i = 0; i < randomEnemyAmount; i++)
        {
            _randomEnemy = Random.Range(0, enemyTypes.Count);
            _activeEnemies.Add(_enemyFactory.SpawnEnemy(enemyTypes[_randomEnemy].name, _randomEnemy, _spawnPositions[i],_enemyContainer));
        }
    }
}

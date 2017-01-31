using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ActiveEnemies : MonoBehaviour {

    private List<Character> _activeEnemies = new List<Character>();
    public delegate void EnemySpawner();
    public delegate void AddActiveEnemy(Character enemy);
    public static event AddActiveEnemy AddEnemyToList;

	
	// Update is called once per frame
	void Update () {
	
	}

    /*public void AddActiveEnemy(Character enemy)
    {
        _activeEnemies.Add(enemy);
    }*/
}

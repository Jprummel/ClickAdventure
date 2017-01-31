using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

    public Enemy _enemyType;

    /// <summary>
    /// this function spawns a new enemy based on the type parameter, it then sets the order so that enemies are displayed correctly
    /// and puts them at a designated spawn position
    /// </summary>
    
    public GameObject SpawnEnemy(string spawnedEnemyType,int renderLayer, Transform spawnPosition,Transform parent)
    {
        GameObject _newEnemy = new GameObject();    //Creates a new object
        _newEnemy.transform.SetParent(parent);      //Sets the parent parameter as the parent object for _newEnemy
        _newEnemy.AddComponent<BoxCollider2D>();    //Adds a collider       
        
        switch (spawnedEnemyType)
        {
            //Decides the type of the new Enemy, it uses the enemies name to determine its type
            case "Rat":
                _enemyType = _newEnemy.AddComponent<Rat>();
                break;
            case "Knight":
                _enemyType = _newEnemy.AddComponent<Knight>();
                break;
            default:
                break;                
        }

        //Gives the new enemy a sprite renderer and sets its order in the renderer
        SpriteRenderer spriteRenderer = _newEnemy.AddComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder = renderLayer;
        spriteRenderer.sprite = Resources.Load<Sprite>("Art/Sprites/Enemies/" + _enemyType.enemySpriteFileName);

        //Gives the enemy a name, tag and spawn position
        _newEnemy.name = _enemyType.name;
        _newEnemy.tag = Tags.ENEMY;
        _newEnemy.transform.position = spawnPosition.position;
        return _newEnemy;
    }
}

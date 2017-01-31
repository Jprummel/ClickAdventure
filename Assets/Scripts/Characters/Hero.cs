using UnityEngine;
using System.Collections;

public class Hero : Character {

    private Enemy _targetedEnemy;

    void Death()
    {
        if (health <= 0)
        {
            //play death animation
            //disable hero from fighting
        }
    }

    Enemy TargetEnemy()
    {
        //Target enemy from the active enemy list
        return _targetedEnemy;
    }

    void AttackEnemy()
    {
        //Attack the target
    }
}

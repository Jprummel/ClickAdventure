using UnityEngine;
using System.Collections;

public class Knight : Enemy {

	public Knight()
    {
        enemySpriteFileName = "Knight_Sprite";
        goldWorth = 50;

        name = "Knight";
        health = 120;
        damage = 15;
        attackSpeed = 0.8f;
    }
}

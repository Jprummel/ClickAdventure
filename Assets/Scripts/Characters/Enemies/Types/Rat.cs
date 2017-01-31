using UnityEngine;
using System.Collections;

public class Rat : Enemy {

    public Rat()
    {
        enemySpriteFileName = "Rat_Sprite";
        goldWorth = 20;

        name = "Rat";
        health = 100;
        damage = 10;
        attackSpeed = 0.8f;
    }
}

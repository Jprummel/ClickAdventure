using UnityEngine;
using System.Collections;

public class PlayerClick : MonoBehaviour
{

    private float _clickDamage;

    void Update()
    {
        DealClickDamage();
    }

    void CalculateClickDamage()
    {
        _clickDamage = PlayerInformation.ClickLevel * 10 + (PlayerInformation.ClickLevel + 5);
    }

    void DealClickDamage()
    {
        if (Input.GetMouseButtonDown(0)) //Left mouse click
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            //if (!hit == null)
            //{

                if (hit.collider.gameObject.tag == Tags.ENEMY)
                {
                    CalculateClickDamage();
                    Debug.Log(hit.transform.name);
                    Enemy enemy = hit.transform.GetComponent<Enemy>();
                    enemy.health -= _clickDamage;
                    Debug.Log("Dealth damage. Enemy has " + enemy.health + " health left");
                }
            //}
        }
    }
}

using UnityEngine;
using System.Collections;

public class BuyHero : MonoBehaviour, IBuyable {

    [SerializeField]private int _cost;

    public void Buy(int cost)
    {
        cost = _cost;
        if (cost <= PlayerInformation.Gold)
        {

        }
    }
}

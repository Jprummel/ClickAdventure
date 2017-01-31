using UnityEngine;
using System.Collections;

public class UpgradeClickDamage : MonoBehaviour, IBuyable {

    private int _cost = 100;

    public void Buy(int cost)
    {
        cost = _cost;
        if (cost <= PlayerInformation.Gold)
        {
            PlayerInformation.ClickLevel++;
            PlayerInformation.Gold -= cost;
            DetermineNewCost();
        }
    }

    void DetermineNewCost()
    {
        _cost = _cost + (PlayerInformation.ClickLevel * 10);
    }
}

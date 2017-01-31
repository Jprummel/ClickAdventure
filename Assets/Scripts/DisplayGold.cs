using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayGold : MonoBehaviour {

    private Text _gold;

	void Start () {
        _gold = GetComponent<Text>();
	}
	
	void Update () {
        DisplayGoldAmount();
	}

    void DisplayGoldAmount()
    {
        _gold.text = "Gold : " + PlayerInformation.Gold;
    }
}

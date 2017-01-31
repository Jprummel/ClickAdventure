using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class HeroUnlockButton : MonoBehaviour{

    [SerializeField]private List<Button> _heroUnlockButtons = new List<Button>();
    public int cost;
    private Button _button;
    private Text _buttonText;

    public void Buy(int buyCost,int buttonNumber)
    {
        buyCost = cost;
        if (PlayerInformation.Gold >= buyCost)
        {
            for (int i = 0; i < _heroUnlockButtons.Count; i++)
            {
                if (i == buttonNumber)
                {
                    _button = _heroUnlockButtons[buttonNumber].GetComponent<Button>();
                    _buttonText = _heroUnlockButtons[buttonNumber].GetComponentInChildren<Text>();
                    _button.interactable = false;
                    _buttonText.text = "Unlocked";
                }
            }
            PlayerInformation.Gold -= buyCost;
        }
    }
}

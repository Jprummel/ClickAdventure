using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PanelToggle : MonoBehaviour {

    [SerializeField]private List<GameObject> _panels = new List<GameObject>();

    /// <summary>
    /// This function is called from a button's OnClick
    /// It enables a panel thats in the list according to the parameter int given
    /// If that panel is already enabled it will disable it
    /// It disables all other panels
    /// </summary>
    /// <param name="panelNumber"></param>
    
    public void TogglePanel(int panelNumber)
    {
        for (int i = 0; i < _panels.Count; i++)
        {
            if(i != panelNumber)
            {
                _panels[i].SetActive(false);
            }

            if (_panels[panelNumber].active == false)
            {
                _panels[panelNumber].SetActive(true);
            }
            else if (_panels[panelNumber].active == true)
            {
                _panels[panelNumber].SetActive(false);
            }
        }
    }
}

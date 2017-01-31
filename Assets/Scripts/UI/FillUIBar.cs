using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FillUIBar : MonoBehaviour {

    public void FillBar(Image fillImage, float fillValue, float maxValue)
    {
        fillImage.fillAmount = maxValue / fillValue;
    }
}

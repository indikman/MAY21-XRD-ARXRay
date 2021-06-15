using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{

    public Image brainIcon;
    public Image heartIcon;
    public Image rightLungIcon;
    public Image bladderIcon;
    public Image kidneyIcon;

    public void OnBrainFound()
    {
        brainIcon.color = new Color(1, 1, 1, 1);
    }
    public void OnheartFound()
    {
        heartIcon.color = new Color(1, 1, 1, 1);
    }
    public void OnRightLungFound()
    {
        rightLungIcon.color = new Color(1, 1, 1, 1);
    }
    public void OnKidneyFound()
    {
        kidneyIcon.color = new Color(1, 1, 1, 1);
    }
    public void OnBladderFound()
    {
        bladderIcon.color = new Color(1, 1, 1, 1);
    }
}

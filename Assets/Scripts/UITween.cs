using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UITween : MonoBehaviour
{

    public void moveOnNV(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(10, 0, 0), 1).setEaseOutBack();
    }
    public void moveOffNV(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(815, 0, 0), 1).setEaseOutBack();
    }
    public void moveOnNT(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(10, 0, 0), 1).setEaseOutBack();
    }
    public void moveOffNT(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(-1000, 0, 0), 1).setEaseOutBack();
    }

    public void moveOnBtGroup1(RectTransform btGroup1)
    {
        LeanTween.move(btGroup1, new Vector3(0, 0, 0), 1).setEaseOutBack().setDelay(0.5f);
    }
    public void moveOffBtGroup1(RectTransform btGroup1)
    {
        LeanTween.move(btGroup1, new Vector3(-400, 0, 0), 0f);
    }

    public void ButtonOn(GameObject button)
    {
        LeanTween.scale(button, new Vector3(1.1f, 1.1f, 1.1f), 1f).setEaseOutBounce();
    }
    public void ButtonOff(GameObject button)
    {
        LeanTween.scale(button, new Vector3(1f, 1f, 1f), 1f).setEaseOutElastic();
    }

    public void moveOnCustomPanel(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(0, 0, 0), 1).setEaseOutBack();
    }
    public void moveOffCustomPanel(RectTransform panel)
    {
        LeanTween.move(panel, new Vector3(0, 1800, 0), 1).setEaseOutBack();
    }

    public void switchButton(GameObject button)
    {
        LeanTween.scale(button, new Vector3(0.7f, 0.7f, 1f), 0.2f).setEaseOutElastic();
        LeanTween.scale(button, new Vector3(0.6f, 0.6f, 1f), 0.1f).setDelay(0.2f);
    }
}

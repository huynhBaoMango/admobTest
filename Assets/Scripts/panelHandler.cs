using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelHandler : MonoBehaviour
{
    public void onToggleSelect(GameObject panel, bool status)
    {
        panel.SetActive(status);
    }
}

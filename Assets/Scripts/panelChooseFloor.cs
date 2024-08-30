using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class panelChooseFloor : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public GameObject placePrefab;
    public GameObject parentPlace;
    public bool isChooseAll = false;


    private void Start()
    {
        for (int i = 0; i < gameManager.placeSOList.Count; i++)
        {
            if(gameManager.placeSOList[i].loai == PlaceSO.Type.tang)
            {
                GameObject currentPlace = Instantiate(placePrefab, parentPlace.transform);
                currentPlace.GetComponentInChildren<TextMeshProUGUI>().text = gameManager.placeSOList[i].name;
            }
        }
    }

    public void ChooseAllButton()
    {
        isChooseAll = !isChooseAll;
        Toggle[] tgScripts = parentPlace.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in tgScripts)
        {
            t.isOn = isChooseAll;
        }
    }
    public void UnChooseAll()
    {
        isChooseAll = false;
        Toggle[] tgScripts = parentPlace.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in tgScripts)
        {
            t.isOn = false;
        }
    }
}

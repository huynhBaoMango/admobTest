using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoiThatPanel : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public GameObject placePrefab;
    public GameObject parentPlace;


    private void OnEnable()
    {
        for(int i = 0;i < gameManager.placeSOList.Count; i++)
        {
            GameObject currentPlace = Instantiate(placePrefab, parentPlace.transform);
            currentPlace.GetComponentInChildren<GetNoiThatFromParent>().SetNoiThat(gameManager.placeSOList[i]);
            currentPlace.GetComponentInChildren<TextMeshProUGUI>().text = gameManager.placeSOList[i].name;
        }
    }
}

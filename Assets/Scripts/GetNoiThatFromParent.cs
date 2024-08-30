using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetNoiThatFromParent : MonoBehaviour
{
    public GameObject noiThatPrefab;
    public GameObject noiThatParent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNoiThat(PlaceSO placeSO)
    {
        for(int i = 0; i < placeSO.NoiThatSO.Count; i++)
        {
            GameObject currentNoiThat = Instantiate(noiThatPrefab, noiThatParent.transform);
            currentNoiThat.GetComponentInChildren<TextMeshProUGUI>().text = placeSO.NoiThatSO[i].name;
        }
    }
}

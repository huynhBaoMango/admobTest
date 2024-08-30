using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class panelNhanVien : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public GameObject placePrefab;
    public GameObject parentPlace;
    public TextMeshProUGUI titleText;

    public GameObject bgCustom;
    public RectTransform customPanel;
    public UITween anim;

    public TextMeshProUGUI loaiText, headSkinText, bodySkinText;

    public void OnClickSortTHANGMAY()
    {
        ResetParentList();
        titleText.text = "Nhân viên thang máy";
        for (int i = 0; i < gameManager.placeSOList.Count; i++)
        {
            if(gameManager.placeSOList[i].loai == PlaceSO.Type.thangmay)
            {
                PlaceSO place = gameManager.placeSOList[i];
                GameObject currentPlace = Instantiate(placePrefab, parentPlace.transform);
                currentPlace.GetComponentInChildren<TextMeshProUGUI>().text = place.name;
                currentPlace.GetComponent<Button>().onClick.AddListener(() => OpenAndSetInfoNV(place.NhanVienSO));
            }
        }
    }
    public void OnClickSortQUAYBAN()
    {
        titleText.text = "Nhân viên quầy bán";
        ResetParentList();
        for (int i = 0; i < gameManager.placeSOList.Count; i++)
        {
            if (gameManager.placeSOList[i].loai == PlaceSO.Type.quaybanhang)
            {
                PlaceSO place = gameManager.placeSOList[i];
                GameObject currentPlace = Instantiate(placePrefab, parentPlace.transform);
                currentPlace.GetComponentInChildren<TextMeshProUGUI>().text = place.name;
                currentPlace.GetComponent<Button>().onClick.AddListener(() => OpenAndSetInfoNV(place.NhanVienSO));
            }
        }
    }
    public void OnClickSortCACTANG()
    {
        
        titleText.text = "Nhân viên các tầng";
        ResetParentList();
        for (int i = 0; i < gameManager.placeSOList.Count; i++)
        {
            if (gameManager.placeSOList[i].loai == PlaceSO.Type.tang)
            {
                PlaceSO place = gameManager.placeSOList[i];
                GameObject currentPlace = Instantiate(placePrefab, parentPlace.transform);
                currentPlace.GetComponentInChildren<TextMeshProUGUI>().text = place.name;
                currentPlace.GetComponent<Button>().onClick.AddListener(() => OpenAndSetInfoNV(place.NhanVienSO));
            }
        }
    }

    public void ResetParentList()
    {
        foreach (Transform child in parentPlace.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void OpenAndSetInfoNV(NhanVienSO nvSO)
    {
        bgCustom.SetActive(true);
        anim.moveOnCustomPanel(customPanel);
        loaiText.text = nvSO.loai.ToString();
        headSkinText.text = nvSO.headSkin.name;
        bodySkinText.text = nvSO.bodySkin.name;
    }    

    public void CloseInfo()
    {
        anim.moveOffCustomPanel(customPanel);
        bgCustom.SetActive(false);
    }


}

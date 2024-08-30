using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class panelCustomScript : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;

    private int currentPosLoaiNV = 0;
    private int currentPosSkinHead = 0;
    private int currentPosSkinBody = 0;

    public TextMeshProUGUI loaiText, headText, bodyText;


    public void NextLoaiNV()
    {
        if (currentPosLoaiNV == gameManager.loaiNVList.Count - 1) currentPosLoaiNV = 0;
        else currentPosLoaiNV++;
    }
    public void PrevLoaiNV()
    {
        if (currentPosLoaiNV == 0) currentPosLoaiNV = gameManager.loaiNVList.Count - 1;
        else currentPosLoaiNV--;
    }

    public void NextHead()
    {
        if (currentPosSkinHead == gameManager.skinHeadSOList.Count - 1) currentPosSkinHead = 0;
        else currentPosSkinHead++;
    }
    public void PrevHead()
    {
        if (currentPosSkinHead == 0) currentPosSkinHead = gameManager.skinHeadSOList.Count - 1;
        else currentPosSkinHead--;
    }

    public void NextBody()
    {
        if (currentPosSkinBody == gameManager.skinBodySOList.Count - 1) currentPosSkinBody = 0;
        else currentPosSkinBody++;
    }
    public void PrevBody()
    {
        if (currentPosSkinBody == 0) currentPosSkinBody = gameManager.skinBodySOList.Count - 1;
        else currentPosSkinBody--;
    }

    public void SaveInfoNV()
    {

    }

    private void Update()
    {
        loaiText.text = gameManager.loaiNVList[currentPosLoaiNV].ToString();
        headText.text = gameManager.skinHeadSOList[currentPosSkinHead].name;
        bodyText.text = gameManager.skinBodySOList[currentPosSkinBody].name;
    }
}

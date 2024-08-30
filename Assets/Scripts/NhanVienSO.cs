using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = ("Create NhanVien SO"))]
public class NhanVienSO : ScriptableObject
{
    public loaiNV loai;
    public SkinHeadSO headSkin;
    public SkinBodySO bodySkin;


    public enum loaiNV
    {
        Cho,
        Meo,
        Ga,
        Heo
    }

}

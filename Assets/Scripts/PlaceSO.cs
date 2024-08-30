using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName =("Create Place SO"))]
public class PlaceSO : ScriptableObject
{
    public Type loai;
    public string name;
    public List<NoiThatSO> NoiThatSO;
    public NhanVienSO NhanVienSO;
    

    public enum Type
    {
        quaybanhang,
        thangmay,
        tang
    }
}

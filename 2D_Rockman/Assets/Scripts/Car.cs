using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("汽車的CC數")]
    [Tooltip("這是汽車的CC數")]
    [Range(0,5000)]
    public int cc = 2000;
    [Header("重量"),Tooltip("汽車的重量"),Range(0.5f,10)]
    public float weignt = 1.5f;
    [Header("汽車品牌")]
    public string brand = "BMW";
    [Header("有沒有天窗")]
    public bool hasWindow = true;


}

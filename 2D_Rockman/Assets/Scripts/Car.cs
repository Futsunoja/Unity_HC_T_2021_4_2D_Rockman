using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("汽車的CC數")]
    [Tooltip("這是汽車的CC數")]
    [Range(0, 5000)]
    public int cc = 2000;
    [Header("重量"), Tooltip("汽車的重量"), Range(0.5f, 10)]
    public float weignt = 1.5f;
    [Header("汽車品牌")]
    public string brand = "BMW";
    [Header("有沒有天窗")]
    public bool hasWindow = true;

    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2my = new Vector2(7, 9);

    public Vector3 v3 = new Vector3(1, 2, 3);
    public Vector4 v4 = new Vector4(1, 2, 3, 4);

    public KeyCode key1;
    public KeyCode key2 = KeyCode.A;
    public KeyCode key3 = KeyCode.Mouse0;  //左0，右1，滾輪2
    public KeyCode key4 = KeyCode.Joystick1Button0;

    public GameObject obj1;

    public Transform tra;  //可儲存含Transform元件的物件
    public SpriteRenderer spr;  //可儲存含SpriteRenderer元件的物件
}

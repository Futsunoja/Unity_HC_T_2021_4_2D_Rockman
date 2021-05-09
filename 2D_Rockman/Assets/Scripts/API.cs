using UnityEngine;

public class API : MonoBehaviour
{
    //靜態API
    //非靜態API

    //1.非靜態API需要物件
    //2.定義一個欄位-物件
    public Transform tra1;
    public Transform tra2;
    public Transform tra3;
    public Camera cam1;
    public SpriteRenderer spr;
    public SpriteRenderer spr2;
    public Rigidbody2D rig1;

    private void Start()
    {
        //靜態
        //類別名稱.靜態屬性
        float f = Random.value;

        //非靜態
        //物件名稱.非靜態屬性
        print("取得物件的座標：" + tra1.position);

        //存放屬性
        //物件名稱.非靜態屬性 指定 值；
        tra2.localScale = new Vector3(3, 3, 3);

        spr.color = new Color(1, 0, 0);
        spr.flipX = true;

        print("攝影機的深度：" + cam1.depth);
        print("圖片顏色：" + spr2.color);

        cam1.backgroundColor = new Color(1, 0, 1);
        spr2.flipY = true;
        //rig1.gravityScale = -1;
    }

    private void Update()
    {
        //非靜態
        //使用方法
        //物件名稱.非靜態方法(對應參數)
        tra2.Translate(0.1f, 0, 0);

        tra3.Rotate(0, 0, 0.1f);
        rig1.AddForce(new Vector2(0,20));
    }
}

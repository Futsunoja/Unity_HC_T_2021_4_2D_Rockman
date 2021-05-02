﻿using UnityEngine;

public class APIStatic : MonoBehaviour
{
    //認是靜態 API
    //包含關鍵字 static 就是靜態

    private void Start()
    {
        //練習取得靜態屬性 Static Properties
        //語法
        //類別名稱.靜態屬性明稱
        float r = Random.value;
        print("隨機值" + r);

        //練習存放靜態屬性 Static Properties
        //有顯示 Read Only 的屬性不能存取
        //語法
        //類別名稱.靜態屬性名稱 指定 值
        Cursor.visible = false;    //指標.可見度
    }
}
using UnityEngine;

public class Car : MonoBehaviour
{
    #region 欄位
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
    #endregion

    #region 事件
    public int number = 1;
    public bool test = false;
    public string prop = "紅色藥水";
    //事件：特定時間會執行的方法
    //Unity提供的事件：開始、更新

    //開始是建：播放遊戲後執行一次
    //應用：數值初始化，例如：遊戲一開始多少金幣或生命值等等
    private void Start()
    {
        //print(任何資料)-輸出資料到Console儀表板上
        print("開始事件");

        //欄位存取
        //取得
        //語法：欄位名稱
        //字串串接：字串 + 其他欄位
        print("取得欄位" + number);

        //存放
        //語法：欄位名稱 指定 值
        //值必須與欄位類型相同
        test = true;
        print("存放欄位後的結果" + test);

        prop = "藍色藥水";
        print("存放後的道具名稱" + prop);

        //呼叫方法
        //方法名稱();
        Test();

        //傳回方法：
        //傳回類型 名稱=傳回方法();
        int t = Ten();
        print("傳回結果" + t);
        Drive50();
        Drive100();
        Drive300();
        //呼叫方法要有相同數量參數
        //有預設值的參數為選填式參數
        Drive(200,"咻咻咻");
        Drive(999, "轟隆隆", "爆炸特效");
        //有多個選填式參數
        Drive(70, "閃電");          //錯誤
        Drive(70, effect: "閃電");  //正確

        float bmi = BMI(1.65f, 65);
        print("BMI：" + bmi);
    }

    //更新事件執行時間點與次數：開始事件後以每秒約六十次執行 60FPS
    //應用：監聽完家輸入與物件持續行為，例如：玩家有沒有按按鈕或讓物件持續移動
    private void Update()
    {
        print("更新事件");
    }
    #endregion

    #region 方法
    //方法：保存較複雜或演算法的程式區塊
    //語法：
    //修飾詞 傳回類型 名稱(){較複雜或演算法的程式區塊}
    //void 無傳回：使用這個方法不會有傳回
    //方法需要被【呼叫】才會執行
    /// <summary>
    /// 測試方法
    /// </summary>
    private void Test()
    {
        print("測試方法");
    }

    //如果不是無傳回void
    //在大括號內必須使用傳回return值(必須跟傳回類型相同)
    
    ///<summary>
    ///傳回整數十的方法
    ///</summary>
    private int Ten()
    {
        return 10;
    }

    //舉例：
    //三個方法 1.以時速50開車 2.時速100 3.時速300
    //加新功能 要有音效
    //加特效
    private void Drive50()
    {
        print("開車時速：" + 50);
        print("開車音效");
    }
    private void Drive100()
    {
        print("開車時速：" + 100);
        print("開車音效");
    }
    private void Drive300()
    {
        print("開車時速：" + 300);
        print("開車音效");
    }

    //用參數解決
    //參數與法：類型 參數名稱
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="sound"></param>
    /// <param name="effect"></param>
    //有預設值的參數只能寫在最右邊
    private void Drive(int speed, string sound = "咻", string effect = "灰塵效果")
    {
        print("開車時速：" + speed);
        print("開車音效：" + sound);
        print("特效：" + effect);
    }

    /// <summary>
    /// BMI值計算
    /// </summary>
    /// <param name="height">身高(公尺)</param>
    /// <param name="weight">體重(公斤)</param>
    /// <returns></returns>
    private float BMI(float height, float weight)
    {
        return weight / (height * height);
    }
    #endregion
}

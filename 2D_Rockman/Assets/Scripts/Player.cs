using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"),Range(0,1000)]
    public float speed = 10.5f;
    [Header("跳越高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("血量"), Range(0, 200)]
    public int hp = 100;
    [Header("是否在地上"), Tooltip("是否接觸地面")]
    public bool isGrounded = false;
    [Header("子彈"), Tooltip("子彈物件")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("生成子彈的地方")]
    public Transform bulletPoint;
    [Range(0, 5000)]
    public float bulletSpeed = 800f;
    [Header("開槍音效"), Tooltip("槍聲")]
    public AudioClip bulletSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    private void Start()
    {
        //利用程式取的方法
        //傳回元件 取得元件<元件名稱>() - <泛型>
        //取得跟腳本同一層的元件
        rig = GetComponent<Rigidbody2D>();
    }

    //一秒約執行60次
    private void Update()
    {
        Move();
        Jump();
    }

    [Header("判斷地板碰撞的位移與半徑")]
    public Vector3 groundOffset;
    public float groundRadius = 0.2f;

    //繪製圖示-輔助編輯時的圖形線條
    private void OnDrawGizmos()
    {
        //1.指定顏色
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //2.繪製圖形
        //transform可以抓到此腳本同一層的變形元件
        Gizmos.DrawSphere(transform.position+groundOffset,groundRadius);
    }

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        //1.玩家按下左右鍵的資訊
        float h = Input.GetAxis("Horizontal");
        //2.使用左右鍵的資訊控制左右
        //剛體.加速度=二為向量(水平*速度*一幀的時間，0)
        rig.velocity = new Vector2(h * speed * Time.deltaTime, rig.velocity.y);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }

    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {
        
    }

    /// <summary>
    /// 傷害
    /// </summary>
    /// <param name="damage"></param>
    private void Hit(float damage)
    {
        
    }

    /// <summary>
    /// 死亡
    /// </summary>
    /// <param name="dead"></param>
    /// <returns></returns>
    private bool Dead()
    {
        return false;
    }

    /// <summary>
    /// 吃道具
    /// </summary>
    /// <param name="prop"></param>
    private void EatProp(string prop)
    {
        print("");
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
}

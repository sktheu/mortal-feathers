using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Components
    [HideInInspector]
    public static Rigidbody2D rb;

    [HideInInspector]
    public static SpriteRenderer spr;

    [HideInInspector]
    public static Animator animator;

    [HideInInspector]
    public static Transform transf;

    [HideInInspector]
    public static Animator anim;


    [HideInInspector]
    public static bool canPlay = true;

    [HideInInspector]
    public static float animSpeed;

    #region Engine Functions
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spr = gameObject.GetComponent<SpriteRenderer>();
        transf = gameObject.GetComponent<Transform>();
        anim = gameObject.GetComponent<Animator>();

        animSpeed = anim.speed;
    }
    #endregion
}

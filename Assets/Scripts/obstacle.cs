using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;

    public float damageThreshhold;
    SpriteRenderer sprite;
    public Color color;
    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sprite = this.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        sprite.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (speed > damageThreshhold)
        {
            die();
        }

        try
        {
            if (collision.gameObject.GetComponent<ball>().speed > damageThreshhold)
            {
                die();
            }
            Debug.Log(collision.gameObject.GetComponent<ball>().speed);
        }
        catch { }

        

        Debug.Log("hit");
    }

    private void die()
    {
        Destroy(this.gameObject);
        Debug.Log("destroy");
    }
}

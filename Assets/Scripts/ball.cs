using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] TrailRenderer trail;

    public float speed
    {
        get { return rb.velocity.magnitude; }
    }

    private void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; 
    }

    public void Shoot(Vector2 _angle, float _power)
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.AddForce(_angle * (_power * 1.5f), ForceMode2D.Impulse);
        trail.emitting = true;
    }
}

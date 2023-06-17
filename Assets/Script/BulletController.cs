using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] float b_speed = 3.0f;
    [SerializeField] float b_lifetime = 5.0f;
    public bool lookingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (lookingRight)
        {
            rb.velocity = Vector2.right * b_speed;
        }
        else
        {
            rb.velocity = Vector2.left * b_speed;
        }

        Destroy(this.gameObject,b_lifetime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

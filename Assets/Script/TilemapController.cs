using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float speed = 5f;

    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        _rb.velocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //����������p�C�v��������
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}

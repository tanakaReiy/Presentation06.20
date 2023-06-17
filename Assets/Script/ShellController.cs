using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    /// <summary>”­Ë‚·‚é‘¬“x</summary>
    [SerializeField] float m_initialSpeed = 5f;
    [SerializeField] GameObject m_effectPrefab = default;


    void Start()
    {
        // Rigidbody ‚ğæ“¾‚µ‚Ä”­Ë‚·‚é
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = this.transform.up * m_initialSpeed;
    }

    void Update()
    {
        // ‰º‚É—‚¿‚½‚ç©•ª©g‚ğ”jŠü‚·‚é
        if (this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Shell") || (collision.gameObject.tag == "Rock") || (collision.gameObject.tag == "Ground"))
        {
            if (m_effectPrefab)
            {
                Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
            }

        }

        Destroy(this.gameObject);
    }
}

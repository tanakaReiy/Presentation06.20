using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    Rigidbody2D _rb;
    private float _h;
    [SerializeField] float _jumpPower;
    [SerializeField] GameObject _gameOverTextGameObject;
    [SerializeField] GameManager _gm;
    [SerializeField] Text _resultScoreText;
    [SerializeField] GameObject _scoreObject;
    [SerializeField] GameObject _allDestroyObject;
    [SerializeField] float _speed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        _h = Input.GetAxisRaw("Horizontal");  // h は Horizontal（水平）の h

        _rb.AddForce(_h * _speed * Vector2.right);
        //_rb.AddForce(_h * _speed * Vector2.left);

        if (Input.GetButtonDown("Jump"))
        {
            //_rb.velocity = Vector2.zero;
            _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }

        //if (Input.GetMouseButtonUp(1))
        //{
        //    Debug.Log("左クリックが離された");
        //}
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scoring")
        {
            _gm._score++;
        }
        //死んだときに呼ばれる
        if (collision.gameObject.tag == "Obstacle")
        {
           _resultScoreText.text = $"Score:{_gm._score}";
            gameObject.SetActive(false);
            _scoreObject.SetActive(false);
            _gameOverTextGameObject.SetActive(true);
            _allDestroyObject.SetActive(true);
        }
    }
}
   








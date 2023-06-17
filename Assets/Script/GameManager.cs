using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _playerObject;
    [SerializeField] GameObject _scoreTextObject;
    [SerializeField] GameObject _pipeManagerObject;
    [SerializeField] GameObject _gameStartButton;
    [SerializeField] GameObject _titleObject;
    [SerializeField] Rigidbody2D _playerRb;
    [SerializeField] GameObject _gameOver;
    [SerializeField] GameObject _allDestroy;
    Vector3 _playerPos;
    //public 他のスクリプトから使えるように
    public int _score = 0;

    void Start()
    {
        //スタートの位置を覚えておく
        _playerPos = _playerObject.transform.position;
    }

    //ボタンコンポーネントから呼び出せるようにpublic
    public void StartButton()
    {
        _playerObject.SetActive(true);
        _scoreTextObject.SetActive(true);
        _pipeManagerObject.SetActive(true);
        _gameStartButton.SetActive(false);
        _titleObject.SetActive(false);
        _allDestroy.SetActive(false);
        //スタート位置にリセット
        _playerObject.transform.position = _playerPos;
        //速度をリセット
        _playerRb.velocity = Vector2.zero;
        //スコアをリセット
        _score = 0;
        //リスタート用に書く
        _gameOver.SetActive(false);
    }
}

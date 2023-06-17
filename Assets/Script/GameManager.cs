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
    //public ���̃X�N���v�g����g����悤��
    public int _score = 0;

    void Start()
    {
        //�X�^�[�g�̈ʒu���o���Ă���
        _playerPos = _playerObject.transform.position;
    }

    //�{�^���R���|�[�l���g����Ăяo����悤��public
    public void StartButton()
    {
        _playerObject.SetActive(true);
        _scoreTextObject.SetActive(true);
        _pipeManagerObject.SetActive(true);
        _gameStartButton.SetActive(false);
        _titleObject.SetActive(false);
        _allDestroy.SetActive(false);
        //�X�^�[�g�ʒu�Ƀ��Z�b�g
        _playerObject.transform.position = _playerPos;
        //���x�����Z�b�g
        _playerRb.velocity = Vector2.zero;
        //�X�R�A�����Z�b�g
        _score = 0;
        //���X�^�[�g�p�ɏ���
        _gameOver.SetActive(false);
    }
}

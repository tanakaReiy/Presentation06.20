using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    /// <summary>�C�e�Ƃ��Đ�������v���n�u</summary>
    [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>�C�����w�肷��</summary>
    [SerializeField] Transform m_muzzle = default;
    AudioSource m_audio = default;
    [SerializeField] GameObject _crosshair;

    [SerializeField] float m_interval = 1f;//���˂̃N�[���^�C��
    float m_timer;//�^�C�}�[

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        this.transform.up = _crosshair.transform.position - this.transform.position;//�J�[�\���ɖC��̌��������킹��
        m_timer += Time.deltaTime;//�o�ߎ���
        if (m_timer > m_interval && Input.GetButtonDown("Fire1"))
        {
            m_timer = 0;//�o�ߎ��ԃ��Z�b�g
            m_audio.Play();
            Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
        }
    }
}
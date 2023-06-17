using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    /// <summary>砲弾として生成するプレハブ</summary>
    [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>砲口を指定する</summary>
    [SerializeField] Transform m_muzzle = default;
    AudioSource m_audio = default;
    [SerializeField] GameObject _crosshair;

    [SerializeField] float m_interval = 1f;//発射のクールタイム
    float m_timer;//タイマー

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        this.transform.up = _crosshair.transform.position - this.transform.position;//カーソルに砲台の向きを合わせる
        m_timer += Time.deltaTime;//経過時間
        if (m_timer > m_interval && Input.GetButtonDown("Fire1"))
        {
            m_timer = 0;//経過時間リセット
            m_audio.Play();
            Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
        }
    }
}
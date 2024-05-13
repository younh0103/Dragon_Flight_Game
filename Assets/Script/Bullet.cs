using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // float moveSpeed = 0.45f;
    float moveSpeed = 1f;

    void Start()
    {
        
    }

    
    void Update()
    {
        // Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 부딫힘.
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);  // 적 지우기.
            Destroy(gameObject);    // 총알(자기자신) 지우기.
        }
    }
}

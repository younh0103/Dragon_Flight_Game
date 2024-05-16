using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // float moveSpeed = 0.45f;
    public float moveSpeed = 1f;
    public GameObject Explosion;

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
            // 폭발 이펙트 생성
            Instantiate(Explosion, transform.position, Quaternion.identity);
            // 사운드 추가.
            SoundManager.instance.SoundDie();
            // 점수 추가.
            GameManager.instance.AddScore(10);
            Destroy(collision.gameObject);  // 적 지우기.
            Destroy(gameObject);    // 총알(자기자신) 지우기.
        }
    }

    // OnBeCameInvisible() : 화면 밖으로 나가서 안보이게 되면 호출이 되는 함수
    private void OnBeCameInvisible()
    {
        // 화면 밖으로 나가면 미사일 지움
        Destroy(gameObject);
    }
}

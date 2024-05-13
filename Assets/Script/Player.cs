using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // 움직이는 속도를 정의.
    public float moveSpeed = 5.0f;

    void Start()
    {

    }

    void Update()
    {
        moveControl();

    }

    void moveControl()
    {
        // 지정한 Axis를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 정함.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // 이동량만큼 실제로 이동을 해주는 함수.
        transform.Translate(distanceX, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy") // 충돌이 적인지 판단.
        {
            // 적을 파괴.
            Destroy(collision.gameObject);

            // 자신도 파괴.
            Destroy(gameObject);
        }
    }
}

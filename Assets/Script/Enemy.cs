using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 움직일 속도를 지정.
    public float moveSpeed = 1.3f;

    void Start()
    {
        
    }

    
    void Update()
    {
        // 움직일 거리를 계산.
        float distanceY = moveSpeed * Time.deltaTime;
        // 움직임을 반영.
        transform.Translate(0, -distanceY, 0);
    }

    private void OnBeCameInvisible()
    {
        // 화면 밖으로 나가면 지움
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject Bullet;   // bullet 프리팹 가져올 변수.

    void Start()
    {
        // InvokeRepeating(함수이름, 초기지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.6f, 0.6f);
    }

    void Shoot()
    {
        // 미사일 프리팹, 런처포지션, 방향값 안줌
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
    
    void Update()
    {
        
    }
}

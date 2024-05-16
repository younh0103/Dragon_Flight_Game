using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject enemy;    // prefab을 받을 public 변수

    // 적을 생성하는 함수
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);  // 적이 나타날 X 좌표를 랜덤으로 생성하기

        if(enableSpawn)
        {
            // 적을 생성. randomX 랜덤한 X값
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        }
    }
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 1);
    }

    
    void Update()
    {
        
    }
}

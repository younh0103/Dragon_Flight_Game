using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 0.8f);  // 0.8초 뒤에 자기자신 지움.
    }

    
    void Update()
    {
        
    }
}

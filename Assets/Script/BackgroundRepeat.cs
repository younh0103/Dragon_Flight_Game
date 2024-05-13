using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    // 스크롤할 속도를 상수로 지정.
    public float scrollSpeed = 1.2f;
    // 쿼드의 머터리얼 데이터를 받아올 객체를 선언.
    private Material thisMaterial;

    void Start()
    {
        // 객체가 생성될 때 최초 1회 호출되는 함수
        // 현재 객체의 Component들을 참조해 Renderer라는 컴포넌트의 Material 정보를 받아옴.

        thisMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // 새롭게 지정해줄 Offset 객체를 선언.
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        // Y 부분에 현재값 y 값에 속도에 프레임 보정을 해서 더해줌.
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));
        // 최종적으로 offset 값을 지정.
        thisMaterial.mainTextureOffset = newoffset;

    }
}

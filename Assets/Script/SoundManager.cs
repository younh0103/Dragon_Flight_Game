using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글톤 : 전역관리 쉬움.
    // 자기 자신을 변수로 담음.
    public static SoundManager instance;

    AudioSource myAudio;    // AudioSource 컴포넌트를 변수로 담음.

    public AudioClip soundExplosion;    // 재생할 소리를 변수로 담음.
    public AudioClip soundDie;

    // Start() 보다도 먼저 객체가 생성될 때 호출.
    void Awake()
    {
        if(SoundManager.instance == null)   // instance가 비어있는지 검사.
        {
            SoundManager.instance = this;   // 자기 자신을 담음.
        }
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();  // AudioSource 컴포넌트 가져오기.
    }

    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
}

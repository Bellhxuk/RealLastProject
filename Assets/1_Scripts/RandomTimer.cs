using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTimer : MonoBehaviour
{
    public Camera mainCamera;
    public bool isClear = false; // 클리어 확인
    public AudioClip clip; // 사운드 파일
    public AudioClip clearSound;

    private AudioSource audioSource;
    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // 만일 카메라 없으면 씬에서 메인 카메라 가져오기
        }
        audioSource = mainCamera.GetComponent<AudioSource>();
        audioSource.clip = clip; 
        StartCoroutine(IntervalTime());
    }

    private void Update()
    {
        if (isClear) // 클리어 변수가 true가 되면 돌고 있는 코루틴 모두 정지
        {
            StopAllCoroutines();
            audioSource.Stop();
            audioSource.clip = clearSound;
            audioSource.Play();
        }
    }

    IEnumerator IntervalTime() // 특정 시간 간격으로 동작하도록 설정
    {
        float rndT = Random.Range(60f, 120f); // Random.Range는 시작, 끝 시간 포함
        yield return new WaitForSeconds(rndT);
        // 여기 아래가 위에서 WaitForSeconds() 안에 들어있는 초 만큼 기다렸다가
        StartCoroutine(CameraShake());
        audioSource.Play();
    }

    IEnumerator CameraShake()
    {
        float t = 0.5f;
        float shakeIntensity = 0.5f;
        float interval = 0.02f;
        Vector3 originCameraPos = mainCamera.transform.position;
        while (t > 0)
        {
            mainCamera.transform.localPosition = originCameraPos + Random.insideUnitSphere * shakeIntensity;
            yield return new WaitForSeconds(interval);
            t -= interval;
        }
        mainCamera.transform.localPosition = originCameraPos;
        StartCoroutine(IntervalTime());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTimer : MonoBehaviour
{
    public Camera mainCamera;
    public bool isClear = false; // Ŭ���� Ȯ��
    public AudioClip clip; // ���� ����
    public AudioClip clearSound;

    private AudioSource audioSource;
    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // ���� ī�޶� ������ ������ ���� ī�޶� ��������
        }
        audioSource = mainCamera.GetComponent<AudioSource>();
        audioSource.clip = clip; 
        StartCoroutine(IntervalTime());
    }

    private void Update()
    {
        if (isClear) // Ŭ���� ������ true�� �Ǹ� ���� �ִ� �ڷ�ƾ ��� ����
        {
            StopAllCoroutines();
            audioSource.Stop();
            audioSource.clip = clearSound;
            audioSource.Play();
        }
    }

    IEnumerator IntervalTime() // Ư�� �ð� �������� �����ϵ��� ����
    {
        float rndT = Random.Range(60f, 120f); // Random.Range�� ����, �� �ð� ����
        yield return new WaitForSeconds(rndT);
        // ���� �Ʒ��� ������ WaitForSeconds() �ȿ� ����ִ� �� ��ŭ ��ٷȴٰ�
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

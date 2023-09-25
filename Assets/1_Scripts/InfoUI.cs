using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    public GameObject infoCanvas;
    public LineRenderer uiLaser;
    public Image img;
    public Text explanation;
    public Text shortExplanation;
    public Text names;
    public string[] explanationString;
    public string[] shortExplanationString;
    public string[] namesString;
    public Sprite[] infoSprites;
    public AudioClip[] TTSSounds;
    AudioSource TtsSource;
    private SceneChanger changer;

    // Start is called before the first frame update
    void Awake()
    {
        changer = GetComponent<SceneChanger>();
    }

    void Start()
    {
        TtsSource = GameObject.Find("Info UI").GetComponent<AudioSource>();
        OffInfoUI();
    }

    public void ShowInfo(int num)
    {
        infoCanvas.SetActive(true);
        Debug.Log("1Clear");
        uiLaser.enabled = true;
        Debug.Log("2Clear");
        img.sprite = infoSprites[num];
        Debug.Log("3Clear");
        explanation.text = explanationString[num];
        Debug.Log("4Clear");
        shortExplanation.text = shortExplanationString[num];
        Debug.Log("5Clear");
        names.text = namesString[num];
        Debug.Log("6Clear");
        changer.objectNum += 1;
        Debug.Log("7Clear");
        TtsSource.clip = TTSSounds[num];
        Debug.Log("8Clear");
        TtsSource.Play();
        Debug.Log("FinalClear");
    }


    public void OffInfoUI()
    {
        uiLaser.enabled = false;
        infoCanvas.SetActive(false);
        TtsSource.Stop();
    }
}

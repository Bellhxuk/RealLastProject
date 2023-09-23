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
    public AudioClip[] ttsSounds;
    AudioSource AudioSource;
    private SceneChanger changer;

    // Start is called before the first frame update
    void Awake()
    {
        changer = GetComponent<SceneChanger>();
    }

    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        OffInfoUI();
    }

    public void ShowInfo(int num)
    {
        infoCanvas.SetActive(true);
        uiLaser.enabled = true;
        img.sprite = infoSprites[num];
        explanation.text = explanationString[num];
        shortExplanation.text = shortExplanationString[num];
        names.text = namesString[num];
        changer.objectNum += 1;
        AudioSource.clip = ttsSounds[num];
        AudioSource.Play();
    }


    public void OffInfoUI()
    {
        uiLaser.enabled = false;
        infoCanvas.SetActive(false);
        AudioSource.Stop();
    }
}

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
    public string[] explanationString;
    public string[] shortExplanationString;
    public Sprite[] infoSprites;

    // Start is called before the first frame update
    void Start()
    {
        OffInfoUI();
    }

    public void ShowInfo(int num)
    {
        infoCanvas.SetActive(true);
        uiLaser.enabled = true;
        img.sprite = infoSprites[num];
        explanation.text = explanationString[num];
        shortExplanation.text = shortExplanationString[num];
    }

    public void OffInfoUI()
    {
        uiLaser.enabled = false;
        infoCanvas.SetActive(false);
    }
}

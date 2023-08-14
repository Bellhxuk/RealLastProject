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
    private SceneChanger changer;

    // Start is called before the first frame update
    void Awake()
    {
        changer = GetComponent<SceneChanger>();
    }

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
        changer.objectNum += 1;
    }

    public void OffInfoUI()
    {
        uiLaser.enabled = false;
        infoCanvas.SetActive(false);
    }
}

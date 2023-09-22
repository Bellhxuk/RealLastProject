using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chap1ListUI : MonoBehaviour
{

    public Sprite changeImg;
    Image thisImg;

    // Start is called before the first frame update
    void Start()
    {
        thisImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ImgChange()
    {
        thisImg.sprite = changeImg;
    }
}

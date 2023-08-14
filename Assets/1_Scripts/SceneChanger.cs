using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject GoOutCanvas;
    public int objectNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        GoOutCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (objectNum == 30)
        {
            GoOutCanvas.SetActive(true);
        }
    }

    public void Change() // °è´Ü ¾À ·Îµå
    {
        SceneManager.LoadScene("Chap1-2Stairs");
    }
}

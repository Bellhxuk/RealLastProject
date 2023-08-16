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
        Scene nowScene = SceneManager.GetActiveScene();
        if (nowScene.name != "Chap1House")
        {
            objectNum = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objectNum == 20)
        {
            GoOutCanvas.SetActive(true);
        }
    }

    public void Change() // ��� �� �ε�
    {
        Scene nowScene = SceneManager.GetActiveScene();
        switch (nowScene.name)
        {
            case "Chap1House":
                SceneManager.LoadScene("Chap1-2Stairs_ver2");
                break;
            case "Chap1-2Stairs":
                SceneManager.LoadScene("Chap2City");
                break;
            case "Chap2City":
                SceneManager.LoadScene("Chap3Subway");
                break;
        }
        //SceneManager.LoadScene("Chap1-2Stairs_ver2");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * 프로젝트 시작하면 주변 막혀있음
 * 휴대폰 클릭하면 UI로 위급 재난문자 띄움
 * UI 닫으면 화면 점점 검게 변함, 밑에 플레이어 대사
 */
public class Chap1_1 : MonoBehaviour
{
    public Image alpha;
    public int alphaNum;
    public GameObject StartCanvas;
    GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        alpha = GetComponent<Image>();
        barrier = GameObject.Find("Chap1-1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OK()
    {
        StartCanvas.SetActive(false);
        Destroy(barrier);

        while (alphaNum < 100)
        {
            alpha.color = new Color(alpha.color.r, alpha.color.g, alpha.color.b, alphaNum) ;
            alphaNum++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * 프로젝트 시작하면 주변 막혀있음
 * 재난문자에 '확인' 누르면 UI 닫힘
 * UI 닫으면 화면 점점 검게 변함, 밑에 플레이어 대사
 * 잠시 후에 화면 다시 밝아짐, 필터 적용
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

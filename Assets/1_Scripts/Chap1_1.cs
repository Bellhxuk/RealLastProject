using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * ������Ʈ �����ϸ� �ֺ� ��������
 * �޴��� Ŭ���ϸ� UI�� ���� �糭���� ���
 * UI ������ ȭ�� ���� �˰� ����, �ؿ� �÷��̾� ���
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

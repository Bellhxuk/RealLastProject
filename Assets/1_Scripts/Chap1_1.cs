using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * ������Ʈ �����ϸ� �ֺ� ��������
 * �糭���ڿ� 'Ȯ��' ������ UI ����
 * UI ������ ȭ�� ���� �˰� ����, �ؿ� �÷��̾� ���
 * ��� �Ŀ� ȭ�� �ٽ� �����, ���� ����
 */
public class Chap1_1 : MonoBehaviour
{
    public Image effectFilter;
    public GameObject StartCanvas;
    GameObject barrier;
    GameObject Effect;

    // Start is called before the first frame update
    void Start()
    {
        Effect = GameObject.Find("Effect");
        effectFilter = GetComponent<Image>();
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
        Effect.GetComponent<FadeEffect>().FadeInEffect();
        effectFilter.color = new Color(effectFilter.color.r, effectFilter.color.g, effectFilter.color.b, 42f);
        Effect.GetComponent<FadeEffect>().FadeOutEffect();

    }
}

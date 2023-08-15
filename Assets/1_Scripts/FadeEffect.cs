using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeEffect : MonoBehaviour
{
    public float fadeDuration = 2.0f;
    public Image image; 

    public void FadeInEffect()
    {
        StartCoroutine(FadeCoroutine(true));
    }

    public void FadeOutEffect()
    {
        StartCoroutine(FadeCoroutine(false));
    }

    private IEnumerator FadeCoroutine(bool isIn)
    {
        float elapsedTime = 0;
        Color startColor = image.color;

        while (elapsedTime < fadeDuration)
        {
            float normalizedTime = elapsedTime / fadeDuration;
            if (!isIn)
            {
                normalizedTime = 1 - normalizedTime;
            }
            Color targetColor = new Color(startColor.r, startColor.g, startColor.b, normalizedTime);

            image.color = targetColor;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Color finalColor = new Color(startColor.r, startColor.g, startColor.b, 0);
        image.color = finalColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    [SerializeField] Color startColor;
    [SerializeField] Color targetColor;
    [SerializeField] Image fadeImage;

    float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 0.0f && elapsedTime <= 1.0f)
        {
            fadeImage.color = Color.Lerp(startColor, targetColor, elapsedTime);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void OnDisable()
    {
        elapsedTime = 0.0f;
    }
}

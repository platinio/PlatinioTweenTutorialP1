using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimationExample : MonoBehaviour
{
    [SerializeField] private Vector2 destPosition = Vector2.zero;
    [SerializeField] private float moveTime = 1.0f;

    private RectTransform rectTransform = null;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        StartCoroutine(DoAnimationRoutine());
    }

    private IEnumerator DoAnimationRoutine()
    {
        float timer = 0.0f;
        Vector2 startPosition = rectTransform.anchoredPosition;

        while (timer < moveTime)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(startPosition , destPosition , timer / moveTime);
            timer += Time.deltaTime;
            yield return null;
        }
    }

}

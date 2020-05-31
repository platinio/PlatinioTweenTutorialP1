using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseExample : MonoBehaviour
{
    [SerializeField] private RectTransform canvas = null;
    [SerializeField] private Vector2 destPosition = Vector2.zero;
    [SerializeField] private float moveTime = 1.0f;
    [SerializeField] private Ease ease = Ease.Linear;

    private RectTransform rectTransform = null;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.MoveUI(destPosition, canvas, moveTime).SetEase(ease);
    }
}

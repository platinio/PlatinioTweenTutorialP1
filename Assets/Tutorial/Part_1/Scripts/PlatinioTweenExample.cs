using UnityEngine;

public class PlatinioTweenExample : MonoBehaviour
{
    [SerializeField] private RectTransform canvas = null;
    [SerializeField] private Vector2 destPosition = Vector2.zero;
    [SerializeField] private float moveTime = 1.0f;

    private RectTransform rectTransform = null;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.MoveUI( destPosition , canvas , moveTime);
    }
}

using DG.Tweening;
using UnityEngine;

public class DOTween_UI_Move : MonoBehaviour
{
    [SerializeField] Vector2 targetPos = new Vector2(0, 0);
    [SerializeField] Vector2 targetPos2 = new Vector2(0, 0);
    [SerializeField] Vector2 targetSize = new Vector2(0, 0);
    [SerializeField] Vector2 targetSize2 = new Vector2(0, 0);
    [SerializeField] bool changeSize = false;
    [SerializeField] bool changeSize2 = false;
    [SerializeField] float tweenTime = 0.6f;

    private RectTransform movingObject;
    private Vector2 originalPos;
    private Vector2 originalSize;

    private void Start()
    {
        movingObject = GetComponent<RectTransform>();
        originalPos = movingObject.anchoredPosition;   // 시작할 때 위치 저장
        originalSize = movingObject.sizeDelta;         // 시작할 때 width/height 저장
    }

    public void moveAway() // targetPos, targetSize로 이동/확대
    {
        if (movingObject != null)
        {
            movingObject.DOAnchorPos(targetPos, tweenTime).SetEase(Ease.OutQuad);
            if (changeSize)
            {
                movingObject.DOSizeDelta(targetSize, tweenTime).SetEase(Ease.OutQuad);
            }
        }
        else
        {
            Debug.LogWarning("movingObject가 할당되지 않았습니다!");
        }
    }

    public void moveAway2() // targetPos, targetSize로 이동/확대
    {
        if (movingObject != null)
        {
            movingObject.DOAnchorPos(targetPos2, tweenTime).SetEase(Ease.OutQuad);
            if (changeSize2)
            {
                movingObject.DOSizeDelta(targetSize2, tweenTime).SetEase(Ease.OutQuad);
            }
        }
        else
        {
            Debug.LogWarning("movingObject가 할당되지 않았습니다!");
        }
    }

    public void moveBack() // 원래 위치, 크기로 복귀
    {
        if (movingObject != null)
        {
            movingObject.DOAnchorPos(originalPos, tweenTime).SetEase(Ease.OutQuad);
            movingObject.DOSizeDelta(originalSize, tweenTime).SetEase(Ease.OutQuad);
        }
        else
        {
            Debug.LogWarning("movingObject가 할당되지 않았습니다!");
        }
    }
}

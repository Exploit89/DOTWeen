using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.blue, 2).SetLoops(-1, LoopType.Yoyo); // делать цвет
        _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo); // делать невидимку
    }
}

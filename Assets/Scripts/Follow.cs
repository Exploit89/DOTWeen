using UnityEngine;
using DG.Tweening;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _targetLastPosition;
    private Tweener _tween;

    private void Start()
    {
        _tween = transform.DOMove(_target.position, 2).SetAutoKill(false); // отключаем автоуничтожение после завершения анимации
        _targetLastPosition = _target.position;
    }

    private void Update()
    {
        if(_targetLastPosition != _target.position)
        {
            _tween.ChangeEndValue(_target.position, true).Restart(); // перезапускаем анимацию
            _targetLastPosition = _target.position;
        }
    }
}

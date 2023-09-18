using UnityEngine;
using DG.Tweening;

public class Mover : AnimationComponent
{
    [SerializeField] private float _endValue;

    private void Start()
    {
        transform.DOMove(transform.position + transform.up * _endValue, _time).SetLoops(-1);
    }
}

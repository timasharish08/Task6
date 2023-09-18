using UnityEngine;
using DG.Tweening;

public class Grower : AnimationComponent
{
    [SerializeField] private float _endValue;

    private void Start()
    {
        transform.DOScale(_endValue, _time).SetLoops(-1);
    }
}

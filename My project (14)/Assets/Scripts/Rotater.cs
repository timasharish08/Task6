using UnityEngine;
using DG.Tweening;

public class Rotater : AnimationComponent
{
    [SerializeField] private float _endValue;

    private void Start()
    {
        transform.DORotate(new Vector3(0, 0, _endValue), _time).SetLoops(-1);
    }
}

using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : AnimationComponent
{
    [SerializeField] private Color _endValue;

    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _renderer.DOColor(_endValue, _time).SetLoops(-1);
    }
}

using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Text))]
public class TextChanger : AnimationComponent
{
    [SerializeField] private string _firstText;
    [SerializeField] private string _secondText;
    [SerializeField] private string _thirdText;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_firstText, _time));
        sequence.Append(_text.DOText(_secondText, _time).SetRelative());
        sequence.Append(_text.DOText(_thirdText, _time, true, ScrambleMode.All));

        sequence.SetLoops(-1);
    }
}

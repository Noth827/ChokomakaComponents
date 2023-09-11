using System.ComponentModel;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Chokomaka.UIs.Animations
{
    public class UIFadeLoop : MonoBehaviour, IAnimationLoopUI
    {
        [SerializeField] private float loopDuration;

        [Description("フェード後のAlphaの値")] [SerializeField]
        private float fadeAlpha;

        [SerializeField] private Ease easeFadeOut;
        [SerializeField] private Ease easeFadeIn;


        private TextMeshProUGUI _renderer;
        private Sequence _sequence;

        private void Awake()
        {
            _renderer = GetComponent<TextMeshProUGUI>();

            _sequence = DOTween.Sequence();
            _sequence.Append(_renderer.DOFade(1f, loopDuration).SetEase(easeFadeIn));
            _sequence.Append(_renderer.DOFade(fadeAlpha, loopDuration).SetEase(easeFadeOut));
            _sequence.SetLoops(-1);
        }

        private void Start()
        {
            _sequence.Play().SetLink(gameObject);
        }
    }
}
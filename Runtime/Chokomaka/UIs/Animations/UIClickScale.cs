using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Chokomaka.UIs.Animations
{
    [RequireComponent(typeof(Button))]
    public class UIClickScale : MonoBehaviour, IAnimationUI
    {
        private Button _button;

        [SerializeField] private float scale = 1.1f;
        [SerializeField] private float animationDuration = 0.15f;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() =>
            {
                transform.DOScale(scale, animationDuration).SetEase(Ease.OutBack).OnComplete(() =>
                {
                    transform.DOScale(1f, animationDuration).SetEase(Ease.OutBack);
                });
            });
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}
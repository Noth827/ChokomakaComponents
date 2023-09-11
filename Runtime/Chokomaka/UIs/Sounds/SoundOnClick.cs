using System;
using AnnulusGames.LucidTools.Audio;
using UnityEngine;
using UnityEngine.UI;

namespace Chokomaka.UIs.Sounds
{
    [RequireComponent(typeof(Button))]
    public class SoundOnClick : MonoBehaviour, ISoundUI
    {
        private Button _button;
        
        [SerializeField] private AudioClip sfx;
        [SerializeField] private float volumeMultiplier = 1f;
        [SerializeField] private float fadeInDuration;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() =>
            {
                LucidAudio.PlaySE(sfx, fadeInDuration).SetVolume(volumeMultiplier);
            });
        }
        
        private void OnDestroy()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}
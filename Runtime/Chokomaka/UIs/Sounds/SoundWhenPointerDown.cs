using AnnulusGames.LucidTools.Audio;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Chokomaka.UIs.Sounds
{
    public class SoundWhenPointerDown : MonoBehaviour, IPointerDownHandler, ISoundUI
    {
        [SerializeField] private AudioClip sfx;
        [SerializeField] private float volumeMultiplier = 1f;
        [SerializeField] private float fadeInDuration;


        public void OnPointerDown(PointerEventData eventData)
        {
            LucidAudio.PlaySE(sfx, fadeInDuration).SetVolume(volumeMultiplier);
        }
    }
}
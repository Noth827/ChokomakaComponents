using AnnulusGames.LucidTools.Audio;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Chokomaka.UIs.Sounds
{
    public class SoundWhenPointerUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ISoundUI
    {
        [SerializeField] private AudioClip sfx;
        [SerializeField] private float volumeMultiplier = 1f;
        [SerializeField] private float fadeInDuration;


        public void OnPointerUp(PointerEventData eventData)
        {
            LucidAudio.PlaySE(sfx, fadeInDuration).SetVolume(volumeMultiplier);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
        }
    }
}
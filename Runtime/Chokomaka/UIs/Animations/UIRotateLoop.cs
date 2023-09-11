using UnityEngine;

namespace Chokomaka.UIs.Animations
{
    public class UIRotateLoop : MonoBehaviour, IAnimationLoopUI
    {
        [SerializeField] private float speed = 10f;

        private void Update()
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }
    }
}
using Chokomaka.UIs.Views.Pops;
using UnityEngine;

namespace Chokomaka.UIs.Examples
{
    public class PopYesNoExample1 : MonoBehaviour
    {
        [SerializeField] private PopYesNo popYesNo;

        private int _counter;

        private void Start()
        {
            var init = Instantiate(popYesNo, transform);
            init.Initialize(
                "Title Example1",
                "Message Example1. Press Yes Button to show number counting up in Debug Log.",
                () => { Debug.Log($"{_counter++}"); },
                () =>
                {
                    Debug.Log("End");
                    Destroy(popYesNo.gameObject);
                },
                true);
        }
    }
}
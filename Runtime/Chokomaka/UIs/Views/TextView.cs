using TMPro;
using UnityEngine;

namespace Chokomaka.UIs.Views
{
    public class TextView : MonoBehaviour, IView<string>
    {
        [SerializeField] private TextMeshProUGUI textMeshPro;
        
        public void SetCurrent(string value)
        {
            textMeshPro.text = value;
        }
    }
}
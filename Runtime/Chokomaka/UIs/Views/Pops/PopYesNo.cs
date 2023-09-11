using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Chokomaka.UIs.Views.Pops
{
    public class PopYesNo : MonoBehaviour, IPop
    {
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private TextMeshProUGUI message;
        [SerializeField] private Button buttonYes;
        [SerializeField] private Button buttonNo;

        /// <summary>
        /// 初期化メソッド
        /// </summary>
        /// <param name="title">ポップのタイトル</param>
        /// <param name="message">ポップの内容</param>
        /// <param name="onYes">Yesを押した時のAction</param>
        /// <param name="onNo">Noを押した時のAction</param>
        /// <param name="destroyManually">呼び出し元が手動でDestroy()を実行するかどうか</param>
        public void Initialize(string title, string message, Action onYes, Action onNo, bool destroyManually = false)
        {
            this.title.text = title;
            this.message.text = message;
            buttonYes.onClick.AddListener(() =>
            {
                onYes?.Invoke();
                if (!destroyManually) Destroy(gameObject);
            });
            buttonNo.onClick.AddListener(() =>
            {
                onNo?.Invoke();
                if (!destroyManually) Destroy(gameObject);
            });
        }

        private void OnDestroy()
        {
            buttonYes.onClick.RemoveAllListeners();
            buttonNo.onClick.RemoveAllListeners();
        }
    }
}
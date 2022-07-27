using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hyno.AR.Vuforia
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("Hyno 圖片")]
        private DefaultObserverEventHandler observerHyno;

        private void Awake()
        {
            observerHyno.OnTargetFound.AddListener(CardFounf);
            observerHyno.OnTargetFound.AddListener(CardLost);
        }

        /// <summary>
        /// 圖片辨識成功
        /// </summary>
        private void CardFounf()
        {
            print("<color=yellow>找到卡片</color>");
        }

        /// <summary>
        /// 圖片辨識失敗
        /// </summary>
        private void CardLost()
        {
            print("<color=yellow>沒找到卡片</color>");
        }
    }
}

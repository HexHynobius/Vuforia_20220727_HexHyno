using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hyno.AR.Vuforia
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField,Header("Hyno �Ϥ�")]
        private DefaultObserverEventHandler observerHyno;

        private void Awake()
        {
            observerHyno.OnTargetFound.AddListener(CardFounf);
            observerHyno.OnTargetFound.AddListener(CardLost);
        }

        /// <summary>
        /// �Ϥ����Ѧ��\
        /// </summary>
        private void CardFounf()
        {
            print("<color=yellow>���d��</color>");
        }

        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>
        private void CardLost()
        {
            print("<color=yellow>�S���d��</color>");
        }
    }
}

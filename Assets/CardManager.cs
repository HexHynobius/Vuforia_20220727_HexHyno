using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Hyno.AR.Vuforia
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("Hyno �Ϥ�")]
        private DefaultObserverEventHandler observerHyno;
        [SerializeField, Header("UChan")]
        private Animator aniUnityChan;
        [SerializeField, Header("���s")]
        private Button butAttack;
        [SerializeField, Header("�������s")]
        private VirtualButtonBehaviour vbbAttack;
        
        private AudioSource audBGM;


        private string parYa = "Ĳ�o";





        private void Awake()
        {
            observerHyno.OnTargetFound.AddListener(CardFounf);
            observerHyno.OnTargetLost.AddListener(CardLost);

            butAttack.onClick.AddListener(Attack);

            vbbAttack.RegisterOnButtonPressed(OnAttackPressed);

            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnAttackPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>����2</color>");
        }





        /// <summary>
        /// �Ϥ����Ѧ��\
        /// </summary>
        private void CardFounf()
        {
            print("<color=yellow>���d��</color>");
            aniUnityChan.SetTrigger(parYa);
            audBGM.Play();
        }

        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>
        private void CardLost()
        {
            print("<color=yellow>�S���d��</color>");
            audBGM.Stop();
        }

        private void Attack()
        {
            print("<color=#9955aa>����!!!</color>");
        }
    }
}

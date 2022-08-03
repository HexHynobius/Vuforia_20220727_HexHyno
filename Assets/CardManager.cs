using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Hyno.AR.Vuforia
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("Hyno 圖片")]
        private DefaultObserverEventHandler observerHyno;
        [SerializeField, Header("UChan")]
        private Animator aniUnityChan;
        [SerializeField, Header("按鈕")]
        private Button butAttack;
        [SerializeField, Header("虛擬按鈕")]
        private VirtualButtonBehaviour vbbAttack;
        
        private AudioSource audBGM;


        private string parYa = "觸發";
        private string parAtt = "攻擊";
        private string parHapa = "拍手";





        private void Awake()
        {
            observerHyno.OnTargetFound.AddListener(CardFounf);
            observerHyno.OnTargetLost.AddListener(CardLost);

            butAttack.onClick.AddListener(Attack);

            vbbAttack.RegisterOnButtonPressed(OnHapaPressed);

            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnHapaPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>拍手</color>");
            aniUnityChan.SetTrigger(parHapa);
        }





        /// <summary>
        /// 圖片辨識成功
        /// </summary>
        private void CardFounf()
        {
            print("<color=yellow>找到卡片</color>");
            aniUnityChan.SetTrigger(parYa);
            audBGM.Play();
        }

        /// <summary>
        /// 圖片辨識失敗
        /// </summary>
        private void CardLost()
        {
            print("<color=yellow>沒找到卡片</color>");
            audBGM.Stop();
        }

        private void Attack()
        {
            print("<color=#9955aa>攻擊!!!</color>");
            aniUnityChan.SetTrigger(parAtt);
        }
    }
}

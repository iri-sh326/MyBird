using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MyBird
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static bool IsStart { get; set; }

        public static bool IsDeath { get; set; }

        public static int Score { get; set; }

        public static int BestScore { get; set; }

        // ���� UI
        public TextMeshProUGUI scoreText;
        #endregion

        private void Start()
        {
            // �ʱ�ȭ
            IsStart = false;
            IsDeath = false;
            Score = 0;
        }

        private void Update()
        {
            // score UI
            scoreText.text = Score.ToString();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyBird
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static bool IsStart { get; set; }
        #endregion

        private void Start()
        {
            // �ʱ�ȭ
            IsStart = false;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace MyBird
{
    public class GameOverUI : MonoBehaviour
    {
        #region Variables
        public TextMeshProUGUI bestScore;
        public TextMeshProUGUI score;
        public TextMeshProUGUI newText;

        [SerializeField] private string loadToScene = "TitleScene";
        #endregion

        private void OnEnable()
        {
            // ���� ������ ����
            GameManager.BestScore = PlayerPrefs.GetInt("BestScore", 0); // ����� ������ ��������
            //Debug.Log($"load BestScore: {loadScore}");

            if (GameManager.Score > GameManager.BestScore)   // ����� �����Ϳ� ���ϱ�
            {
                GameManager.BestScore = GameManager.Score;
                PlayerPrefs.SetInt("BestScore", GameManager.Score);
                newText.text = "NEW";
                //Debug.Log($"Save BestScore: {GameManager.BestScore}");
            }else if(GameManager.Score == GameManager.BestScore)
            {
                newText.text = "SAME";
            }
            else
            {
                newText.text = "";
            }

            // UI ����
            bestScore.text = GameManager.BestScore.ToString();
            score.text = GameManager.Score.ToString();
        }

        public void Retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Menu()
        {
            SceneManager.LoadScene(loadToScene);
        }

    }
}


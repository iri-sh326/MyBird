using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyBird
{
    public class TitleUI : MonoBehaviour
    {
        #region Variables
        [SerializeField] private string loadToScene = "PlayScene";
        #endregion

        private void Update()
        {
            // 치트 - P key
            if (Input.GetKeyDown(KeyCode.P))
            {
                ResetGameData();
                Debug.Log("데이터 리셋!");
            }
        }
        public void Play()
        {
            SceneManager.LoadScene(loadToScene);
        }

        // 치트 - 게임데이터 리셋
        void ResetGameData()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}


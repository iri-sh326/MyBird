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
            // ġƮ - P key
            if (Input.GetKeyDown(KeyCode.P))
            {
                ResetGameData();
                Debug.Log("������ ����!");
            }
        }
        public void Play()
        {
            SceneManager.LoadScene(loadToScene);
        }

        // ġƮ - ���ӵ����� ����
        void ResetGameData()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}


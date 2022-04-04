using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class MainMenu : MonoBehaviour
    {
        public static bool SetLoad;
        private void Start()
        {
            Cursor.visible = true;
        }

        public void PlayGame()
        {
            SetLoad = false;
            SceneManager.LoadScene(1);
        }

        public void Exit()
        {
            Application.Quit();
        }

        public void Load()
        {
            SetLoad = true;
            SceneManager.LoadScene(PlayerPrefs.GetInt("SceneIndex"));
        }
    }
}
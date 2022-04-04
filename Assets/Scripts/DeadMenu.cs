using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class DeadMenu : MonoBehaviour
    {
        [SerializeField] private Text MenuScoreText;
        [SerializeField] private Text MenuCoinsText;
        [SerializeField] private Text MenuStopwatchText;

        private void Awake()
        {
            MenuScoreText.text = "Score: " + PlayerPrefs.GetFloat("MenuScore").ToString("00000");
            MenuCoinsText.text = "Asteroids: " + PlayerPrefs.GetFloat("Asteroids");
            MenuStopwatchText.text = PlayerPrefs.GetString("PlayTime");
        }
        private void Start()
        {
            Cursor.visible = true;
        }

        public void ReturnToGame()
        {
            SceneManager.LoadScene(1);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}
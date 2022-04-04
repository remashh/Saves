using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private Text stopwatchTimeText;
        [SerializeField] private Text coinCountText;
        [SerializeField] private Text scoreText;
        [SerializeField] private Text highScoreText;
        private float _currentTime;
        private float _seconds;
        private float _minutes;
        private static string _currentTimeText;
        private float _pointsPerSecond = 1;
        private float _transitionSpeed = 100;
        private float _displayScore;
        private float _score;
        private float _highScore;
        private float _previousHighScore;
        private float _scoreForCoin = 5f;
        public static float CoinCount;
        
        
        private void Awake()
        {
            if (MainMenu.SetLoad == true)
            {
                _score = PlayerPrefs.GetFloat("MenuScore");
                CoinCount = PlayerPrefs.GetFloat("Coins");
            }
            _highScore = PlayerPrefs.GetFloat("highScore");
            _previousHighScore = _highScore;
            UpdateHighScoreDisplay();
            CoinCount = 0;
        }
        public void IncreaseScoreForCoin()
        {
            IncreaseScore(_scoreForCoin);
            CoinCount++;
            UpdateCoinDisplay();
        }
        
        private void Update()
        {
            IncreaseScore(_pointsPerSecond * Time.deltaTime);
            StopwatchCalculate();
        }

        private void IncreaseScore(float amount)
        {
            _score += amount;
            _displayScore =
                Mathf.MoveTowards(_displayScore, _score, _transitionSpeed * Time.deltaTime);
            UpdateScoreDisplay();
            UpdateHighScore();
        }

        private void UpdateScoreDisplay()
        {
            PlayerPrefs.SetFloat("MenuScore", _score);
            scoreText.text = "Score:" + $"{_displayScore:00000}";
        }

        private void UpdateHighScore()
        {
            if (_highScore < _score)
            {
                _highScore = _score;
                PlayerPrefs.SetFloat("highScore", _highScore);
                UpdateHighScoreDisplay();
            }
        }

        private void UpdateHighScoreDisplay()
        {
            highScoreText.text = "HighScore: " + $"{_highScore:00000}";
        }

        private void UpdateCoinDisplay()
        {
            PlayerPrefs.SetFloat("Coins", CoinCount);
            coinCountText.text = "Coins: " + $"{CoinCount}";
        }

        private void StopwatchCalculate()
        {
            _currentTime += Time.deltaTime;
            _seconds = _currentTime % 60;
            _minutes = _currentTime / 60;
            _currentTimeText = "Time:" + _minutes.ToString("00") + ":" + _seconds.ToString("00");
            stopwatchTimeText.text = _currentTimeText;
            PlayerPrefs.SetString("PlayTime", _currentTimeText);
        }
    }
}
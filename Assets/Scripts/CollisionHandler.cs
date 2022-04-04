using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class CollisionHandler : MonoBehaviour
    {
        public event Action collect;
        private readonly ScoreController _scoreController;
        

        private void Collect()
        {
            _scoreController.IncreaseScoreForCoin();
        }

        public CollisionHandler(ScoreController scoreController)
        {
            _scoreController = scoreController;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                Debug.Log("Collect");
                collect?.Invoke();
                Destroy(other.gameObject);
            }
        }
    }
}
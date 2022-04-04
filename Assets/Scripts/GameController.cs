using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private GameObject _root;
        public CollisionHandler CollisionHandler;
        public ScoreController ScoreController;
        
        private void Start()
        {
            CollisionHandler = _player.GetComponent<CollisionHandler>();
            ScoreController = _root.GetComponent<ScoreController>();
            CollisionHandler.collect += CollisionHandlerOncollect;
        }

        private void CollisionHandlerOncollect()
        {
            ScoreController.IncreaseScoreForCoin();
        }

        private void OnDisable()
        {
            CollisionHandler.collect -= CollisionHandlerOncollect;
        }
    }
}
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _coin;
        public List<GameObject> coins;

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                var spawnPos = new Vector3(Random.Range(-45f, 45f), 0.6f, Random.Range(-45, 45));
                var coin = Instantiate(_coin, spawnPos, Quaternion.identity);
                coin.AddComponent<CollisionHandler>();
                coins.Add(coin);
            }
        }

        private void Update()
        {
            foreach (var coin in coins)
            {
                coin.transform.Rotate(0,2f,0,Space.Self);
            }
        }
    }
}
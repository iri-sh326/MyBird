using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyBird
{
    public class SpawnManager : MonoBehaviour
    {
        #region Variables
        // ������ ������
        public GameObject spawnPrefab;

        // ���� Ÿ�̸�
        [SerializeField] private float spawnTimer = 1.0f;
        private float countdown = 0;

        [SerializeField] private float maxSpawnTimer = 1.05f;
        [SerializeField] private float minSpawnTimer = 0.95f;

        // ���� ��ġ
        [SerializeField] private float maxSpawnY = 3.5f;
        [SerializeField] private float minSpawnY = -1.5f;
        #endregion

        private void Start()
        {
            // �ʱ�ȭ
            countdown = spawnTimer;
        }
        private void Update()
        {
            if(GameManager.IsStart == false || GameManager.IsDeath == true)
                return;

            // ���� Ÿ�̸�
            if(countdown <= 0f)
            {
                // ����
                SpawnPipe();

                // Ÿ�̸� �ʱ�ȭ
                //countdown = spawnTimer;
                countdown = Random.Range(minSpawnTimer, maxSpawnTimer);
            }
            countdown -= Time.deltaTime;
        }

        void SpawnPipe()
        {
            float spawnY = transform.position.y + Random.Range(minSpawnY, maxSpawnY);
            Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, 0f);
            Instantiate(spawnPrefab, spawnPosition, Quaternion.identity);
        }


    }
}


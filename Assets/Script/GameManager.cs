using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region SINGLETON
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null) Debug.LogError("No Game Manager Found!!!");
            }
            return _instance;
        }
    }
    #endregion

    [Header("Box Coin Controller")]
    public int coinSpawn;
    [SerializeField] BoxCoin boxCoinPrefabs;

    [Header("Game area constraint")]
    public float areaConstraintValue = 5f;

    private void Start()
    {
        for (int i = 0; i < coinSpawn; i++)
        {
            BoxCoin coin = Instantiate(boxCoinPrefabs);
            coin.Spawn();
        }
    }

    public Vector2 GetRandomPosition()
    {
        float xPosition = Random.Range(-areaConstraintValue, areaConstraintValue);
        float yPosition = Random.Range(-areaConstraintValue, areaConstraintValue);

        return new Vector2(xPosition, yPosition);
    }
}
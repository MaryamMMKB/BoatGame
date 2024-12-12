using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;
    private int fiskar = 0; 
    private int health = 3;
    public GameObject icePrefab;
    public GameObject fishPrefab;
    public int numberSpawned = 11;
    public float planeSize = 10f;

    void Awake()
    {
        SpawnObjects(icePrefab, numberSpawned);
        SpawnObjects(fishPrefab, numberSpawned);

        void SpawnObjects(GameObject prefab, int count)
        {
            for (int i = 0; i < count; i++) {
                Vector3 randomposition = GetRandomPositionOnPlane();
                Instantiate(prefab, randomposition, Quaternion.identity);
            }
        }
        Vector3 GetRandomPositionOnPlane()
        {
            float x = Random.Range(-planeSize / 2, planeSize / 2);
            float z = Random.Range(-planeSize / 2, planeSize / 2);
            return new Vector3(x, 1f, z); //Höjden över Plane där prefabs spawnar
        }

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    public void AddFisk(int amount)
    {
        fiskar += amount;
        Debug.Log("Antal Fiskar. " + fiskar);
    }
    public void LoseHealth(int amount) { 
    health-= amount;
        Debug.Log("Liv: " +  health);
        if (health <= 0)
        {
            Debug.Log("Du är Död!");
        }
    }

}

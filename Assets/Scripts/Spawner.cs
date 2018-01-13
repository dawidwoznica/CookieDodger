using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	public GameObject[] FoodPrefabs;
	public GameObject BoostPrefab;
	public Vector3 SpawnPositionValues;
	public float FoodSpawnWait;
	public float BoostSpawnWait;

	private bool _playerAlive;

	void Start ()
	{
		_playerAlive = true;
		StartCoroutine(SpawnFood());
		StartCoroutine(SpawnBoosts());
	}
	

	IEnumerator SpawnFood()
	{
		while (_playerAlive)
		{       
			Instantiate(FoodPrefabs[Random.Range(0,FoodPrefabs.Length)], GetSpawnPosition(), GetSpawnRotation());

			yield return new WaitForSeconds(FoodSpawnWait);
		}
	}

	IEnumerator SpawnBoosts()
	{
		while (_playerAlive)
		{
			yield return new WaitForSeconds(BoostSpawnWait);
			
			Instantiate(BoostPrefab, GetSpawnPosition(), GetSpawnRotation());			
		}
	}

	Vector3 GetSpawnPosition()
	{
		return new Vector3(Random.Range(-SpawnPositionValues.x, SpawnPositionValues.x), SpawnPositionValues.y, SpawnPositionValues.z);
	}

	Quaternion GetSpawnRotation()
	{
		return Quaternion.identity;
	}
}

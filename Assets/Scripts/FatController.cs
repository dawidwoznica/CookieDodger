using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FatController : MonoBehaviour
{
	public Slider FatLevelSlider;
	public GameObject PlayerCharacter;
	public float FatLoseSpeed;
	public float NormalPlayerWeight;
	public GameController GameController;
	public float FatResistanceTime;

	private bool _isResistantToFat;

	
	void Update ()
	{
		LetsDoSomeCrossfit();
		CheckPlayerWeight();
	}

	public void Eat(float amountOfFat)
	{
		CheckIfThisCookieCanKillYou(amountOfFat);
		if(!_isResistantToFat)
			FatLevelSlider.value += amountOfFat;
	}

	void LetsDoSomeCrossfit()
	{
		FatLevelSlider.value -= Time.deltaTime * FatLoseSpeed;
		PlayerCharacter.transform.localScale = new Vector3(NormalPlayerWeight + 4 * FatLevelSlider.value, NormalPlayerWeight, (NormalPlayerWeight + 4 * FatLevelSlider.value) / 2);
	}

	void CheckIfThisCookieCanKillYou(float amountOfFat)
	{
		if (!_isResistantToFat && FatLevelSlider.value + amountOfFat > 1.0f)
		{
			FatLevelSlider.value = 1f;
			GameController.LoseGame();
		}
	}

	void CheckPlayerWeight()
	{
		if(FatLevelSlider.value <= 0.0f)
		{
			FatLevelSlider.value = 1f;
			GameController.WinGame();
		}
	}

	public IEnumerator FatResistance()
	{
		_isResistantToFat = true;
		yield return new WaitForSeconds(FatResistanceTime);
		_isResistantToFat = false;
	}
}

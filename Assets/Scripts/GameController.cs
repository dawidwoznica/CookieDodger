using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Image WinGameScreen;
	public Image LoseGameScreen;
	public Button RestartGameButton;
	public Button QuitButton;
	public Text GameTimeText;

	private float _gameTime;

	void Start()
	{
		_gameTime = Time.time;
	}

	public void LoseGame()
	{
		FinishTheGame(LoseGameScreen);
	}

	public void WinGame()
	{
		FinishTheGame(WinGameScreen);
	}

	public void FinishTheGame(Image loadedScreen)
	{
		Time.timeScale = 0f;
		loadedScreen.gameObject.SetActive(true);
		RestartGameButton.gameObject.SetActive(true);
		GameTimeText.gameObject.SetActive(true);
		QuitButton.gameObject.SetActive(true);
		GameTimeText.text = "Your run lasted " + Math.Round(Time.time - _gameTime, 2) + " seconds";
	}
}

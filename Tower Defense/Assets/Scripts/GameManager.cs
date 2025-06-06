using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
	public static bool GameIsOver;

	public GameObject gameOverUI;

	void Start()
	{
		GameIsOver = false;
	}


	// Update is called once per frame
	void Update()
	{
		if (GameIsOver)
			return;

		if (PlayerStats.Lives <= 0)
		{
			EndGame();
		}
	}

	void EndGame()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}

}

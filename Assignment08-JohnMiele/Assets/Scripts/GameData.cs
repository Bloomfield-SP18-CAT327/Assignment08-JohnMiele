using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData {
	public static GameData current;
	public int Bounce;
	public int Score;

	public GameData(){
		Bounce = GameData.current.Bounce;
		Score = GameData.current.Score;
	}
}

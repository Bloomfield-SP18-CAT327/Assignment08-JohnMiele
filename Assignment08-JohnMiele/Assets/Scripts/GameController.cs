using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[Header("Cube and Rigidbody")]
	public GameObject movingCube;
	public Rigidbody movingCubeRB;

	[Header("Variables")]
	public static int score;
	public Text scoreText;
	public static int bounce;
	public Text bounceText;


	// Use this for initialization
	void Start () {
		movingCubeRB = movingCube.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
		bounceText.text = "Bounce count: " + bounce;
	}

	public void IncreaseScore(){
		score += 100;
	}

	public void CubeBounce(){
		bounce++;
		movingCubeRB.velocity = new Vector3 (0, 10, 0);
	}

	public void Load(){
		SaveFile.Load ();
	}

	public void SaveGame(){
		SaveFile.Save ();
	}

	public void resetNumebrs(){
		score = 0;
		bounce = 0;
	}
}

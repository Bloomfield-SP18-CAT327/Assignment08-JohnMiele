using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveFile{

	// Use this for initialization
	public static List<GameData> savedGames = new List<GameData>();

	public static void Save(){
		Debug.Log ("Saving");
		SaveFile.savedGames.Add (GameData.current);
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + Path.DirectorySeparatorChar + "/savedGame.sg");
		bf.Serialize (file, SaveFile.savedGames);
		file.Close ();
		Debug.Log ("Saved");
	}

	public static void Load(){
		Debug.Log ("Loading");
		if (File.Exists (Application.persistentDataPath + Path.DirectorySeparatorChar + "/savedGame.sg")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + Path.DirectorySeparatorChar + "/savedGame.sg", FileMode.Open);
			SaveFile.savedGames = (List<GameData>)bf.Deserialize (file);
			file.Close();
			Debug.Log ("Loaded");
		}
	}
}

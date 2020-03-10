using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo : MonoBehaviour {
	[Space(5f)]
	[Header("Variables")]
	public Level levelInformation;
}

[System.Serializable]
public struct Level {
	public string name;
	public Sprite image;
	[TextArea]
	public string description;
	public MapType mapType;
}

[System.Serializable]
public struct LevelMetadata {
	public string fileName;
	public Level levelFile;
}

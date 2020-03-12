using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LevelMusicManager : MonoBehaviour {
	public GameMusic musicSet;
	public AudioClip overrideMusic;
	public AudioClip overrideXMusic;

	[Space(5f)]
	[Header("Dependencies")]
	public AudioSource normalMusic;
	public AudioSource xMusic;

	//public bool xMusicEnabled;
}

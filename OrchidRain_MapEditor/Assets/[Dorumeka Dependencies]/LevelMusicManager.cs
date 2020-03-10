using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LevelMusicManager : MonoBehaviour {
	[Space(5f)]
	[Header("Dependencies")]
	public AudioSource normalMusic;
	public AudioSource xMusic;

	private AudioSource _currentMusic;

	public bool xMusicEnabled;
	private float _playCounter = 0f;
}

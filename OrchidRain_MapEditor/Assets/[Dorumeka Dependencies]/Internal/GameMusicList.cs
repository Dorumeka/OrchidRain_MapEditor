using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "GameMusicList", menuName = "Game Stats/Game Music List")]
public class GameMusicList : ScriptableObject {
	public GameMusicSet[] musicSets;
}

[System.Serializable]
public struct GameMusicSet {
	public GameMusic setName;
	public AudioClip normalClip;
	public AudioClip xClip;
}
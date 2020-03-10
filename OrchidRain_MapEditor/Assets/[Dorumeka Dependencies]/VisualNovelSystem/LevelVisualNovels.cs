using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "Level_VisualNovels", menuName = "Game Stats/Level Visual Novels")]
public class LevelVisualNovels : ScriptableObject {
	public VN_Dialogue[] dialogues;

	public VN_Dialogue GetDialogue (string name) {
		foreach (VN_Dialogue d in dialogues) {
			if (d.dialogueName == name) return d;
		}
		return new VN_Dialogue();
	}
}

[System.Serializable]
public struct VN_Dialogue {
	public string dialogueName;
	public VN_Line[] sequence;
	public AudioClip dialogueMusic;
}

[System.Serializable]
public struct VN_Line {
	public Sprite image;
	[TextArea] public string text;
	public VisualNovelAnimation animation;
	[Range(-1f, 1f)] public float screenPosition;
}
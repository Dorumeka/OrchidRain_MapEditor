using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemOnDeath : MonoBehaviour {
	[Header("Depemdencies")]
	public DropableItemType dropableItem;

	[Header("Variables")]
	[Range(0f, 1f)]
	public float chanceToDrop;
}

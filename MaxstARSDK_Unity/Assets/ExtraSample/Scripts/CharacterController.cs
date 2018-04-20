using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public Vector3 position;
	public Vector3 scale;
	public Vector3 eulerRotation;

	private GameObject instantTrackable;

	void Start()
	{
		instantTrackable = GameObject.Find("InstantTrackable");

		//transform.localPosition = position;
		//transform.localScale = scale;
		//transform.localRotation = Quaternion.Euler(eulerRotation);

		transform.SetParent(instantTrackable.transform, false);

		Debug.Log("Set transform");
	}
}

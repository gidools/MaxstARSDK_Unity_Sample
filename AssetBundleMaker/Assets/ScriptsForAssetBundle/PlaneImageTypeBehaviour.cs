using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneImageTypeBehaviour : MonoBehaviour
{
	void Start()
	{
		Canvas canvas = FindObjectOfType<Canvas>();
		if (canvas != null)
		{
			transform.SetParent(canvas.transform, false);
		}
	}
}

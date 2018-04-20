using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwap : MonoBehaviour
{
	public bool enableSpriteSwap = false;
	public float swapInterval = 0.5f;
	public List<Sprite> spriteList;

	private Image imageComponent;

	void Start()
	{
		imageComponent = GetComponent<Image>();

		if (enableSpriteSwap)
		{
			StartCoroutine(SpriteSwapCoroutine(swapInterval));
		}
	}

	private IEnumerator SpriteSwapCoroutine(float interval)
	{
		int index = 0;

		while(true)
		{
			yield return new WaitForSeconds(interval);
			if (index < spriteList.Count)
			{
				imageComponent.sprite = spriteList[index];
			}

			index++;

			if (index == spriteList.Count)
			{
				index = 0;
			}
		}
	}
}

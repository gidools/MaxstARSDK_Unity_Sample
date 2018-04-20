using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSwap : MonoBehaviour
{
	public bool enableTextureSwap = false;
	public float textureSwapInterval = 0.5f;
	public List<Texture2D> textureList;

	private Material thisMaterial;

	void Start()
	{
		thisMaterial = GetComponent<Renderer>().material;

		if (enableTextureSwap)
		{
			StartCoroutine(TextureSwapCoroutine(textureSwapInterval));
		}
	}

	private IEnumerator TextureSwapCoroutine(float interval)
	{
		int index = 0;

		while(true)
		{
			yield return new WaitForSeconds(interval);
			if (index < textureList.Count)
			{
				thisMaterial.mainTexture = textureList[index];
			}

			index++;

			if (index == textureList.Count)
			{
				index = 0;
			}
		}
	}
}

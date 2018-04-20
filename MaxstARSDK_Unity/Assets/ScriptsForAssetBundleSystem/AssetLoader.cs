using UnityEngine;
using System.Collections;

public class AssetLoader : BaseLoader {

	public void LoadAssetBundle(string assetBundleName)
	{
		StartCoroutine(Load(assetBundleName));
	}

	// Use this for initialization
	IEnumerator Load(string assetBundleName)
	{
		string assetFileName = assetBundleName;
		string assetName = assetBundleName;
		yield return StartCoroutine(Initialize());

		// Load asset.
		yield return StartCoroutine(Load(assetBundleName, assetName));

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(assetBundleName);
	}

	void OnDestroy()
	{
		AssetBundleManager[] assetLoaderObject = GameObject.FindObjectsOfType<AssetBundleManager>();
		foreach (AssetBundleManager assetBundleManager in assetLoaderObject)
		{
			Destroy(assetBundleManager.gameObject);
		}
	}
}

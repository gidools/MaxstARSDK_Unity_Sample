using UnityEngine;
using System.Collections;

public class AssetLoader : BaseLoader {

	public string assetBundleName;
	public string assetName;

	// Use this for initialization
	IEnumerator Start()
	{

		yield return StartCoroutine(Initialize());

		// Load asset.
		yield return StartCoroutine(Load(assetBundleName, assetName));

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(assetBundleName);
	}
}

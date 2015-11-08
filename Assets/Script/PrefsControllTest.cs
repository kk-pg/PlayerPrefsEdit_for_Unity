using UnityEngine;
using System.Collections;

public class PrefsControllTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("testStr", "テスト文字列");
        PlayerPrefs.SetInt("testInt", 111111);
        PlayerPrefs.SetFloat("testFloat", 1.1111f);
        PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onClickDispPrefs()
    {
        Debug.Log(PlayerPrefs.GetString("testStr"));
        Debug.Log(PlayerPrefs.GetInt("testInt"));
        Debug.Log(PlayerPrefs.GetFloat("testFloat"));
    }
}

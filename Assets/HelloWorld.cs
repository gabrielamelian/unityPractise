using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	public string text = "Hello world";
	public bool turnOn = true;
	public float posX = 5.0f;
	public int intTest = 5;
	public string[] names;

	// Use this for initialization
	void Start () {
		text = Test("Calling Test()"); //"Updated during start()";
		print("hello world");
	}

	// Update is called once per frame
	void Update () {

	}

	string Test (string value) {
		return value + "Updated during test()";
	}
}

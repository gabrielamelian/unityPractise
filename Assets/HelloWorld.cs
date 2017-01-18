using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld : MonoBehaviour {

	public string text = "Hello world";
	public bool turnOn = true;
	public float posX = 5.0f;
	public int intTest = 5;
	string[] names = new string[]{"Jesse", "Freeman"};
	List<string> animals = new List<string>(){"dog", "cat"};

	Dictionary<string, string> weapons = new Dictionary<string, string>();

	// Use this for initialization
	void Start () {
		animals.Add ("fish");
		animals.Add ("bird");

		animals.Remove ("bird");

		print ("List to Array length " + animals.ToArray().Length);
		// names [0] = "Jesse";
		// text = Test("Calling Test()"); //"Updated during start()";
		print ("First name " + names[0]);
		print ("Total names " + names.Length);

		print ("Total animals " + animals.Count);
		print ("Animal 1 " + animals[0]);
		print ("Last animal 1 " + animals[animals.Count-1]);

		weapons.Add("slot1", "sword");

		print ("Weapon in slot 1 " + weapons["slot1"]);
		print ("Slot 2 equiped " + weapons.ContainsKey("slot2"));
	}

	// Update is called once per frame
	void Update () {

	}

	string Test (string value) {
		return value + "Updated during test()";
	}
}

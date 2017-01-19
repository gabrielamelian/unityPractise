using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MyGame;

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

		Player cc = new Player ();

		print (cc.health + "/" + cc.maxHealth);

		print ("Health " + cc.CurrentHealthPercent() + "%");

		animals.Add ("fish");
		animals.Add ("bird");

		animals.Remove ("bird");
		//
		// print ("List to Array length " + animals.ToArray().Length);
		names [0] = "Jesse";
		text = Test("Calling Test()"); //"Updated during start()";
		// print ("First name " + names[0]);
		// print ("Total names " + names.Length);
		//
		// print ("Total animals " + animals.Count);
		// print ("Animal 1 " + animals[0]);
		// print ("Last animal 1 " + animals[animals.Count-1]);
		//
		weapons.Add("slot1", "sword");
		weapons.Add("slot2", "dagger");
		//
		// print ("Weapon in slot 1 " + weapons["slot1"]);
		// print ("Slot 2 equiped " + weapons.ContainsKey("slot2"));

		// ConditionTest ();
		// LoopTest();
	}

	// Update is called once per frame
	void Update () {

	}

	string Test (string value) {
		return value + "Updated during test()";
	}

	void ConditionTest(){

		string name = "Marlon";

		if (name == "Jesse") {
			print ("Name is Jesse");
		} else if (name == "Freeman"){
			print ("Name is Freeman");
		} else {
			print ("Name is not Jesse");
		}

		int health = 0;

		bool isDead = health <= 0;

		print ("is dead " + isDead);

		if (isDead)
			print ("Player is dead");

		string mode = isDead == true ? "Game over" : "Is Playing";

		print ("Game Mode " + mode);
	}

	void LoopTest(){

		for (int i = 0; i < 10; i ++) {
			print ("Loop " + i);
		}

		for (int i = 10; i > 0; i --) {
			print ("Loop " + i);
		}

		for (int i = 0; i < names.Length; i++){
			print ("Name " + i + " " + names [i]);
		}

		foreach(string name in animals){
			print (name);
		}

		foreach (var item in weapons) {
			print (item.Key + " " + item.Value);
		}
	}
}

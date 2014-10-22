﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CC10Shell : Ammunition 
{
	static public string Short = "10cc Shells";
	static public string Long = "A bundle of 10cc ballistic shells.";
	static public int Velocity = 5;//Affects accuracy, power degredation
	static public List<string> Compatible = new List<string>() {"TC-10", "AC-10"};
	static public float Combustibility = 0.1f;
	static public int Bundle = 8;
	public CC10Shell()
	{
		PrefabID = "Bullet";
		Amount = Bundle;
		DamageType = "ballistic";
		Damage = 200;
	}
}
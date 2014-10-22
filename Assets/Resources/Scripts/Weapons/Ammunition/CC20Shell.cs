﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CC20Shell : Ammunition 
{
	static public string Short = "20cc Shells";
	static public string Long = "A bundle of 15cc ballistic shells.";
	static public int Velocity = 2;//Affects accuracy, power degredation
	static public List<string> Compatible = new List<string>() {"TC-20"};
	static public float Combustibility = 0.2f;
	static public int Bundle = 3;
	public CC20Shell()
	{
		PrefabID = "Bullet";
		Amount = Bundle;
		DamageType = "ballistic";
		Damage = 400;
	}
}
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CC15Shell : Ammunition 
{
	static public string Short = "15cc Shells";
	static public string Long = "A bundle of 15cc ballistic shells.";
	static public int Velocity = 3;//Affects accuracy, power degredation
	static public List<string> Compatible = new List<string>() {"TC-15", "AC-15"};
	static public float Combustibility = 0.15f;
	static public int Bundle = 5;
	public CC15Shell()
	{
		PrefabID = "Bullet";
		Amount = Bundle;
		DamageType = "ballistic";
		Damage = 300;
	}
}
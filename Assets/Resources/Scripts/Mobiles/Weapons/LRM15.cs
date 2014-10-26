﻿using UnityEngine;
using System.Collections;

public class LRM15 : Weapon 
{
	public string Short = "LRM-15";
	public string Long = "A missile battery that stores up to 15 long-range missiles.";
	public int Capacity = 15;
	public int RateOfFire = 5;
	public List<string> Ammo = new List<string>() {"A-1 Missile"};
	public string[] Compatibility = new string[] {"head", "left arm", "right arm", "left leg", "right leg", "left torso", "right torso", "center torso"};
	public LRM15()
	{
		Energy = new Dictionary<string,int>() {{"fire",15}, {"reload",15}};
		SetMass(6.0f);
	}
}
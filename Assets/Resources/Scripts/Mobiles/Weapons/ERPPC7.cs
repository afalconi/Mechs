﻿using UnityEngine;
using System.Collections.Generic;

public class ERPPC7 : Weapon 
{
	public int RateOfFire = 1;
	public string[] Compatibility = new string[] {"head", "left arm", "right arm", "left leg", "right leg", "left torso", "right torso", "center torso"};
	public ERPPC7()
	{
		Short = "ERPPC-7";
		Long = "An extended range particle projection cannon.";
		Capacity = 1;
		Ammo = new List<string>() {};
		Energy = new Dictionary<string,float>() {{"fire",80.0f}};
		SetMass(8.0f);
	}
}

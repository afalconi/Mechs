﻿using UnityEngine;
using System.Collections.Generic;

public class LeftLeg : Part
{
	public LeftLeg () 
	{
		Short = "left leg";
		HitTable = new Dictionary<string,int>() {{"front", 4}, {"left", 5}, {"right", 2}};
		Proportion["ratio"] = 0.14f;
		Melee.Add("kick");
	}
	public float[] GetFiringArc()
	{
		float[] arc = {285.0f, 0.0f};
		return arc;
	}
	public int GetMeleeCR()
	{
		return 0;
	}
	//handle movement with actuators and balance withi foot actuators and rotation with hip actuators and torso twist
}
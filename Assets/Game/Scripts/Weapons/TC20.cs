﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TC20 : Weapon 
{
	public string Short = "TC-20";
	public string Long = "A tactical cannon that fires 20cc shells.";
	public int Capacity = 1;
	public List<string> Compatible = new List<string>() {"20cc Shell"};
	public TC20()
	{
		SetMass(10.0f);
	}
}

using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using uFrame.Attributes;
using System;

[ActionLibrary, uFrameCategory("Boolean")]
public static class BooleanUtils {

	public static bool toggle(bool value){
		return !value;
	}

	public static void  doSth(bool value, Vector2 danything){
	}

	public static void someActions(bool value, Action first, Action secon){
		if (value) {
			first.Invoke ();
		} else {
			secon.Invoke ();
		}
	}

	public static void giveTwoNumbers(out int first, out int second){
		first = 3;
		second = 5;
	}
		

}

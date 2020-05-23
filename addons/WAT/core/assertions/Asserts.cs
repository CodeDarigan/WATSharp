using Godot;
using System;

public class Asserts : Reference
{
	
	public Reference assertions;
	
	public Asserts()
	{
		String path = "res://addons/WAT/core/assertions/assertions.gd";
		Godot.Script script = (Godot.Script)ResourceLoader.Load(path);
		assertions = (Reference)script.Call("new");
	}
	
	public void IsTrue(bool a, String context = "")
	{
		assertions.Call("is_true", a, context);
	}
	
	public void IsFalse(bool a, String context = "")
	{
		assertions.Call("is_false", a, context);
	}
	
}
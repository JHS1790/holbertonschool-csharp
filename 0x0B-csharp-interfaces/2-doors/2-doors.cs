using System;

abstract class Base
{
	public string name = "";

	public override string ToString()
	{
		return $"{this.name} is a {this.GetType()}";
	}
}

class Door : Base, IInteractive
{
	public void Interact()
	{
		Console.WriteLine($"You try to open the {this.name}. It's locked.");
	}

	public Door(string Name = "Door")
	{
		this.name = Name;
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }

	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }

	void Collect();
}

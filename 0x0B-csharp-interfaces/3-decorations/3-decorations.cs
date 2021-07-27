using System;

abstract class Base
{
	public string name  { get; set; }

	public override string ToString()
	{
		return $"{this.name} is a {this.GetType()}";
	}
}

class Decoration : Base, IInteractive, IBreakable
{
	public int durability { get; set; }

	public bool isQuestItem;

	public void Break()
	{
		this.durability--;
		if (this.durability > 0)
			Console.WriteLine($"You hit the {this.name}. It cracks.");
		else if (this.durability == 0)
			Console.WriteLine($"You smash the {this.name}. What a mess.");
		else
			Console.WriteLine($"The {this.name} is already broken.");
	}
	public void Interact()
	{
		if (this.durability <= 0)
			Console.WriteLine($"The {this.name} has been broken.");
		else if (isQuestItem == true)
			Console.WriteLine($"You look at the {this.name}. There's a key inside.");
		else
			Console.WriteLine($"You look at the {this.name}. Not much to see here.");
	}

	public Decoration(string Name = "Decoration", int Durability = 1, bool QuestItem = false)
	{
		if (Durability <= 0)
			throw new Exception("Durability must be greater than 0");
		this.name = Name;
		this.durability = Durability;
		this.isQuestItem = QuestItem;
	}
}

class Door : Base, IInteractive
{
	public void Interact()
	{
		Console.WriteLine($"You try to open the {this.name}. It's locked.");
	}

	public Door(string Name)
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

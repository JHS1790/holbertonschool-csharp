using System;

class Player
{
	private string name;

	private float maxHp;
	
	public float hp;


	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
		{
			this.maxHp = maxHp;
		}
		this.name = name;
		this.hp = this.maxHp;
	}

	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}
	
	public delegate void CalculateHealth(float h);
	public void TakeDamage(float damage)
	{
		if (damage > 0)
		{
			Console.WriteLine($"{this.name} takes {damage} damage!");
			this.hp -= damage;
		}
		else
		{
			Console.WriteLine($"{this.name} takes 0 damage!");
		}
	}
	public void HealDamage(float heal)
	{
		if (heal > 0)
		{
			Console.WriteLine($"{this.name} heals {heal} hp!");
			this.hp += heal;
		}
		else
		{
			Console.WriteLine($"{this.name} heals 0 hp!");
		}
	}
}

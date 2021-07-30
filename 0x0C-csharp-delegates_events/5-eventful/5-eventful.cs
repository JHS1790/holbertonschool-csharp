using System;

///<summary>Interminably based</summary>
public enum Modifier
{
	///<summary>unfathombly</summary>
	Weak,
	///<summary>uncontrollably</summary>
	Base,
	///<summary>based</summary>
	Strong
}

///<summary>so they said welcome aboard</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs
{
	public float currentHp;

	public CurrentHPArgs(float newHp)
	{
        this.currentHp = newHp;
	}
}

class Player
{
	private string name;

	private float maxHp;
	
	public float hp;

	private string status;


	public Player(string name = "Player", float maxHp = 100f)
	{
		this.status = $"{this.name} is ready to go!";
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
		HPCheck += CheckStatus;
	}

	public void PrintHealth()
	{
		Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
	}
	
	public delegate void CalculateHealth(float h);
	public void TakeDamage(float damage)
	{
		float tempHp = this.hp;
		
		if (damage > 0)
		{
			Console.WriteLine($"{this.name} takes {damage} damage!");
			tempHp -= damage;
		}
		else
		{
			Console.WriteLine($"{this.name} takes 0 damage!");
		}

		ValidateHP(tempHp);
	}
	public void HealDamage(float heal)
	{
		float tempHp = this.hp;

		if (heal > 0)
		{
			Console.WriteLine($"{this.name} heals {heal} HP!");
			tempHp += heal;
		}
		else
		{
			Console.WriteLine($"{this.name} heals 0 HP!");
		}

		ValidateHP(tempHp);
	}

	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
		{
			this.hp = 0;
		}
		else if (newHp > this.maxHp)
		{
			this.hp = this.maxHp;
		}
		else
		{
			this.hp = newHp;
		}
		OnCheckStatus(new CurrentHPArgs(this.hp));
	}

	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
		{
			return (baseValue / 2);
		}
		else if (modifier == Modifier.Base)
		{
			return (baseValue);
		}
		else
		{
			return (baseValue * 1.5f);
		}
	}

	EventHandler<CurrentHPArgs> HPCheck = (sender, eventArgs) => {};

	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == this.maxHp)
		{
			Console.WriteLine($"{this.name} is in perfect health!");
		}
		else if (e.currentHp >= this.maxHp / 2 && e.currentHp < this.maxHp)
		{
			Console.WriteLine($"{this.name} is doing well!");
		}
		else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
		{
			Console.WriteLine($"{this.name} isn't doing too great...");
		}
		else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
		{
			Console.WriteLine($"{this.name} isn't doing too great...");
		}
		else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4)
		{
			Console.WriteLine($"{this.name} needs help!");
		}
		else
		{
			Console.WriteLine($"{this.name} is knocked out!");
		}
	}

	private void HPValueWarning(object sender, CurrentHPArgs e)
	{
		if (e.currentHp == 0)
		{
			Console.WriteLine("Health has reached zero!");
		}
		else
		{
			Console.WriteLine("Health is low!");
		}
	}

	private void OnCheckStatus(CurrentHPArgs e)
	{
		if (e.currentHp <= this.maxHp / 4)
		{
			HPCheck += HPValueWarning;
		}
		else
		{
			HPCheck -= HPValueWarning;
		}

		HPCheck(this, e);
	}
}

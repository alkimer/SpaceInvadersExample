using UnityEngine;

public class LifeBar
{
    public int Health { get; private set; } = 100;
    private bool HasShield { get; set; } = false;
    private bool Poisoned { get; set; } = false;

    public LifeBar(int health)
    {
        Health = health;
    }
    
    public LifeBar() {}
    
    public void IncrementHealth(int ammount)
    {
        if (Health <= 100)
        {
            Health = Mathf.Min(100, Health + ammount);
        }
    }

    public void DecreaseHealth(int ammount)
    {
        if (!HasShield)
        {
            Health = Mathf.Max(0, Health - (Poisoned ? (2 * ammount) : ammount));
        }
        else
        {
            HasShield = false;
        }
    }

  /*  public void UseMagicPotion()
    {
        Health += 50;
    }*/

    public void AddShield()
    {
        HasShield = true;
    }
/*
    public void Poison()
    {
        Poisoned = true;
    }*/
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string title { get; set; }
    public float durability { get; set; }

    public void setTitleDurability(string title, float durability)
    {
        this.title = title;
        this.durability = durability;
    }
}

public class Food : Item
{
    public float Hunger { get; set; }
    public float Thirst { get; set; }

    public void setHungerThirst(float hunger, float thirst)
    {
        this.Hunger = hunger;
        this.Thirst = thirst;
    }
}

public class MidKit : Item
{
    public float Mind { get; set; }
    public float Health { get; set; }

    private string[] effects = new string[] { };

    public string getEffect(int index)
    {
        return effects[index];
    }

    public void setEffect(int index, string inputEffect)
    {
        effects[index] = inputEffect;
    }

    public void setAllEffects(string[] inputArray)
    {
        effects = inputArray;
    }

    public void setMindHealth(float mind, float health)
    {
        this.Mind = mind;
        this.Health = health;
    }
}

public class Weapon : Item
{
    public float damage { get; set; }

    public void setDamage(float damage)
    {
        this.damage = damage;
    }
}

public class Inventory
{
    public static int getLengthList()
    {
        return Stats.inventory.Count;
    }

    public static void addItemList(string title, float durability)
    {
        Item tempVariable = new Item();
        tempVariable.setTitleDurability(title, durability);
        Stats.inventory.Add(tempVariable);
    }

    public static void addFoodList(string title, float durability, float hunger, float thirst)
    {
        Food tempVariable = new Food();
        tempVariable.setTitleDurability(title, durability);
        tempVariable.setHungerThirst(hunger, thirst);
        Stats.inventory.Add(tempVariable);
    }

    public static void addMidkitList(
        string title,
        float durability,
        float mind,
        float health,
        string[] effects
    )
    {
        MidKit tempVariable = new MidKit();
        tempVariable.setTitleDurability(title, durability);
        tempVariable.setMindHealth(mind, health);
        tempVariable.setAllEffects(effects);
        Stats.inventory.Add(tempVariable);
    }

    public static void addWeaponList(string title, float durability, float damage)
    {
        Weapon tempVariable = new Weapon();
        tempVariable.setTitleDurability(title, durability);
        tempVariable.setDamage(damage);
        Stats.inventory.Add(tempVariable);
    }

    public static Item getItemList(int index)
    {
        return Stats.inventory[index];
    }

    public static Item getItemTypeList(Item inputItemType)
    {
        bool tmepVariable = false;
        for (int i = 0; i < getLengthList(); i++)
        {
            if (getItemList(i).GetType() == inputItemType.GetType())
            {
                tmepVariable = true;
            }
        }
        if (tmepVariable == true)
        {
            return inputItemType;
        }
        else
        {
            return null;
        }
    }
}

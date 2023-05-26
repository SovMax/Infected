using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string title { get; set; }
    public float durability { get; set; }
}

public class Food : Item
{
    public float increaceHunger { get; set; }
    public float increaceThirst { get; set; }
}

public class MidKit : Item
{
    public float increaceMind { get; set; }
    public float increaceHealth { get; set; }

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
}

public class Weapon : Item
{
    public float damage { get; set; }
}

public class Inventory
{ //Переделать механику добавления и хранения предметов в двумерный массив
    public static void addItemList(string title, float durability)
    {
        int length = Stats.inventory.Count;
        Stats.inventory.Add(new Item());
        Stats.inventory[length].title = title;
        Stats.inventory[length].durability = durability;
    }

    public static void addFoodList(
        string title,
        float durability,
        float increaceHunger,
        float increaceThirst
    )
    {
        int length = Stats.inventory.Count;
        Food tempVariable = new Food();
        tempVariable.title = title;
        tempVariable.durability = durability;
        tempVariable.increaceHunger = increaceHunger;
        tempVariable.increaceThirst = increaceThirst;
        Stats.inventory.Add(tempVariable);
    }

    public static void addMidkitList(
        string title,
        float durability,
        float increaceMind,
        float increaceHealth,
        string[] effects
    )
    {
        int length = Stats.inventory.Count;
        MidKit tempVariable = new MidKit();
        tempVariable.title = title;
        tempVariable.durability = durability;
        tempVariable.increaceMind = increaceMind;
        tempVariable.increaceHealth = increaceHealth;
        tempVariable.setAllEffects(effects);
        Stats.inventory.Add(tempVariable);
    }

    public static void addWeaponList(string title, float durability, float damage)
    {
        int length = Stats.inventory.Count;
        Weapon tempVariable = new Weapon();
        tempVariable.title = title;
        tempVariable.durability = durability;
        tempVariable.damage = damage;
        Stats.inventory.Add(tempVariable);
    }

    public static Item getItemList(int index)
    {
        return Stats.inventory[index];
    }
}

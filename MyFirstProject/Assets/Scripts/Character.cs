using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp;

    public Character()
    {
        this.name = "Name not given";
        this.exp = 0;
    }

    public Character(string newCharacterName)
    {
        this.name = newCharacterName; //""This"" is not really needed here, but it cannot hurt
    }

    public Character(string name, int exp)
    {
        this.name = name; //This is badly needed here, to differentate
        this.exp = exp; //Between inputparameter of the method and internal variable
    }

    public virtual void printStatsInfo()
    {
        Debug.LogFormat("Character: {0} - {1} EXP", this.name, this.exp);
    }

    public string GetCharacterName()
    {
        return this.name;
    }

}
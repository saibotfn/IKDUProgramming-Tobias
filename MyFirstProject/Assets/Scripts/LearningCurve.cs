using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character( "", 500);

        Character nicerHero = new Character("Nice Name");

        Character jamesBond = new Character("James Bond", 100);
        

        hero.printStatsInfo();
        nicerHero.printStatsInfo();
        jamesBond.printStatsInfo();


        //string characterName = jamesBond.name; //DO NOT USE THIS LINE, BAD PRACTICE!
        string myFavoriteCharacterName = jamesBond.GetCharacterName();
        Debug.Log("My favorite character is " + myFavoriteCharacterName);

        nicerHero = jamesBond;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

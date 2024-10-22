using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    public int currentAge = 20;
    public int ageIncrease = 5;
    bool isFunny = true;
    //string myName = "Tobias";
    //string mySecondName = "Nielsen";
    public int a = 512;
    public int b = 731;
    int d0 = 10;
    int d1 = 20;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.LogFormat("The initial values are: a={0}, b={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Debug.LogFormat("The swapped values are: a={0}, b={1}", a, b);



        (a, b) = Swap(a, b);
        Debug.LogFormat("The double swapped a and b values with the swap method are: a={0}, b={1}", a, b);

        Debug.LogFormat("The initial values are: d0={0}, d1={1}", d0, d1);
        (d0, d1) = Swap(d0, d1);
        Debug.LogFormat("The swapped values are: d0={0}, d1={1}", d0, d1);

        (int m1, int m2) = Swap(1, 7);
        Debug.LogFormat("swapping 1 and 7 with the swap method: {0}, {1}", m1, m2);

        (float f1, float f2) = Swap(1.5f, 7.3f);
        Debug.LogFormat("swapping 1.5 and 7.3 with the swap float method: {0}, {1}", f1, f2);
        */
        (currentAge) = AgeIncreasedMethod(currentAge);
        Debug.Log("This is your age next year " + currentAge);

        (currentAge, ageIncrease) = AgeIncreasedMethod(currentAge, ageIncrease);
        Debug.LogFormat("And after {1} years your age is {0}", currentAge, ageIncrease);
    }

    /// <summary>
    /// Swaps two ints
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    
    (int, int) Swap(int m, int n)
    {
        /*
        int temp = m;
        m = n;
        n = temp;
        */
        return (n, m);
    }

    /// <summary>
    /// Swaps two floats
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>

    (float, float) Swap(float m, float n)
    {
        float temp = m;
        m = n;
        n = temp;
        return (m, n);
    }

    /// <summary>
    /// Method for increasing current age by 1
    /// </summary>
    /// <param name="currentAge"></param>
    /// <param name=""></param>
    /// <returns></returns>
    int AgeIncreasedMethod(int currentAge)
    {
        return (currentAge + 1);
    }

    /// <summary>
    /// Increases the age with ageIncrease
    /// </summary>
    /// <param name="currentAge"></param>
    /// <param name="ageIncrease"></param>
    /// <returns></returns>
    (int, int) AgeIncreasedMethod(int currentAge, int ageIncrease)
    {
        return (currentAge + ageIncrease - 1, ageIncrease);
    }

    /// <summary>
    /// Method for increasing current age by ageIncrease
    /// </summary>
    /// <param name="currentAge"></param>
    /// <param name=""></param>
    /// <returns></returns>


    /*(int, int) IncreaseAge(int age, int years)
    {

        newAge = (currentAge + ageIncrease);
        return (newAge);
    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}

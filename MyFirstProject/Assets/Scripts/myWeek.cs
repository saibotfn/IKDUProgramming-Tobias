using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myWeek : MonoBehaviour
{
    public string today;
    // Start is called before the first frame update
    void Start()
    {
        if (today == week[0])
        {
            Debug.Log("Monday: Program");
        }
        else if (today == week[1])
        {
            Debug.Log("Tuesday: Train");
        }
        else if (today == week[2])
        {
            Debug.Log("Wednesday: Goon");
        }
        else if (today == week[3])
        {
            Debug.Log("Thursday: Jump");
        }
        else if (today == week[4])
        {
            Debug.Log("Friday: Bang head a wall");
        }
        else if (today == week[5])
        {
            Debug.Log("Saturday: Run");
        }
        else if (today == week[6])
        {
            Debug.Log("Sunday: Program");
        }
        else
        {
            Debug.Log("Thats not a weekday");
        }

        foreach (string i in weekProgram)
        {
            Debug.Log(i);
        }

        switch (today)
        {
            case "Monday":
                Debug.Log("Monday: Program");
                break;
            case "Tuesday":
                Debug.Log("Tuesday: Train");
                break;
            case "Wednesday":
                Debug.Log("Wednesday: Goon");
                break;
            case "Thursday":
                Debug.Log("Thursday: Jump");
                break;
            case "Friday":
                Debug.Log("Friday: Bang head a wall");
                break;
            case "Saturday":
                Debug.Log("Saturday: Run");
                break;
            case "Sunday":
                Debug.Log("Sunday: Program");
                break;
            default:
                Debug.Log("Thats not a weekday");
                break;
        }

    }


    string[] week = new string[7] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    string[] weekProgram = new string[7] { "Monday: Program", "Tuesday: Train", "Wednesday: Goon", "Thursday: Jump", "Friday: Bang head a wall", "Saturday: Run", "Thats not a weekday" };



}

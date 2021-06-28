using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckAns : MonoBehaviour
{
    Display D;
   [SerializeField] TextMeshProUGUI[] TBtext;

    [SerializeField] GameObject hint;
     public void checkans()
    {

        if (TBtext[0].text == "B" && TBtext[1].text == "I" && TBtext[2].text == "R" && TBtext[3].text == "D")
        {

            D = FindObjectOfType<Display>();
            D.Display_Score();



        }
        else if (TBtext[0].text != "B" && TBtext[1].text != "I" && TBtext[2].text != "R" && TBtext[3].text != "D" || TBtext[0].text != "" && TBtext[1].text != "" && TBtext[2].text != "" && TBtext[3].text != "")
        {
            Hint();
        
        }

    }

    int k = 0;

    /*public void check()
    {
        if (TBtext[0].text == "B" && TBtext[1].text == "I" && TBtext[2].text == "R" && TBtext[3].text == "D")
        {

            D = FindObjectOfType<Display>();
            D.Display_Score();
            

        }
        if (TBtext[0].text != "B" && TBtext[1].text != "I" && TBtext[2].text != "R" && TBtext[3].text != "D")
        {

            Hint();


        }


    }*/




    public void Hint()

    {
        print("hi");
        hint.SetActive(true);
        
    }
   
}

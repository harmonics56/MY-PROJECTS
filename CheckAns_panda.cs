using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckAns_panda : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Score;
   [SerializeField] TextMeshProUGUI[] TBtext;
    Display D;

    [SerializeField] GameObject hint;
     public void checkans()
    {

        if (TBtext[0].text == "P" && TBtext[1].text == "A" && TBtext[2].text == "N" && TBtext[3].text == "D" && TBtext[4].text == "A")
        {

            D = FindObjectOfType<Display>();
            D.Display_Score();




        }
        else if (TBtext[0].text != "P" && TBtext[1].text != "A" && TBtext[2].text != "N" && TBtext[3].text != "D"&& TBtext[4].text != "A" || TBtext[0].text != "" && TBtext[1].text != "" && TBtext[2].text != "" && TBtext[3].text != "" && TBtext[4].text != "")
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

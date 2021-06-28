using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] CBtext;
    [SerializeField] TextMeshProUGUI[] TBtext;
    
    Display D;
    
    String[] Name = { "B", "R","I", "D" };
    String myString;
    int i, j,flag,k=0;
    int c_flag=0;











        
    public void onbuttonclick()
    {
        for ( i = 0; i < CBtext.Length; i++)
        { 
            for ( j = 0; j < TBtext.Length; j++)
            {
                if (TBtext[j].text =="")
                {
                    TBtext[j].text = "";
                    TBtext[j].gameObject.SetActive(true);
                    TBtext[j].text = CBtext[i].text;
                    FindObjectOfType<CheckAns>().checkans();
                    CBtext[i].text ="";

                    


                    break;
                    
               


                }

             
            }
        

        }
        



    }

    public void onreturnclick()
    {


        for (i = 0; i < CBtext.Length; i++)
        {
            for (j = 0; j < TBtext.Length; j++)
            {
                if (TBtext[j].text =="")
                {   
                    TBtext[j].gameObject.SetActive(true);
                    TBtext[j].text = CBtext[i].text;
                    CBtext[i].text="";
                         
                   




                    break;





                }


            }
            
        }
        


    }

    
}

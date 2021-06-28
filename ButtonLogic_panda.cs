using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ButtonLogic_panda : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] CBtext;
    [SerializeField] TextMeshProUGUI[] TBtext;


    int i, j;
    






    





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
                    FindObjectOfType<CheckAns_panda>().checkans();
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

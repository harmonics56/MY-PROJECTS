using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class RandomizeLetters_panda : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] CurrentText_text;
    string[] Name = { "P", "A", "N", "D","A" };


    GetTags Current_Text_Tag;
    
   [SerializeField] GameObject[] CurrentText;
    System.Random rnd = new System.Random();
    TextMeshProUGUI Reference;
    
    
    int i = 0;
     void Start()
    {
        
        Randomize();    
    }

    public List<string> Randomize()
    {
        
        List<string> available = new List<string>(5);
        for (int i = 0; i <5; i++)
            available.Add(Name[i]);

        List<string> result = new List<string>(5);
        while (available.Count >0)
        {
            int index = rnd.Next(available.Count);
            result.Add(available[index]);
            Randomplaced(available[index]);
            

            
            
            available.RemoveAt(index);
      

        }

        return result;
    }  

        

        

    

    public  void Randomplaced(string ran)
    {
    


       
        CurrentText[i].GetComponent<TextMeshProUGUI>().text =ran;
        
        i++;
        
        
            
     }


}

   


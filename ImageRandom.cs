using System.Collections.Generic;
using UnityEngine;

public class ImageRandom : MonoBehaviour
{
     [SerializeField]   Sprite Images;
    [SerializeField] GameObject Bird;
    
    System.Random random = new System.Random();
    string[] NameB = { "B", "I", "R", "D" };
    string[] NameA = { "A", "I", "N", "M","L" };
    string[] NameT = { "B", "T", "A", "E","L" };

    // Start is called before the first frame update
    void Start()
    {
        
        Randomplaced();
        
       
    }

    private void Randomplaced()
    {

        Bird.GetComponent<SpriteRenderer>().sprite = Images;
       
        

    }

   
    void Update()
    {

    }

}

    
    

    
   


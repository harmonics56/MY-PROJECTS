using System.Collections.Generic;
using UnityEngine;

public class ImageRandom_panda : MonoBehaviour
{
     [SerializeField]   Sprite Images;
    [SerializeField] GameObject Panda;
    
    System.Random random = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        
        Randomplaced();
        
       
    }

    private void Randomplaced()
    {

        Panda.GetComponent<SpriteRenderer>().sprite = Images;
       
        

    }

   
    void Update()
    {

    }

}

    
    

    
   


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display_panda : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }
    public void Display_Score()
    {

        gameObject.GetComponent<TextMeshProUGUI>().text = "10";
    
    }
}

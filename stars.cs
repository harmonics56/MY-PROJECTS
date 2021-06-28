using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stars : MonoBehaviour
{
    [SerializeField] GameObject[] Stars;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayStars());
    }
    IEnumerator DisplayStars()
    {
        while (i != 3)
        {
            Stars[i].SetActive(true);
            yield return new WaitForSeconds(0.3f);
            i++;
        }
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

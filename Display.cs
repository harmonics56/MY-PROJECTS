using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Display : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {

    }
    public void Display_Score()
    {
        StartCoroutine(Dislpay());

    }

    IEnumerator Dislpay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Win");
       
    }
}

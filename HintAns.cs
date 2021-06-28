using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintAns : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Hintans;
    [SerializeField] GameObject Hint;
    public void destroyandshowHint()
    {

        StartCoroutine(ans());
        Hint.SetActive(true);
    }
    IEnumerator ans()
    {

        Hintans.text = "BIRD";
        yield return new WaitForSeconds(0.5f);
        Hint.SetActive(false);
        gameObject.SetActive(false);





    }
}

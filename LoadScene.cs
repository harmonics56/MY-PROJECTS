using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    System.Random rnd = new System.Random();
    string[] scenes_Load = { "Level1", "Level2" };
    public void  Randomize()
    {

        List<string> available = new List<string>(2);
        for (int i = 0; i < 2; i++)
            available.Add(scenes_Load[i]);

        List<string> result = new List<string>(2);
        while (available.Count > 1)
        {
            int index = rnd.Next(available.Count);
            result.Add(available[index]);
            LScene(available[index]);




            available.RemoveAt(index);


        }

        
    }
    public void LScene(string scenes_l)
    {
        SceneManager.LoadScene(scenes_l);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);    
    }
    public void Quit()
    {
        Application.Quit();
    }

}

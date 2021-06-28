using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volume : MonoBehaviour
{

    [SerializeField] Slider volumeslider;
    [SerializeField] Camera maincam;


    public void volumehandle()
    {

        maincam.GetComponent<AudioSource>().volume = volumeslider.value;
        save();
    
    }
    public void Load()
    {

        volumeslider.value = PlayerPrefs.GetFloat("musicVolume");
    
    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume",volumeslider.value);


    }


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {


            PlayerPrefs.SetFloat("musicvolume", 1);
            Load();
        }
        else { Load(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

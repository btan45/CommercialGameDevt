using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource BackgroundMusic;
    public static AudioSource InteractSound;
    public static AudioSource WalkingSound;
    public static AudioSource DoorSound;
    public static AudioSource ButtonSound;

    static AudioSource audioSrc;

    private static AudioManager audioManagerInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (audioManagerInstance == null)
        {
            audioManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        BackgroundMusic = Resources.Load<AudioSource>("BackgroundMusic");
        InteractSound = Resources.Load<AudioSource>("interact");
        WalkingSound = Resources.Load<AudioSource>("Walking");
        DoorSound = Resources.Load<AudioSource>("door");
        ButtonSound = Resources.Load<AudioSource>("ButtonClick");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

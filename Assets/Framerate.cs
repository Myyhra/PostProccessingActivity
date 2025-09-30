using UnityEngine;


public class Framerate : MonoBehaviour
{
    public int rate = 60;
    void Start()
    {
        Application.targetFrameRate = rate;
    }

    
  
}


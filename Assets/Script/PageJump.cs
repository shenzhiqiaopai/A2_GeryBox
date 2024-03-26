using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PageJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpToHome()
    {
        SceneManager.LoadScene(1);
    }

    public void JumpToCharactor()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStickButton()
    {
        SceneManager.LoadScene("StickdownScene");
    }
    public void OnClickWallButton()
    {
        SceneManager.LoadScene("WallScene");
    }
    public void OnClickResultButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}

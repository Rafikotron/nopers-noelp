using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class start_button : MonoBehaviour
{

    public int gameStartScene;
    // Start is called before the first frame update

    public void StartGame()
    {
        SceneManager.LoadScene(gameStartScene);
    }

}

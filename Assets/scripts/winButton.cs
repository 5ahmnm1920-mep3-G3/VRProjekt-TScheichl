using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winButton : MonoBehaviour
{

    public void QuitWin()
    {
        SceneManager.LoadScene(0);
    }

}

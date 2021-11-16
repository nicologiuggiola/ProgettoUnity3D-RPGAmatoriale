using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToQuestGiverLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameToNext()
    {
        SceneManager.LoadScene(4);
    }
}

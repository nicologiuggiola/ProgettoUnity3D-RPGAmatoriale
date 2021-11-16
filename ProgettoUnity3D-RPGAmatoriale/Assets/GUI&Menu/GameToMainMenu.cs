using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameToMainMenu : MonoBehaviour
{
    public InventorySlots InventoryOne;
    // Start is called before the first frame update
    public void GameToMain()
    {
        SceneManager.LoadScene(0);
        InventoryOne.Contenitore.Clear();
    }

}

using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerNumberCreation : MonoBehaviour
{
    public int count;
    public void NumberInput()
    {
        GameParams.NumberOfPlayers = count;
        SceneManager.LoadScene(count - 2);
    }
}

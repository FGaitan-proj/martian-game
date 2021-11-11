using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene(0);
    }
}

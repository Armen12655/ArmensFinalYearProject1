using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour
{
    /// <summary>
    /// The StraightLevelClick
    /// </summary>
    public void StraightLevelClick()
    {
        SceneManager.LoadScene("straightPathsLevel"); // loading scene.
    }
}

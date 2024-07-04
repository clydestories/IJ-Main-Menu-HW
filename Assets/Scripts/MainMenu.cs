using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#elif UNITY_STANDALONE_WIN
        Application.Quit();
#endif
    }
}

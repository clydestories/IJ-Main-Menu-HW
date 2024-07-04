using UnityEngine.SceneManagement;

public static class SceneChanger
{
    public static void LoadNewScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString()); 
    }
}

public enum Scene
{
    MainMenu,
    Game
}

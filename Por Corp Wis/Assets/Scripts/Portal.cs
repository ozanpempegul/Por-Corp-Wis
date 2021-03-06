using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{

    public string[] sceneNames;


    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            // Game Saves after teleporting
            GameManager.instance.SaveState();
            // Teleport the player
            string sceneName = sceneNames[0];
            SceneManager.LoadScene(sceneName);
        }
    }
}

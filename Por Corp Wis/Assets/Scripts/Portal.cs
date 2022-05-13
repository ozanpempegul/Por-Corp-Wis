using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : Collidable
{

    public string[] sceneNames;


    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            // Teleport the player
            string sceneName = sceneNames[1];
            SceneManager.LoadScene(sceneName);
        }
    }
}

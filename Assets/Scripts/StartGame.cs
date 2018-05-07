using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void lightingAnimation()
    {
        Application.OpenURL("https://opengameart.org/content/lightning-animation");
    }

    public void titleMusic()
    {
        Application.OpenURL("http://freemusicarchive.org/music/Andrew_Codeman/Neon_Wind/Andrew_Codeman_Neon_Wind_02_Bear_with_a_guitar");
    }

    public void gameMusic()
    {
        Application.OpenURL("http://freemusicarchive.org/music/Michett/~/Beachclub");
    }

    public void gameSounds()
    {
        Application.OpenURL("https://www.bfxr.net/");
        Application.OpenURL(" https://freesound.org/people/sharesynth/sounds/341666/");
    }

    public void gameFont()
    {
        Application.OpenURL("https://fonts.google.com/specimen/Bungee+Inline");
    }

    public void gameParticles()
    {
        Application.OpenURL("https://assetstore.unity.com/packages/vfx/particles/starter-particle-pack-83179");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tombol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void scale(float scale)
    {
        transform.localScale = new Vector2(1 / scale, 1 * scale);
    }

    public void scene(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }

    public void reload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

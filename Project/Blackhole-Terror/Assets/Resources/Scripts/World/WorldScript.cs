using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorldScript : MonoBehaviour {
    public float speed = 10f;
    public float Delay = 5f;
    public float Delay2 = 10f;
    public float Delay3 = 13f;
    public bool MenuShown = false;

    public GameObject Blackhole;
    public Canvas Menu;

    void Start() {
        Menu.gameObject.SetActive(false);
		Screen.showCursor = true;
    }
    
    void FixedUpdate () {
        if (Delay > 0)
        {
            Delay -= Time.deltaTime;
        }
        else
        {
            float step = speed * Time.fixedDeltaTime;

            Physics2D.gravity = Vector2.Lerp(Physics2D.gravity, new Vector2(0f, 9.81f), step);
            Blackhole.transform.localScale = Vector3.Lerp(Blackhole.transform.localScale, new Vector3(3, 3, 3), step / 10);
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 12, step / 2);
            Camera.main.transform.position = new Vector3(Mathf.Lerp(Camera.main.transform.position.x, 20, step / 2), Camera.main.transform.position.y, Camera.main.transform.position.z);
        }

        if (Delay2 > 0)
        {
            Delay2 -= Time.deltaTime;
        }
        else
        {
            Camera.main.transform.rotation = new Quaternion(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y,  Mathf.LerpAngle(Camera.main.transform.rotation.z, 180, Time.fixedDeltaTime / 100), Camera.main.transform.rotation.w);
        }

        if (!MenuShown)
        {
            if (Delay3 > 0)
            {
                Delay3 -= Time.deltaTime;
            }
            else
            {
                ShowMenu();
            }
        }
	}

    private void ShowMenu() {
        MenuShown = true;
        Menu.gameObject.SetActive(true);
    }

    public void StartGame() {
        Physics2D.gravity = new Vector2(0f, -9.81f * 2.5f);
        Application.LoadLevel("GamePlay Linked");
    }
}

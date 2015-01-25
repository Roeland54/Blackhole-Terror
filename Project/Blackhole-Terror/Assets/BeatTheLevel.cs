using UnityEngine;
using System.Collections;

public class BeatTheLevel : MonoBehaviour
{
    public GameObject blackHole;
    public GameObject player;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == 9)
        {
            Collapse collapse = blackHole.GetComponent<Collapse>();
            collapse.Activate();
            Camera.main.GetComponent<PlayerCamera>().Player = blackHole.transform;
            Camera.main.orthographicSize = 10;
            player.transform.FindChild("HudDisplay").gameObject.SetActive(false);
            

        }
    }


}

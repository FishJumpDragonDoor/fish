using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("oooo");
            MessageBoxWnd.Instance.Show("meiemie");
        }
	}
}

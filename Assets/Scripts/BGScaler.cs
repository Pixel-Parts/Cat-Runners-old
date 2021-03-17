using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

    void Start()
    {
        // Calculate height
        float height = Camera.main.orthographicSize * 2f;
        // Calculate width
        float width = height * Screen.width / Screen.height;

        if (gameObject.name == "Background")
        {
            // Scale Background
            transform.localScale = new Vector3(width, height, 0);
        }   else
            transform.localScale = new Vector3(width + 10f, 2, 0);
    }
}
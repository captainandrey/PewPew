using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    List<GameObject> boxes;
    public int BoxesToGenerate = 10;
    public GameObject BoxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        boxes = new List<GameObject>();
        GenerateBoxes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateBoxes()
    {
        DestroyAllBoxes();

        for (int i = 0; i < BoxesToGenerate; i++)
        {
            var color = Random.ColorHSV(0.2f, 0.8f, 0.5f, 1f, 0.5f, 1f, 0.7f, 0.7f);

            var newBox = Instantiate(BoxPrefab, new Vector3(Random.Range(-20, 20), Random.Range(2, 5), Random.Range(-20, 20)), Quaternion.Euler(90, 0, 0));
            newBox.GetComponent<Renderer>().material.color = color;

            boxes.Add(newBox);
        }
    }

    void DestroyAllBoxes()
    {
        foreach(var box in boxes)
        {
            Destroy(box);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    List<GameObject> boxes;
    public int BoxesToGenerate = 20;
    public GameObject BoxPrefab;
    int score = 0;

    public Text TextScore;
    

    // Start is called before the first frame update
    void Start()
    {
        SceneEvents.Events.OnBoxDestroyed += Events_OnBoxDestroyed;
        boxes = new List<GameObject>();
        GenerateBoxes();
    }

    private void Events_OnBoxDestroyed(GameObject obj)
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = $"Score: {score}";
    }

    void GenerateBoxes()
    {
        DestroyAllBoxes();

        for (int i = 0; i < BoxesToGenerate; i++)
        {
            var newBox = Instantiate(BoxPrefab, new Vector3(Random.Range(-20, 20), Random.Range(2, 5), Random.Range(-20, 20)), Quaternion.Euler(90, 0, 0));
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

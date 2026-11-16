using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; 1 <10; i++)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErosionButton : MonoBehaviour
{



    [SerializeField] private Button _btn;



    public GameObject terrain;
    // Start is called before the first frame update
    void Start()
    {

        terrain = GameObject.Find("Terrain");
        TerrainGenerator tg = (TerrainGenerator)terrain.GetComponent(typeof(TerrainGenerator));
        HeightMapGenerator mg = (HeightMapGenerator)terrain.GetComponent(typeof(HeightMapGenerator));

        _btn.onClick.AddListener(() => {
            mg.seed = Random.Range(-10000, 10000);
            tg.GenerateHeightMap();
            tg.ContructMesh();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

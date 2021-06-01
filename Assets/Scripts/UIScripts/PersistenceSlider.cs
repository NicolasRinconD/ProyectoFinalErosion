using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PersistenceSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;

    public GameObject terrain;


    // Start is called before the first frame update
    void Start()
    {

        TerrainGenerator tg = (TerrainGenerator)terrain.GetComponent(typeof(TerrainGenerator));
        HeightMapGenerator hmg = (HeightMapGenerator)terrain.GetComponent(typeof(HeightMapGenerator));
        _slider.value = hmg.persistence;
        _sliderText.text = hmg.persistence.ToString("0.00");

        _slider.onValueChanged.AddListener((v) => {

            _sliderText.text = v.ToString("0.00");
            hmg.persistence = (float)v;
            tg.GenerateHeightMap();
            tg.ContructMesh();
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

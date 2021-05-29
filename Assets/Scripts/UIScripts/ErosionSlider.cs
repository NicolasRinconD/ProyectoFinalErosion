using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ErosionSlider : MonoBehaviour
{


    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;

    public GameObject terrain;

    // Start is called before the first frame update
    void Start()
    {
        TerrainGenerator tg = (TerrainGenerator)terrain.GetComponent(typeof(TerrainGenerator));

        _slider.value = (float)tg.numErosionIterations;
        _sliderText.text = tg.numErosionIterations.ToString();
        _slider.onValueChanged.AddListener((v) => {

            _sliderText.text = v.ToString();
            tg.numErosionIterations = (int)v;
            tg.GenerateHeightMap();
            tg.Erode();
            tg.ContructMesh();
        });   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

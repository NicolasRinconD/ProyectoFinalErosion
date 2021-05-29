using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElevationSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;

    public GameObject terrain;

    // Start is called before the first frame update
    void Start()
    {

        TerrainGenerator tg = (TerrainGenerator)terrain.GetComponent(typeof(TerrainGenerator));

        _slider.value = (float)tg.elevationScale;
        _sliderText.text = tg.elevationScale.ToString("0.00");
        _slider.onValueChanged.AddListener((v) => {

            _sliderText.text = v.ToString("0.00");
            tg.elevationScale = (float)v;
            tg.GenerateHeightMap();
            tg.ContructMesh();
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

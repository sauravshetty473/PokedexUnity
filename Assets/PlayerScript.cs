using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public GameObject mainImage;
    public GameObject background;
    public GameObject first;
    public GameObject second;
    public Sprite[] sprites;




    public GameObject name;
    public GameObject type1;
    public GameObject type2;




    private void Awake()
    {
        Image image = mainImage.GetComponent<Image>();
        image.sprite = sprites[PokemonInformation.currentIndex];



        name.GetComponent<TextMeshProUGUI>().text = PokemonInformation.values[PokemonInformation.currentIndex].name;
        type1.GetComponent<TextMeshProUGUI>().text = PokemonInformation.values[PokemonInformation.currentIndex].types[0];
        type2.GetComponent<TextMeshProUGUI>().text = PokemonInformation.values[PokemonInformation.currentIndex].types[1];

        //background.GetComponent<Image>().color = PokemonInformation.values[PokemonInformation.currentIndex].colors[0];
        //first.GetComponent<Image>().color = PokemonInformation.values[PokemonInformation.currentIndex].colors[1];
        //second.GetComponent<Image>().color = PokemonInformation.values[PokemonInformation.currentIndex].colors[2];
    }
}

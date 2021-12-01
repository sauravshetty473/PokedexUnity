using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PokemonInformation : MonoBehaviour
{

    public static int currentIndex = 0;

    public static Values[] values = new Values[]
    {
        new Values("pikachu", new string[]{"mouse", "electric",}, new Color[]{ new Color(245, 30, 141), new Color(245, 253, 141), new Color(245, 253, 141) } ),
        new Values("mew", new string[]{"legendary", "magic" },  new Color[]{ new Color(245, 253, 141), new Color(245, 253, 141), new Color(245, 253, 141) } ),
        new Values("umbreon", new string[]{"mouse", "magic" },  new Color[]{ new Color(245, 253, 141), new Color(245, 253, 141), new Color(245, 253, 141) }),
        new Values("Coffing", new string[]{"flying", "poison" },  new Color[]{ new Color(245, 253, 141), new Color(245, 253, 141), new Color(245, 253, 141) }),
        new Values("gible", new string[]{"mouse", "electric" },  new Color[]{ new Color(245, 253, 141), new Color(245, 253, 141), new Color(245, 253, 141) }),
    };

    

    public class Values
    {
        public string name;
        public string[] types;
        public Color[] colors;

        public Values(string name, string[] types, Color[] colors)
        {
            this.name = name;
            this.types = types;
            this.colors = colors;
        }
    }

}




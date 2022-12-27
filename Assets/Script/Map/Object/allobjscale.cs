  using UnityEngine;

public class allobjscale : MonoBehaviour
{
    public static int DuctTape; //изолента
    public static int Plastic; //пластик
    public static int OreIron; //руды железа
    public static int OreCopper; //руды меди
    public static int Iron; //железо
    public static int Copper; //медь
    public static int Wires; //провода
    public static int Motherboard; //плата

    private void Start()
    {
        DuctTape = 0;
        Wires = 0;
        Plastic = 0;
        OreIron = 0;
        OreCopper = 0;
        Iron = 0;
        Copper = 0;
        Motherboard = 0;
    }
}

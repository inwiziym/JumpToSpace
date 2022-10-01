using UnityEngine;
using UnityEngine.UI;
public class LoadScopeObj : MonoBehaviour
{
    public Text DuctTape;
    public Text Wires;
    public Text Plastic;

    public void Start()
    {
        DuctTape.text = PlayerPrefs.GetInt("DuctTapeScope", 0).ToString();
        Wires.text = PlayerPrefs.GetInt("WiresScope", 0).ToString();
        Plastic.text = PlayerPrefs.GetInt("PlasticScope", 0).ToString();
    }
}

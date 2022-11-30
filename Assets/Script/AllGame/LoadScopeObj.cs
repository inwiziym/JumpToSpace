using UnityEngine;
using UnityEngine.UI;
public class LoadScopeObj : MonoBehaviour
{
    public Text DuctTape;
    public Text Wires;
    public Text Plastic;

    public GameObject[] repwindows;

    public void Start()
    {
        for( int i = 0; i < repwindows.Length; i++ )
        {
            bool active;
            if (PlayerPrefs.GetInt("repwindows" + i, 1) == 1)
            {
                active = true;
            }
            else
            {
                active = false;
            }
            repwindows[i].SetActive(active);
        }
        DuctTape.text = PlayerPrefs.GetInt("DuctTapeScope", 0).ToString();
        Wires.text = PlayerPrefs.GetInt("WiresScope", 0).ToString();
        Plastic.text = PlayerPrefs.GetInt("PlasticScope", 0).ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageDisplayScript : MonoBehaviour
{
    public Text displayText;
    // Start is called before the first frame update

    public DamageController myDamage;

    // Update is called once per frame
    void Update()
    {
        //displayText.text = "Damage: [" + myDamageZones.damage.ToString() + "]";
       displayText.text = myDamage.playerDamage.ToString();
    }
}

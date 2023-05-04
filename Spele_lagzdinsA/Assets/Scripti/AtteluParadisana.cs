using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
    public Sprite goblinSlayer;
    public Sprite goblin;
    public GameObject mainigaisAttels;
    public GameObject vertSlaideris;
	public GameObject horizSlaideris;
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0){
			mainigaisAttels.GetComponent<Image>().sprite =
                goblinSlayer;
		}
        if(skaitlis == 1){
		 mainigaisAttels.GetComponent<Image>().sprite =
               goblin;	 
		}
    }

    public void mainitIzmeru()
    {
		float pasreizejaisIzmersY =
			vertSlaideris.GetComponent<Slider>().value;
		float pasreizejaisIzmersX =
			horizSlaideris.GetComponent<Slider>().value;
		mainigaisAttels.transform.localScale =
			new Vector2(1f* pasreizejaisIzmersX,pasreizejaisIzmersY);

		mainigaisAttels.transform.localScale =
			new Vector2(pasreizejaisIzmersX,
				1f*pasreizejaisIzmersY);
    }
}

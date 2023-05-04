using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	private string vards, gadi;
	public GameObject vardaIevade;
	public GameObject gaduIevade;
	public GameObject tekstaAttelosana;
	public void UzglabatTekstu(){
		gadi= gaduIevade.GetComponent<InputField>().text;
		vards = vardaIevade.GetComponent<InputField>().text;
		tekstaAttelosana.GetComponent<Text>().text = vards+" ir "+gadi+" gadus vec/veca.";
	}
}
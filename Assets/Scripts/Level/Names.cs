using UnityEngine;
using System.Collections;

public class Names : MonoBehaviour {

    private string[] firstNames = {"Adi", "Ailyn", "Allyn", "Ajunta", "Alinn", "Anya", "Apailana", "Appo", "Arvel", "Astri", "Aubrie", "Aurra", "Azlyn", "B.", "Barriss", "Bast", "Bastila", "Beru", "Bevel", "Bib", "Bly", "Boba", "Breed", "Breha", "Bren", "Bria", "C.", "Cad", "Callista", "Carnor", "Cassio", "Cham", "Chi", "Cliegg", "Cody", "Coleman", "Corde", "Crix", "D.", "Dash", "Darial", "Daultay", "Deliah", "Depa", "Dorme", "Dott", "Even", "Falon", "Fay", "Feylis", "Figrin", "Firmus", "Fode", "Fox", "Freia" };
    private string[] lastNames = { "Ackbar", "Allie", "Amedda", "Amidala", "Antilles", "Argente", "Axmis", "Baba", "Bast", "Bibble", "Binks", "Bulq", "Brashin", "Calrissian", "Celchu", "Clovis", "Colton", "Crynyd", "Daala", "Dan", "Danva", "Dassyne", "Delso", "Derlin", "Dod", "Dodonna", "Dofine", "Drallig", "Eclipse", "Eval", "Evazan", "Fett", "Fisto", "Fortuna" };

	void Start ()
    {
	
	}
	
	public string GetFirstName ()
    {
        return firstNames[Random.Range(0, firstNames.Length)];
    }

    public string GetLastName()
    {
        return lastNames[Random.Range(0, firstNames.Length)];
    }
}

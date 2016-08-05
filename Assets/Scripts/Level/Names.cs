using UnityEngine;
using System.Collections;

public class Names : MonoBehaviour {

    private string[] firstNames = {"Adi", "Ailyn", "Allyn", "Ajunta", "Alinn", "Anya", "Apailana", "Appo", "Arvel", "Astri", "Aubrie", "Aurra", "Azlyn", "B.", "Barriss", "Bast", "Bastila", "Beru", "Bevel", "Bib", "Bly", "Boba", "Breed", "Breha", "Bren", "Bria", "C.", "Cad", "Callista", "Carnor", "Cassio", "Cham", "Chi", "Cliegg", "Cody", "Coleman", "Corde", "Crix", "D.", "Dash", "Darial", "Daultay", "Deliah", "Depa", "Dorme", "Dott", "Even", "Falon", "Fay", "Feylis", "Figrin", "Firmus", "Fode", "Fox", "Freia", "Garris", "Gavyn", "Gilad", "Githany", "Gizor", "Henne", "Iella", "J.", "Jaden", "Jaina", "Jan", "Jana", "Jarael", "Jax", "Jenna", "Jeremoch", "Jobal", "Jocasta", "Joclad", "Jodo", "Jude", "Jysella", "Karina", "Karreio", "Kass", "Kazdan", "Ken", "Kendal", "Kit", "Kyle", "L.", "Lando", "Leia", "Liana", "Logray", "Lorth", "Lott", "Lumiya", "Lyn", "M.", "Mako", "Mara", "Marasiah", "Maris", "Miraj", "Mirax", "Mirta", "Mon", "Moradmin", "Nien", "Noa", "Nute", "Nyche", "O.", "Oola", "Orn", "Oro", "Owen", "Padme", "Passel", "Pix", "Ponda", "Prestor", "Q.", "Q'Anilia", "R.", "Rako", "Raymus", "Rex", "Roganda", "Rune", "Rush", "Ryoo", "Sabe", "Sache", "San", "Sate", "Satele", "Saul", "Saw", "Scerra", "Shmi", "Sintas", "Sio", "Siri", "Sola", "Sora", "Stass", "Steela", "Sy", "Syal", "T.", "Talon", "Talzin", "Tamith", "Taun", "Tavion", "Teela", "Tenel", "Tenniel", "Tyber", "Tycho", "Tyria", "Vima", "Visas", "Wat", "Wedge", "Wes", "Wilhuff", "Xamuel", "Zeb", "Zule", "Zuud" };
    private string[] lastNames = { "Ackbar", "Allie", "Amedda", "Amidala", "Antilles", "Argente", "Axmis", "Baba", "Bast", "Bibble", "Binks", "Bulq", "Brashin", "Calrissian", "Celchu", "Clovis", "Colton", "Crynyd", "Daala", "Dan", "Danva", "Dassyne", "Delso", "Derlin", "Dod", "Dodonna", "Dofine", "Drallig", "Eclipse", "Eval", "Evazan", "Fett", "Fisto", "Fortuna", "Gerrera", "Gev", "Grey", "Gunray", "Haako", "Hardeen", "Hill", "Iblis", "Isard", "Janson", "Jax", "Jerjerrod", "Jettster", "Jinn", "Karath", "Karrde", "Kast", "Katarn", "Kenobi", "Khai", "Klivian", "Kolar", "Koon", "Korr", "Kota", "Kryze", "Lars", "Lemelisk", "Lennox", "Madine", "Mandrell", "Medon", "Mothma", "Motti", "Naberrie", "Nadon", "Nass", "Needa", "Nu", "Nunb", "Offee", "Ohnaka", "Oola", "Organa", "Ozzel", "Panaka", "Papanoida", "Paratus", "Pavan", "Pelleon", "Pestage", "Piett", "Ralter", "Rebo", "Rendar", "Scintel", "Secura", "Senesca", "Seti", "Shan", "Shrike", "Sing", "Syndulla", "Taa", "Tagge", "Tambor", "Tarkin", "Tharen", "Thrawn", "Typho", "Unduli", "Veers", "Vos", "Wesell", "Zann" };
	
	public string GetFirstName ()
    {
        return firstNames[Random.Range(0, firstNames.Length)];
    }

    public string GetLastName()
    {
        return lastNames[Random.Range(0, lastNames.Length)];
    }
}

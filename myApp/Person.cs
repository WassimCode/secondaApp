using System;
using System.Globalization;
/// <summary>
/// Classe persona che ci consente di salvare i dati di un individuo
/// </summary>
public class Person
{
	// Attributi
	public string firstName;
	public string secondName;
	public char gender; // m o f
	public string birthCity;
	public string birthDate;
 	public Person()
	{
		this.firstName = "";
		this.secondName = "";
		this.gender = ' ';
		this.birthCity = "";
		this.birthDate = "";
	} 	
	public Person(string firstName, string secondName, char gender, string birthCity, string birthDate)
	{
		this.firstName = firstName;
		this.secondName = secondName;
		this.gender = gender;
		this.birthCity = birthCity;
		this.birthDate = birthDate; 
	}



    public int calcolaAnni()
    {
        DateTime dataNascita;
        if (DateTime.TryParseExact(this.birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascita))
        {
            int anni = DateTime.Now.Year - dataNascita.Year;
            if (DateTime.Now.DayOfYear < dataNascita.DayOfYear)
                anni--;
            return anni;
        }
        else
        {
            throw new ArgumentException("La stringa non rappresenta una data valida.");
        }
    }



    public string GeneraCodiceFiscale(string nome, string cognome, string luogo, int anno)
    {
        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(luogo))
        {
            throw new ArgumentException("I parametri nome, cognome e luogo non possono essere nulli o vuoti.");
        }

        if (anno < 1900 || anno > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("Il parametro anno deve essere compreso tra 1900 e l'anno corrente.");
        }

        // Calcola il codice fiscale
        string codiceFiscale = "TODO";

        return codiceFiscale;
    }
    



}

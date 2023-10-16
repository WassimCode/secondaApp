using System;
using System.Globalization;

namespace myApp;
/// <summary>
/// Classe persona che ci consente di salvare i dati di un individuo
/// </summary>
public class Person
{
	// Attributi
	public string firstName;
	public string secondName;
	public string gender; // m o f
	public string birthCity;
	public string birthDate;
    public CodiceFiscale cf;

 	public Person()
	{
		this.firstName = "";
		this.secondName = "";
		this.gender = "";
		this.birthCity = "";
		this.birthDate = "";
	} 	
	public Person(string firstName, string secondName, string gender, string birthCity, string birthDate)
	{
		this.firstName = firstName;
		this.secondName = secondName;
		this.gender = gender;
		this.birthCity = birthCity;
		this.birthDate = birthDate; 
        cf = new CodiceFiscale(secondName, firstName, gender,DateTime.ParseExact(this.birthDate, "dd/mm/yyyy", CultureInfo.InvariantCulture), "Scandiano" , "RE", 0);
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




    



}

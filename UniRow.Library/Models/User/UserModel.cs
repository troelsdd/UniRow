using SQLite;
using System;
using System.Drawing;

namespace UniRow.Library.Models
{
    public class UserModel
    {
        public UserModel()
        {
        }
        public UserModel(string Firstname, string Lastname, string Address, int Zip, string City, DateTime Birthday, string EmailAddress, string password, string Phonenumber)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Address = Address;
            this.Postalcode = Zip;
            this.City = City;
            this.Birthday = Birthday;
            this.Email = EmailAddress;
            //this.Password = HashPassword(password);
            this.PhoneNumber = Phonenumber;
            Enrollment = DateTime.Now;
        }
        /// <summary>
        /// ID nummeret som hver bruger får når de bliver oprettet i systemet. Autogenereres
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Det selvvalgte Brugernavn som brugeren ønsker at benytte og navigere rundt og bruge appen med
        /// </summary>
        [MaxLength(250)]
        public string Username { get; set; }
        /// <summary>
        /// Det selvvalgte Password som brugeren ønsker at benytte og navigere rundt og bruge appen med. 
        /// </summary>
        //TODO: Kør password gennem encryption algorithm og ændre det til en ikke-decryptbar bytevalue som password hash kan sammenlignes med ved login.
        public byte Password { get; set; }
        /// <summary>
        /// Fødselsdatoen for den specifikke bruger. Sættes ved brugeroprettelse, og bliver derefter ikke ændret yderligere.
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Fornavn for brugeren for identifikation.
        /// </summary>
        [MaxLength(250)]
        public string Firstname { get; set; }
        /// <summary>
        /// Efternavn for brugeren for identifikation
        /// </summary>
        [MaxLength(250)]
        public string Lastname { get; set; }
        /// <summary>
        /// Addressen for brugeren. Gadenavn, husnummer, sal, th/tv m.v.
        /// </summary>
        [MaxLength(250)]
        public string Address { get; set; }
        /// <summary>
        /// Postkode for byen hvori brugeren bor
        /// </summary>
        [MaxLength(250)]
        public int Postalcode { get; set; }
        /// <summary>
        /// By hvori brugeren bor.
        /// </summary>
        [MaxLength(250)]
        public string City { get; set; }
        /// <summary>
        /// Landet hvori brugeren bor
        /// </summary>
        [MaxLength(250)]
        public string Country { get; set; }
        /// <summary>
        /// Sex of the person in question
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Telefonnummeret på pågældende bruger
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Emailaddressen på pågældende bruger
        /// </summary>
        private string _Email { get; set; }
        public string Email {
            get { return _Email; }
            set
            {
                    _Email = value;
            }
        }
        /// <summary>
        /// Autogenereret dato for den dag brugeren blev oprettet i databasen, i fald databasen flyttes eller lignende sker.
        /// </summary>
        public DateTime Enrollment { get { return _Enrollment; } set { _Enrollment = DateTime.Now; } }
        /// <summary>
        /// Autogenereret dato for den dag brugeren blev oprettet i databasen, i fald databasen flyttes eller lignende sker.
        /// </summary>
        private DateTime _Enrollment { get; set; }
        /// <summary>
        /// Autogenereret dato for den dag brugeren ophører som medlem i foreningen.
        /// </summary>
        private DateTime Resignation { get; set; }
        
        //Andre tilføjelser som kunne ses på:

        /// <summary>
        /// Brugerens egen sprogpreference. Dansk Standard.
        /// </summary>
        string language { get; set; }
        /// <summary>
        /// Tilhørsklub for brugeren. Aalborg Roklub Standard.
        /// </summary>
        string Club { get; set; }
        /// <summary>
        /// Rettigheder for roeren i klubben / Hvad må brugeren i klubben?
        /// </summary>
        string[] Rowingrights = { "Scullerret", "Outriggerret", "Inriggerret", "Frigivet", "Svømmebevis" };
        /// <summary>
        /// Hvilke udvalg brugeren er en del af i klubben?
        /// </summary>
        string[] CommiteeMembership = { "Uddannelsesudvalg", "Socialudvalg", "SoMe Udvalg", "Kaproningsudvalg", "etc..." };
        /// <summary>
        /// Fag-relevante uddannelsesbaggrund for roeren.
        /// </summary>
        string[] ClubCertifications = { "Korttursstyrmandskursus", "Langtursstyrmandskursus", "Trænerkursus Modul A", "Trænerkursus Modul B", "Trænerkursus Modul C", "Trænerkursus Modul D", "Concept2 Instructor Certification", "DIF Diplomtræneruddannelse" };
        /// <summary>
        /// Hvilken adgang skal brugeren have? "Roer" og dermed kun adgang til selv at taste data ind, eller "træner" og dermed adgang til at se roerens data? Eller bestyrelsesmedlem og kunne ændre ALLE data, men ikke se træningslog?
        /// </summary>
        public string Accesright { get; set; }

    }         
}

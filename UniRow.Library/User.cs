using System;

namespace UniRow.Library
{
    public class User
    {
        /// <summary>
        /// ID nummeret som hver bruger får når de bliver oprettet i systemet. Autogenereres
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Det selvvalgte Brugernavn som brugeren ønsker at benytte og navigere rundt og bruge appen med
        /// </summary>
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
        public string Firstname { get; set; }
        /// <summary>
        /// Efternavn for brugeren for identifikation
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Addressen for brugeren. Gadenavn, husnummer, sal, th/tv m.v.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Postkode for byen hvori brugeren bor
        /// </summary>
        public int Postalcode { get; set; }
        /// <summary>
        /// By hvori brugeren bor.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Landet hvori brugeren bor
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Telefonnummeret på pågældende bruger
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Emailaddressen på pågældende bruger
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Autogenereret dato for den dag brugeren blev oprettet i databasen, i fald databasen flyttes eller lignende sker.
        /// </summary>
        private DateTime Enrollment { get; set; }
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
        /// Fag-relevante uddannelsesbaggrund for roeren.
        /// </summary>
        string[] CommiteeMembership = { "Uddannelsesudvalg", "Socialudvalg", "SoMe Udvalg", "Kaproningsudvalg", "etc..." };
        string[] ClubCertifications = { "Korttursstyrmandskursus", "Langtursstyrmandskursus", "Trænerkursus Modul A", "Trænerkursus Modul B", "Trænerkursus Modul C", "Trænerkursus Modul D", "Concept2 Instructor Certification", "DIF Diplomtræneruddannelse" };
        /// <summary>
        /// Hvilken adgang skal brugeren have? "Roer" og dermed kun adgang til selv at taste data ind, eller "træner" og dermed adgang til at se roerens data? Eller bestyrelsesmedlem og kunne ændre ALLE data, men ikke se træningslog?
        /// </summary>
        string Accesrights { get; set; }
    }        
    
}

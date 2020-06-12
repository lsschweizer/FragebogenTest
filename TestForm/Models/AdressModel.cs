using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public class AdressModel
    {
        public string Straße { get; set; }
        public string Ort { get; set; }
        public string Bundesland { get; set; }
        public string PLZ { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geschlecht { get; set; }
        public string Geburtsdatum { get; set; }
        public string EMail { get; set; }

        public string Telefonnummer { get; set; }
        public string Größe { get; set; }
        public string Gewicht { get; set; }
        public string Land { get; set; }
        public string Strava { get; set; }
        public string Trainingpeaks { get; set; }
        public string StravaName { get; set; }

    }
}

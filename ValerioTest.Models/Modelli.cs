using System;
using System.Collections.Generic;
using System.Text;
using dapper = Dapper.Contrib.Extensions;

namespace ValerioTest.Models

{   
    [dapper.Table("dbo.Scuola")] 
    public class Modelli              //Identifico la tabella del database
    {
                                      

        [dapper.Key]                   //Definisco le classi del mio modello ad oggetti
        public int IdPiano { get; set; }
        public string Aula { get; set; }
        public string Nome { get; set; }

        public string Materia { get; set; }
        public int Scadenza { get; set; }
    }
}
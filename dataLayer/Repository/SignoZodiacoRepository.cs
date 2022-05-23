using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataLayer.Models;
namespace dataLayer.Repository
{
    public sealed class SignoZodiacoRepository
    {
        public static SignoZodiacoRepository Instance { get; } = new();

        /* Debido a que no se nos permite guardar los datos en una base de datos como tal, implemete el singleton para simular una
        base de datos temporal o a los que algunos llaman en otro entorno, local storage.*/

        //Implemtacion de los Signos Zodiacos

        private List<Signo_Zodiaco> SignosZodiacosList = new();        

        private SignoZodiacoRepository(){}        

        //Metodo para devolver al controlador los datos que existen en el Singleton.
        public List<Signo_Zodiaco> getAll()
        {
            SignosZodiacosList.Clear();
            addAllSigns();
            return SignosZodiacosList;
        }

        private void addAllSigns()
        {
            int _Id = 1;

            Signo_Zodiaco Aries = new()
            {
                Id = _Id ,
                Title = "Aries",
                StartDate = DateTime.Parse($"21/03/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"19/04/{DateTime.Now.Year}")
            };

            _Id = _Id+ 1;

            Signo_Zodiaco Tauro = new()
            {
                Id = _Id,
                Title = "Tauro",
                StartDate = DateTime.Parse($"20/04/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"21/05/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Geminis = new()
            {
                Id = _Id  ,
                Title = "Géminis",
                StartDate = DateTime.Parse($"22/05/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"20/06/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Cancer = new()
            {
                Id = _Id  ,
                Title = "Cáncer",
                StartDate = DateTime.Parse($"21/06/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"22/07/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Leo = new()
            {
                Id = _Id  ,
                Title = "Leo",
                StartDate = DateTime.Parse($"23/07/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"22/08/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Virgo = new()
            {
                Id = _Id  ,
                Title = "Virgo",
                StartDate = DateTime.Parse($"23/08/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"22/09/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Libra = new()
            {
                Id = _Id  ,
                Title = "Libra",
                StartDate = DateTime.Parse($"23/09/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"22/10/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Escorpion = new()
            {
                Id = _Id  ,
                Title = "Escorpio",
                StartDate = DateTime.Parse($"23/10/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"21/11/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;            
            Signo_Zodiaco Sagitario = new()
            {
                Id = _Id  ,
                Title = "Sagitario",
                StartDate = DateTime.Parse($"22/11/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"21/12/{DateTime.Now.Year}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Capricornio = new()
            {
                Id = _Id  ,
                Title = "Capricornio",
                StartDate = DateTime.Parse($"22/12/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"19/01/{DateTime.Now.Year + 1}")
            };
            _Id = _Id+ 1;
            Signo_Zodiaco Acuario = new()
            {
                Id = _Id,
                Title = "Acuario",
                StartDate = DateTime.Parse($"20/01/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"18/02/{DateTime.Now.Year}")
            };
            _Id = _Id + 1;
            Signo_Zodiaco Piscis = new()
            {
                Id = _Id  ,
                Title = "Piscis",
                StartDate = DateTime.Parse($"19/02/{DateTime.Now.Year}"),
                EndDate = DateTime.Parse($"20/03/{DateTime.Now.Year}")
            };

            SignosZodiacosList.Add(Aries);
            SignosZodiacosList.Add(Tauro);
            SignosZodiacosList.Add(Geminis);
            SignosZodiacosList.Add(Cancer);
            SignosZodiacosList.Add(Leo);
            SignosZodiacosList.Add(Virgo);
            SignosZodiacosList.Add(Libra);
            SignosZodiacosList.Add(Escorpion);
            SignosZodiacosList.Add(Sagitario);
            SignosZodiacosList.Add(Capricornio);
            SignosZodiacosList.Add(Acuario);
            SignosZodiacosList.Add(Piscis);
        }



    }
}

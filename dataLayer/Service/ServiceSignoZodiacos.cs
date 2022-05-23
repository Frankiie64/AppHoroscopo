using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataLayer.Models;
using dataLayer.Repository;

namespace dataLayer.Service
{
    public class ServiceSignoZodiacos
    {        
        public UserSign findSignoZodiaco(DateTime bDay)
        {
            DateTime FixedTime = DateTime.Parse($"{bDay.Day}/{bDay.Month}/{DateTime.Now.Year}");

            if (bDay.Month == 01)
            {
                FixedTime = DateTime.Parse($"{bDay.Day}/{bDay.Month}/{DateTime.Now.Year + 1}");
            }

            List<Signo_Zodiaco> list = new();
            list = SignoZodiacoRepository.Instance.getAll();

            foreach (var item in list)
            {
                if(FixedTime.CompareTo(item.StartDate)>= 0 && FixedTime.CompareTo(item.EndDate) <= 0)
                {
                    UserSign user = new()
                    {
                        bDay = FixedTime,
                        Signo = item
                    };
                    return user;
                }
            }

            return null;
        }

        public List<Signo_Zodiaco> getAll()
        {
            return SignoZodiacoRepository.Instance.getAll();
        }
    }
}
